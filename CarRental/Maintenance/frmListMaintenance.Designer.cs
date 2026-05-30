namespace CarRental.Maintenance
{
    partial class frmListMaintenance
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
            this.dgvMaintenanceList = new System.Windows.Forms.DataGridView();
            this.btnNewMaintenance = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.stsStatusBar = new System.Windows.Forms.StatusStrip();
            this.tsslRecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLastUpdated = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlButtonContainer = new System.Windows.Forms.Panel();
            this.grpMaintenanceList = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceList)).BeginInit();
            this.stsStatusBar.SuspendLayout();
            this.pnlButtonContainer.SuspendLayout();
            this.grpMaintenanceList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaintenanceList
            // 
            this.dgvMaintenanceList.AllowUserToAddRows = false;
            this.dgvMaintenanceList.AllowUserToDeleteRows = false;
            this.dgvMaintenanceList.AllowUserToOrderColumns = true;
            this.dgvMaintenanceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaintenanceList.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaintenanceList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMaintenanceList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMaintenanceList.ColumnHeadersHeight = 40;
            this.dgvMaintenanceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMaintenanceList.GridColor = System.Drawing.Color.LightGray;
            this.dgvMaintenanceList.Location = new System.Drawing.Point(15, 30);
            this.dgvMaintenanceList.MultiSelect = false;
            this.dgvMaintenanceList.Name = "dgvMaintenanceList";
            this.dgvMaintenanceList.RowHeadersVisible = false;
            this.dgvMaintenanceList.RowHeadersWidth = 51;
            this.dgvMaintenanceList.RowTemplate.Height = 35;
            this.dgvMaintenanceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaintenanceList.Size = new System.Drawing.Size(950, 355);
            this.dgvMaintenanceList.TabIndex = 0;
            this.dgvMaintenanceList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaintenanceList_CellValueChanged);
            this.dgvMaintenanceList.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvMaintenanceList_CurrentCellDirtyStateChanged);
            // 
            // btnNewMaintenance
            // 
            this.btnNewMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNewMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNewMaintenance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewMaintenance.Location = new System.Drawing.Point(10, 10);
            this.btnNewMaintenance.Name = "btnNewMaintenance";
            this.btnNewMaintenance.Size = new System.Drawing.Size(169, 40);
            this.btnNewMaintenance.TabIndex = 1;
            this.btnNewMaintenance.Text = "New Maintenance";
            this.btnNewMaintenance.UseVisualStyleBackColor = false;
            this.btnNewMaintenance.Click += new System.EventHandler(this.btnNewMaintenance_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHistory.Location = new System.Drawing.Point(185, 10);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(189, 40);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "Maintenance History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshList.Location = new System.Drawing.Point(700, 10);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(120, 40);
            this.btnRefreshList.TabIndex = 3;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCloseForm.Location = new System.Drawing.Point(830, 10);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(100, 40);
            this.btnCloseForm.TabIndex = 4;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // stsStatusBar
            // 
            this.stsStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslRecordCount,
            this.tsslSeparator,
            this.tsslLastUpdated});
            this.stsStatusBar.Location = new System.Drawing.Point(0, 480);
            this.stsStatusBar.Name = "stsStatusBar";
            this.stsStatusBar.Size = new System.Drawing.Size(1020, 26);
            this.stsStatusBar.TabIndex = 6;
            this.stsStatusBar.Text = "statusStrip1";
            // 
            // tsslRecordCount
            // 
            this.tsslRecordCount.Name = "tsslRecordCount";
            this.tsslRecordCount.Size = new System.Drawing.Size(166, 20);
            this.tsslRecordCount.Text = "Pending Maintenance: 0";
            // 
            // tsslSeparator
            // 
            this.tsslSeparator.Name = "tsslSeparator";
            this.tsslSeparator.Size = new System.Drawing.Size(13, 20);
            this.tsslSeparator.Text = "|";
            // 
            // tsslLastUpdated
            // 
            this.tsslLastUpdated.Name = "tsslLastUpdated";
            this.tsslLastUpdated.Size = new System.Drawing.Size(116, 20);
            this.tsslLastUpdated.Text = "Last Updated: --";
            // 
            // pnlButtonContainer
            // 
            this.pnlButtonContainer.Controls.Add(this.btnNewMaintenance);
            this.pnlButtonContainer.Controls.Add(this.btnHistory);
            this.pnlButtonContainer.Controls.Add(this.btnRefreshList);
            this.pnlButtonContainer.Controls.Add(this.btnCloseForm);
            this.pnlButtonContainer.Location = new System.Drawing.Point(15, 425);
            this.pnlButtonContainer.Name = "pnlButtonContainer";
            this.pnlButtonContainer.Size = new System.Drawing.Size(980, 60);
            this.pnlButtonContainer.TabIndex = 5;
            // 
            // grpMaintenanceList
            // 
            this.grpMaintenanceList.Controls.Add(this.dgvMaintenanceList);
            this.grpMaintenanceList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpMaintenanceList.Location = new System.Drawing.Point(15, 15);
            this.grpMaintenanceList.Name = "grpMaintenanceList";
            this.grpMaintenanceList.Size = new System.Drawing.Size(980, 400);
            this.grpMaintenanceList.TabIndex = 0;
            this.grpMaintenanceList.TabStop = false;
            this.grpMaintenanceList.Text = "Pending Maintenance";
            // 
            // frmListMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 506);
            this.Controls.Add(this.stsStatusBar);
            this.Controls.Add(this.pnlButtonContainer);
            this.Controls.Add(this.grpMaintenanceList);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListMaintenance";
            this.Text = "Maintenance Management";
            this.Load += new System.EventHandler(this.frmListMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceList)).EndInit();
            this.stsStatusBar.ResumeLayout(false);
            this.stsStatusBar.PerformLayout();
            this.pnlButtonContainer.ResumeLayout(false);
            this.grpMaintenanceList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Data Grid View
        private System.Windows.Forms.DataGridView dgvMaintenanceList;

        // Buttons
        private System.Windows.Forms.Button btnNewMaintenance;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnCloseForm;

        // Status Strip
        private System.Windows.Forms.StatusStrip stsStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslRecordCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslSeparator;
        private System.Windows.Forms.ToolStripStatusLabel tsslLastUpdated;

        // Panel & Group Box
        private System.Windows.Forms.Panel pnlButtonContainer;
        private System.Windows.Forms.GroupBox grpMaintenanceList;
    }
}