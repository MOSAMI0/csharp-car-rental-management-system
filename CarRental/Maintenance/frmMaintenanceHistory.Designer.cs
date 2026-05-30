namespace CarRental.Maintenance
{
    partial class frmMaintenanceHistory
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
            // Data Grid View
            this.dgvMaintenanceHistory = new System.Windows.Forms.DataGridView();

            // Buttons
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();

            // Status Strip
            this.stsStatusBar = new System.Windows.Forms.StatusStrip();
            this.tsslRecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLastUpdated = new System.Windows.Forms.ToolStripStatusLabel();

            // Panel for buttons
            this.pnlButtonContainer = new System.Windows.Forms.Panel();

            // Group Box
            this.grpHistoryArchive = new System.Windows.Forms.GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceHistory)).BeginInit();
            this.stsStatusBar.SuspendLayout();
            this.pnlButtonContainer.SuspendLayout();
            this.grpHistoryArchive.SuspendLayout();
            this.SuspendLayout();

            // 
            // grpHistoryArchive
            // 
            this.grpHistoryArchive.Controls.Add(this.dgvMaintenanceHistory);
            this.grpHistoryArchive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpHistoryArchive.Location = new System.Drawing.Point(15, 15);
            this.grpHistoryArchive.Name = "grpHistoryArchive";
            this.grpHistoryArchive.Size = new System.Drawing.Size(980, 400);
            this.grpHistoryArchive.TabIndex = 0;
            this.grpHistoryArchive.TabStop = false;
            this.grpHistoryArchive.Text = "Maintenance History Archive";

            // 
            // dgvMaintenanceHistory
            // 
            this.dgvMaintenanceHistory.AllowUserToAddRows = false;
            this.dgvMaintenanceHistory.AllowUserToDeleteRows = false;
            this.dgvMaintenanceHistory.AllowUserToOrderColumns = true;
            this.dgvMaintenanceHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaintenanceHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaintenanceHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMaintenanceHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMaintenanceHistory.ColumnHeadersHeight = 40;
            this.dgvMaintenanceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMaintenanceHistory.GridColor = System.Drawing.Color.LightGray;
            this.dgvMaintenanceHistory.Location = new System.Drawing.Point(15, 30);
            this.dgvMaintenanceHistory.MultiSelect = false;
            this.dgvMaintenanceHistory.Name = "dgvMaintenanceHistory";
            this.dgvMaintenanceHistory.ReadOnly = true;
            this.dgvMaintenanceHistory.RowHeadersVisible = false;
            this.dgvMaintenanceHistory.RowHeadersWidth = 51;
            this.dgvMaintenanceHistory.RowTemplate.Height = 35;
            this.dgvMaintenanceHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaintenanceHistory.Size = new System.Drawing.Size(950, 355);
            this.dgvMaintenanceHistory.TabIndex = 0;

            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshList.Location = new System.Drawing.Point(10, 10);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(120, 40);
            this.btnRefreshList.TabIndex = 1;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);

            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseForm.Location = new System.Drawing.Point(850, 10);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(100, 40);
            this.btnCloseForm.TabIndex = 2;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);

            // 
            // pnlButtonContainer
            // 
            this.pnlButtonContainer.Controls.Add(this.btnRefreshList);
            this.pnlButtonContainer.Controls.Add(this.btnCloseForm);
            this.pnlButtonContainer.Location = new System.Drawing.Point(15, 425);
            this.pnlButtonContainer.Name = "pnlButtonContainer";
            this.pnlButtonContainer.Size = new System.Drawing.Size(980, 60);
            this.pnlButtonContainer.TabIndex = 3;

            // 
            // stsStatusBar
            // 
            this.stsStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslRecordCount,
            this.tsslSeparator,
            this.tsslLastUpdated});
            this.stsStatusBar.Location = new System.Drawing.Point(0, 500);
            this.stsStatusBar.Name = "stsStatusBar";
            this.stsStatusBar.Size = new System.Drawing.Size(1020, 26);
            this.stsStatusBar.TabIndex = 4;
            this.stsStatusBar.Text = "statusStrip1";

            // 
            // tsslRecordCount
            // 
            this.tsslRecordCount.Name = "tsslRecordCount";
            this.tsslRecordCount.Size = new System.Drawing.Size(120, 20);
            this.tsslRecordCount.Text = "Total Records: 0";

            // 
            // tsslSeparator
            // 
            this.tsslSeparator.Name = "tsslSeparator";
            this.tsslSeparator.Size = new System.Drawing.Size(10, 20);
            this.tsslSeparator.Text = "|";

            // 
            // tsslLastUpdated
            // 
            this.tsslLastUpdated.Name = "tsslLastUpdated";
            this.tsslLastUpdated.Size = new System.Drawing.Size(100, 20);
            this.tsslLastUpdated.Text = "Last Updated: --";

            // 
            // frmMaintenanceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 526);
            this.Controls.Add(this.stsStatusBar);
            this.Controls.Add(this.pnlButtonContainer);
            this.Controls.Add(this.grpHistoryArchive);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMaintenanceHistory";
           // this.StartPosition = System.Windows.Forms.StartPosition.CenterParent;
            this.Text = "Maintenance History";
            this.Load += new System.EventHandler(this.frmMaintenanceHistory_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceHistory)).EndInit();
            this.stsStatusBar.ResumeLayout(false);
            this.stsStatusBar.PerformLayout();
            this.pnlButtonContainer.ResumeLayout(false);
            this.grpHistoryArchive.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Data Grid View
        private System.Windows.Forms.DataGridView dgvMaintenanceHistory;

        // Buttons
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnCloseForm;

        // Status Strip
        private System.Windows.Forms.StatusStrip stsStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslRecordCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslSeparator;
        private System.Windows.Forms.ToolStripStatusLabel tsslLastUpdated;

        // Panel & Group Box
        private System.Windows.Forms.Panel pnlButtonContainer;
        private System.Windows.Forms.GroupBox grpHistoryArchive;
    }
}