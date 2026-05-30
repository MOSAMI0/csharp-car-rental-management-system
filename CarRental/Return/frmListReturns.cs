using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Return
{
    public partial class frmListReturns : Form
    {
        private DataTable _dtReturns;

        public frmListReturns()
        {
            InitializeComponent();
        }

        private void RefreshReturnsList()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                _dtReturns = clsReturn.ListReturns();
                dgvReturnsList.DataSource = _dtReturns;
                ConfigureDataGridViewColumns();
                UpdateStatusBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading returns: {ex.Message}",
                    "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            if (dgvReturnsList.Columns.Count == 0) return;

            // Set friendly column headers
            if (dgvReturnsList.Columns.Contains("ReturnID"))
                dgvReturnsList.Columns["ReturnID"].HeaderText = "ID";

            if (dgvReturnsList.Columns.Contains("BookingID"))
                dgvReturnsList.Columns["BookingID"].HeaderText = "Booking ID";

            if (dgvReturnsList.Columns.Contains("CustomerName"))
                dgvReturnsList.Columns["CustomerName"].HeaderText = "Customer";

            if (dgvReturnsList.Columns.Contains("VehicleInfo"))
                dgvReturnsList.Columns["VehicleInfo"].HeaderText = "Vehicle";

            if (dgvReturnsList.Columns.Contains("ReturnDate"))
            {
                dgvReturnsList.Columns["ReturnDate"].HeaderText = "Return Date";
                dgvReturnsList.Columns["ReturnDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            if (dgvReturnsList.Columns.Contains("Days"))
                dgvReturnsList.Columns["Days"].HeaderText = "Days";

            if (dgvReturnsList.Columns.Contains("Mileage"))
            {
                dgvReturnsList.Columns["Mileage"].HeaderText = "Mileage (km)";
                dgvReturnsList.Columns["Mileage"].DefaultCellStyle.Format = "N0";
                dgvReturnsList.Columns["Mileage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvReturnsList.Columns.Contains("Consumed"))
            {
                dgvReturnsList.Columns["Consumed"].HeaderText = "Consumed (km)";
                dgvReturnsList.Columns["Consumed"].DefaultCellStyle.Format = "N0";
                dgvReturnsList.Columns["Consumed"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvReturnsList.Columns.Contains("ExtraCharges"))
            {
                dgvReturnsList.Columns["ExtraCharges"].HeaderText = "Extra Charges";
                dgvReturnsList.Columns["ExtraCharges"].DefaultCellStyle.Format = "C2";
                dgvReturnsList.Columns["ExtraCharges"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvReturnsList.Columns.Contains("Total"))
            {
                dgvReturnsList.Columns["Total"].HeaderText = "Total Amount";
                dgvReturnsList.Columns["Total"].DefaultCellStyle.Format = "C2";
                dgvReturnsList.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvReturnsList.Columns.Contains("Notes"))
                dgvReturnsList.Columns["Notes"].HeaderText = "Notes";

            // Set column widths
            if (dgvReturnsList.Columns.Contains("ReturnID"))
                dgvReturnsList.Columns["ReturnID"].Width = 60;

            if (dgvReturnsList.Columns.Contains("BookingID"))
                dgvReturnsList.Columns["BookingID"].Width = 90;

            if (dgvReturnsList.Columns.Contains("CustomerName"))
                dgvReturnsList.Columns["CustomerName"].Width = 150;

            if (dgvReturnsList.Columns.Contains("VehicleInfo"))
                dgvReturnsList.Columns["VehicleInfo"].Width = 150;
        }

        private void UpdateStatusBar()
        {
            if (_dtReturns != null)
            {
                tsslRecordCount.Text = $"Total Returns: {_dtReturns.Rows.Count}";
                tsslLastUpdated.Text = $"Last Updated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            }
        }

        private int GetSelectedReturnID()
        {
            try
            {
                if (dgvReturnsList.CurrentRow.Cells["ReturnID"] != null &&
                    dgvReturnsList.CurrentRow.Cells["ReturnID"].Value != null)
                {
                    return Convert.ToInt32(dgvReturnsList.CurrentRow.Cells["ReturnID"].Value);
                }
                else if (dgvReturnsList.CurrentRow.Cells[0].Value != null)
                {
                    return Convert.ToInt32(dgvReturnsList.CurrentRow.Cells[0].Value);
                }
            }
            catch (Exception)
            {
                return -1;
            }
            return -1;
        }

        private void DeleteReturnRecord()
        {
            if (dgvReturnsList.CurrentRow == null)
            {
                MessageBox.Show("Please select a return record to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int returnID = GetSelectedReturnID();
            if (returnID == -1)
            {
                MessageBox.Show("Unable to retrieve the return ID. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete Return Record #{returnID}?\n\nThis action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (clsReturn.Delete(returnID))
                    {
                        MessageBox.Show("Return record has been deleted successfully.",
                            "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshReturnsList();
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete the return record. Please try again.",
                            "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the record: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event Handlers
        private void frmListReturns_Load(object sender, EventArgs e)
        {
            RefreshReturnsList();
        }

        private void btnReturnVehicle_Click(object sender, EventArgs e)
        {
            using (frmReturnVehicle frm = new frmReturnVehicle())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RefreshReturnsList();
                }
            }
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshReturnsList();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiDeleteReturn_Click(object sender, EventArgs e)
        {
            DeleteReturnRecord();
        }
    }
}