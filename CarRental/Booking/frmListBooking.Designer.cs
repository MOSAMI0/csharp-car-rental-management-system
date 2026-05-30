namespace CarRental.Booking
{
    partial class frmListBooking
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
            this.dgvBookingsList = new System.Windows.Forms.DataGridView();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.cmsBookingActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCancelBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.stsStatusBar = new System.Windows.Forms.StatusStrip();
            this.tsslRecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLastUpdated = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlButtonContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingsList)).BeginInit();
            this.cmsBookingActions.SuspendLayout();
            this.stsStatusBar.SuspendLayout();
            this.pnlButtonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBookingsList
            // 
            this.dgvBookingsList.AllowUserToAddRows = false;
            this.dgvBookingsList.AllowUserToDeleteRows = false;
            this.dgvBookingsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookingsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookingsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBookingsList.ColumnHeadersHeight = 40;
            this.dgvBookingsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBookingsList.Location = new System.Drawing.Point(15, 15);
            this.dgvBookingsList.MultiSelect = false;
            this.dgvBookingsList.Name = "dgvBookingsList";
            this.dgvBookingsList.ReadOnly = true;
            this.dgvBookingsList.RowHeadersVisible = false;
            this.dgvBookingsList.RowHeadersWidth = 51;
            this.dgvBookingsList.RowTemplate.Height = 35;
            this.dgvBookingsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookingsList.Size = new System.Drawing.Size(950, 350);
            this.dgvBookingsList.TabIndex = 0;
            this.dgvBookingsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookingsList_CellDoubleClick);
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNewBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNewBooking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewBooking.Location = new System.Drawing.Point(10, 10);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(140, 40);
            this.btnNewBooking.TabIndex = 1;
            this.btnNewBooking.Text = "New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = false;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
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
            this.btnCloseForm.Location = new System.Drawing.Point(830, 10);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(120, 40);
            this.btnCloseForm.TabIndex = 3;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // cmsBookingActions
            // 
            this.cmsBookingActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsBookingActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewDetails,
            this.tsmiEditBooking,
            this.toolStripSeparator1,
            this.tsmiCancelBooking,
            this.tsmiDeleteBooking});
            this.cmsBookingActions.Name = "cmsBookingActions";
            this.cmsBookingActions.Size = new System.Drawing.Size(182, 106);
            // 
            // tsmiViewDetails
            // 
            this.tsmiViewDetails.Name = "tsmiViewDetails";
            this.tsmiViewDetails.Size = new System.Drawing.Size(181, 24);
            this.tsmiViewDetails.Text = "View Details";
            this.tsmiViewDetails.Click += new System.EventHandler(this.tsmiViewDetails_Click);
            // 
            // tsmiEditBooking
            // 
            this.tsmiEditBooking.Name = "tsmiEditBooking";
            this.tsmiEditBooking.Size = new System.Drawing.Size(181, 24);
            this.tsmiEditBooking.Text = "Edit Booking";
            this.tsmiEditBooking.Click += new System.EventHandler(this.tsmiEditBooking_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // tsmiCancelBooking
            // 
            this.tsmiCancelBooking.Name = "tsmiCancelBooking";
            this.tsmiCancelBooking.Size = new System.Drawing.Size(181, 24);
            this.tsmiCancelBooking.Text = "Cancel Booking";
            this.tsmiCancelBooking.Click += new System.EventHandler(this.tsmiCancelBooking_Click);
            // 
            // tsmiDeleteBooking
            // 
            this.tsmiDeleteBooking.Name = "tsmiDeleteBooking";
            this.tsmiDeleteBooking.Size = new System.Drawing.Size(181, 24);
            this.tsmiDeleteBooking.Text = "Delete Booking";
            this.tsmiDeleteBooking.Click += new System.EventHandler(this.tsmiDeleteBooking_Click);
            // 
            // stsStatusBar
            // 
            this.stsStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslRecordCount,
            this.tsslSeparator,
            this.tsslLastUpdated});
            this.stsStatusBar.Location = new System.Drawing.Point(0, 455);
            this.stsStatusBar.Name = "stsStatusBar";
            this.stsStatusBar.Size = new System.Drawing.Size(1020, 26);
            this.stsStatusBar.TabIndex = 5;
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
            this.pnlButtonContainer.Controls.Add(this.btnNewBooking);
            this.pnlButtonContainer.Controls.Add(this.btnRefreshList);
            this.pnlButtonContainer.Controls.Add(this.btnCloseForm);
            this.pnlButtonContainer.Location = new System.Drawing.Point(15, 380);
            this.pnlButtonContainer.Name = "pnlButtonContainer";
            this.pnlButtonContainer.Size = new System.Drawing.Size(980, 60);
            this.pnlButtonContainer.TabIndex = 4;
            // 
            // frmListBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 481);
            this.ContextMenuStrip = this.cmsBookingActions;
            this.Controls.Add(this.stsStatusBar);
            this.Controls.Add(this.pnlButtonContainer);
            this.Controls.Add(this.dgvBookingsList);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListBooking";
            this.Text = "Booking Management";
            this.Load += new System.EventHandler(this.frmListBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingsList)).EndInit();
            this.cmsBookingActions.ResumeLayout(false);
            this.stsStatusBar.ResumeLayout(false);
            this.stsStatusBar.PerformLayout();
            this.pnlButtonContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Data Grid View
        private System.Windows.Forms.DataGridView dgvBookingsList;

        // Buttons
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnCloseForm;

        // Context Menu
        private System.Windows.Forms.ContextMenuStrip cmsBookingActions;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditBooking;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelBooking;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteBooking;

        // Status Strip
        private System.Windows.Forms.StatusStrip stsStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslRecordCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslSeparator;
        private System.Windows.Forms.ToolStripStatusLabel tsslLastUpdated;

        // Panel
        private System.Windows.Forms.Panel pnlButtonContainer;
    }
}