namespace CarRental.Vehicles
{
    partial class frmAddEditVehicle
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
            this.lblMakeTitle = new System.Windows.Forms.Label();
            this.lblModelTitle = new System.Windows.Forms.Label();
            this.lblCategoryTitle = new System.Windows.Forms.Label();
            this.lblYearTitle = new System.Windows.Forms.Label();
            this.lblLicensePlateTitle = new System.Windows.Forms.Label();
            this.lblMileageTitle = new System.Windows.Forms.Label();
            this.lblDailyPriceTitle = new System.Windows.Forms.Label();
            this.lblVehicleImageTitle = new System.Windows.Forms.Label();
            this.lblModeTitle = new System.Windows.Forms.Label();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.txtDailyPrice = new System.Windows.Forms.TextBox();
            this.btnSaveVehicle = new System.Windows.Forms.Button();
            this.btnCancelClose = new System.Windows.Forms.Button();
            this.picVehicleImage = new System.Windows.Forms.PictureBox();
            this.lnkSetVehicleImage = new System.Windows.Forms.LinkLabel();
            this.lnkRemoveImage = new System.Windows.Forms.LinkLabel();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.lblModeValue = new System.Windows.Forms.Label();
            this.grpVehicleInformation = new System.Windows.Forms.GroupBox();
            this.lblFuelTypeTitle = new System.Windows.Forms.Label();
            this.cboFuelType = new System.Windows.Forms.ComboBox();
            this.grpVehicleImage = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicleImage)).BeginInit();
            this.grpVehicleInformation.SuspendLayout();
            this.grpVehicleImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMakeTitle
            // 
            this.lblMakeTitle.AutoSize = true;
            this.lblMakeTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMakeTitle.Location = new System.Drawing.Point(20, 35);
            this.lblMakeTitle.Name = "lblMakeTitle";
            this.lblMakeTitle.Size = new System.Drawing.Size(51, 20);
            this.lblMakeTitle.TabIndex = 0;
            this.lblMakeTitle.Text = "Make:";
            // 
            // lblModelTitle
            // 
            this.lblModelTitle.AutoSize = true;
            this.lblModelTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModelTitle.Location = new System.Drawing.Point(20, 75);
            this.lblModelTitle.Name = "lblModelTitle";
            this.lblModelTitle.Size = new System.Drawing.Size(57, 20);
            this.lblModelTitle.TabIndex = 2;
            this.lblModelTitle.Text = "Model:";
            // 
            // lblCategoryTitle
            // 
            this.lblCategoryTitle.AutoSize = true;
            this.lblCategoryTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategoryTitle.Location = new System.Drawing.Point(20, 115);
            this.lblCategoryTitle.Name = "lblCategoryTitle";
            this.lblCategoryTitle.Size = new System.Drawing.Size(77, 20);
            this.lblCategoryTitle.TabIndex = 6;
            this.lblCategoryTitle.Text = "Category:";
            // 
            // lblYearTitle
            // 
            this.lblYearTitle.AutoSize = true;
            this.lblYearTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblYearTitle.Location = new System.Drawing.Point(20, 195);
            this.lblYearTitle.Name = "lblYearTitle";
            this.lblYearTitle.Size = new System.Drawing.Size(44, 20);
            this.lblYearTitle.TabIndex = 8;
            this.lblYearTitle.Text = "Year:";
            // 
            // lblLicensePlateTitle
            // 
            this.lblLicensePlateTitle.AutoSize = true;
            this.lblLicensePlateTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLicensePlateTitle.Location = new System.Drawing.Point(20, 235);
            this.lblLicensePlateTitle.Name = "lblLicensePlateTitle";
            this.lblLicensePlateTitle.Size = new System.Drawing.Size(103, 20);
            this.lblLicensePlateTitle.TabIndex = 10;
            this.lblLicensePlateTitle.Text = "License Plate:";
            // 
            // lblMileageTitle
            // 
            this.lblMileageTitle.AutoSize = true;
            this.lblMileageTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMileageTitle.Location = new System.Drawing.Point(20, 275);
            this.lblMileageTitle.Name = "lblMileageTitle";
            this.lblMileageTitle.Size = new System.Drawing.Size(68, 20);
            this.lblMileageTitle.TabIndex = 12;
            this.lblMileageTitle.Text = "Mileage:";
            // 
            // lblDailyPriceTitle
            // 
            this.lblDailyPriceTitle.AutoSize = true;
            this.lblDailyPriceTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDailyPriceTitle.Location = new System.Drawing.Point(20, 315);
            this.lblDailyPriceTitle.Name = "lblDailyPriceTitle";
            this.lblDailyPriceTitle.Size = new System.Drawing.Size(86, 20);
            this.lblDailyPriceTitle.TabIndex = 14;
            this.lblDailyPriceTitle.Text = "Daily Price:";
            // 
            // lblVehicleImageTitle
            // 
            this.lblVehicleImageTitle.AutoSize = true;
            this.lblVehicleImageTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblVehicleImageTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblVehicleImageTitle.Location = new System.Drawing.Point(20, 30);
            this.lblVehicleImageTitle.Name = "lblVehicleImageTitle";
            this.lblVehicleImageTitle.Size = new System.Drawing.Size(203, 20);
            this.lblVehicleImageTitle.TabIndex = 0;
            this.lblVehicleImageTitle.Text = "Select an image for the vehicle";
            // 
            // lblModeTitle
            // 
            this.lblModeTitle.AutoSize = true;
            this.lblModeTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModeTitle.Location = new System.Drawing.Point(25, 15);
            this.lblModeTitle.Name = "lblModeTitle";
            this.lblModeTitle.Size = new System.Drawing.Size(53, 20);
            this.lblModeTitle.TabIndex = 2;
            this.lblModeTitle.Text = "Mode:";
            // 
            // cboMake
            // 
            this.cboMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMake.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Location = new System.Drawing.Point(150, 32);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(220, 28);
            this.cboMake.TabIndex = 1;
            this.cboMake.SelectedIndexChanged += new System.EventHandler(this.cboMake_SelectedIndexChanged);
            // 
            // cboModel
            // 
            this.cboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(150, 72);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(220, 28);
            this.cboModel.TabIndex = 3;
            this.cboModel.SelectedIndexChanged += new System.EventHandler(this.cboModel_SelectedIndexChanged);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(150, 115);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(220, 28);
            this.cboCategory.TabIndex = 7;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(150, 192);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(220, 28);
            this.cboYear.TabIndex = 9;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLicensePlate.Location = new System.Drawing.Point(150, 232);
            this.txtLicensePlate.MaxLength = 20;
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(220, 27);
            this.txtLicensePlate.TabIndex = 11;
            // 
            // txtMileage
            // 
            this.txtMileage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMileage.Location = new System.Drawing.Point(150, 272);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(220, 27);
            this.txtMileage.TabIndex = 13;
            // 
            // txtDailyPrice
            // 
            this.txtDailyPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDailyPrice.Location = new System.Drawing.Point(150, 312);
            this.txtDailyPrice.Name = "txtDailyPrice";
            this.txtDailyPrice.Size = new System.Drawing.Size(220, 27);
            this.txtDailyPrice.TabIndex = 15;
            // 
            // btnSaveVehicle
            // 
            this.btnSaveVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSaveVehicle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveVehicle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveVehicle.Location = new System.Drawing.Point(580, 490);
            this.btnSaveVehicle.Name = "btnSaveVehicle";
            this.btnSaveVehicle.Size = new System.Drawing.Size(120, 40);
            this.btnSaveVehicle.TabIndex = 4;
            this.btnSaveVehicle.Text = "Save Vehicle";
            this.btnSaveVehicle.UseVisualStyleBackColor = false;
            this.btnSaveVehicle.Click += new System.EventHandler(this.btnSaveVehicle_Click);
            // 
            // btnCancelClose
            // 
            this.btnCancelClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelClose.Location = new System.Drawing.Point(720, 490);
            this.btnCancelClose.Name = "btnCancelClose";
            this.btnCancelClose.Size = new System.Drawing.Size(120, 40);
            this.btnCancelClose.TabIndex = 5;
            this.btnCancelClose.Text = "Cancel";
            this.btnCancelClose.UseVisualStyleBackColor = true;
            this.btnCancelClose.Click += new System.EventHandler(this.btnCancelClose_Click);
            // 
            // picVehicleImage
            // 
            this.picVehicleImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVehicleImage.Location = new System.Drawing.Point(24, 72);
            this.picVehicleImage.Name = "picVehicleImage";
            this.picVehicleImage.Size = new System.Drawing.Size(350, 238);
            this.picVehicleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVehicleImage.TabIndex = 1;
            this.picVehicleImage.TabStop = false;
            // 
            // lnkSetVehicleImage
            // 
            this.lnkSetVehicleImage.AutoSize = true;
            this.lnkSetVehicleImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkSetVehicleImage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lnkSetVehicleImage.Location = new System.Drawing.Point(24, 330);
            this.lnkSetVehicleImage.Name = "lnkSetVehicleImage";
            this.lnkSetVehicleImage.Size = new System.Drawing.Size(135, 20);
            this.lnkSetVehicleImage.TabIndex = 2;
            this.lnkSetVehicleImage.TabStop = true;
            this.lnkSetVehicleImage.Text = "Browse for Image...";
            this.lnkSetVehicleImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSetVehicleImage_LinkClicked);
            // 
            // lnkRemoveImage
            // 
            this.lnkRemoveImage.AutoSize = true;
            this.lnkRemoveImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkRemoveImage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lnkRemoveImage.Location = new System.Drawing.Point(160, 330);
            this.lnkRemoveImage.Name = "lnkRemoveImage";
            this.lnkRemoveImage.Size = new System.Drawing.Size(109, 20);
            this.lnkRemoveImage.TabIndex = 3;
            this.lnkRemoveImage.TabStop = true;
            this.lnkRemoveImage.Text = "Remove Image";
            this.lnkRemoveImage.Visible = false;
            this.lnkRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRemoveImage_LinkClicked);
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "openFileDialogImage";
            this.openFileDialogImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            this.openFileDialogImage.Title = "Select Vehicle Image";
            // 
            // lblModeValue
            // 
            this.lblModeValue.AutoSize = true;
            this.lblModeValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblModeValue.Location = new System.Drawing.Point(82, 15);
            this.lblModeValue.Name = "lblModeValue";
            this.lblModeValue.Size = new System.Drawing.Size(92, 20);
            this.lblModeValue.TabIndex = 3;
            this.lblModeValue.Text = "[Add / Edit]";
            // 
            // grpVehicleInformation
            // 
            this.grpVehicleInformation.Controls.Add(this.lblMakeTitle);
            this.grpVehicleInformation.Controls.Add(this.cboMake);
            this.grpVehicleInformation.Controls.Add(this.lblModelTitle);
            this.grpVehicleInformation.Controls.Add(this.cboModel);
            this.grpVehicleInformation.Controls.Add(this.lblFuelTypeTitle);
            this.grpVehicleInformation.Controls.Add(this.cboFuelType);
            this.grpVehicleInformation.Controls.Add(this.lblCategoryTitle);
            this.grpVehicleInformation.Controls.Add(this.cboCategory);
            this.grpVehicleInformation.Controls.Add(this.lblYearTitle);
            this.grpVehicleInformation.Controls.Add(this.cboYear);
            this.grpVehicleInformation.Controls.Add(this.lblLicensePlateTitle);
            this.grpVehicleInformation.Controls.Add(this.txtLicensePlate);
            this.grpVehicleInformation.Controls.Add(this.lblMileageTitle);
            this.grpVehicleInformation.Controls.Add(this.txtMileage);
            this.grpVehicleInformation.Controls.Add(this.lblDailyPriceTitle);
            this.grpVehicleInformation.Controls.Add(this.txtDailyPrice);
            this.grpVehicleInformation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpVehicleInformation.Location = new System.Drawing.Point(25, 50);
            this.grpVehicleInformation.Name = "grpVehicleInformation";
            this.grpVehicleInformation.Size = new System.Drawing.Size(400, 420);
            this.grpVehicleInformation.TabIndex = 0;
            this.grpVehicleInformation.TabStop = false;
            this.grpVehicleInformation.Text = "Vehicle Information";
            // 
            // lblFuelTypeTitle
            // 
            this.lblFuelTypeTitle.AutoSize = true;
            this.lblFuelTypeTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFuelTypeTitle.Location = new System.Drawing.Point(20, 156);
            this.lblFuelTypeTitle.Name = "lblFuelTypeTitle";
            this.lblFuelTypeTitle.Size = new System.Drawing.Size(79, 20);
            this.lblFuelTypeTitle.TabIndex = 4;
            this.lblFuelTypeTitle.Text = "Fuel Type:";
            // 
            // cboFuelType
            // 
            this.cboFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuelType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboFuelType.FormattingEnabled = true;
            this.cboFuelType.Location = new System.Drawing.Point(150, 153);
            this.cboFuelType.Name = "cboFuelType";
            this.cboFuelType.Size = new System.Drawing.Size(220, 28);
            this.cboFuelType.TabIndex = 5;
            this.cboFuelType.SelectedIndexChanged += new System.EventHandler(this.cboFuelType_SelectedIndexChanged);
            // 
            // grpVehicleImage
            // 
            this.grpVehicleImage.Controls.Add(this.lblVehicleImageTitle);
            this.grpVehicleImage.Controls.Add(this.picVehicleImage);
            this.grpVehicleImage.Controls.Add(this.lnkSetVehicleImage);
            this.grpVehicleImage.Controls.Add(this.lnkRemoveImage);
            this.grpVehicleImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpVehicleImage.Location = new System.Drawing.Point(450, 50);
            this.grpVehicleImage.Name = "grpVehicleImage";
            this.grpVehicleImage.Size = new System.Drawing.Size(400, 420);
            this.grpVehicleImage.TabIndex = 1;
            this.grpVehicleImage.TabStop = false;
            this.grpVehicleImage.Text = "Vehicle Image";
            // 
            // frmAddEditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 550);
            this.Controls.Add(this.btnCancelClose);
            this.Controls.Add(this.btnSaveVehicle);
            this.Controls.Add(this.lblModeValue);
            this.Controls.Add(this.lblModeTitle);
            this.Controls.Add(this.grpVehicleImage);
            this.Controls.Add(this.grpVehicleInformation);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditVehicle";
            this.Text = "Add / Edit Vehicle";
            this.Load += new System.EventHandler(this.frmAddEditVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVehicleImage)).EndInit();
            this.grpVehicleInformation.ResumeLayout(false);
            this.grpVehicleInformation.PerformLayout();
            this.grpVehicleImage.ResumeLayout(false);
            this.grpVehicleImage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Title Labels
        private System.Windows.Forms.Label lblMakeTitle;
        private System.Windows.Forms.Label lblModelTitle;
        private System.Windows.Forms.Label lblCategoryTitle;
        private System.Windows.Forms.Label lblYearTitle;
        private System.Windows.Forms.Label lblLicensePlateTitle;
        private System.Windows.Forms.Label lblMileageTitle;
        private System.Windows.Forms.Label lblDailyPriceTitle;
        private System.Windows.Forms.Label lblVehicleImageTitle;
        private System.Windows.Forms.Label lblModeTitle;

        // Input Controls
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.TextBox txtDailyPrice;

        // Buttons
        private System.Windows.Forms.Button btnSaveVehicle;
        private System.Windows.Forms.Button btnCancelClose;

        // Image Controls
        private System.Windows.Forms.PictureBox picVehicleImage;
        private System.Windows.Forms.LinkLabel lnkSetVehicleImage;
        private System.Windows.Forms.LinkLabel lnkRemoveImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;

        // Other Controls
        private System.Windows.Forms.Label lblModeValue;
        private System.Windows.Forms.GroupBox grpVehicleInformation;
        private System.Windows.Forms.GroupBox grpVehicleImage;
        private System.Windows.Forms.Label lblFuelTypeTitle;
        private System.Windows.Forms.ComboBox cboFuelType;
    }
}