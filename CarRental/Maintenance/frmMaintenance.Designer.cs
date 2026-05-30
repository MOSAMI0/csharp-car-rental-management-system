namespace CarRental.Maintenance
{
    partial class frmMaintenance
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblVehicleTitle = new System.Windows.Forms.Label();
            this.lblDescriptionTitle = new System.Windows.Forms.Label();
            this.lblCostTitle = new System.Windows.Forms.Label();
            this.cboVehicle = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnSaveMaintenance = new System.Windows.Forms.Button();
            this.btnCancelClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVehicleTitle
            // 
            this.lblVehicleTitle.AutoSize = true;
            this.lblVehicleTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVehicleTitle.Location = new System.Drawing.Point(15, 25);
            this.lblVehicleTitle.Name = "lblVehicleTitle";
            this.lblVehicleTitle.Size = new System.Drawing.Size(62, 20);
            this.lblVehicleTitle.TabIndex = 0;
            this.lblVehicleTitle.Text = "Vehicle:";
            // 
            // lblDescriptionTitle
            // 
            this.lblDescriptionTitle.AutoSize = true;
            this.lblDescriptionTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescriptionTitle.Location = new System.Drawing.Point(15, 70);
            this.lblDescriptionTitle.Name = "lblDescriptionTitle";
            this.lblDescriptionTitle.Size = new System.Drawing.Size(93, 20);
            this.lblDescriptionTitle.TabIndex = 2;
            this.lblDescriptionTitle.Text = "Description:";
            // 
            // lblCostTitle
            // 
            this.lblCostTitle.AutoSize = true;
            this.lblCostTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCostTitle.Location = new System.Drawing.Point(15, 145);
            this.lblCostTitle.Name = "lblCostTitle";
            this.lblCostTitle.Size = new System.Drawing.Size(44, 20);
            this.lblCostTitle.TabIndex = 4;
            this.lblCostTitle.Text = "Cost:";
            // 
            // cboVehicle
            // 
            this.cboVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicle.Location = new System.Drawing.Point(120, 22);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(250, 28);
            this.cboVehicle.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 67);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 60);
            this.txtDescription.TabIndex = 2;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(120, 142);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(150, 27);
            this.txtCost.TabIndex = 3;
            // 
            // btnSaveMaintenance
            // 
            this.btnSaveMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSaveMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnSaveMaintenance.Location = new System.Drawing.Point(170, 200);
            this.btnSaveMaintenance.Name = "btnSaveMaintenance";
            this.btnSaveMaintenance.Size = new System.Drawing.Size(100, 35);
            this.btnSaveMaintenance.TabIndex = 4;
            this.btnSaveMaintenance.Text = "Save";
            this.btnSaveMaintenance.UseVisualStyleBackColor = false;
            this.btnSaveMaintenance.Click += new System.EventHandler(this.btnSaveMaintenance_Click);
            // 
            // btnCancelClose
            // 
            this.btnCancelClose.Location = new System.Drawing.Point(280, 200);
            this.btnCancelClose.Name = "btnCancelClose";
            this.btnCancelClose.Size = new System.Drawing.Size(90, 35);
            this.btnCancelClose.TabIndex = 5;
            this.btnCancelClose.Text = "Cancel";
            this.btnCancelClose.Click += new System.EventHandler(this.btnCancelClose_Click);
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 257);
            this.Controls.Add(this.lblVehicleTitle);
            this.Controls.Add(this.cboVehicle);
            this.Controls.Add(this.lblDescriptionTitle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCostTitle);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnSaveMaintenance);
            this.Controls.Add(this.btnCancelClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMaintenance";
            this.Text = "Maintenance Record";
            this.Load += new System.EventHandler(this.frmMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblVehicleTitle;
        private System.Windows.Forms.Label lblDescriptionTitle;
        private System.Windows.Forms.Label lblCostTitle;
        private System.Windows.Forms.ComboBox cboVehicle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnSaveMaintenance;
        private System.Windows.Forms.Button btnCancelClose;
    }
}