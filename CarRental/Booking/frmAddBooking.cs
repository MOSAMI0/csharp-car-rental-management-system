using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Booking
{
    public partial class frmAddBooking : Form
    {
        private DataTable _dtCustomers;
        private DataTable _dtVehicles;
        private decimal _currentVehiclePrice = 0;

        public frmAddBooking()
        {
            InitializeComponent();
        }

        private void frmAddBooking_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadAvailableVehicles();
            SetDefaultDates();
            SetupEventHandlers();
            CalculateRentalSummary();
        }

        private void SetupEventHandlers()
        {
            dtpStartDate.ValueChanged += (s, ev) => CalculateRentalSummary();
            dtpEndDate.ValueChanged += (s, ev) => CalculateRentalSummary();
            cboVehicle.SelectedIndexChanged += (s, ev) => CalculateRentalSummary();
        }

        private void SetDefaultDates()
        {
            dtpStartDate.Value = DateTime.Now.Date;

            dtpEndDate.Value = DateTime.Now.Date.AddDays(1);
        }

        private void LoadCustomers()
        {
            try
            {
                _dtCustomers = clsCustomer.ListCustomers();
                cboCustomer.DataSource = _dtCustomers;
                cboCustomer.DisplayMember = "Name";
                cboCustomer.ValueMember = "CustomerID";

                if (_dtCustomers.Rows.Count > 0)
                    cboCustomer.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading customers: {ex.Message}",
                    "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAvailableVehicles()
        {
            try
            {
                _dtVehicles = clsVehicle.GetAvailableVehicles();
                cboVehicle.DataSource = _dtVehicles;
                cboVehicle.DisplayMember = "VehicleName";
                cboVehicle.ValueMember = "VehicleID";

                if (_dtVehicles.Rows.Count > 0)
                    cboVehicle.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading available vehicles: {ex.Message}",
                    "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateRentalSummary()
        {
            try
            {
                if (dtpEndDate.Value < dtpStartDate.Value)
                {
                    lblRentalDaysValue.Text = "0";
                    lblTotalCostValue.Text = "$0.00";
                    return;
                }

                int rentalDays = (dtpEndDate.Value - dtpStartDate.Value).Days;
                if (rentalDays <= 0) rentalDays = 1;

                lblRentalDaysValue.Text = rentalDays.ToString();

                decimal pricePerDay = GetVehiclePricePerDay();
                decimal totalCost = rentalDays * pricePerDay;

                lblTotalCostValue.Text = totalCost.ToString("C2");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error calculating rental summary: {ex.Message}");
                lblRentalDaysValue.Text = "0";
                lblTotalCostValue.Text = "$0.00";
            }
        }

        private decimal GetVehiclePricePerDay()
        {
            if (cboVehicle.SelectedValue == null || cboVehicle.SelectedIndex == -1)
                return 0;

            try
            {
                int vehicleID = Convert.ToInt32(cboVehicle.SelectedValue);
                _currentVehiclePrice = clsVehicle.GetPrice(vehicleID);
                return _currentVehiclePrice;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error getting vehicle price: {ex.Message}");
                return 0;
            }
        }

        private bool ValidateForm()
        {
            if (cboCustomer.SelectedValue == null || cboCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer for this booking.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCustomer.Focus();
                return false;
            }

            if (cboVehicle.SelectedValue == null || cboVehicle.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle for this booking.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboVehicle.Focus();
                return false;
            }

            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                MessageBox.Show("The end date must be after the start date.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Focus();
                return false;
            }

            if (dtpStartDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("The start date cannot be in the past.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpStartDate.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPickupLocation.Text))
            {
                MessageBox.Show("Please enter the pickup location.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPickupLocation.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDropoffLocation.Text))
            {
                MessageBox.Show("Please enter the dropoff location.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDropoffLocation.Focus();
                return false;
            }

            int rentalDays = (dtpEndDate.Value - dtpStartDate.Value).Days;
            if (rentalDays <= 0)
            {
                MessageBox.Show("The rental period must be at least 1 day.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Focus();
                return false;
            }

            return true;
        }

        private void CreateBooking()
        {
            if (!ValidateForm())
                return;

            try
            {
                clsBooking booking = new clsBooking();

                booking.CustomerID = Convert.ToInt32(cboCustomer.SelectedValue);
                booking.VehicleID = Convert.ToInt32(cboVehicle.SelectedValue);
                booking.StartMileage = clsVehicle.GetMileage(booking.VehicleID);

                booking.StartDate = dtpStartDate.Value;
                booking.EndDate = dtpEndDate.Value;
                booking.Pickup = txtPickupLocation.Text.Trim();
                booking.Dropoff = txtDropoffLocation.Text.Trim();
                booking.Days = Convert.ToInt32(lblRentalDaysValue.Text);
                booking.PricePerDay = GetVehiclePricePerDay();
                booking.Total = Convert.ToDecimal(lblTotalCostValue.Text.Replace("$", "").Replace(",", ""));
                booking.Notes = txtNotes.Text.Trim();

                if (booking.Save())
                {
                    MessageBox.Show("Booking has been created successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error occurred while creating the booking. Please try again.",
                        "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveBooking_Click(object sender, EventArgs e)
        {
            CreateBooking();
        }

        private void btnCancelClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

       
    }
}