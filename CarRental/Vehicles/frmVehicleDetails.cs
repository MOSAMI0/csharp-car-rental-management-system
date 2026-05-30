using BusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CarRental.Vehicles
{
    public partial class frmVehicleDetails : Form
    {
        private int _VehicleID;

        

        public frmVehicleDetails(int vehicleID)
        {
            InitializeComponent();
            _VehicleID = vehicleID;
        }

        private void LoadVehicleData()
        {
            try
            {
                DataTable dt = clsVehicle.GetVehicleDetails(_VehicleID);

                // Better null/empty check
                if (dt == null || dt.Rows.Count == 0)
                {
                    // Important: Only show message box if NOT in design mode
                    if (!this.DesignMode)
                    {
                        MessageBox.Show("Vehicle not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    return; // Exit immediately
                }

                // Now it is safe to access Rows[0]
                DataRow row = dt.Rows[0];

                lblMakeValue.Text = row["MakeName"]?.ToString() ?? "-";
                lblModelValue.Text = row["ModelName"]?.ToString() ?? "-";
                lblYearValue.Text = row["Year"]?.ToString() ?? "-";
                lblFuelTypeValue.Text = row["FuelTypeName"]?.ToString() ?? "-";
                lblCategoryValue.Text = row["CategoryName"]?.ToString() ?? "-";
                lblLicensePlateValue.Text = row["PlateNumber"]?.ToString() ?? "-";
                lblMileageValue.Text = row["Mileage"]?.ToString() ?? "-";
                lblDailyPriceValue.Text = row["RentalPricePerDay"]?.ToString() ?? "-";

                lblAvailabilityValue.Text =
                    row["IsAvailableForRent"] != DBNull.Value &&
                    (bool)row["IsAvailableForRent"]
                    ? "Available"
                    : "Not Available";

                LoadImage(row["ImagePath"]?.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicle data:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadImage(string imagePath)
        {
            // Prevent designer crash
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            try
            {
                if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(imagePath))
                {
                    picVehicleImage.Image = null;
                    return;
                }

                using (var tempImage = Image.FromFile(imagePath))
                {
                    picVehicleImage.Image?.Dispose();
                    picVehicleImage.Image = new Bitmap(tempImage);
                }
            }
            catch
            {
                picVehicleImage.Image = null;
            }
        }



        // to enable the refresh in frmListVehicles
        public event Action OnVehicleUpdated;

        private bool _isUpdated = false;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (frmAddEditVehicle frm = new frmAddEditVehicle(_VehicleID))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadVehicleData();
                    _isUpdated = true; // mark as updated
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_isUpdated)
                OnVehicleUpdated?.Invoke();

            this.Close();
            

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            picVehicleImage.Image?.Dispose();
            base.OnFormClosed(e);
        }

   
        private void frmVehicleDetails_Load_1(object sender, EventArgs e)
        {
            // Add this check at the very beginning
            if (this.DesignMode)
                return;

            LoadVehicleData();
        }
    }
}