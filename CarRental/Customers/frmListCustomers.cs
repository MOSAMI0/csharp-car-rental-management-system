using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmListCustomers : Form
    {
        private DataTable _dtCustomers;
        private bool _isLoading = false;

        public frmListCustomers()
        {
            InitializeComponent();
            SetupSearchComboBox();
        }

        private void SetupSearchComboBox()
        {
            cboSearchField.Items.Clear();
            cboSearchField.Items.Add("Customer ID");
            cboSearchField.Items.Add("Name");
            cboSearchField.Items.Add("Contact Information");
            cboSearchField.Items.Add("Driver License");
            cboSearchField.SelectedIndex = 0;
        }

        private void RefreshCustomersList()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                _dtCustomers = clsCustomer.ListCustomers();
                dgvCustomersList.DataSource = _dtCustomers;

                // Configure columns for professional appearance
                ConfigureDataGridViewColumns();

                // Update status bar
                UpdateStatusBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading customers: {ex.Message}",
                    "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            if (dgvCustomersList.Columns.Count == 0) return;

            // Hide unnecessary columns
            if (dgvCustomersList.Columns.Contains("ImagePath"))
                dgvCustomersList.Columns["ImagePath"].Visible = false;

            // Set friendly column headers using actual database column names
            if (dgvCustomersList.Columns.Contains("CustomerID"))
                dgvCustomersList.Columns["CustomerID"].HeaderText = "ID";

            if (dgvCustomersList.Columns.Contains("Name"))
                dgvCustomersList.Columns["Name"].HeaderText = "Customer Name";

            if (dgvCustomersList.Columns.Contains("ContactInformation"))
                dgvCustomersList.Columns["ContactInformation"].HeaderText = "Contact Info";

            if (dgvCustomersList.Columns.Contains("DriverLicenseNumber"))
                dgvCustomersList.Columns["DriverLicenseNumber"].HeaderText = "Driver License";

            // Set column widths
            if (dgvCustomersList.Columns.Contains("CustomerID"))
                dgvCustomersList.Columns["CustomerID"].Width = 80;

            if (dgvCustomersList.Columns.Contains("Name"))
                dgvCustomersList.Columns["Name"].Width = 200;

            if (dgvCustomersList.Columns.Contains("ContactInformation"))
                dgvCustomersList.Columns["ContactInformation"].Width = 180;

            if (dgvCustomersList.Columns.Contains("DriverLicenseNumber"))
                dgvCustomersList.Columns["DriverLicenseNumber"].Width = 150;
        }

        private void UpdateStatusBar()
        {
            if (_dtCustomers != null)
            {
                tsslRecordCount.Text = $"Total Records: {_dtCustomers.Rows.Count}";
                tsslLastUpdated.Text = $"Last Updated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            }
        }

        private void PerformSearch()
        {
            if (_dtCustomers == null) return;

            string searchField = cboSearchField.SelectedItem.ToString();
            string searchValue = txtSearchValue.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                // Clear search - show all records
                dgvCustomersList.DataSource = _dtCustomers;
                tsslRecordCount.Text = $"Total Records: {_dtCustomers.Rows.Count}";
                return;
            }

            // Map display field to actual column name (C# 7.3 compatible)
            string columnName;
            switch (searchField)
            {
                case "Customer ID":
                    columnName = "CustomerID";
                    break;
                case "Name":
                    columnName = "Name";
                    break;
                case "Contact Information":
                    columnName = "ContactInformation";
                    break;
                case "Driver License":
                    columnName = "DriverLicenseNumber";
                    break;
                default:
                    columnName = searchField;
                    break;
            }

            // Check if column exists
            if (!_dtCustomers.Columns.Contains(columnName))
            {
                MessageBox.Show($"The column '{columnName}' was not found in the data source.",
                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Perform case-insensitive search
            DataTable dtFiltered = _dtCustomers.Clone();

            foreach (DataRow row in _dtCustomers.Rows)
            {
                object value = row[columnName];
                if (value != null && value.ToString().ToLower().Contains(searchValue.ToLower()))
                {
                    dtFiltered.ImportRow(row);
                }
            }

            dgvCustomersList.DataSource = dtFiltered;
            tsslRecordCount.Text = $"Search Results: {dtFiltered.Rows.Count} of {_dtCustomers.Rows.Count}";
        }

        private void ClearSearch()
        {
            txtSearchValue.Clear();
            dgvCustomersList.DataSource = _dtCustomers;
            UpdateStatusBar();
        }

        private int GetSelectedCustomerID()
        {
            try
            {
                // Try to get by column name first
                if (dgvCustomersList.CurrentRow.Cells["CustomerID"] != null &&
                    dgvCustomersList.CurrentRow.Cells["CustomerID"].Value != null)
                {
                    return Convert.ToInt32(dgvCustomersList.CurrentRow.Cells["CustomerID"].Value);
                }
                // Fallback to column index 0
                else if (dgvCustomersList.CurrentRow.Cells[0].Value != null)
                {
                    return Convert.ToInt32(dgvCustomersList.CurrentRow.Cells[0].Value);
                }
            }
            catch (Exception)
            {
                return -1;
            }
            return -1;
        }

        private string GetCustomerDisplayInfo()
        {
            try
            {
                string name = dgvCustomersList.CurrentRow.Cells["Name"]?.Value?.ToString() ?? "Unknown";
                string contact = dgvCustomersList.CurrentRow.Cells["ContactInformation"]?.Value?.ToString() ?? "Unknown";
                int customerID = GetSelectedCustomerID();

                return $"ID: {customerID}\nName: {name}\nContact: {contact}";
            }
            catch
            {
                return $"ID: {GetSelectedCustomerID()}";
            }
        }

        private void EditSelectedCustomer()
        {
            // Check if a row is selected
            if (dgvCustomersList.CurrentRow == null)
            {
                MessageBox.Show("Please select a customer to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the Customer ID
            int customerID = GetSelectedCustomerID();
            if (customerID == -1)
            {
                MessageBox.Show("Unable to retrieve the customer ID. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (frmAddEditCustomer frm = new frmAddEditCustomer(customerID))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RefreshCustomersList();
                }
            }
        }

        private void DeleteSelectedCustomer()
        {
            // Check if a row is selected
            if (dgvCustomersList.CurrentRow == null)
            {
                MessageBox.Show("Please select a customer to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the Customer ID
            int customerID = GetSelectedCustomerID();
            if (customerID == -1)
            {
                MessageBox.Show("Unable to retrieve the customer ID. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get customer info for confirmation message
            string customerInfo = GetCustomerDisplayInfo();

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the following customer?\n\n{customerInfo}\n\nThis action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (clsCustomer.Delete(customerID))
                    {
                        MessageBox.Show("Customer has been deleted successfully.",
                            "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshCustomersList();
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete the customer. They may have active reservations.",
                            "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the customer: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmListCustomers_Load(object sender, EventArgs e)
        {
            _isLoading = true;
            RefreshCustomersList();
            _isLoading = false;
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            using (frmAddEditCustomer frm = new frmAddEditCustomer(-1))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RefreshCustomersList();
                }
            }
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshCustomersList();
            ClearSearch();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiEditCustomer_Click(object sender, EventArgs e)
        {
            EditSelectedCustomer();
        }

        private void tsmiDeleteCustomer_Click(object sender, EventArgs e)
        {
            DeleteSelectedCustomer();
        }

      

        private void dgvCustomersList_MouseClick(object sender, MouseEventArgs e)
        {
            // Show context menu on right-click
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dgvCustomersList.HitTest(e.X, e.Y);
                if (hitTest.RowIndex >= 0)
                {
                    dgvCustomersList.ClearSelection();
                    dgvCustomersList.Rows[hitTest.RowIndex].Selected = true;
                    cmsCustomerActions.Show(dgvCustomersList, e.Location);
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
            // Optional: Real-time search (uncomment if desired)
            // if (!_isLoading)
            // {
            //     PerformSearch();
            // }
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

        
    }
}