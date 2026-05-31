using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Maintenance
{
    public partial class frmListMaintenance : Form
    {
        private bool _isProcessing = false;

        public frmListMaintenance()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            dgvMaintenanceList.DataSource = clsMaintenance.ListMaintenance();
            UpdateStatusBar();
        }

        private void UpdateStatusBar()
        {
            if (dgvMaintenanceList.DataSource != null)
            {
                DataTable dt = (DataTable)dgvMaintenanceList.DataSource;
                tsslRecordCount.Text = $"Pending Maintenance: {dt.Rows.Count}";
                tsslLastUpdated.Text = $"Last Updated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            }
        }

        private void frmListMaintenance_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnNewMaintenance_Click(object sender, EventArgs e)
        {
            new frmMaintenance().ShowDialog();
            LoadData();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            new frmMaintenanceHistory().ShowDialog();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMaintenanceList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_isProcessing) return;
            if (e.RowIndex < 0) return;

            if (dgvMaintenanceList.Columns[e.ColumnIndex].Name == "IsCompleted")
            {
                int id = Convert.ToInt32(
                    dgvMaintenanceList.Rows[e.RowIndex].Cells["MaintenanceID"].Value);

                object val = dgvMaintenanceList.Rows[e.RowIndex].Cells["IsCompleted"].Value;

                bool isChecked = false;

                if (val != DBNull.Value)
                    isChecked = Convert.ToBoolean(val);

                if (isChecked)
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to complete this maintenance?\n\n" +
                        "This will mark the maintenance as completed and make the vehicle available again.",
                        "Confirm Completion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (clsMaintenance.Complete(id))
                        {
                            MessageBox.Show("Maintenance Completed and Archived", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.BeginInvoke(new Action(() =>
                            {
                                LoadData();
                            }));
                        }
                        else
                        {
                            MessageBox.Show("Failed to complete maintenance. Please try again.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                            this.BeginInvoke(new Action(() =>
                            {
                                LoadData();
                            }));
                        }
                    }
                    else
                    {
                        _isProcessing = true;
                        this.BeginInvoke(new Action(() =>
                        {
                            LoadData();
                            _isProcessing = false;
                        }));
                    }
                }
            }
        }

        private void dgvMaintenanceList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvMaintenanceList.IsCurrentCellDirty && !_isProcessing)
            {
                dgvMaintenanceList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}