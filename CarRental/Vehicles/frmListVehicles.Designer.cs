namespace CarRental
{
    partial class frmListVehicles
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
            this.dgvVehiclesList = new System.Windows.Forms.DataGridView();
            this.btnAddNewVehicle = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.cmsVehicleActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.cboSearchField = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.stsStatusBar = new System.Windows.Forms.StatusStrip();
            this.tsslRecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLastUpdated = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlButtonContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiclesList)).BeginInit();
            this.cmsVehicleActions.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.stsStatusBar.SuspendLayout();
            this.pnlButtonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVehiclesList
            // 
            this.dgvVehiclesList.AllowUserToAddRows = false;
            this.dgvVehiclesList.AllowUserToDeleteRows = false;
            this.dgvVehiclesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehiclesList.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehiclesList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVehiclesList.ColumnHeadersHeight = 40;
            this.dgvVehiclesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVehiclesList.Location = new System.Drawing.Point(15, 120);
            this.dgvVehiclesList.MultiSelect = false;
            this.dgvVehiclesList.Name = "dgvVehiclesList";
            this.dgvVehiclesList.ReadOnly = true;
            this.dgvVehiclesList.RowHeadersVisible = false;
            this.dgvVehiclesList.RowHeadersWidth = 51;
            this.dgvVehiclesList.RowTemplate.Height = 35;
            this.dgvVehiclesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiclesList.Size = new System.Drawing.Size(1050, 350);
            this.dgvVehiclesList.TabIndex = 0;
            this.dgvVehiclesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiclesList_CellDoubleClick);
            this.dgvVehiclesList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvVehiclesList_MouseClick);
            // 
            // btnAddNewVehicle
            // 
            this.btnAddNewVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAddNewVehicle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewVehicle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewVehicle.Location = new System.Drawing.Point(10, 10);
            this.btnAddNewVehicle.Name = "btnAddNewVehicle";
            this.btnAddNewVehicle.Size = new System.Drawing.Size(130, 40);
            this.btnAddNewVehicle.TabIndex = 1;
            this.btnAddNewVehicle.Text = "Add New Vehicle";
            this.btnAddNewVehicle.UseVisualStyleBackColor = false;
            this.btnAddNewVehicle.Click += new System.EventHandler(this.btnAddNewVehicle_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshList.Location = new System.Drawing.Point(150, 10);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(130, 40);
            this.btnRefreshList.TabIndex = 2;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCloseForm.Location = new System.Drawing.Point(935, 10);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(130, 40);
            this.btnCloseForm.TabIndex = 3;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // cmsVehicleActions
            // 
            this.cmsVehicleActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsVehicleActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditVehicle,
            this.tsmiDeleteVehicle,
            this.toolStripSeparator1,
            this.tsmiViewDetails});
            this.cmsVehicleActions.Name = "cmsVehicleActions";
            this.cmsVehicleActions.Size = new System.Drawing.Size(174, 82);
            // 
            // tsmiEditVehicle
            // 
            this.tsmiEditVehicle.Name = "tsmiEditVehicle";
            this.tsmiEditVehicle.Size = new System.Drawing.Size(173, 24);
            this.tsmiEditVehicle.Text = "Edit Vehicle";
            this.tsmiEditVehicle.Click += new System.EventHandler(this.tsmiEditVehicle_Click);
            // 
            // tsmiDeleteVehicle
            // 
            this.tsmiDeleteVehicle.Name = "tsmiDeleteVehicle";
            this.tsmiDeleteVehicle.Size = new System.Drawing.Size(173, 24);
            this.tsmiDeleteVehicle.Text = "Delete Vehicle";
            this.tsmiDeleteVehicle.Click += new System.EventHandler(this.tsmiDeleteVehicle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // tsmiViewDetails
            // 
            this.tsmiViewDetails.Name = "tsmiViewDetails";
            this.tsmiViewDetails.Size = new System.Drawing.Size(173, 24);
            this.tsmiViewDetails.Text = "View Details";
            this.tsmiViewDetails.Click += new System.EventHandler(this.tsmiViewDetails_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblSearchTitle);
            this.grpSearch.Controls.Add(this.cboSearchField);
            this.grpSearch.Controls.Add(this.txtSearchValue);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.btnClearSearch);
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpSearch.Location = new System.Drawing.Point(15, 15);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(1080, 90);
            this.grpSearch.TabIndex = 5;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Vehicles";
            this.grpSearch.Enter += new System.EventHandler(this.grpSearch_Enter);
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchTitle.Location = new System.Drawing.Point(15, 35);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(80, 20);
            this.lblSearchTitle.TabIndex = 0;
            this.lblSearchTitle.Text = "Search by:";
            // 
            // cboSearchField
            // 
            this.cboSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboSearchField.FormattingEnabled = true;
            this.cboSearchField.Location = new System.Drawing.Point(120, 32);
            this.cboSearchField.Name = "cboSearchField";
            this.cboSearchField.Size = new System.Drawing.Size(180, 28);
            this.cboSearchField.TabIndex = 1;
            this.cboSearchField.SelectedIndexChanged += new System.EventHandler(this.cboSearchField_SelectedIndexChanged);
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchValue.Location = new System.Drawing.Point(310, 32);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(300, 27);
            this.txtSearchValue.TabIndex = 2;
            this.txtSearchValue.TextChanged += new System.EventHandler(this.txtSearchValue_TextChanged);
            this.txtSearchValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchValue_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(625, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(735, 30);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(100, 32);
            this.btnClearSearch.TabIndex = 4;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // stsStatusBar
            // 
            this.stsStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslRecordCount,
            this.tsslSeparator,
            this.tsslLastUpdated});
            this.stsStatusBar.Location = new System.Drawing.Point(0, 555);
            this.stsStatusBar.Name = "stsStatusBar";
            this.stsStatusBar.Size = new System.Drawing.Size(1110, 26);
            this.stsStatusBar.TabIndex = 6;
            this.stsStatusBar.Text = "statusStrip1";
            // 
            // tsslRecordCount
            // 
            this.tsslRecordCount.Name = "tsslRecordCount";
            this.tsslRecordCount.Size = new System.Drawing.Size(114, 20);
            this.tsslRecordCount.Text = "Total Records: 0";
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
            this.pnlButtonContainer.Controls.Add(this.btnAddNewVehicle);
            this.pnlButtonContainer.Controls.Add(this.btnRefreshList);
            this.pnlButtonContainer.Controls.Add(this.btnCloseForm);
            this.pnlButtonContainer.Location = new System.Drawing.Point(15, 480);
            this.pnlButtonContainer.Name = "pnlButtonContainer";
            this.pnlButtonContainer.Size = new System.Drawing.Size(1080, 60);
            this.pnlButtonContainer.TabIndex = 4;
            // 
            // frmListVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 581);
            this.ContextMenuStrip = this.cmsVehicleActions;
            this.Controls.Add(this.stsStatusBar);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.pnlButtonContainer);
            this.Controls.Add(this.dgvVehiclesList);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListVehicles";
            this.Text = "Vehicle Management";
            this.Load += new System.EventHandler(this.frmListVehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiclesList)).EndInit();
            this.cmsVehicleActions.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.stsStatusBar.ResumeLayout(false);
            this.stsStatusBar.PerformLayout();
            this.pnlButtonContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Data Grid View
        private System.Windows.Forms.DataGridView dgvVehiclesList;

        // Buttons
        private System.Windows.Forms.Button btnAddNewVehicle;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnCloseForm;

        // Context Menu
        private System.Windows.Forms.ContextMenuStrip cmsVehicleActions;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditVehicle;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteVehicle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewDetails;

        // Search Panel
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.ComboBox cboSearchField;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;

        // Status Strip
        private System.Windows.Forms.StatusStrip stsStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslRecordCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslSeparator;
        private System.Windows.Forms.ToolStripStatusLabel tsslLastUpdated;

        // Panel
        private System.Windows.Forms.Panel pnlButtonContainer;
    }
}