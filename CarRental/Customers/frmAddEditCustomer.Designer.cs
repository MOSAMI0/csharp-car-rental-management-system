namespace CarRental
{
    partial class frmAddEditCustomer
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
            this.lblCustomerNameTitle = new System.Windows.Forms.Label();
            this.lblContactInfoTitle = new System.Windows.Forms.Label();
            this.lblLicenseNumberTitle = new System.Windows.Forms.Label();
            this.lblCustomerImageTitle = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.txtLicenseNumber = new System.Windows.Forms.TextBox();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.btnCancelClose = new System.Windows.Forms.Button();
            this.picCustomerImage = new System.Windows.Forms.PictureBox();
            this.lnkSetCustomerImage = new System.Windows.Forms.LinkLabel();
            this.lnkRemoveImage = new System.Windows.Forms.LinkLabel();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.grpCustomerInformation = new System.Windows.Forms.GroupBox();
            this.grpCustomerImage = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomerImage)).BeginInit();
            this.grpCustomerInformation.SuspendLayout();
            this.grpCustomerImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModeTitle
            // 
            this.lblModeTitle.AutoSize = true;
            this.lblModeTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModeTitle.Location = new System.Drawing.Point(25, 20);
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
            this.lblModeValue.Location = new System.Drawing.Point(82, 20);
            this.lblModeValue.Name = "lblModeValue";
            this.lblModeValue.Size = new System.Drawing.Size(92, 20);
            this.lblModeValue.TabIndex = 3;
            this.lblModeValue.Text = "[Add / Edit]";
            // 
            // lblCustomerNameTitle
            // 
            this.lblCustomerNameTitle.AutoSize = true;
            this.lblCustomerNameTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCustomerNameTitle.Location = new System.Drawing.Point(20, 40);
            this.lblCustomerNameTitle.Name = "lblCustomerNameTitle";
            this.lblCustomerNameTitle.Size = new System.Drawing.Size(84, 20);
            this.lblCustomerNameTitle.TabIndex = 0;
            this.lblCustomerNameTitle.Text = "Full Name:";
            // 
            // lblContactInfoTitle
            // 
            this.lblContactInfoTitle.AutoSize = true;
            this.lblContactInfoTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblContactInfoTitle.Location = new System.Drawing.Point(20, 85);
            this.lblContactInfoTitle.Name = "lblContactInfoTitle";
            this.lblContactInfoTitle.Size = new System.Drawing.Size(100, 20);
            this.lblContactInfoTitle.TabIndex = 2;
            this.lblContactInfoTitle.Text = "Contact Info:";
            // 
            // lblLicenseNumberTitle
            // 
            this.lblLicenseNumberTitle.AutoSize = true;
            this.lblLicenseNumberTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLicenseNumberTitle.Location = new System.Drawing.Point(20, 130);
            this.lblLicenseNumberTitle.Name = "lblLicenseNumberTitle";
            this.lblLicenseNumberTitle.Size = new System.Drawing.Size(93, 20);
            this.lblLicenseNumberTitle.TabIndex = 4;
            this.lblLicenseNumberTitle.Text = "License No.:";
            // 
            // lblCustomerImageTitle
            // 
            this.lblCustomerImageTitle.AutoSize = true;
            this.lblCustomerImageTitle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerImageTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblCustomerImageTitle.Location = new System.Drawing.Point(20, 23);
            this.lblCustomerImageTitle.Name = "lblCustomerImageTitle";
            this.lblCustomerImageTitle.Size = new System.Drawing.Size(191, 17);
            this.lblCustomerImageTitle.TabIndex = 0;
            this.lblCustomerImageTitle.Text = "Select an image for the customer";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerName.Location = new System.Drawing.Point(170, 37);
            this.txtCustomerName.MaxLength = 100;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 27);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContactInfo.Location = new System.Drawing.Point(170, 82);
            this.txtContactInfo.MaxLength = 50;
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(200, 27);
            this.txtContactInfo.TabIndex = 3;
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLicenseNumber.Location = new System.Drawing.Point(170, 127);
            this.txtLicenseNumber.MaxLength = 50;
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.Size = new System.Drawing.Size(200, 27);
            this.txtLicenseNumber.TabIndex = 5;
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSaveCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveCustomer.Location = new System.Drawing.Point(459, 385);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(120, 40);
            this.btnSaveCustomer.TabIndex = 4;
            this.btnSaveCustomer.Text = "Save Customer";
            this.btnSaveCustomer.UseVisualStyleBackColor = false;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // btnCancelClose
            // 
            this.btnCancelClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelClose.Location = new System.Drawing.Point(599, 385);
            this.btnCancelClose.Name = "btnCancelClose";
            this.btnCancelClose.Size = new System.Drawing.Size(120, 40);
            this.btnCancelClose.TabIndex = 5;
            this.btnCancelClose.Text = "Cancel";
            this.btnCancelClose.UseVisualStyleBackColor = true;
            this.btnCancelClose.Click += new System.EventHandler(this.btnCancelClose_Click);
            // 
            // picCustomerImage
            // 
            this.picCustomerImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCustomerImage.Location = new System.Drawing.Point(23, 43);
            this.picCustomerImage.Name = "picCustomerImage";
            this.picCustomerImage.Size = new System.Drawing.Size(149, 203);
            this.picCustomerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCustomerImage.TabIndex = 1;
            this.picCustomerImage.TabStop = false;
            // 
            // lnkSetCustomerImage
            // 
            this.lnkSetCustomerImage.AutoSize = true;
            this.lnkSetCustomerImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkSetCustomerImage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lnkSetCustomerImage.Location = new System.Drawing.Point(9, 269);
            this.lnkSetCustomerImage.Name = "lnkSetCustomerImage";
            this.lnkSetCustomerImage.Size = new System.Drawing.Size(135, 20);
            this.lnkSetCustomerImage.TabIndex = 2;
            this.lnkSetCustomerImage.TabStop = true;
            this.lnkSetCustomerImage.Text = "Browse for Image...";
            this.lnkSetCustomerImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSetCustomerImage_LinkClicked);
            // 
            // lnkRemoveImage
            // 
            this.lnkRemoveImage.AutoSize = true;
            this.lnkRemoveImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkRemoveImage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lnkRemoveImage.Location = new System.Drawing.Point(145, 269);
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
            this.openFileDialogImage.Title = "Select Customer Image";
            // 
            // grpCustomerInformation
            // 
            this.grpCustomerInformation.Controls.Add(this.lblCustomerNameTitle);
            this.grpCustomerInformation.Controls.Add(this.txtCustomerName);
            this.grpCustomerInformation.Controls.Add(this.lblContactInfoTitle);
            this.grpCustomerInformation.Controls.Add(this.txtContactInfo);
            this.grpCustomerInformation.Controls.Add(this.lblLicenseNumberTitle);
            this.grpCustomerInformation.Controls.Add(this.txtLicenseNumber);
            this.grpCustomerInformation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpCustomerInformation.Location = new System.Drawing.Point(25, 60);
            this.grpCustomerInformation.Name = "grpCustomerInformation";
            this.grpCustomerInformation.Size = new System.Drawing.Size(400, 304);
            this.grpCustomerInformation.TabIndex = 0;
            this.grpCustomerInformation.TabStop = false;
            this.grpCustomerInformation.Text = "Customer Information";
            // 
            // grpCustomerImage
            // 
            this.grpCustomerImage.Controls.Add(this.lblCustomerImageTitle);
            this.grpCustomerImage.Controls.Add(this.picCustomerImage);
            this.grpCustomerImage.Controls.Add(this.lnkSetCustomerImage);
            this.grpCustomerImage.Controls.Add(this.lnkRemoveImage);
            this.grpCustomerImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpCustomerImage.Location = new System.Drawing.Point(450, 60);
            this.grpCustomerImage.Name = "grpCustomerImage";
            this.grpCustomerImage.Size = new System.Drawing.Size(277, 304);
            this.grpCustomerImage.TabIndex = 1;
            this.grpCustomerImage.TabStop = false;
            this.grpCustomerImage.Text = "Customer Image";
            // 
            // frmAddEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 437);
            this.Controls.Add(this.btnCancelClose);
            this.Controls.Add(this.btnSaveCustomer);
            this.Controls.Add(this.lblModeValue);
            this.Controls.Add(this.lblModeTitle);
            this.Controls.Add(this.grpCustomerImage);
            this.Controls.Add(this.grpCustomerInformation);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditCustomer";
            this.Text = "Add / Edit Customer";
            this.Load += new System.EventHandler(this.frmAddEditCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCustomerImage)).EndInit();
            this.grpCustomerInformation.ResumeLayout(false);
            this.grpCustomerInformation.PerformLayout();
            this.grpCustomerImage.ResumeLayout(false);
            this.grpCustomerImage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Title Labels
        private System.Windows.Forms.Label lblModeTitle;
        private System.Windows.Forms.Label lblModeValue;

        // Field Labels
        private System.Windows.Forms.Label lblCustomerNameTitle;
        private System.Windows.Forms.Label lblContactInfoTitle;
        private System.Windows.Forms.Label lblLicenseNumberTitle;
        private System.Windows.Forms.Label lblCustomerImageTitle;

        // Input Controls
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.TextBox txtLicenseNumber;

        // Buttons
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.Button btnCancelClose;

        // Image Controls
        private System.Windows.Forms.PictureBox picCustomerImage;
        private System.Windows.Forms.LinkLabel lnkSetCustomerImage;
        private System.Windows.Forms.LinkLabel lnkRemoveImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;

        // Group Boxes
        private System.Windows.Forms.GroupBox grpCustomerInformation;
        private System.Windows.Forms.GroupBox grpCustomerImage;
    }
}