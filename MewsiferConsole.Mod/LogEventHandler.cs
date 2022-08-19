﻿using MewsiferConsole.Common;
using MewsiferConsole.Mod.IPC;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static MewsiferConsole.Common.PipeContract;

namespace MewsiferConsole.Mod
{
  public interface ILogEventHandler
  {
    void OnLogEvent(LogEvent logEvent);
  }

  /// <summary>
  /// Handler for processing all log events.
  /// </summary>
  internal class LogEventHandler : ILogEventHandler
  {
    /// <summary>
    /// Max log events in the queue before dumping to the log file.
    /// </summary>
    private const int MaxQueue = 5000;

    /// <summary>
    /// Temporary file used to store logs when the queue is full.
    /// </summary>
    private readonly string LogTempFile = Path.GetTempFileName();

    // Queue for dumping to the log file. Contains JSON serialized PipeMessage for each log event.
    private readonly ConcurrentQueue<string> LogFileQueue = new();

    private Thread WriteToFileThread;
    private int _fileOpen = 0;
    private bool FileOpen
    {
      get { return Interlocked.CompareExchange(ref _fileOpen, 1, 1) == 1; }
      set
      {
        if (value) { Interlocked.CompareExchange(ref _fileOpen, 1, 0); }
        else { Interlocked.CompareExchange(ref _fileOpen, 0, 1); }
      }
    }

    internal void Init()
    {
      try
      {
        Main.Logger.Log($"Logging to {LogTempFile}");
        File.WriteAllLines(LogTempFile, new string[] { Client.VersionCheck });
      }
      catch (Exception e)
      {
        Main.Logger.LogException(e);
      }
    }

    public void OnLogEvent(LogEvent logEvent)
    {
      LogFileQueue.Enqueue(Client.Instance.SendMessage(PipeMessage.ForLogEvent(logEvent)));
      if (LogFileQueue.Count > MaxQueue && !FileOpen)
      {
        FileOpen = true;
        // Write on another thread so it doesn't block the thread triggering log events from the game.
        WriteToFileThread = new Thread(new ThreadStart(WriteToTempFile));
        WriteToFileThread.Start();
      }
    }

    private void WriteToTempFile()
    {
      Main.Logger.Log($"Writing logs to file: {LogTempFile}");
      using (var writer = new StreamWriter(LogTempFile, append: true))
      {
        var processedLogs = new HashSet<string>();
        while (LogFileQueue.Any())
        {
          if (LogFileQueue.TryDequeue(out string message))
          {
            if (processedLogs.Add(message))
            {
              writer.WriteLine(message);
            }
          }
        }
      }
      FileOpen = false;
    }

    internal async Task<string> GetLogDump(string fileName)
    {
      Main.Logger.Log("Log dump requested.");
      var task = new Task<string>(() => GetLogDumpInternal(fileName));
      task.Start();
      return await task;
    }

    internal string GetLogDumpInternal(string fileName)
    {
      if (FileOpen)
      {
        Main.Logger.NativeLog("Log file open, waiting.");
        // Timeout after 30s since that's a really long time to write such a small file (max 2500 lines)
        if (!WriteToFileThread.Join(30 * 1000))
        {
          throw new TimeoutException("Timed out waiting for the log file to be written.");
        }
      }
      else
      {
        FileOpen = true;
        WriteToTempFile();
      }

      // Just assume queue won't fill up in the time it takes to do this. Otherwise we'd need to check FileOpen and
      // wait for the write thread again.
      var filePath = Path.Combine(Path.GetTempPath(), $"{fileName}.mew");
      Main.Logger.Log($"Writing compressed log file: {filePath}");
      MewFile.Write(LogTempFile, filePath);
      return filePath;
    }
  }
}
