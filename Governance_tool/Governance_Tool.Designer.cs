namespace Governance_tool
{
    partial class Governance_Tool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_CheckValue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_L1_Handler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Control_Report_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_LastUpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_IsStatus_Updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchby_l1_handler = new System.Windows.Forms.ComboBox();
            this.searchby_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update_complete = new System.Windows.Forms.Button();
            this.update_pending = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchby_status = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_CheckValue,
            this.txt_ID,
            this.txt_Date,
            this.txt_L1_Handler,
            this.txt_Control_Report_Name,
            this.txt_Frequency,
            this.txt_ProcessName,
            this.txt_LastUpdatedBy,
            this.txt_IsStatus_Updated,
            this.txt_Description});
            this.dataGridView1.Location = new System.Drawing.Point(25, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1617, 760);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // txt_CheckValue
            // 
            this.txt_CheckValue.HeaderText = "CheckValue";
            this.txt_CheckValue.MinimumWidth = 8;
            this.txt_CheckValue.Name = "txt_CheckValue";
            this.txt_CheckValue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txt_CheckValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.txt_CheckValue.Width = 150;
            // 
            // txt_ID
            // 
            this.txt_ID.DataPropertyName = "ID";
            this.txt_ID.HeaderText = "ID";
            this.txt_ID.MinimumWidth = 8;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Width = 50;
            // 
            // txt_Date
            // 
            this.txt_Date.DataPropertyName = "Date";
            this.txt_Date.HeaderText = "Date";
            this.txt_Date.MinimumWidth = 8;
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Width = 150;
            // 
            // txt_L1_Handler
            // 
            this.txt_L1_Handler.DataPropertyName = "L1_Handler";
            this.txt_L1_Handler.HeaderText = "L1_Handler";
            this.txt_L1_Handler.MinimumWidth = 8;
            this.txt_L1_Handler.Name = "txt_L1_Handler";
            this.txt_L1_Handler.Width = 150;
            // 
            // txt_Control_Report_Name
            // 
            this.txt_Control_Report_Name.DataPropertyName = "Control_Report_Name";
            this.txt_Control_Report_Name.HeaderText = "Control_Report_Name";
            this.txt_Control_Report_Name.MinimumWidth = 8;
            this.txt_Control_Report_Name.Name = "txt_Control_Report_Name";
            this.txt_Control_Report_Name.Width = 200;
            // 
            // txt_Frequency
            // 
            this.txt_Frequency.DataPropertyName = "Frequency";
            this.txt_Frequency.HeaderText = "Frequency";
            this.txt_Frequency.MinimumWidth = 8;
            this.txt_Frequency.Name = "txt_Frequency";
            this.txt_Frequency.Width = 150;
            // 
            // txt_ProcessName
            // 
            this.txt_ProcessName.DataPropertyName = "ProcessName";
            this.txt_ProcessName.HeaderText = "ProcessName";
            this.txt_ProcessName.MinimumWidth = 8;
            this.txt_ProcessName.Name = "txt_ProcessName";
            this.txt_ProcessName.Width = 150;
            // 
            // txt_LastUpdatedBy
            // 
            this.txt_LastUpdatedBy.DataPropertyName = "LastUpdatedBy";
            this.txt_LastUpdatedBy.HeaderText = "LastUpdatedBy";
            this.txt_LastUpdatedBy.MinimumWidth = 8;
            this.txt_LastUpdatedBy.Name = "txt_LastUpdatedBy";
            this.txt_LastUpdatedBy.Width = 150;
            // 
            // txt_IsStatus_Updated
            // 
            this.txt_IsStatus_Updated.DataPropertyName = "IsStatus_Updated";
            this.txt_IsStatus_Updated.HeaderText = "IsStatus_Updated";
            this.txt_IsStatus_Updated.MinimumWidth = 8;
            this.txt_IsStatus_Updated.Name = "txt_IsStatus_Updated";
            this.txt_IsStatus_Updated.Width = 150;
            // 
            // txt_Description
            // 
            this.txt_Description.DataPropertyName = "Description";
            this.txt_Description.HeaderText = "Description";
            this.txt_Description.MinimumWidth = 8;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Width = 400;
            // 
            // searchby_l1_handler
            // 
            this.searchby_l1_handler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchby_l1_handler.FormattingEnabled = true;
            this.searchby_l1_handler.Location = new System.Drawing.Point(441, 36);
            this.searchby_l1_handler.Name = "searchby_l1_handler";
            this.searchby_l1_handler.Size = new System.Drawing.Size(290, 28);
            this.searchby_l1_handler.TabIndex = 2;
            this.searchby_l1_handler.SelectedIndexChanged += new System.EventHandler(this.searchby_l1_handler_SelectedIndexChanged);
            this.searchby_l1_handler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchby_l1_handler_KeyDown);
            // 
            // searchby_date
            // 
            this.searchby_date.CustomFormat = " ";
            this.searchby_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchby_date.Location = new System.Drawing.Point(755, 37);
            this.searchby_date.Name = "searchby_date";
            this.searchby_date.Size = new System.Drawing.Size(217, 26);
            this.searchby_date.TabIndex = 3;
            this.searchby_date.ValueChanged += new System.EventHandler(this.searchby_date_ValueChanged);
            this.searchby_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchby_date_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search by L1 Handler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search by Date";
            // 
            // update_complete
            // 
            this.update_complete.Location = new System.Drawing.Point(25, 59);
            this.update_complete.Name = "update_complete";
            this.update_complete.Size = new System.Drawing.Size(188, 43);
            this.update_complete.TabIndex = 6;
            this.update_complete.Text = "Update Complete";
            this.update_complete.UseVisualStyleBackColor = true;
            this.update_complete.Click += new System.EventHandler(this.update_complete_Click);
            // 
            // update_pending
            // 
            this.update_pending.Location = new System.Drawing.Point(25, 110);
            this.update_pending.Name = "update_pending";
            this.update_pending.Size = new System.Drawing.Size(188, 43);
            this.update_pending.TabIndex = 7;
            this.update_pending.Text = "Update Pending";
            this.update_pending.UseVisualStyleBackColor = true;
            this.update_pending.Click += new System.EventHandler(this.update_pending_Click);
            // 
            // reports
            // 
            this.reports.Location = new System.Drawing.Point(25, 8);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(188, 43);
            this.reports.TabIndex = 8;
            this.reports.Text = "Reports";
            this.reports.UseVisualStyleBackColor = true;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1047, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search by Status";
            // 
            // searchby_status
            // 
            this.searchby_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchby_status.FormattingEnabled = true;
            this.searchby_status.Location = new System.Drawing.Point(994, 35);
            this.searchby_status.Name = "searchby_status";
            this.searchby_status.Size = new System.Drawing.Size(236, 28);
            this.searchby_status.TabIndex = 10;
            this.searchby_status.SelectedIndexChanged += new System.EventHandler(this.searchby_status_SelectedIndexChanged);
            this.searchby_status.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchby_status_KeyDown);
            // 
            // Governance_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1782, 941);
            this.Controls.Add(this.searchby_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.update_pending);
            this.Controls.Add(this.update_complete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchby_date);
            this.Controls.Add(this.searchby_l1_handler);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Governance_Tool";
            this.Text = "Governance_Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Governance_Tool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox searchby_l1_handler;
        private System.Windows.Forms.DateTimePicker searchby_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn txt_CheckValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_L1_Handler;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Control_Report_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_LastUpdatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_IsStatus_Updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Description;
        private System.Windows.Forms.Button update_complete;
        private System.Windows.Forms.Button update_pending;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox searchby_status;
    }
}