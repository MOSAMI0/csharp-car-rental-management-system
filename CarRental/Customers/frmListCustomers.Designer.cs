namespace CarRental
{
    partial class frmListCustomers
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
            this.dgvCustomersList = new System.Windows.Forms.DataGridView();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.cmsCustomerActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).BeginInit();
            this.cmsCustomerActions.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.stsStatusBar.SuspendLayout();
            this.pnlButtonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomersList
            // 
            this.dgvCustomersList.AllowUserToAddRows = false;
            this.dgvCustomersList.AllowUserToDeleteRows = false;
            this.dgvCustomersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomersList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomersList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCustomersList.ColumnHeadersHeight = 40;
            this.dgvCustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomersList.Location = new System.Drawing.Point(15, 120);
            this.dgvCustomersList.MultiSelect = false;
            this.dgvCustomersList.Name = "dgvCustomersList";
            this.dgvCustomersList.ReadOnly = true;
            this.dgvCustomersList.RowHeadersVisible = false;
            this.dgvCustomersList.RowHeadersWidth = 51;
            this.dgvCustomersList.RowTemplate.Height = 35;
            this.dgvCustomersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomersList.Size = new System.Drawing.Size(950, 350);
            this.dgvCustomersList.TabIndex = 0;
            this.dgvCustomersList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCustomersList_MouseClick);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(10, 10);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(150, 40);
            this.btnAddNewCustomer.TabIndex = 1;
            this.btnAddNewCustomer.Text = "Add New Customer";
            this.btnAddNewCustomer.UseVisualStyleBackColor = false;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshList.Location = new System.Drawing.Point(170, 10);
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
            this.btnCloseForm.Location = new System.Drawing.Point(820, 10);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(130, 40);
            this.btnCloseForm.TabIndex = 3;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // cmsCustomerActions
            // 
            this.cmsCustomerActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCustomerActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditCustomer,
            this.tsmiDeleteCustomer});
            this.cmsCustomerActions.Name = "cmsCustomerActions";
            this.cmsCustomerActions.Size = new System.Drawing.Size(190, 52);
            // 
            // tsmiEditCustomer
            // 
            this.tsmiEditCustomer.Name = "tsmiEditCustomer";
            this.tsmiEditCustomer.Size = new System.Drawing.Size(189, 24);
            this.tsmiEditCustomer.Text = "Edit Customer";
            this.tsmiEditCustomer.Click += new System.EventHandler(this.tsmiEditCustomer_Click);
            // 
            // tsmiDeleteCustomer
            // 
            this.tsmiDeleteCustomer.Name = "tsmiDeleteCustomer";
            this.tsmiDeleteCustomer.Size = new System.Drawing.Size(189, 24);
            this.tsmiDeleteCustomer.Text = "Delete Customer";
            this.tsmiDeleteCustomer.Click += new System.EventHandler(this.tsmiDeleteCustomer_Click);
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
            this.grpSearch.Size = new System.Drawing.Size(980, 90);
            this.grpSearch.TabIndex = 5;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Customers";
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
            this.cboSearchField.Items.AddRange(new object[] {
            "Customer ID",
            "Name",
            "Contact Information",
            "Driver License"});
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
            this.stsStatusBar.Size = new System.Drawing.Size(1020, 26);
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
            this.pnlButtonContainer.Controls.Add(this.btnAddNewCustomer);
            this.pnlButtonContainer.Controls.Add(this.btnRefreshList);
            this.pnlButtonContainer.Controls.Add(this.btnCloseForm);
            this.pnlButtonContainer.Location = new System.Drawing.Point(15, 480);
            this.pnlButtonContainer.Name = "pnlButtonContainer";
            this.pnlButtonContainer.Size = new System.Drawing.Size(980, 60);
            this.pnlButtonContainer.TabIndex = 4;
            // 
            // frmListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 581);
            this.ContextMenuStrip = this.cmsCustomerActions;
            this.Controls.Add(this.stsStatusBar);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.pnlButtonContainer);
            this.Controls.Add(this.dgvCustomersList);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListCustomers";
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.frmListCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).EndInit();
            this.cmsCustomerActions.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvCustomersList;

        // Buttons
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnCloseForm;

        // Context Menu
        private System.Windows.Forms.ContextMenuStrip cmsCustomerActions;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteCustomer;

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