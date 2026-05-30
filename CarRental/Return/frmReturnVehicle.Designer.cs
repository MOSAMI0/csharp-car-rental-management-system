namespace CarRental.Return
{
    partial class frmReturnVehicle
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpReturnInformation = new System.Windows.Forms.GroupBox();
            this.lblBookingTitle = new System.Windows.Forms.Label();
            this.cboBooking = new System.Windows.Forms.ComboBox();
            this.lblReturnDateTitle = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblCurrentMileageTitle = new System.Windows.Forms.Label();
            this.txtCurrentMileage = new System.Windows.Forms.TextBox();
            this.lblConsumedKilometersTitle = new System.Windows.Forms.Label();
            this.txtConsumedKilometers = new System.Windows.Forms.TextBox();
            this.lblExtraChargesTitle = new System.Windows.Forms.Label();
            this.txtExtraCharges = new System.Windows.Forms.TextBox();
            this.lblReturnNotesTitle = new System.Windows.Forms.Label();
            this.txtReturnNotes = new System.Windows.Forms.TextBox();
            this.grpBookingDetails = new System.Windows.Forms.GroupBox();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.lblCustomerValue = new System.Windows.Forms.Label();
            this.lblVehicleTitle = new System.Windows.Forms.Label();
            this.lblVehicleValue = new System.Windows.Forms.Label();
            this.lblBookingPeriodTitle = new System.Windows.Forms.Label();
            this.lblBookingPeriodValue = new System.Windows.Forms.Label();
            this.lblBookedDaysTitle = new System.Windows.Forms.Label();
            this.lblBookedDaysValue = new System.Windows.Forms.Label();
            this.lblPricePerDayTitle = new System.Windows.Forms.Label();
            this.lblPricePerDayValue = new System.Windows.Forms.Label();
            this.lblOriginalTotalTitle = new System.Windows.Forms.Label();
            this.lblOriginalTotalValue = new System.Windows.Forms.Label();
            this.grpCalculationSummary = new System.Windows.Forms.GroupBox();
            this.lblActualDaysTitle = new System.Windows.Forms.Label();
            this.lblActualDaysValue = new System.Windows.Forms.Label();
            this.lblTotalDueTitle = new System.Windows.Forms.Label();
            this.lblTotalDueValue = new System.Windows.Forms.Label();
            this.lblSurplusMessage = new System.Windows.Forms.Label();
            this.btnCompleteReturn = new System.Windows.Forms.Button();
            this.btnCancelClose = new System.Windows.Forms.Button();
            this.stsStatusBar = new System.Windows.Forms.StatusStrip();
            this.tsslBookingStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpReturnInformation.SuspendLayout();
            this.grpBookingDetails.SuspendLayout();
            this.grpCalculationSummary.SuspendLayout();
            this.stsStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReturnInformation
            // 
            this.grpReturnInformation.Controls.Add(this.lblBookingTitle);
            this.grpReturnInformation.Controls.Add(this.cboBooking);
            this.grpReturnInformation.Controls.Add(this.lblReturnDateTitle);
            this.grpReturnInformation.Controls.Add(this.dtpReturnDate);
            this.grpReturnInformation.Controls.Add(this.lblCurrentMileageTitle);
            this.grpReturnInformation.Controls.Add(this.txtCurrentMileage);
            this.grpReturnInformation.Controls.Add(this.lblConsumedKilometersTitle);
            this.grpReturnInformation.Controls.Add(this.txtConsumedKilometers);
            this.grpReturnInformation.Controls.Add(this.lblExtraChargesTitle);
            this.grpReturnInformation.Controls.Add(this.txtExtraCharges);
            this.grpReturnInformation.Controls.Add(this.lblReturnNotesTitle);
            this.grpReturnInformation.Controls.Add(this.txtReturnNotes);
            this.grpReturnInformation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpReturnInformation.Location = new System.Drawing.Point(15, 15);
            this.grpReturnInformation.Name = "grpReturnInformation";
            this.grpReturnInformation.Size = new System.Drawing.Size(430, 380);
            this.grpReturnInformation.TabIndex = 0;
            this.grpReturnInformation.TabStop = false;
            this.grpReturnInformation.Text = "Return Information";
            this.grpReturnInformation.Enter += new System.EventHandler(this.grpReturnInformation_Enter);
            // 
            // lblBookingTitle
            // 
            this.lblBookingTitle.AutoSize = true;
            this.lblBookingTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBookingTitle.Location = new System.Drawing.Point(15, 35);
            this.lblBookingTitle.Name = "lblBookingTitle";
            this.lblBookingTitle.Size = new System.Drawing.Size(116, 20);
            this.lblBookingTitle.TabIndex = 0;
            this.lblBookingTitle.Text = "Select Booking:";
            // 
            // cboBooking
            // 
            this.cboBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboBooking.FormattingEnabled = true;
            this.cboBooking.Location = new System.Drawing.Point(140, 32);
            this.cboBooking.Name = "cboBooking";
            this.cboBooking.Size = new System.Drawing.Size(270, 28);
            this.cboBooking.TabIndex = 1;
            this.cboBooking.SelectedIndexChanged += new System.EventHandler(this.cboBooking_SelectedIndexChanged);
            // 
            // lblReturnDateTitle
            // 
            this.lblReturnDateTitle.AutoSize = true;
            this.lblReturnDateTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReturnDateTitle.Location = new System.Drawing.Point(15, 80);
            this.lblReturnDateTitle.Name = "lblReturnDateTitle";
            this.lblReturnDateTitle.Size = new System.Drawing.Size(98, 20);
            this.lblReturnDateTitle.TabIndex = 2;
            this.lblReturnDateTitle.Text = "Return Date:";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(140, 77);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(150, 27);
            this.dtpReturnDate.TabIndex = 3;
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);
            // 
            // lblCurrentMileageTitle
            // 
            this.lblCurrentMileageTitle.AutoSize = true;
            this.lblCurrentMileageTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCurrentMileageTitle.Location = new System.Drawing.Point(15, 125);
            this.lblCurrentMileageTitle.Name = "lblCurrentMileageTitle";
            this.lblCurrentMileageTitle.Size = new System.Drawing.Size(125, 20);
            this.lblCurrentMileageTitle.TabIndex = 4;
            this.lblCurrentMileageTitle.Text = "Current Mileage:";
            // 
            // txtCurrentMileage
            // 
            this.txtCurrentMileage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCurrentMileage.Location = new System.Drawing.Point(140, 122);
            this.txtCurrentMileage.Name = "txtCurrentMileage";
            this.txtCurrentMileage.Size = new System.Drawing.Size(150, 27);
            this.txtCurrentMileage.TabIndex = 5;
          //
          //this.txtCurrentMileage.TextChanged += new System.EventHandler(this.txtCurrentMileage_TextChanged);
            // 
            // lblConsumedKilometersTitle
            // 
            this.lblConsumedKilometersTitle.AutoSize = true;
            this.lblConsumedKilometersTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConsumedKilometersTitle.Location = new System.Drawing.Point(15, 170);
            this.lblConsumedKilometersTitle.Name = "lblConsumedKilometersTitle";
            this.lblConsumedKilometersTitle.Size = new System.Drawing.Size(125, 20);
            this.lblConsumedKilometersTitle.TabIndex = 6;
            this.lblConsumedKilometersTitle.Text = "Consumed (km):";
            // 
            // txtConsumedKilometers
            // 
            this.txtConsumedKilometers.BackColor = System.Drawing.Color.LightYellow;
            this.txtConsumedKilometers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConsumedKilometers.Location = new System.Drawing.Point(140, 167);
            this.txtConsumedKilometers.Name = "txtConsumedKilometers";
            this.txtConsumedKilometers.ReadOnly = true;
            this.txtConsumedKilometers.Size = new System.Drawing.Size(150, 27);
            this.txtConsumedKilometers.TabIndex = 7;
            // 
            // lblExtraChargesTitle
            // 
            this.lblExtraChargesTitle.AutoSize = true;
            this.lblExtraChargesTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExtraChargesTitle.Location = new System.Drawing.Point(15, 215);
            this.lblExtraChargesTitle.Name = "lblExtraChargesTitle";
            this.lblExtraChargesTitle.Size = new System.Drawing.Size(109, 20);
            this.lblExtraChargesTitle.TabIndex = 8;
            this.lblExtraChargesTitle.Text = "Extra Charges:";
            // 
            // txtExtraCharges
            // 
            this.txtExtraCharges.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExtraCharges.Location = new System.Drawing.Point(140, 212);
            this.txtExtraCharges.Name = "txtExtraCharges";
            this.txtExtraCharges.Size = new System.Drawing.Size(150, 27);
            this.txtExtraCharges.TabIndex = 9;
            this.txtExtraCharges.Text = "0";
            this.txtExtraCharges.TextChanged += new System.EventHandler(this.txtExtraCharges_TextChanged);
            // 
            // lblReturnNotesTitle
            // 
            this.lblReturnNotesTitle.AutoSize = true;
            this.lblReturnNotesTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReturnNotesTitle.Location = new System.Drawing.Point(15, 260);
            this.lblReturnNotesTitle.Name = "lblReturnNotesTitle";
            this.lblReturnNotesTitle.Size = new System.Drawing.Size(107, 20);
            this.lblReturnNotesTitle.TabIndex = 10;
            this.lblReturnNotesTitle.Text = "Return Notes:";
            // 
            // txtReturnNotes
            // 
            this.txtReturnNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReturnNotes.Location = new System.Drawing.Point(140, 257);
            this.txtReturnNotes.MaxLength = 500;
            this.txtReturnNotes.Multiline = true;
            this.txtReturnNotes.Name = "txtReturnNotes";
            this.txtReturnNotes.Size = new System.Drawing.Size(270, 100);
            this.txtReturnNotes.TabIndex = 11;
            // 
            // grpBookingDetails
            // 
            this.grpBookingDetails.Controls.Add(this.lblCustomerTitle);
            this.grpBookingDetails.Controls.Add(this.lblCustomerValue);
            this.grpBookingDetails.Controls.Add(this.lblVehicleTitle);
            this.grpBookingDetails.Controls.Add(this.lblVehicleValue);
            this.grpBookingDetails.Controls.Add(this.lblBookingPeriodTitle);
            this.grpBookingDetails.Controls.Add(this.lblBookingPeriodValue);
            this.grpBookingDetails.Controls.Add(this.lblBookedDaysTitle);
            this.grpBookingDetails.Controls.Add(this.lblBookedDaysValue);
            this.grpBookingDetails.Controls.Add(this.lblPricePerDayTitle);
            this.grpBookingDetails.Controls.Add(this.lblPricePerDayValue);
            this.grpBookingDetails.Controls.Add(this.lblOriginalTotalTitle);
            this.grpBookingDetails.Controls.Add(this.lblOriginalTotalValue);
            this.grpBookingDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpBookingDetails.Location = new System.Drawing.Point(460, 15);
            this.grpBookingDetails.Name = "grpBookingDetails";
            this.grpBookingDetails.Size = new System.Drawing.Size(330, 250);
            this.grpBookingDetails.TabIndex = 1;
            this.grpBookingDetails.TabStop = false;
            this.grpBookingDetails.Text = "Booking Details";
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomerTitle.Location = new System.Drawing.Point(15, 35);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(82, 20);
            this.lblCustomerTitle.TabIndex = 0;
            this.lblCustomerTitle.Text = "Customer:";
            // 
            // lblCustomerValue
            // 
            this.lblCustomerValue.AutoSize = true;
            this.lblCustomerValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustomerValue.Location = new System.Drawing.Point(130, 35);
            this.lblCustomerValue.Name = "lblCustomerValue";
            this.lblCustomerValue.Size = new System.Drawing.Size(24, 20);
            this.lblCustomerValue.TabIndex = 1;
            this.lblCustomerValue.Text = "—";
            // 
            // lblVehicleTitle
            // 
            this.lblVehicleTitle.AutoSize = true;
            this.lblVehicleTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVehicleTitle.Location = new System.Drawing.Point(15, 65);
            this.lblVehicleTitle.Name = "lblVehicleTitle";
            this.lblVehicleTitle.Size = new System.Drawing.Size(62, 20);
            this.lblVehicleTitle.TabIndex = 2;
            this.lblVehicleTitle.Text = "Vehicle:";
            // 
            // lblVehicleValue
            // 
            this.lblVehicleValue.AutoSize = true;
            this.lblVehicleValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVehicleValue.Location = new System.Drawing.Point(130, 65);
            this.lblVehicleValue.Name = "lblVehicleValue";
            this.lblVehicleValue.Size = new System.Drawing.Size(24, 20);
            this.lblVehicleValue.TabIndex = 3;
            this.lblVehicleValue.Text = "—";
            // 
            // lblBookingPeriodTitle
            // 
            this.lblBookingPeriodTitle.AutoSize = true;
            this.lblBookingPeriodTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBookingPeriodTitle.Location = new System.Drawing.Point(15, 95);
            this.lblBookingPeriodTitle.Name = "lblBookingPeriodTitle";
            this.lblBookingPeriodTitle.Size = new System.Drawing.Size(120, 20);
            this.lblBookingPeriodTitle.TabIndex = 4;
            this.lblBookingPeriodTitle.Text = "Booking Period:";
            // 
            // lblBookingPeriodValue
            // 
            this.lblBookingPeriodValue.AutoSize = true;
            this.lblBookingPeriodValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookingPeriodValue.Location = new System.Drawing.Point(130, 95);
            this.lblBookingPeriodValue.Name = "lblBookingPeriodValue";
            this.lblBookingPeriodValue.Size = new System.Drawing.Size(24, 20);
            this.lblBookingPeriodValue.TabIndex = 5;
            this.lblBookingPeriodValue.Text = "—";
            // 
            // lblBookedDaysTitle
            // 
            this.lblBookedDaysTitle.AutoSize = true;
            this.lblBookedDaysTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBookedDaysTitle.Location = new System.Drawing.Point(15, 125);
            this.lblBookedDaysTitle.Name = "lblBookedDaysTitle";
            this.lblBookedDaysTitle.Size = new System.Drawing.Size(104, 20);
            this.lblBookedDaysTitle.TabIndex = 6;
            this.lblBookedDaysTitle.Text = "Booked Days:";
            // 
            // lblBookedDaysValue
            // 
            this.lblBookedDaysValue.AutoSize = true;
            this.lblBookedDaysValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookedDaysValue.Location = new System.Drawing.Point(130, 125);
            this.lblBookedDaysValue.Name = "lblBookedDaysValue";
            this.lblBookedDaysValue.Size = new System.Drawing.Size(24, 20);
            this.lblBookedDaysValue.TabIndex = 7;
            this.lblBookedDaysValue.Text = "—";
            // 
            // lblPricePerDayTitle
            // 
            this.lblPricePerDayTitle.AutoSize = true;
            this.lblPricePerDayTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPricePerDayTitle.Location = new System.Drawing.Point(15, 155);
            this.lblPricePerDayTitle.Name = "lblPricePerDayTitle";
            this.lblPricePerDayTitle.Size = new System.Drawing.Size(81, 20);
            this.lblPricePerDayTitle.TabIndex = 8;
            this.lblPricePerDayTitle.Text = "Price/Day:";
            // 
            // lblPricePerDayValue
            // 
            this.lblPricePerDayValue.AutoSize = true;
            this.lblPricePerDayValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPricePerDayValue.Location = new System.Drawing.Point(130, 155);
            this.lblPricePerDayValue.Name = "lblPricePerDayValue";
            this.lblPricePerDayValue.Size = new System.Drawing.Size(24, 20);
            this.lblPricePerDayValue.TabIndex = 9;
            this.lblPricePerDayValue.Text = "—";
            // 
            // lblOriginalTotalTitle
            // 
            this.lblOriginalTotalTitle.AutoSize = true;
            this.lblOriginalTotalTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOriginalTotalTitle.Location = new System.Drawing.Point(15, 185);
            this.lblOriginalTotalTitle.Name = "lblOriginalTotalTitle";
            this.lblOriginalTotalTitle.Size = new System.Drawing.Size(107, 20);
            this.lblOriginalTotalTitle.TabIndex = 10;
            this.lblOriginalTotalTitle.Text = "Original Total:";
            // 
            // lblOriginalTotalValue
            // 
            this.lblOriginalTotalValue.AutoSize = true;
            this.lblOriginalTotalValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOriginalTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblOriginalTotalValue.Location = new System.Drawing.Point(130, 185);
            this.lblOriginalTotalValue.Name = "lblOriginalTotalValue";
            this.lblOriginalTotalValue.Size = new System.Drawing.Size(24, 20);
            this.lblOriginalTotalValue.TabIndex = 11;
            this.lblOriginalTotalValue.Text = "—";
            // 
            // grpCalculationSummary
            // 
            this.grpCalculationSummary.Controls.Add(this.lblActualDaysTitle);
            this.grpCalculationSummary.Controls.Add(this.lblActualDaysValue);
            this.grpCalculationSummary.Controls.Add(this.lblTotalDueTitle);
            this.grpCalculationSummary.Controls.Add(this.lblTotalDueValue);
            this.grpCalculationSummary.Controls.Add(this.lblSurplusMessage);
            this.grpCalculationSummary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpCalculationSummary.Location = new System.Drawing.Point(460, 275);
            this.grpCalculationSummary.Name = "grpCalculationSummary";
            this.grpCalculationSummary.Size = new System.Drawing.Size(330, 120);
            this.grpCalculationSummary.TabIndex = 2;
            this.grpCalculationSummary.TabStop = false;
            this.grpCalculationSummary.Text = "Calculation Summary";
            // 
            // lblActualDaysTitle
            // 
            this.lblActualDaysTitle.AutoSize = true;
            this.lblActualDaysTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblActualDaysTitle.Location = new System.Drawing.Point(15, 30);
            this.lblActualDaysTitle.Name = "lblActualDaysTitle";
            this.lblActualDaysTitle.Size = new System.Drawing.Size(96, 20);
            this.lblActualDaysTitle.TabIndex = 0;
            this.lblActualDaysTitle.Text = "Actual Days:";
            // 
            // lblActualDaysValue
            // 
            this.lblActualDaysValue.AutoSize = true;
            this.lblActualDaysValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblActualDaysValue.Location = new System.Drawing.Point(130, 30);
            this.lblActualDaysValue.Name = "lblActualDaysValue";
            this.lblActualDaysValue.Size = new System.Drawing.Size(17, 20);
            this.lblActualDaysValue.TabIndex = 1;
            this.lblActualDaysValue.Text = "0";
            // 
            // lblTotalDueTitle
            // 
            this.lblTotalDueTitle.AutoSize = true;
            this.lblTotalDueTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalDueTitle.Location = new System.Drawing.Point(15, 60);
            this.lblTotalDueTitle.Name = "lblTotalDueTitle";
            this.lblTotalDueTitle.Size = new System.Drawing.Size(91, 23);
            this.lblTotalDueTitle.TabIndex = 2;
            this.lblTotalDueTitle.Text = "Total Due:";
            // 
            // lblTotalDueValue
            // 
            this.lblTotalDueValue.AutoSize = true;
            this.lblTotalDueValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalDueValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalDueValue.Location = new System.Drawing.Point(130, 58);
            this.lblTotalDueValue.Name = "lblTotalDueValue";
            this.lblTotalDueValue.Size = new System.Drawing.Size(61, 25);
            this.lblTotalDueValue.TabIndex = 3;
            this.lblTotalDueValue.Text = "$0.00";
            // 
            // lblSurplusMessage
            // 
            this.lblSurplusMessage.AutoSize = true;
            this.lblSurplusMessage.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSurplusMessage.ForeColor = System.Drawing.Color.Red;
            this.lblSurplusMessage.Location = new System.Drawing.Point(15, 92);
            this.lblSurplusMessage.Name = "lblSurplusMessage";
            this.lblSurplusMessage.Size = new System.Drawing.Size(0, 19);
            this.lblSurplusMessage.TabIndex = 4;
            this.lblSurplusMessage.Visible = false;
            // 
            // btnCompleteReturn
            // 
            this.btnCompleteReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCompleteReturn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCompleteReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompleteReturn.Location = new System.Drawing.Point(628, 410);
            this.btnCompleteReturn.Name = "btnCompleteReturn";
            this.btnCompleteReturn.Size = new System.Drawing.Size(162, 40);
            this.btnCompleteReturn.TabIndex = 3;
            this.btnCompleteReturn.Text = "Complete Return";
            this.btnCompleteReturn.UseVisualStyleBackColor = false;
            this.btnCompleteReturn.Click += new System.EventHandler(this.btnCompleteReturn_Click);
            // 
            // btnCancelClose
            // 
            this.btnCancelClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelClose.Location = new System.Drawing.Point(456, 410);
            this.btnCancelClose.Name = "btnCancelClose";
            this.btnCancelClose.Size = new System.Drawing.Size(158, 40);
            this.btnCancelClose.TabIndex = 4;
            this.btnCancelClose.Text = "Cancel";
            this.btnCancelClose.UseVisualStyleBackColor = true;
            this.btnCancelClose.Click += new System.EventHandler(this.btnCancelClose_Click);
            // 
            // stsStatusBar
            // 
            this.stsStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslBookingStatus});
            this.stsStatusBar.Location = new System.Drawing.Point(0, 458);
            this.stsStatusBar.Name = "stsStatusBar";
            this.stsStatusBar.Size = new System.Drawing.Size(810, 26);
            this.stsStatusBar.TabIndex = 5;
            this.stsStatusBar.Text = "statusStrip1";
            this.stsStatusBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.stsStatusBar_ItemClicked);
            // 
            // tsslBookingStatus
            // 
            this.tsslBookingStatus.Name = "tsslBookingStatus";
            this.tsslBookingStatus.Size = new System.Drawing.Size(50, 20);
            this.tsslBookingStatus.Text = "Ready";
            // 
            // frmReturnVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 484);
            this.Controls.Add(this.stsStatusBar);
            this.Controls.Add(this.btnCancelClose);
            this.Controls.Add(this.btnCompleteReturn);
            this.Controls.Add(this.grpCalculationSummary);
            this.Controls.Add(this.grpBookingDetails);
            this.Controls.Add(this.grpReturnInformation);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReturnVehicle";
            this.Text = "Return Vehicle";
            this.Load += new System.EventHandler(this.frmReturnVehicle_Load);
            this.grpReturnInformation.ResumeLayout(false);
            this.grpReturnInformation.PerformLayout();
            this.grpBookingDetails.ResumeLayout(false);
            this.grpBookingDetails.PerformLayout();
            this.grpCalculationSummary.ResumeLayout(false);
            this.grpCalculationSummary.PerformLayout();
            this.stsStatusBar.ResumeLayout(false);
            this.stsStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Group Boxes
        private System.Windows.Forms.GroupBox grpReturnInformation;
        private System.Windows.Forms.GroupBox grpBookingDetails;
        private System.Windows.Forms.GroupBox grpCalculationSummary;

        // Input Controls
        private System.Windows.Forms.ComboBox cboBooking;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.TextBox txtCurrentMileage;
        private System.Windows.Forms.TextBox txtConsumedKilometers;
        private System.Windows.Forms.TextBox txtExtraCharges;
        private System.Windows.Forms.TextBox txtReturnNotes;

        // Static Labels (Titles)
        private System.Windows.Forms.Label lblBookingTitle;
        private System.Windows.Forms.Label lblReturnDateTitle;
        private System.Windows.Forms.Label lblCurrentMileageTitle;
        private System.Windows.Forms.Label lblConsumedKilometersTitle;
        private System.Windows.Forms.Label lblExtraChargesTitle;
        private System.Windows.Forms.Label lblReturnNotesTitle;
        private System.Windows.Forms.Label lblActualDaysTitle;
        private System.Windows.Forms.Label lblTotalDueTitle;

        // Booking Details Labels (Titles)
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.Label lblVehicleTitle;
        private System.Windows.Forms.Label lblBookingPeriodTitle;
        private System.Windows.Forms.Label lblBookedDaysTitle;
        private System.Windows.Forms.Label lblPricePerDayTitle;
        private System.Windows.Forms.Label lblOriginalTotalTitle;

        // Booking Details Values
        private System.Windows.Forms.Label lblCustomerValue;
        private System.Windows.Forms.Label lblVehicleValue;
        private System.Windows.Forms.Label lblBookingPeriodValue;
        private System.Windows.Forms.Label lblBookedDaysValue;
        private System.Windows.Forms.Label lblPricePerDayValue;
        private System.Windows.Forms.Label lblOriginalTotalValue;

        // Calculation Results
        private System.Windows.Forms.Label lblActualDaysValue;
        private System.Windows.Forms.Label lblTotalDueValue;
        private System.Windows.Forms.Label lblSurplusMessage;

        // Buttons
        private System.Windows.Forms.Button btnCompleteReturn;
        private System.Windows.Forms.Button btnCancelClose;

        // Status Strip
        private System.Windows.Forms.StatusStrip stsStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslBookingStatus;
    }
}