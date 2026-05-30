using BusinessLayer;
using System;
using System.Windows.Forms;

namespace CarRental.Transaction
{
    public partial class frmTransaction : Form
    {
        int _BookingID;
        int _ReturnID;
        decimal _ActualAmount;

        public frmTransaction(int bookingID, int returnID, decimal actualAmount)
        {
            InitializeComponent();

            _BookingID = bookingID;
            _ReturnID = returnID;
            _ActualAmount = actualAmount;
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            // Show amount due with $ prefix to match designer label style
            lblActual.Text = "$" + _ActualAmount.ToString("0.00");

            // Payment methods
            cbPaymentMethod.Items.Clear();
            cbPaymentMethod.Items.Add("Cash");
            cbPaymentMethod.Items.Add("Card");
            cbPaymentMethod.Items.Add("Online");
            cbPaymentMethod.SelectedIndex = 0;

            // Default paid = actual (best UX — customer pays exact amount)
            txtPaid.Text = _ActualAmount.ToString("0.00");

            // Run once to populate remaining/refund labels on load
            Calculate();

            // Auto-recalculate on every keystroke
            txtPaid.TextChanged += (s, ev) => Calculate();
        }

        void Calculate()
        {
            decimal.TryParse(txtPaid.Text, out decimal paid);

            decimal remaining = _ActualAmount > paid ? _ActualAmount - paid : 0;
            decimal refund = paid > _ActualAmount ? paid - _ActualAmount : 0;

            // Update labels with $ prefix and color feedback
            lblRemaining.Text = "$" + remaining.ToString("0.00");
            lblRefund.Text = "$" + refund.ToString("0.00");

            // Visual feedback: highlight remaining in red when still owed
            lblRemaining.ForeColor = remaining > 0
                ? System.Drawing.Color.OrangeRed
                : System.Drawing.Color.SeaGreen;

            // Highlight refund in green only when there's a positive refund
            lblRefund.ForeColor = refund > 0
                ? System.Drawing.Color.SeaGreen
                : System.Drawing.Color.DimGray;
        }

        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Closing without saving → DialogResult stays Cancel (default)
            // frmReturnVehicle checks this and rolls back the return record
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to cancel?\n" +
                "The return record will be removed if you cancel now.",
                "Cancel Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
                this.Close();
        }

        private void btnSaveTransaction_Click_1(object sender, EventArgs e)

        {

            if (!decimal.TryParse(txtPaid.Text, out decimal paid) || paid <= 0)
            {
                MessageBox.Show("Please enter a valid paid amount.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaid.Focus();
                return;
            }

            if (cbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbPaymentMethod.Focus();
                return;
            }

            // Warn if customer is paying less than the amount due
            decimal remaining = _ActualAmount - paid;
            if (remaining > 0)
            {
                DialogResult confirm = MessageBox.Show(
                    $"The customer is paying ${paid:0.00} but owes ${_ActualAmount:0.00}.\n" +
                    $"There is still ${remaining:0.00} remaining.\n\n" +
                    "Save this partial payment anyway?",
                    "Partial Payment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes)
                    return;
            }

            clsTransaction t = new clsTransaction();
            t.BookingID = _BookingID;
            t.ReturnID = _ReturnID;
            t.PaymentMethod = cbPaymentMethod.Text;
            t.PaidAmount = paid;
            t.ActualAmount = _ActualAmount;

            if (t.Save())
            {
                MessageBox.Show(
                    "Transaction completed successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


                // this is what keeps the return record in the list
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Transaction could not be saved. It may already exist.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
