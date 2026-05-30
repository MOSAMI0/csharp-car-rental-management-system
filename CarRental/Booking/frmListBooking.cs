using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Booking
{
    public partial class frmListBooking : Form
    {
        private DataTable _dtBookings;

        public frmListBooking()
        {
            InitializeComponent();
        }

        private void RefreshBookingsList()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                _dtBookings = clsBooking.ListActiveBookings();
                dgvBookingsList.DataSource = _dtBookings;

                // Configure columns just renaming
                ConfigureDataGridViewColumns();

                // Update status bar
                UpdateStatusBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading bookings: {ex.Message}",
                    "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            if (dgvBookingsList.Columns.Count == 0) return;

            // Set friendly column headers
            if (dgvBookingsList.Columns.Contains("BookingID"))
                dgvBookingsList.Columns["BookingID"].HeaderText = "ID";

            if (dgvBookingsList.Columns.Contains("CustomerID"))
                dgvBookingsList.Columns["CustomerID"].HeaderText = "Customer ID";

            if (dgvBookingsList.Columns.Contains("VehicleID"))
                dgvBookingsList.Columns["VehicleID"].HeaderText = "Vehicle ID";

            if (dgvBookingsList.Columns.Contains("StartDate"))
            {
                dgvBookingsList.Columns["StartDate"].HeaderText = "Start Date";
                dgvBookingsList.Columns["StartDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            if (dgvBookingsList.Columns.Contains("EndDate"))
            {
                dgvBookingsList.Columns["EndDate"].HeaderText = "End Date";
                dgvBookingsList.Columns["EndDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            if (dgvBookingsList.Columns.Contains("Pickup"))
                dgvBookingsList.Columns["Pickup"].HeaderText = "Pickup Location";

            if (dgvBookingsList.Columns.Contains("Dropoff"))
                dgvBookingsList.Columns["Dropoff"].HeaderText = "Dropoff Location";

            if (dgvBookingsList.Columns.Contains("Days"))
                dgvBookingsList.Columns["Days"].HeaderText = "Days";

            if (dgvBookingsList.Columns.Contains("PricePerDay"))
            {
                dgvBookingsList.Columns["PricePerDay"].HeaderText = "Price/Day";
                dgvBookingsList.Columns["PricePerDay"].DefaultCellStyle.Format = "C2";
                dgvBookingsList.Columns["PricePerDay"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvBookingsList.Columns.Contains("Total"))
            {
                dgvBookingsList.Columns["Total"].HeaderText = "Total Cost";
                dgvBookingsList.Columns["Total"].DefaultCellStyle.Format = "C2";
                dgvBookingsList.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvBookingsList.Columns.Contains("Notes"))
                dgvBookingsList.Columns["Notes"].HeaderText = "Notes";

            // Set column widths
            if (dgvBookingsList.Columns.Contains("BookingID"))
                dgvBookingsList.Columns["BookingID"].Width = 60;

            if (dgvBookingsList.Columns.Contains("CustomerID"))
                dgvBookingsList.Columns["CustomerID"].Width = 100;

            if (dgvBookingsList.Columns.Contains("VehicleID"))
                dgvBookingsList.Columns["VehicleID"].Width = 100;
        }

        private void UpdateStatusBar()
        {
            if (_dtBookings != null)
            {
                tsslRecordCount.Text = $"Total Records: {_dtBookings.Rows.Count}";
                tsslLastUpdated.Text = $"Last Updated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            }
        }

        private int GetSelectedBookingID()
        {
            try
            {
                if (dgvBookingsList.CurrentRow.Cells["BookingID"] != null &&
                    dgvBookingsList.CurrentRow.Cells["BookingID"].Value != null)
                {
                    return Convert.ToInt32(dgvBookingsList.CurrentRow.Cells["BookingID"].Value);
                }
                else if (dgvBookingsList.CurrentRow.Cells[0].Value != null)
                {
                    return Convert.ToInt32(dgvBookingsList.CurrentRow.Cells[0].Value);
                }
            }
            catch (Exception)
            {
                return -1;
            }
            return -1;
        }

        private void DeleteSelectedBooking()
        {
            // Check if a row is selected
            if (dgvBookingsList.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookingID = GetSelectedBookingID();
            if (bookingID == -1)
            {
                MessageBox.Show("Unable to retrieve the booking ID. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete Booking #{bookingID}?\n\nThis action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (clsBooking.Delete(bookingID))
                    {
                        MessageBox.Show("Booking has been deleted successfully.",
                            "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshBookingsList();
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete the booking. Please try again.",
                            "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the booking: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event Handlers
        private void frmListBooking_Load(object sender, EventArgs e)
        {
            RefreshBookingsList();
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            frmAddBooking frm = new frmAddBooking();
            frm.ShowDialog();
            RefreshBookingsList();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshBookingsList();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //next version with Taha
        private void tsmiViewDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View Details feature will be implemented in the next version.",
                "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmiEditBooking_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit Booking feature will be implemented in the next version.",
                "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmiCancelBooking_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel Booking feature will be implemented in the next version.",
                "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmiDeleteBooking_Click(object sender, EventArgs e)
        {
            DeleteSelectedBooking();
        }

        private void dgvBookingsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MessageBox.Show("View Details feature will be implemented in the next version.",
                    "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}