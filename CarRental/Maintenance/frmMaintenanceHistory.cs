using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Maintenance
{
    public partial class frmMaintenanceHistory : Form
    {
        public frmMaintenanceHistory()
        {
            InitializeComponent();
        }

        private void LoadMaintenanceHistory()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                DataTable dtHistory = clsMaintenance.ListMaintenanceHistory();
                dgvMaintenanceHistory.DataSource = dtHistory;

                ConfigureDataGridViewColumns();
                UpdateStatusBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading maintenance history: {ex.Message}",
                    "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            if (dgvMaintenanceHistory.Columns.Count == 0) return;

            if (dgvMaintenanceHistory.Columns.Contains("MaintenanceID"))
                dgvMaintenanceHistory.Columns["MaintenanceID"].HeaderText = "ID";

            if (dgvMaintenanceHistory.Columns.Contains("VehicleID"))
                dgvMaintenanceHistory.Columns["VehicleID"].HeaderText = "Vehicle ID";

            if (dgvMaintenanceHistory.Columns.Contains("VehicleName"))
                dgvMaintenanceHistory.Columns["VehicleName"].HeaderText = "Vehicle";

            if (dgvMaintenanceHistory.Columns.Contains("Description"))
                dgvMaintenanceHistory.Columns["Description"].HeaderText = "Description";

            if (dgvMaintenanceHistory.Columns.Contains("Cost"))
            {
                dgvMaintenanceHistory.Columns["Cost"].HeaderText = "Cost";
                dgvMaintenanceHistory.Columns["Cost"].DefaultCellStyle.Format = "C2";
                dgvMaintenanceHistory.Columns["Cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvMaintenanceHistory.Columns.Contains("MaintenanceDate"))
            {
                dgvMaintenanceHistory.Columns["MaintenanceDate"].HeaderText = "Maintenance Date";
                dgvMaintenanceHistory.Columns["MaintenanceDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            if (dgvMaintenanceHistory.Columns.Contains("CompletedDate"))
            {
                dgvMaintenanceHistory.Columns["CompletedDate"].HeaderText = "Completed Date";
                dgvMaintenanceHistory.Columns["CompletedDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            if (dgvMaintenanceHistory.Columns.Contains("MaintenanceID"))
                dgvMaintenanceHistory.Columns["MaintenanceID"].Width = 60;

            if (dgvMaintenanceHistory.Columns.Contains("VehicleName"))
                dgvMaintenanceHistory.Columns["VehicleName"].Width = 150;

            if (dgvMaintenanceHistory.Columns.Contains("Description"))
                dgvMaintenanceHistory.Columns["Description"].Width = 200;

            if (dgvMaintenanceHistory.Columns.Contains("Cost"))
                dgvMaintenanceHistory.Columns["Cost"].Width = 100;
        }

        private void UpdateStatusBar()
        {
            if (dgvMaintenanceHistory.DataSource != null)
            {
                DataTable dt = (DataTable)dgvMaintenanceHistory.DataSource;
                tsslRecordCount.Text = $"Total Records: {dt.Rows.Count}";
                tsslLastUpdated.Text = $"Last Updated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            }
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            LoadMaintenanceHistory();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMaintenanceHistory_Load(object sender, EventArgs e)
        {
            LoadMaintenanceHistory();
        }
    }
}