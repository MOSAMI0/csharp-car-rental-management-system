namespace CarRental.Transaction
{
    partial class frmListTransactions
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
            this.dgvTransactionsList = new System.Windows.Forms.DataGridView();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.stsStatusBar = new System.Windows.Forms.StatusStrip();
            this.tsslRecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTotalAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSeparator2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLastUpdated = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlButtonContainer = new System.Windows.Forms.Panel();
            this.grpTransactionsArchive = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionsList)).BeginInit();
            this.stsStatusBar.SuspendLayout();
            this.pnlButtonContainer.SuspendLayout();
            this.grpTransactionsArchive.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransactionsList
            // 
            this.dgvTransactionsList.AllowUserToAddRows = false;
            this.dgvTransactionsList.AllowUserToDeleteRows = false;
            this.dgvTransactionsList.AllowUserToOrderColumns = true;
            this.dgvTransactionsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactionsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactionsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTransactionsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTransactionsList.ColumnHeadersHeight = 40;
            this.dgvTransactionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransactionsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTransactionsList.GridColor = System.Drawing.Color.LightGray;
            this.dgvTransactionsList.Location = new System.Drawing.Point(15, 30);
            this.dgvTransactionsList.MultiSelect = false;
            this.dgvTransactionsList.Name = "dgvTransactionsList";
            this.dgvTransactionsList.ReadOnly = true;
            this.dgvTransactionsList.RowHeadersVisible = false;
            this.dgvTransactionsList.RowHeadersWidth = 51;
            this.dgvTransactionsList.RowTemplate.Height = 35;
            this.dgvTransactionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionsList.Size = new System.Drawing.Size(950, 355);
            this.dgvTransactionsList.TabIndex = 0;
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.btnCloseForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCloseForm.Location = new System.Drawing.Point(850, 10);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(100, 40);
            this.btnCloseForm.TabIndex = 2;
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
            this.tsslTotalAmount,
            this.tsslSeparator2,
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
            this.tsslRecordCount.Size = new System.Drawing.Size(142, 20);
            this.tsslRecordCount.Text = "Total Transactions: 0";
            // 
            // tsslSeparator
            // 
            this.tsslSeparator.Name = "tsslSeparator";
            this.tsslSeparator.Size = new System.Drawing.Size(13, 20);
            this.tsslSeparator.Text = "|";
            // 
            // tsslTotalAmount
            // 
            this.tsslTotalAmount.Name = "tsslTotalAmount";
            this.tsslTotalAmount.Size = new System.Drawing.Size(122, 20);
            this.tsslTotalAmount.Text = "Total Amount: $0";
            // 
            // tsslSeparator2
            // 
            this.tsslSeparator2.Name = "tsslSeparator2";
            this.tsslSeparator2.Size = new System.Drawing.Size(13, 20);
            this.tsslSeparator2.Text = "|";
            // 
            // tsslLastUpdated
            // 
            this.tsslLastUpdated.Name = "tsslLastUpdated";
            this.tsslLastUpdated.Size = new System.Drawing.Size(116, 20);
            this.tsslLastUpdated.Text = "Last Updated: --";
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
            // grpTransactionsArchive
            // 
            this.grpTransactionsArchive.Controls.Add(this.dgvTransactionsList);
            this.grpTransactionsArchive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpTransactionsArchive.Location = new System.Drawing.Point(15, 15);
            this.grpTransactionsArchive.Name = "grpTransactionsArchive";
            this.grpTransactionsArchive.Size = new System.Drawing.Size(980, 400);
            this.grpTransactionsArchive.TabIndex = 0;
            this.grpTransactionsArchive.TabStop = false;
            this.grpTransactionsArchive.Text = "Transactions Archive";
            // 
            // frmListTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 526);
            this.Controls.Add(this.stsStatusBar);
            this.Controls.Add(this.pnlButtonContainer);
            this.Controls.Add(this.grpTransactionsArchive);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListTransactions";
            this.Text = "Transactions Archive";
            this.Load += new System.EventHandler(this.frmListTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionsList)).EndInit();
            this.stsStatusBar.ResumeLayout(false);
            this.stsStatusBar.PerformLayout();
            this.pnlButtonContainer.ResumeLayout(false);
            this.grpTransactionsArchive.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Data Grid View
        private System.Windows.Forms.DataGridView dgvTransactionsList;

        // Buttons
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnCloseForm;

        // Status Strip
        private System.Windows.Forms.StatusStrip stsStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslRecordCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslSeparator;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalAmount;
        private System.Windows.Forms.ToolStripStatusLabel tsslSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel tsslLastUpdated;

        // Panel & Group Box
        private System.Windows.Forms.Panel pnlButtonContainer;
        private System.Windows.Forms.GroupBox grpTransactionsArchive;
    }
}