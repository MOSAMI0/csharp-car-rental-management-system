namespace CarRental.Booking
{
    partial class frmAddBooking
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
            this.lblModeTitle = new System.Windows.Forms.Label();
            this.lblModeValue = new System.Windows.Forms.Label();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.lblVehicleTitle = new System.Windows.Forms.Label();
            this.lblStartDateTitle = new System.Windows.Forms.Label();
            this.lblEndDateTitle = new System.Windows.Forms.Label();
            this.lblPickupLocationTitle = new System.Windows.Forms.Label();
            this.lblDropoffLocationTitle = new System.Windows.Forms.Label();
            this.lblNotesTitle = new System.Windows.Forms.Label();
            this.lblRentalDaysTitle = new System.Windows.Forms.Label();
            this.lblTotalCostTitle = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.cboVehicle = new System.Windows.Forms.ComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtPickupLocation = new System.Windows.Forms.TextBox();
            this.txtDropoffLocation = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblRentalDaysValue = new System.Windows.Forms.Label();
            this.lblTotalCostValue = new System.Windows.Forms.Label();
            this.btnSaveBooking = new System.Windows.Forms.Button();
            this.btnCancelClose = new System.Windows.Forms.Button();
            this.grpBookingInformation = new System.Windows.Forms.GroupBox();
            this.grpRentalSummary = new System.Windows.Forms.GroupBox();
            this.grpBookingInformation.SuspendLayout();
            this.grpRentalSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModeTitle
            // 
            this.lblModeTitle.AutoSize = true;
            this.lblModeTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModeTitle.Location = new System.Drawing.Point(15, 20);
            this.lblModeTitle.Name = "lblModeTitle";
            this.lblModeTitle.Size = new System.Drawing.Size(53, 20);
            this.lblModeTitle.TabIndex = 2;
            this.lblModeTitle.Text = "Mode:";
            // 
            // lblModeValue
            // 
            this.lblModeValue.AutoSize = true;
            this.lblModeValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblModeValue.Location = new System.Drawing.Point(72, 20);
            this.lblModeValue.Name = "lblModeValue";
            this.lblModeValue.Size = new System.Drawing.Size(103, 20);
            this.lblModeValue.TabIndex = 3;
            this.lblModeValue.Text = "New Booking";
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomerTitle.Location = new System.Drawing.Point(20, 35);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(82, 20);
            this.lblCustomerTitle.TabIndex = 0;
            this.lblCustomerTitle.Text = "Customer:";
            // 
            // lblVehicleTitle
            // 
            this.lblVehicleTitle.AutoSize = true;
            this.lblVehicleTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVehicleTitle.Location = new System.Drawing.Point(20, 75);
            this.lblVehicleTitle.Name = "lblVehicleTitle";
            this.lblVehicleTitle.Size = new System.Drawing.Size(62, 20);
            this.lblVehicleTitle.TabIndex = 2;
            this.lblVehicleTitle.Text = "Vehicle:";
            // 
            // lblStartDateTitle
            // 
            this.lblStartDateTitle.AutoSize = true;
            this.lblStartDateTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStartDateTitle.Location = new System.Drawing.Point(20, 115);
            this.lblStartDateTitle.Name = "lblStartDateTitle";
            this.lblStartDateTitle.Size = new System.Drawing.Size(84, 20);
            this.lblStartDateTitle.TabIndex = 4;
            this.lblStartDateTitle.Text = "Start Date:";
            // 
            // lblEndDateTitle
            // 
            this.lblEndDateTitle.AutoSize = true;
            this.lblEndDateTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEndDateTitle.Location = new System.Drawing.Point(20, 155);
            this.lblEndDateTitle.Name = "lblEndDateTitle";
            this.lblEndDateTitle.Size = new System.Drawing.Size(76, 20);
            this.lblEndDateTitle.TabIndex = 6;
            this.lblEndDateTitle.Text = "End Date:";
            // 
            // lblPickupLocationTitle
            // 
            this.lblPickupLocationTitle.AutoSize = true;
            this.lblPickupLocationTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPickupLocationTitle.Location = new System.Drawing.Point(20, 195);
            this.lblPickupLocationTitle.Name = "lblPickupLocationTitle";
            this.lblPickupLocationTitle.Size = new System.Drawing.Size(123, 20);
            this.lblPickupLocationTitle.TabIndex = 8;
            this.lblPickupLocationTitle.Text = "Pickup Location:";
            // 
            // lblDropoffLocationTitle
            // 
            this.lblDropoffLocationTitle.AutoSize = true;
            this.lblDropoffLocationTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDropoffLocationTitle.Location = new System.Drawing.Point(20, 235);
            this.lblDropoffLocationTitle.Name = "lblDropoffLocationTitle";
            this.lblDropoffLocationTitle.Size = new System.Drawing.Size(133, 20);
            this.lblDropoffLocationTitle.TabIndex = 10;
            this.lblDropoffLocationTitle.Text = "Dropoff Location:";
            // 
            // lblNotesTitle
            // 
            this.lblNotesTitle.AutoSize = true;
            this.lblNotesTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNotesTitle.Location = new System.Drawing.Point(20, 275);
            this.lblNotesTitle.Name = "lblNotesTitle";
            this.lblNotesTitle.Size = new System.Drawing.Size(55, 20);
            this.lblNotesTitle.TabIndex = 12;
            this.lblNotesTitle.Text = "Notes:";
            // 
            // lblRentalDaysTitle
            // 
            this.lblRentalDaysTitle.AutoSize = true;
            this.lblRentalDaysTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRentalDaysTitle.Location = new System.Drawing.Point(20, 35);
            this.lblRentalDaysTitle.Name = "lblRentalDaysTitle";
            this.lblRentalDaysTitle.Size = new System.Drawing.Size(96, 20);
            this.lblRentalDaysTitle.TabIndex = 0;
            this.lblRentalDaysTitle.Text = "Rental Days:";
            // 
            // lblTotalCostTitle
            // 
            this.lblTotalCostTitle.AutoSize = true;
            this.lblTotalCostTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalCostTitle.Location = new System.Drawing.Point(20, 75);
            this.lblTotalCostTitle.Name = "lblTotalCostTitle";
            this.lblTotalCostTitle.Size = new System.Drawing.Size(83, 20);
            this.lblTotalCostTitle.TabIndex = 2;
            this.lblTotalCostTitle.Text = "Total Cost:";
            // 
            // cboCustomer
            // 
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(150, 32);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(320, 28);
            this.cboCustomer.TabIndex = 1;
            // 
            // cboVehicle
            // 
            this.cboVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboVehicle.FormattingEnabled = true;
            this.cboVehicle.Location = new System.Drawing.Point(150, 72);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(320, 28);
            this.cboVehicle.TabIndex = 3;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(150, 112);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(150, 27);
            this.dtpStartDate.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(150, 152);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(150, 27);
            this.dtpEndDate.TabIndex = 7;
            // 
            // txtPickupLocation
            // 
            this.txtPickupLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPickupLocation.Location = new System.Drawing.Point(150, 192);
            this.txtPickupLocation.MaxLength = 100;
            this.txtPickupLocation.Name = "txtPickupLocation";
            this.txtPickupLocation.Size = new System.Drawing.Size(320, 27);
            this.txtPickupLocation.TabIndex = 9;
            // 
            // txtDropoffLocation
            // 
            this.txtDropoffLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDropoffLocation.Location = new System.Drawing.Point(150, 232);
            this.txtDropoffLocation.MaxLength = 100;
            this.txtDropoffLocation.Name = "txtDropoffLocation";
            this.txtDropoffLocation.Size = new System.Drawing.Size(320, 27);
            this.txtDropoffLocation.TabIndex = 11;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.Location = new System.Drawing.Point(150, 272);
            this.txtNotes.MaxLength = 500;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(320, 100);
            this.txtNotes.TabIndex = 13;
            // 
            // lblRentalDaysValue
            // 
            this.lblRentalDaysValue.AutoSize = true;
            this.lblRentalDaysValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRentalDaysValue.Location = new System.Drawing.Point(150, 35);
            this.lblRentalDaysValue.Name = "lblRentalDaysValue";
            this.lblRentalDaysValue.Size = new System.Drawing.Size(17, 20);
            this.lblRentalDaysValue.TabIndex = 1;
            this.lblRentalDaysValue.Text = "0";
            // 
            // lblTotalCostValue
            // 
            this.lblTotalCostValue.AutoSize = true;
            this.lblTotalCostValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalCostValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblTotalCostValue.Location = new System.Drawing.Point(150, 75);
            this.lblTotalCostValue.Name = "lblTotalCostValue";
            this.lblTotalCostValue.Size = new System.Drawing.Size(49, 20);
            this.lblTotalCostValue.TabIndex = 3;
            this.lblTotalCostValue.Text = "$0.00";
            // 
            // btnSaveBooking
            // 
            this.btnSaveBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSaveBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveBooking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveBooking.Location = new System.Drawing.Point(540, 420);
            this.btnSaveBooking.Name = "btnSaveBooking";
            this.btnSaveBooking.Size = new System.Drawing.Size(150, 40);
            this.btnSaveBooking.TabIndex = 4;
            this.btnSaveBooking.Text = "Create Booking";
            this.btnSaveBooking.UseVisualStyleBackColor = false;
            this.btnSaveBooking.Click += new System.EventHandler(this.btnSaveBooking_Click);
            // 
            // btnCancelClose
            // 
            this.btnCancelClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelClose.Location = new System.Drawing.Point(710, 420);
            this.btnCancelClose.Name = "btnCancelClose";
            this.btnCancelClose.Size = new System.Drawing.Size(110, 40);
            this.btnCancelClose.TabIndex = 5;
            this.btnCancelClose.Text = "Cancel";
            this.btnCancelClose.UseVisualStyleBackColor = false;
            this.btnCancelClose.Click += new System.EventHandler(this.btnCancelClose_Click);
            // 
            // grpBookingInformation
            // 
            this.grpBookingInformation.Controls.Add(this.lblCustomerTitle);
            this.grpBookingInformation.Controls.Add(this.cboCustomer);
            this.grpBookingInformation.Controls.Add(this.lblVehicleTitle);
            this.grpBookingInformation.Controls.Add(this.cboVehicle);
            this.grpBookingInformation.Controls.Add(this.lblStartDateTitle);
            this.grpBookingInformation.Controls.Add(this.dtpStartDate);
            this.grpBookingInformation.Controls.Add(this.lblEndDateTitle);
            this.grpBookingInformation.Controls.Add(this.dtpEndDate);
            this.grpBookingInformation.Controls.Add(this.lblPickupLocationTitle);
            this.grpBookingInformation.Controls.Add(this.txtPickupLocation);
            this.grpBookingInformation.Controls.Add(this.lblDropoffLocationTitle);
            this.grpBookingInformation.Controls.Add(this.txtDropoffLocation);
            this.grpBookingInformation.Controls.Add(this.lblNotesTitle);
            this.grpBookingInformation.Controls.Add(this.txtNotes);
            this.grpBookingInformation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpBookingInformation.Location = new System.Drawing.Point(15, 60);
            this.grpBookingInformation.Name = "grpBookingInformation";
            this.grpBookingInformation.Size = new System.Drawing.Size(500, 400);
            this.grpBookingInformation.TabIndex = 0;
            this.grpBookingInformation.TabStop = false;
            this.grpBookingInformation.Text = "Booking Information";
            // 
            // grpRentalSummary
            // 
            this.grpRentalSummary.Controls.Add(this.lblRentalDaysTitle);
            this.grpRentalSummary.Controls.Add(this.lblRentalDaysValue);
            this.grpRentalSummary.Controls.Add(this.lblTotalCostTitle);
            this.grpRentalSummary.Controls.Add(this.lblTotalCostValue);
            this.grpRentalSummary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpRentalSummary.Location = new System.Drawing.Point(540, 60);
            this.grpRentalSummary.Name = "grpRentalSummary";
            this.grpRentalSummary.Size = new System.Drawing.Size(280, 150);
            this.grpRentalSummary.TabIndex = 1;
            this.grpRentalSummary.TabStop = false;
            this.grpRentalSummary.Text = "Rental Summary";
            // 
            // frmAddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 490);
            this.Controls.Add(this.btnCancelClose);
            this.Controls.Add(this.btnSaveBooking);
            this.Controls.Add(this.lblModeValue);
            this.Controls.Add(this.lblModeTitle);
            this.Controls.Add(this.grpRentalSummary);
            this.Controls.Add(this.grpBookingInformation);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddBooking";
            this.Text = "Create New Booking";
            this.Load += new System.EventHandler(this.frmAddBooking_Load);
            this.grpBookingInformation.ResumeLayout(false);
            this.grpBookingInformation.PerformLayout();
            this.grpRentalSummary.ResumeLayout(false);
            this.grpRentalSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Title Labels
        private System.Windows.Forms.Label lblModeTitle;
        private System.Windows.Forms.Label lblModeValue;

        // Field Labels
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.Label lblVehicleTitle;
        private System.Windows.Forms.Label lblStartDateTitle;
        private System.Windows.Forms.Label lblEndDateTitle;
        private System.Windows.Forms.Label lblPickupLocationTitle;
        private System.Windows.Forms.Label lblDropoffLocationTitle;
        private System.Windows.Forms.Label lblNotesTitle;
        private System.Windows.Forms.Label lblRentalDaysTitle;
        private System.Windows.Forms.Label lblTotalCostTitle;

        // Input Controls
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.ComboBox cboVehicle;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtPickupLocation;
        private System.Windows.Forms.TextBox txtDropoffLocation;
        private System.Windows.Forms.TextBox txtNotes;

        // Display Labels
        private System.Windows.Forms.Label lblRentalDaysValue;
        private System.Windows.Forms.Label lblTotalCostValue;

        // Buttons
        private System.Windows.Forms.Button btnSaveBooking;
        private System.Windows.Forms.Button btnCancelClose;

        // Group Boxes
        private System.Windows.Forms.GroupBox grpBookingInformation;
        private System.Windows.Forms.GroupBox grpRentalSummary;
    }
}