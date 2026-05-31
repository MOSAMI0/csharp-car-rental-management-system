using BusinessLayer;
using CarRental.Vehicles;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmListVehicles : Form
    {
        private DataTable _dtVehicles;
        private bool _isLoading = false;

        public frmListVehicles()
        {
            InitializeComponent();
            SetupSearchComboBox();
        }

        private void SetupSearchComboBox()
        {
            cboSearchField.Items.Clear();
            cboSearchField.Items.Add("Vehicle ID");
            cboSearchField.Items.Add("Make");
            cboSearchField.Items.Add("Model");
            cboSearchField.Items.Add("Year");
            cboSearchField.Items.Add("License Plate");
            cboSearchField.Items.Add("Category");
            cboSearchField.SelectedIndex = 0;
        }

        private void RefreshVehiclesList()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                _dtVehicles = clsVehicle.ListVehicles();
                dgvVehiclesList.DataSource = _dtVehicles;

                ConfigureDataGridViewColumns();

                UpdateStatusBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading vehicles: {ex.Message}",
                    "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            if (dgvVehiclesList.Columns.Count == 0) return;

            if (dgvVehiclesList.Columns.Contains("ImagePath"))
                dgvVehiclesList.Columns["ImagePath"].Visible = false;

            if (dgvVehiclesList.Columns.Contains("MakeID"))
                dgvVehiclesList.Columns["MakeID"].Visible = false;

            if (dgvVehiclesList.Columns.Contains("ModelID"))
                dgvVehiclesList.Columns["ModelID"].Visible = false;

            if (dgvVehiclesList.Columns.Contains("FuelID"))
                dgvVehiclesList.Columns["FuelID"].Visible = false;

            if (dgvVehiclesList.Columns.Contains("CategoryID"))
                dgvVehiclesList.Columns["CategoryID"].Visible = false;

            if (dgvVehiclesList.Columns.Contains("VehicleID"))
                dgvVehiclesList.Columns["VehicleID"].HeaderText = "ID";

            if (dgvVehiclesList.Columns.Contains("Make"))
                dgvVehiclesList.Columns["Make"].HeaderText = "Make";

            if (dgvVehiclesList.Columns.Contains("Model"))
                dgvVehiclesList.Columns["Model"].HeaderText = "Model";

            if (dgvVehiclesList.Columns.Contains("Year"))
                dgvVehiclesList.Columns["Year"].HeaderText = "Year";

            if (dgvVehiclesList.Columns.Contains("Plate"))
                dgvVehiclesList.Columns["Plate"].HeaderText = "License Plate";

            if (dgvVehiclesList.Columns.Contains("Mileage"))
                dgvVehiclesList.Columns["Mileage"].HeaderText = "Mileage";

            if (dgvVehiclesList.Columns.Contains("Price"))
                dgvVehiclesList.Columns["Price"].HeaderText = "Daily Price";

            if (dgvVehiclesList.Columns.Contains("IsAvailableForRent"))
            {
                dgvVehiclesList.Columns["IsAvailableForRent"].HeaderText = "Available";
                dgvVehiclesList.Columns["IsAvailableForRent"].Width = 80;
            }

            if (dgvVehiclesList.Columns.Contains("Price"))
            {
                dgvVehiclesList.Columns["Price"].DefaultCellStyle.Format = "C2";
                dgvVehiclesList.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvVehiclesList.Columns.Contains("Mileage"))
            {
                dgvVehiclesList.Columns["Mileage"].DefaultCellStyle.Format = "N0";
                dgvVehiclesList.Columns["Mileage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvVehiclesList.Columns.Contains("VehicleID"))
                dgvVehiclesList.Columns["VehicleID"].Width = 60;

            if (dgvVehiclesList.Columns.Contains("Make"))
                dgvVehiclesList.Columns["Make"].Width = 120;

            if (dgvVehiclesList.Columns.Contains("Model"))
                dgvVehiclesList.Columns["Model"].Width = 120;

            if (dgvVehiclesList.Columns.Contains("License Plate"))
                dgvVehiclesList.Columns["License Plate"].Width = 120;
        }

        private void UpdateStatusBar()
        {
            if (_dtVehicles != null)
            {
                tsslRecordCount.Text = $"Total Records: {_dtVehicles.Rows.Count}";
                tsslLastUpdated.Text = $"Last Updated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            }
        }

        private void PerformSearch()
        {
            if (_dtVehicles == null) return;

            string searchField = cboSearchField.SelectedItem.ToString();
            string searchValue = txtSearchValue.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                dgvVehiclesList.DataSource = _dtVehicles;
                tsslRecordCount.Text = $"Total Records: {_dtVehicles.Rows.Count}";
                return;
            }

            string columnName;
            switch (searchField)
            {
                case "Vehicle ID":
                    columnName = "VehicleID";
                    break;
                case "License Plate":
                    columnName = "PlateNumber";
                    break;
                case "Make":
                    columnName = "MakeName";  
                    break;
                case "Model":
                    columnName = "ModelName";  
                    break;
                case "Year":
                    columnName = "Year";
                    break;
                case "Category":
                    columnName = "CategoryName";  
                    break;
                default:
                    columnName = searchField;
                    break;
            }

            if (!_dtVehicles.Columns.Contains(columnName))
            {
                MessageBox.Show($"The column '{columnName}' was not found in the data source.",
                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dtFiltered = _dtVehicles.Clone();

            foreach (DataRow row in _dtVehicles.Rows)
            {
                object value = row[columnName];
                if (value != null && value.ToString().ToLower().Contains(searchValue.ToLower()))
                {
                    dtFiltered.ImportRow(row);
                }
            }

            dgvVehiclesList.DataSource = dtFiltered;
            tsslRecordCount.Text = $"Search Results: {dtFiltered.Rows.Count} of {_dtVehicles.Rows.Count}";
        }

        private void ClearSearch()
        {
            txtSearchValue.Clear();
            dgvVehiclesList.DataSource = _dtVehicles;
            UpdateStatusBar();
        }

        private void frmListVehicles_Load(object sender, EventArgs e)
        {
            _isLoading = true;
            RefreshVehiclesList();
            _isLoading = false;
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            using (frmAddEditVehicle frm = new frmAddEditVehicle(-1))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RefreshVehiclesList();
                }
            }
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshVehiclesList();
            ClearSearch();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiEditVehicle_Click(object sender, EventArgs e)
        {
            EditSelectedVehicle();
        }

        private void tsmiDeleteVehicle_Click(object sender, EventArgs e)
        {
            DeleteSelectedVehicle();
        }

        private void tsmiViewDetails_Click(object sender, EventArgs e)
        {
            ViewVehicleDetails();
        }

        private void EditSelectedVehicle()
        {
            if (dgvVehiclesList.CurrentRow == null)
            {
                MessageBox.Show("Please select a vehicle to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int vehicleID = GetSelectedVehicleID();
            if (vehicleID == -1)
            {
                MessageBox.Show("Unable to retrieve the vehicle ID. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (frmAddEditVehicle frm = new frmAddEditVehicle(vehicleID))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RefreshVehiclesList();
                }
            }
        }

        private void DeleteSelectedVehicle()
        {
            if (dgvVehiclesList.CurrentRow == null)
            {
                MessageBox.Show("Please select a vehicle to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int vehicleID = GetSelectedVehicleID();
            if (vehicleID == -1)
            {
                MessageBox.Show("Unable to retrieve the vehicle ID. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string vehicleInfo = GetVehicleDisplayInfo();

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the following vehicle?\n\n{vehicleInfo}\n\nThis action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (clsVehicle.Delete(vehicleID))
                    {
                        MessageBox.Show("Vehicle has been deleted successfully.",
                            "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshVehiclesList();
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete the vehicle. It may be referenced in existing reservations.",
                            "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the vehicle: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ViewVehicleDetails()
        {
            if (dgvVehiclesList.CurrentRow == null)
            {
                MessageBox.Show("Please select a vehicle to view details.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int vehicleID = GetSelectedVehicleID();
            if (vehicleID == -1)
            {
                MessageBox.Show("Unable to retrieve the vehicle ID. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmVehicleDetails frm = new frmVehicleDetails(vehicleID);

            frm.OnVehicleUpdated += () =>
            {
                RefreshVehiclesList();
            };

            frm.ShowDialog();
        }

        private int GetSelectedVehicleID()
        {
            try
            {
                if (dgvVehiclesList.CurrentRow.Cells["VehicleID"] != null &&
                    dgvVehiclesList.CurrentRow.Cells["VehicleID"].Value != null)
                {
                    return Convert.ToInt32(dgvVehiclesList.CurrentRow.Cells["VehicleID"].Value);
                }
                else if (dgvVehiclesList.CurrentRow.Cells[0].Value != null)
                {
                    return Convert.ToInt32(dgvVehiclesList.CurrentRow.Cells[0].Value);
                }
            }
            catch (Exception)
            {
                return -1;
            }
            return -1;
        }

        private string GetVehicleDisplayInfo()
        {
            try
            {
                string make = dgvVehiclesList.CurrentRow.Cells["Make"]?.Value?.ToString() ?? "Unknown";
                string model = dgvVehiclesList.CurrentRow.Cells["Model"]?.Value?.ToString() ?? "Unknown";
                string plate = dgvVehiclesList.CurrentRow.Cells["Plate"]?.Value?.ToString() ?? "Unknown";
                int vehicleID = GetSelectedVehicleID();

                return $"ID: {vehicleID}\nMake/Model: {make} {model}\nLicense Plate: {plate}";
            }
            catch
            {
                return $"ID: {GetSelectedVehicleID()}";
            }
        }

        private void dgvVehiclesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ViewVehicleDetails();
            }
        }

        private void dgvVehiclesList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dgvVehiclesList.HitTest(e.X, e.Y);
                if (hitTest.RowIndex >= 0)
                {
                    dgvVehiclesList.ClearSelection();
                    dgvVehiclesList.Rows[hitTest.RowIndex].Selected = true;
                    cmsVehicleActions.Show(dgvVehiclesList, e.Location);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            ClearSearch();
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PerformSearch();
                e.Handled = true;
            }
        }

        private void cboSearchField_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchValue.Focus();
            if (!string.IsNullOrEmpty(txtSearchValue.Text))
            {
                PerformSearch();
            }
        }

        private void grpSearch_Enter(object sender, EventArgs e)
        {

        }

     
    }
}