using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Maintenance
{
    public partial class frmMaintenance : Form
    {
        public frmMaintenance()
        {
            InitializeComponent();
        }

        private void frmMaintenance_Load(object sender, EventArgs e)
        {
            LoadVehicles();
        }

        private void LoadVehicles()
        {
            try
            {
                DataTable dtVehicles = clsVehicle.GetAvailableVehicles();
                cboVehicle.DataSource = dtVehicles;
                cboVehicle.DisplayMember = "VehicleName";
                cboVehicle.ValueMember = "VehicleID";
                cboVehicle.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicles: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (cboVehicle.SelectedValue == null || cboVehicle.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle.", "Validation Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboVehicle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.", "Validation Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return false;
            }

            if (!decimal.TryParse(txtCost.Text, out decimal cost) || cost <= 0)
            {
                MessageBox.Show("Please enter a valid cost amount.", "Validation Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCost.Focus();
                return false;
            }

            return true;
        }

        private void SaveMaintenance()
        {
            if (!ValidateForm())
                return;

            try
            {
                clsMaintenance maintenance = new clsMaintenance();
                maintenance.VehicleID = Convert.ToInt32(cboVehicle.SelectedValue);
                maintenance.Description = txtDescription.Text.Trim();
                maintenance.Cost = Convert.ToDecimal(txtCost.Text);

                if (maintenance.Save())
                {
                    MessageBox.Show("Maintenance record saved successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save maintenance record.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveMaintenance_Click(object sender, EventArgs e)
        {
            SaveMaintenance();
        }

        private void btnCancelClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}