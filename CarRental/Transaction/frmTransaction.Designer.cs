namespace CarRental.Transaction
{
    partial class frmTransaction
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
            this.lblActual = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblRefund = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnSaveTransaction = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitleCaption = new System.Windows.Forms.Label();
            this.lblCaptionActual = new System.Windows.Forms.Label();
            this.lblCaptionPaid = new System.Windows.Forms.Label();
            this.lblCaptionMethod = new System.Windows.Forms.Label();
            this.lblCaptionRemain = new System.Windows.Forms.Label();
            this.lblCaptionRefund = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblActual.Location = new System.Drawing.Point(334, 92);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(71, 30);
            this.lblActual.TabIndex = 6;
            this.lblActual.Text = "$0.00";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRemaining.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblRemaining.Location = new System.Drawing.Point(334, 168);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(61, 25);
            this.lblRemaining.TabIndex = 8;
            this.lblRemaining.Text = "$0.00";
            // 
            // lblRefund
            // 
            this.lblRefund.AutoSize = true;
            this.lblRefund.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRefund.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblRefund.Location = new System.Drawing.Point(334, 230);
            this.lblRefund.Name = "lblRefund";
            this.lblRefund.Size = new System.Drawing.Size(61, 25);
            this.lblRefund.TabIndex = 10;
            this.lblRefund.Text = "$0.00";
            // 
            // txtPaid
            // 
            this.txtPaid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPaid.Location = new System.Drawing.Point(20, 92);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(180, 30);
            this.txtPaid.TabIndex = 0;
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Location = new System.Drawing.Point(20, 162);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(200, 28);
            this.cbPaymentMethod.TabIndex = 1;
            // 
            // btnSaveTransaction
            // 
            this.btnSaveTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSaveTransaction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveTransaction.ForeColor = System.Drawing.Color.White;
            this.btnSaveTransaction.Location = new System.Drawing.Point(20, 220);
            this.btnSaveTransaction.Name = "btnSaveTransaction";
            this.btnSaveTransaction.Size = new System.Drawing.Size(140, 55);
            this.btnSaveTransaction.TabIndex = 2;
            this.btnSaveTransaction.Text = " Complete Payment";
            this.btnSaveTransaction.UseVisualStyleBackColor = false;
            this.btnSaveTransaction.Click += new System.EventHandler(this.btnSaveTransaction_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(176, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = " Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitleCaption
            // 
            this.lblTitleCaption.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitleCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblTitleCaption.Location = new System.Drawing.Point(12, 9);
            this.lblTitleCaption.Name = "lblTitleCaption";
            this.lblTitleCaption.Size = new System.Drawing.Size(303, 30);
            this.lblTitleCaption.TabIndex = 0;
            this.lblTitleCaption.Text = "💳 Payment & Transaction";
            this.lblTitleCaption.UseMnemonic = false;
            // 
            // lblCaptionActual
            // 
            this.lblCaptionActual.AutoSize = true;
            this.lblCaptionActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCaptionActual.ForeColor = System.Drawing.Color.DimGray;
            this.lblCaptionActual.Location = new System.Drawing.Point(334, 70);
            this.lblCaptionActual.Name = "lblCaptionActual";
            this.lblCaptionActual.Size = new System.Drawing.Size(99, 20);
            this.lblCaptionActual.TabIndex = 5;
            this.lblCaptionActual.Text = "Amount Due";
            // 
            // lblCaptionPaid
            // 
            this.lblCaptionPaid.AutoSize = true;
            this.lblCaptionPaid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCaptionPaid.Location = new System.Drawing.Point(20, 70);
            this.lblCaptionPaid.Name = "lblCaptionPaid";
            this.lblCaptionPaid.Size = new System.Drawing.Size(126, 20);
            this.lblCaptionPaid.TabIndex = 1;
            this.lblCaptionPaid.Text = "Amount Paid ($)";
            // 
            // lblCaptionMethod
            // 
            this.lblCaptionMethod.AutoSize = true;
            this.lblCaptionMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCaptionMethod.Location = new System.Drawing.Point(20, 140);
            this.lblCaptionMethod.Name = "lblCaptionMethod";
            this.lblCaptionMethod.Size = new System.Drawing.Size(130, 20);
            this.lblCaptionMethod.TabIndex = 2;
            this.lblCaptionMethod.Text = "Payment Method";
            // 
            // lblCaptionRemain
            // 
            this.lblCaptionRemain.AutoSize = true;
            this.lblCaptionRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCaptionRemain.ForeColor = System.Drawing.Color.DimGray;
            this.lblCaptionRemain.Location = new System.Drawing.Point(334, 148);
            this.lblCaptionRemain.Name = "lblCaptionRemain";
            this.lblCaptionRemain.Size = new System.Drawing.Size(142, 20);
            this.lblCaptionRemain.TabIndex = 7;
            this.lblCaptionRemain.Text = "Remaining Balance";
            // 
            // lblCaptionRefund
            // 
            this.lblCaptionRefund.AutoSize = true;
            this.lblCaptionRefund.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCaptionRefund.ForeColor = System.Drawing.Color.DimGray;
            this.lblCaptionRefund.Location = new System.Drawing.Point(334, 210);
            this.lblCaptionRefund.Name = "lblCaptionRefund";
            this.lblCaptionRefund.Size = new System.Drawing.Size(151, 20);
            this.lblCaptionRefund.TabIndex = 9;
            this.lblCaptionRefund.Text = "Refund to Customer";
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.LightGray;
            this.pnlDivider.Location = new System.Drawing.Point(314, 55);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(1, 220);
            this.pnlDivider.TabIndex = 4;
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 314);
            this.Controls.Add(this.lblTitleCaption);
            this.Controls.Add(this.lblCaptionPaid);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.lblCaptionMethod);
            this.Controls.Add(this.cbPaymentMethod);
            this.Controls.Add(this.btnSaveTransaction);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.lblCaptionActual);
            this.Controls.Add(this.lblActual);
            this.Controls.Add(this.lblCaptionRemain);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.lblCaptionRefund);
            this.Controls.Add(this.lblRefund);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Complete Payment";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Value labels
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblRefund;

        // Inputs
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.ComboBox cbPaymentMethod;

        // Buttons
        private System.Windows.Forms.Button btnSaveTransaction;
        private System.Windows.Forms.Button button1;

        // Static captions
        private System.Windows.Forms.Label lblTitleCaption;
        private System.Windows.Forms.Label lblCaptionActual;
        private System.Windows.Forms.Label lblCaptionPaid;
        private System.Windows.Forms.Label lblCaptionMethod;
        private System.Windows.Forms.Label lblCaptionRemain;
        private System.Windows.Forms.Label lblCaptionRefund;

        // Divider
        private System.Windows.Forms.Panel pnlDivider;
    }
}
