namespace CarRental.Return
{
    partial class frmListReturns
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
            this.components = new System.ComponentModel.Container();
            this.dgvReturnsList = new System.Windows.Forms.DataGridView();
            this.btnReturnVehicle = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.cmsReturnActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDeleteReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.stsStatusBar = new System.Windows.Forms.StatusStrip();
            this.tsslRecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLastUpdated = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlButtonContainer = new System.Windows.Forms.Panel();
            this.grpReturnsArchive = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnsList)).BeginInit();
            this.cmsReturnActions.SuspendLayout();
            this.stsStatusBar.SuspendLayout();
            this.pnlButtonContainer.SuspendLayout();
            this.grpReturnsArchive.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReturnsList
            // 
            this.dgvReturnsList.AllowUserToAddRows = false;
            this.dgvReturnsList.AllowUserToDeleteRows = false;
            this.dgvReturnsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvReturnsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReturnsList.ColumnHeadersHeight = 40;
            this.dgvReturnsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReturnsList.Location = new System.Drawing.Point(15, 30);
            this.dgvReturnsList.MultiSelect = false;
            this.dgvReturnsList.Name = "dgvReturnsList";
            this.dgvReturnsList.ReadOnly = true;
            this.dgvReturnsList.RowHeadersVisible = false;
            this.dgvReturnsList.RowHeadersWidth = 51;
            this.dgvReturnsList.RowTemplate.Height = 35;
            this.dgvReturnsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnsList.Size = new System.Drawing.Size(950, 355);
            this.dgvReturnsList.TabIndex = 0;
            // 
            // btnReturnVehicle
            // 
            this.btnReturnVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnReturnVehicle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReturnVehicle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturnVehicle.Location = new System.Drawing.Point(10, 10);
            this.btnReturnVehicle.Name = "btnReturnVehicle";
            this.btnReturnVehicle.Size = new System.Drawing.Size(140, 40);
            this.btnReturnVehicle.TabIndex = 1;
            this.btnReturnVehicle.Text = "Return Vehicle";
            this.btnReturnVehicle.UseVisualStyleBackColor = false;
            this.btnReturnVehicle.Click += new System.EventHandler(this.btnReturnVehicle_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshList.Location = new System.Drawing.Point(160, 10);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(120, 40);
            this.btnRefreshList.TabIndex = 2;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCloseForm.Location = new System.Drawing.Point(860, 10);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(100, 40);
            this.btnCloseForm.TabIndex = 3;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // cmsReturnActions
            // 
            this.cmsReturnActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsReturnActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteReturn});
            this.cmsReturnActions.Name = "cmsReturnActions";
            this.cmsReturnActions.Size = new System.Drawing.Size(221, 28);
            // 
            // tsmiDeleteReturn
            // 
            this.tsmiDeleteReturn.Name = "tsmiDeleteReturn";
            this.tsmiDeleteReturn.Size = new System.Drawing.Size(220, 24);
            this.tsmiDeleteReturn.Text = "Delete Return Record";
            this.tsmiDeleteReturn.Click += new System.EventHandler(this.tsmiDeleteReturn_Click);
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
            this.stsStatusBar.TabIndex = 5;
            this.stsStatusBar.Text = "statusStrip1";
            // 
            // tsslRecordCount
            // 
            this.tsslRecordCount.Name = "tsslRecordCount";
            this.tsslRecordCount.Size = new System.Drawing.Size(110, 20);
            this.tsslRecordCount.Text = "Total Returns: 0";
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
            this.pnlButtonContainer.Controls.Add(this.btnReturnVehicle);
            this.pnlButtonContainer.Controls.Add(this.btnRefreshList);
            this.pnlButtonContainer.Controls.Add(this.btnCloseForm);
            this.pnlButtonContainer.Location = new System.Drawing.Point(15, 425);
            this.pnlButtonContainer.Name = "pnlButtonContainer";
            this.pnlButtonContainer.Size = new System.Drawing.Size(980, 60);
            this.pnlButtonContainer.TabIndex = 4;
            // 
            // grpReturnsArchive
            // 
            this.grpReturnsArchive.Controls.Add(this.dgvReturnsList);
            this.grpReturnsArchive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpReturnsArchive.Location = new System.Drawing.Point(15, 15);
            this.grpReturnsArchive.Name = "grpReturnsArchive";
            this.grpReturnsArchive.Size = new System.Drawing.Size(980, 400);
            this.grpReturnsArchive.TabIndex = 0;
            this.grpReturnsArchive.TabStop = false;
            this.grpReturnsArchive.Text = "Returns Archive";
            // 
            // frmListReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 526);
            this.ContextMenuStrip = this.cmsReturnActions;
            this.Controls.Add(this.stsStatusBar);
            this.Controls.Add(this.pnlButtonContainer);
            this.Controls.Add(this.grpReturnsArchive);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListReturns";
            this.Text = "Returns Archive";
            this.Load += new System.EventHandler(this.frmListReturns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnsList)).EndInit();
            this.cmsReturnActions.ResumeLayout(false);
            this.stsStatusBar.ResumeLayout(false);
            this.stsStatusBar.PerformLayout();
            this.pnlButtonContainer.ResumeLayout(false);
            this.grpReturnsArchive.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Data Grid View
        private System.Windows.Forms.DataGridView dgvReturnsList;
        
        // Buttons
        private System.Windows.Forms.Button btnReturnVehicle;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnCloseForm;
        
        // Context Menu
        private System.Windows.Forms.ContextMenuStrip cmsReturnActions;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteReturn;
        
        // Status Strip
        private System.Windows.Forms.StatusStrip stsStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslRecordCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslSeparator;
        private System.Windows.Forms.ToolStripStatusLabel tsslLastUpdated;
        
        // Panel & Group Box
        private System.Windows.Forms.Panel pnlButtonContainer;
        private System.Windows.Forms.GroupBox grpReturnsArchive;
    }
}