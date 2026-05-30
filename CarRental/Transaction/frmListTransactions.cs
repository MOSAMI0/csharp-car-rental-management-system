using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Transaction
{
    public partial class frmListTransactions : Form
    {
        private DataTable _dtTransactions;

        public frmListTransactions()
        {
            InitializeComponent();
        }

        private void RefreshTransactionsList()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                _dtTransactions = clsTransaction.ListTransactions();
                dgvTransactionsList.DataSource = _dtTransactions;

                // Configure columns for professional appearance
                ConfigureDataGridViewColumns();

                // Update status bar
                UpdateStatusBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading transactions: {ex.Message}",
                    "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            if (dgvTransactionsList.Columns.Count == 0) return;

            // Set friendly column headers
            if (dgvTransactionsList.Columns.Contains("TransactionID"))
                dgvTransactionsList.Columns["TransactionID"].HeaderText = "ID";

            if (dgvTransactionsList.Columns.Contains("BookingID"))
                dgvTransactionsList.Columns["BookingID"].HeaderText = "Booking ID";

            if (dgvTransactionsList.Columns.Contains("CustomerName"))
                dgvTransactionsList.Columns["CustomerName"].HeaderText = "Customer";

            if (dgvTransactionsList.Columns.Contains("VehicleInfo"))
                dgvTransactionsList.Columns["VehicleInfo"].HeaderText = "Vehicle";

            if (dgvTransactionsList.Columns.Contains("TransactionDate"))
            {
                dgvTransactionsList.Columns["TransactionDate"].HeaderText = "Date";
                dgvTransactionsList.Columns["TransactionDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            }

            if (dgvTransactionsList.Columns.Contains("PaymentMethod"))
                dgvTransactionsList.Columns["PaymentMethod"].HeaderText = "Payment Method";

            if (dgvTransactionsList.Columns.Contains("PaidAmount"))
            {
                dgvTransactionsList.Columns["PaidAmount"].HeaderText = "Amount";
                dgvTransactionsList.Columns["PaidAmount"].DefaultCellStyle.Format = "C2";
                dgvTransactionsList.Columns["PaidAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Set column widths
            if (dgvTransactionsList.Columns.Contains("TransactionID"))
                dgvTransactionsList.Columns["TransactionID"].Width = 60;

            if (dgvTransactionsList.Columns.Contains("BookingID"))
                dgvTransactionsList.Columns["BookingID"].Width = 90;

            if (dgvTransactionsList.Columns.Contains("CustomerName"))
                dgvTransactionsList.Columns["CustomerName"].Width = 150;

            if (dgvTransactionsList.Columns.Contains("VehicleInfo"))
                dgvTransactionsList.Columns["VehicleInfo"].Width = 150;
        }

        private void UpdateStatusBar()
        {
            if (_dtTransactions != null)
            {
                // Update record count
                tsslRecordCount.Text = $"Total Transactions: {_dtTransactions.Rows.Count}";

                // Calculate total amount sum
                decimal totalAmount = 0;
                if (_dtTransactions.Columns.Contains("PaidAmount"))
                {
                    foreach (DataRow row in _dtTransactions.Rows)
                    {
                        if (row["PaidAmount"] != DBNull.Value)
                        {
                            totalAmount += Convert.ToDecimal(row["PaidAmount"]);
                        }
                    }
                }
                tsslTotalAmount.Text = $"Total Amount: {totalAmount:C2}";

                // Update last updated timestamp
                tsslLastUpdated.Text = $"Last Updated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            }
        }

        // Event Handlers
        private void frmListTransactions_Load(object sender, EventArgs e)
        {
            RefreshTransactionsList();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshTransactionsList();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}