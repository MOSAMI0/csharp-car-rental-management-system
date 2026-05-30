using BusinessLayer;
using CarRental.Transaction;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Return
{
    public partial class frmReturnVehicle : Form
    {
       
        private int _selectedBookingID;
        private DateTime _bookedStartDate;
        private DateTime _bookedEndDate;
        private int _bookedDays;
        private decimal _pricePerDay;
        private decimal _bookedTotal;
        private int _vehicleID;
        private int _initialVehicleMileage; // Store initial mileage when booking was made

        public frmReturnVehicle()
        {
            InitializeComponent();
        }

        private void frmReturnVehicle_Load(object sender, EventArgs e)
        {
            LoadActiveBookings();
            SetupEventHandlers();
            ClearBookingDetails();
        }

        private void SetupEventHandlers()
        {
            dtpReturnDate.ValueChanged += (s, ev) => CalculateReturnSummary();
            cboBooking.SelectedIndexChanged += (s, ev) => LoadBookingDetails();
            txtCurrentMileage.TextChanged += (s, ev) =>
            {
                CalculateConsumedKilometers();
            };
            txtExtraCharges.TextChanged += (s, ev) => CalculateReturnSummary();
        }

        private void LoadActiveBookings()
        {
            try
            {
                // Detach event to prevent LoadBookingDetails() firing before binding is ready
                cboBooking.SelectedIndexChanged -= cboBooking_SelectedIndexChanged;

                DataTable dtBookings = clsBooking.GetActiveBookings();
                cboBooking.DataSource = dtBookings;
                cboBooking.DisplayMember = "BookingInfo";
                cboBooking.ValueMember = "BookingID";
                cboBooking.SelectedIndex = -1;

                if (dtBookings.Rows.Count == 0)
                    tsslBookingStatus.Text = "No active bookings available";
                else
                    tsslBookingStatus.Text = "Ready - Select a booking";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading bookings: {ex.Message}",
                    "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Always re-attach, even if an exception occurred
                cboBooking.SelectedIndexChanged += cboBooking_SelectedIndexChanged;
            }
        }

        private void ClearBookingDetails()
        {
            lblCustomerValue.Text = "—";
            lblVehicleValue.Text = "—";
            lblBookingPeriodValue.Text = "—";
            lblBookedDaysValue.Text = "—";
            lblPricePerDayValue.Text = "—";
            lblOriginalTotalValue.Text = "—";
            lblActualDaysValue.Text = "0";
            lblTotalDueValue.Text = "$0.00";
            lblSurplusMessage.Text = "";
            lblSurplusMessage.Visible = false;

            txtCurrentMileage.Clear();
            txtConsumedKilometers.Clear();
            txtConsumedKilometers.Text = "0";
            txtExtraCharges.Text = "0";
            txtReturnNotes.Clear();

            _selectedBookingID = -1;
            _vehicleID = -1;
            _initialVehicleMileage = 0;
        }

        private void LoadBookingDetails()
        {
            // Guard: no selection made yet
            if (cboBooking.SelectedItem == null || cboBooking.SelectedIndex == -1)
            {
                ClearBookingDetails();
                return;
            }

            try
            {
              
                DataRowView selectedRow = cboBooking.SelectedItem as DataRowView;

                if (selectedRow == null)
                {
                    ClearBookingDetails();
                    return;
                }

                _selectedBookingID = Convert.ToInt32(selectedRow["BookingID"]);

                // Load full booking row from DB
                DataTable dt = clsBooking.GetBookingByID(_selectedBookingID);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Unable to load booking details. Please try again.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearBookingDetails();
                    return;
                }

                DataRow row = dt.Rows[0];

                // Read booking fields
                _bookedStartDate = Convert.ToDateTime(row["StartDate"]);
                _bookedEndDate = Convert.ToDateTime(row["EndDate"]);
                _bookedDays = Convert.ToInt32(row["Days"]);
                _pricePerDay = Convert.ToDecimal(row["PricePerDay"]);
                _bookedTotal = Convert.ToDecimal(row["Total"]);
                _vehicleID = Convert.ToInt32(row["VehicleID"]);

                // Get the vehicle's mileage (when vehicle was rented)
                _initialVehicleMileage = Convert.ToInt32(row["StartMileage"]);

                string customerName = row["CustomerName"].ToString();
                string vehicleName = row["VehicleName"].ToString();

                // Populate booking detail labels
                lblCustomerValue.Text = customerName;
                lblVehicleValue.Text = vehicleName;
                lblBookingPeriodValue.Text = $"{_bookedStartDate:yyyy-MM-dd} to {_bookedEndDate:yyyy-MM-dd}";
                lblBookedDaysValue.Text = _bookedDays.ToString();
                lblPricePerDayValue.Text = _pricePerDay.ToString("C2");
                lblOriginalTotalValue.Text = _bookedTotal.ToString("C2");

                //// Default return date to the booked end date
                //dtpReturnDate.Value = _bookedEndDate;
                //dtpReturnDate.MinDate = _bookedStartDate;


                dtpReturnDate.MinDate = _bookedStartDate; // or _bookedEndDate
                dtpReturnDate.MaxDate = DateTime.Today.AddYears(1);
                dtpReturnDate.Value = _bookedEndDate;

                // Set focus to mileage field
                txtCurrentMileage.Focus();

                tsslBookingStatus.Text = $"Booking #{_selectedBookingID} selected - Current mileage: {_initialVehicleMileage:N0} km";

                CalculateReturnSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading booking details: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearBookingDetails();
            }
        }


        private void CalculateConsumedKilometers()
        {
            if (_vehicleID == -1)
            {
                txtConsumedKilometers.Text = "0";
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCurrentMileage.Text))
            {
                txtConsumedKilometers.Text = "0";
                return;
            }

            if (int.TryParse(txtCurrentMileage.Text, out int currentMileage))
            {
                // Calculate consumed kilometers based on vehicle's initial mileage
                int consumed = currentMileage - _initialVehicleMileage;
                if (consumed < 0) consumed = 0;
                txtConsumedKilometers.Text = "";
                txtConsumedKilometers.Text = consumed.ToString();
                txtConsumedKilometers.Refresh();

                // Update status with mileage info
                tsslBookingStatus.Text = $"Booking #{_selectedBookingID} - Mileage: {currentMileage:N0} km (Consumed: {consumed:N0} km)";
            }
            else
            {
                txtConsumedKilometers.Text = "0";
                MessageBox.Show("Please enter a valid numeric value for mileage.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            CalculateReturnSummary();
        }

        private void CalculateReturnSummary()
        {
            if (_selectedBookingID == -1 || cboBooking.SelectedIndex == -1)
                return;

            DateTime returnDate = dtpReturnDate.Value.Date;

            // Calculate actual days
            int actualDays = (returnDate - _bookedStartDate.Date).Days;
            if (actualDays <= 0) actualDays = 1;

            lblActualDaysValue.Text = actualDays.ToString();

            // Get extra charges
            decimal extraCharges = 0;
            if (!string.IsNullOrWhiteSpace(txtExtraCharges.Text))
            {
                decimal.TryParse(txtExtraCharges.Text, out extraCharges);
            }

            // Calculate actual total
            decimal actualTotal = (actualDays * _pricePerDay) + extraCharges;
            lblTotalDueValue.Text = actualTotal.ToString("C2");

            // Show surplus/difference message
            decimal difference = actualTotal - _bookedTotal;

            if (difference > 0)
            {
                lblSurplusMessage.Text = $"⚠ Additional charges: +{difference:C2}";
                lblSurplusMessage.ForeColor = System.Drawing.Color.Red;
                lblSurplusMessage.Visible = true;
            }
            else if (difference < 0)
            {
                lblSurplusMessage.Text = $"✓ Customer savings: {difference:C2}";
                lblSurplusMessage.ForeColor = System.Drawing.Color.Green;
                lblSurplusMessage.Visible = true;
            }
            else
            {
                lblSurplusMessage.Text = "✓ Amount matches booking exactly";
                lblSurplusMessage.ForeColor = System.Drawing.Color.Green;
                lblSurplusMessage.Visible = true;
            }
        }

        private bool ValidateReturnForm()
        {
            // Validate booking selection
            if (cboBooking.SelectedValue == null || cboBooking.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a booking to process the return.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBooking.Focus();
                return false;
            }

            // Validate mileage
            if (string.IsNullOrWhiteSpace(txtCurrentMileage.Text))
            {
                MessageBox.Show("Please enter the current vehicle mileage.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentMileage.Focus();
                return false;
            }

            if (!int.TryParse(txtCurrentMileage.Text, out int mileage) || mileage < 0)
            {
                MessageBox.Show("Please enter a valid mileage (positive number).",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentMileage.Focus();
                txtCurrentMileage.SelectAll();
                return false;
            }

            // Validate that current mileage is not less than initial mileage
            if (mileage < _initialVehicleMileage)
            {
                MessageBox.Show($"Current mileage ({mileage:N0} km) cannot be less than the initial mileage ({_initialVehicleMileage:N0} km) when the vehicle was rented.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentMileage.Focus();
                txtCurrentMileage.SelectAll();
                return false;
            }

            // Validate consumed kilometers
            if (!int.TryParse(txtConsumedKilometers.Text, out int consumed) || consumed < 0)
            {
                MessageBox.Show("Unable to calculate consumed kilometers. Please check the mileage value.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentMileage.Focus();
                return false;
            }

            // Validate return date
            if (dtpReturnDate.Value.Date < _bookedStartDate.Date)
            {
                MessageBox.Show("Return date cannot be before the booking start date.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpReturnDate.Focus();
                return false;
            }

            // Validate extra charges
            if (!string.IsNullOrWhiteSpace(txtExtraCharges.Text))
            {
                if (!decimal.TryParse(txtExtraCharges.Text, out decimal extra) || extra < 0)
                {
                    MessageBox.Show("Please enter a valid extra charges amount (positive number).",
                        "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtExtraCharges.Focus();
                    txtExtraCharges.SelectAll();
                    return false;
                }
            }

            return true;
        }

        private void ProcessReturn()
        {
            if (!ValidateReturnForm())
                return;

            try
            {
                // Create return object
                clsReturn ret = new clsReturn();
                ret.BookingID = _selectedBookingID;
                ret.ReturnDate = dtpReturnDate.Value;
                ret.Days = Convert.ToInt32(lblActualDaysValue.Text);
                ret.Mileage = Convert.ToInt32(txtCurrentMileage.Text);
                ret.Consumed = Convert.ToInt32(txtConsumedKilometers.Text);
                ret.Notes = txtReturnNotes.Text.Trim();
                ret.ExtraCharges = string.IsNullOrWhiteSpace(txtExtraCharges.Text) ? 0 : Convert.ToDecimal(txtExtraCharges.Text);

                // Parse total from label (remove currency formatting)
                string totalText = lblTotalDueValue.Text.Replace("$", "").Replace(",", "").Trim();
                ret.Total = Convert.ToDecimal(totalText);

                // Step 1 — Save return, which gives us a ReturnID via SCOPE_IDENTITY
                if (!ret.Save())
                {
                    MessageBox.Show("An error occurred while saving the return record. Please try again.",
                        "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Guard: make sure we actually got a valid ReturnID back
                if (ret.ReturnID <= 0)
                {
                    MessageBox.Show("Return was saved but the Return ID could not be retrieved.\n\n" +
                                    "Please contact system administrator.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Step 2 — Open transaction form
                if (!clsTransaction.HasTransaction(ret.ReturnID))
                {
                    frmTransaction frm = new frmTransaction(ret.BookingID, ret.ReturnID, ret.Total);
                    DialogResult result = frm.ShowDialog();

                    // Step 3 — Transaction was NOT completed → roll back the return
                    if (result != DialogResult.OK)
                    {
                        bool deleted = clsReturn.Delete(ret.ReturnID);

                        if (!deleted)
                        {
                            // Fallback warning so the user knows there's a dirty record
                            MessageBox.Show(
                                $"Warning: Unable to remove return record #{ret.ReturnID}.\n\n" +
                                "Please delete it manually from the database or contact system administrator.",
                                "Rollback Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(
                                "Payment was cancelled. The return has not been recorded.\n\n" +
                                "You can try again or select a different booking.",
                                "Operation Cancelled",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }

                        return; // Stay on the form — user can try again
                    }
                }

                // Step 4 — Update vehicle availability
                clsVehicle.SetAvailability(_vehicleID, true);

                // Step 5 — Both saved successfully
                MessageBox.Show("Vehicle return and payment have been completed successfully!",
                    "Return Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while processing the return: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event Handlers
        private void btnCompleteReturn_Click(object sender, EventArgs e)
        {
            ProcessReturn();
        }

        private void btnCancelClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cboBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBookingDetails();
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateReturnSummary();
        }

        //private void txtCurrentMileage_TextChanged(object sender, EventArgs e)
        //{
        //    CalculateConsumedKilometers();
        //}

        private void txtExtraCharges_TextChanged(object sender, EventArgs e)
        {
            CalculateReturnSummary();
        }

        private void stsStatusBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void grpReturnInformation_Enter(object sender, EventArgs e)
        {

        }
    }
}