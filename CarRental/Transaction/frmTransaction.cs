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
            lblActual.Text = "$" + _ActualAmount.ToString("0.00");

            cbPaymentMethod.Items.Clear();
            cbPaymentMethod.Items.Add("Cash");
            cbPaymentMethod.Items.Add("Card");
            cbPaymentMethod.Items.Add("Online");
            cbPaymentMethod.SelectedIndex = 0;

            txtPaid.Text = _ActualAmount.ToString("0.00");

            Calculate();

            txtPaid.TextChanged += (s, ev) => Calculate();
        }

        void Calculate()
        {
            decimal.TryParse(txtPaid.Text, out decimal paid);

            decimal remaining = _ActualAmount > paid ? _ActualAmount - paid : 0;
            decimal refund = paid > _ActualAmount ? paid - _ActualAmount : 0;

            lblRemaining.Text = "$" + remaining.ToString("0.00");
            lblRefund.Text = "$" + refund.ToString("0.00");

            lblRemaining.ForeColor = remaining > 0
                ? System.Drawing.Color.OrangeRed
                : System.Drawing.Color.SeaGreen;

            lblRefund.ForeColor = refund > 0
                ? System.Drawing.Color.SeaGreen
                : System.Drawing.Color.DimGray;
        }

        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
