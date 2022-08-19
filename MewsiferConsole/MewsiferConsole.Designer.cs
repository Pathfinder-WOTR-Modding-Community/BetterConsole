﻿namespace MewsiferConsole
{
    partial class MewsiferConsole
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ChannelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.TailToggle = new System.Windows.Forms.CheckBox();
      this.OmniFilter = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1536, 707);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
      this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Severity,
            this.ChannelName,
            this.Message});
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(2, 48);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowHeadersWidth = 62;
      this.dataGridView1.RowTemplate.Height = 33;
      this.dataGridView1.Size = new System.Drawing.Size(1532, 643);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellFormatting += DataGrid_CellFormatting;
      // 
      // Severity
      // 
      this.Severity.DataPropertyName = "Severity";
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.Severity.DefaultCellStyle = dataGridViewCellStyle3;
      this.Severity.HeaderText = "Level";
      this.Severity.MinimumWidth = 55;
      this.Severity.Name = "Severity";
      this.Severity.ReadOnly = true;
      this.Severity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.Severity.ToolTipText = "Log Severity";
      this.Severity.Width = 55;
      // 
      // ChannelName
      // 
      this.ChannelName.DataPropertyName = "ChannelName";
      this.ChannelName.HeaderText = "Channel";
      this.ChannelName.MinimumWidth = 8;
      this.ChannelName.Name = "ChannelName";
      this.ChannelName.ReadOnly = true;
      this.ChannelName.Width = 150;
      // 
      // Message
      // 
      this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Message.DataPropertyName = "Message";
      this.Message.FillWeight = 200F;
      this.Message.HeaderText = "Message";
      this.Message.MinimumWidth = 8;
      this.Message.Name = "Message";
      this.Message.ReadOnly = true;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
      this.tableLayoutPanel2.Controls.Add(this.TailToggle, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.OmniFilter, 0, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(1532, 42);
      this.tableLayoutPanel2.TabIndex = 1;
      // 
      // TailToggle
      // 
      this.TailToggle.Appearance = System.Windows.Forms.Appearance.Button;
      this.TailToggle.AutoSize = true;
      this.TailToggle.Checked = true;
      this.TailToggle.CheckState = System.Windows.Forms.CheckState.Checked;
      this.TailToggle.Location = new System.Drawing.Point(1462, 2);
      this.TailToggle.Margin = new System.Windows.Forms.Padding(2);
      this.TailToggle.Name = "TailToggle";
      this.TailToggle.Size = new System.Drawing.Size(40, 28);
      this.TailToggle.TabIndex = 0;
      this.TailToggle.Text = "Tail";
      this.TailToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.TailToggle.UseVisualStyleBackColor = true;
      // 
      // OmniFilter
      // 
      this.OmniFilter.Dock = System.Windows.Forms.DockStyle.Fill;
      this.OmniFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.OmniFilter.Location = new System.Drawing.Point(2, 2);
      this.OmniFilter.Margin = new System.Windows.Forms.Padding(2);
      this.OmniFilter.Name = "OmniFilter";
      this.OmniFilter.Size = new System.Drawing.Size(1456, 29);
      this.OmniFilter.TabIndex = 1;
      // 
      // MewsiferConsole
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1536, 707);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "MewsiferConsole";
      this.Text = "MewsiferConsole";
      this.tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.ResumeLayout(false);

        }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private CheckBox TailToggle;
        private TextBox OmniFilter;
    private DataGridViewTextBoxColumn Severity;
    private DataGridViewTextBoxColumn ChannelName;
    private DataGridViewTextBoxColumn Message;
  }
}