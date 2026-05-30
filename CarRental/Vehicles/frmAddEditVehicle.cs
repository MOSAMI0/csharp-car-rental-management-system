using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Vehicles
{
    public partial class frmAddEditVehicle : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private clsVehicle _Vehicle;
        private int _VehicleID;
        private bool _isLoading = false;

        public frmAddEditVehicle(int vehicleID)
        {
            InitializeComponent();
            _VehicleID = vehicleID;

            _Mode = (_VehicleID == -1) ? enMode.AddNew : enMode.Update;

            SetupComboBoxAutoComplete();
        }

        private void SetupComboBoxAutoComplete()
        {
            cboMake.DropDownStyle = ComboBoxStyle.DropDown;
            cboMake.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMake.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboModel.DropDownStyle = ComboBoxStyle.DropDown;
            cboModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboModel.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboYear.DropDownStyle = ComboBoxStyle.DropDown;
            cboYear.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboYear.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboFuelType.DropDownStyle = ComboBoxStyle.DropDown;
            cboFuelType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboFuelType.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboCategory.DropDownStyle = ComboBoxStyle.DropDown;
            cboCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void frmAddEditVehicle_Load(object sender, EventArgs e)
        {
            _isLoading = true;
            LoadVehicleData();
            _isLoading = false;
        }

        private void LoadVehicleData()
        {
            // Load Makes
            DataTable dtMakes = clsVehicle.ListMakes();
            cboMake.DataSource = dtMakes;
            cboMake.DisplayMember = "MakeName";
            cboMake.ValueMember = "MakeID";
            cboMake.SelectedIndex = -1;

            if (_Mode == enMode.AddNew)
            {
                lblModeValue.Text = "Add New Vehicle";
                _Vehicle = new clsVehicle();
                return;
            }

            // Edit mode
            _Vehicle = clsVehicle.Find(_VehicleID);

            if (_Vehicle == null)
            {
                MessageBox.Show("Vehicle not found.");
                this.Close();
                return;
            }

            lblModeValue.Text = $"Edit Vehicle #{_Vehicle.VehicleID}";
            txtLicensePlate.Text = _Vehicle.Plate;
            txtMileage.Text = _Vehicle.Mileage.ToString();
            txtDailyPrice.Text = _Vehicle.Price.ToString("F2");

            // Load image
            if (!string.IsNullOrEmpty(_Vehicle.ImagePath))
            {
                try
                {
                    picVehicleImage.Load(_Vehicle.ImagePath);
                    lnkRemoveImage.Visible = true;
                }
                catch { }
            }

            // Load Make
            cboMake.SelectedValue = _Vehicle.MakeID;

            // Load Models
            DataTable dtModels = clsVehicle.GetModelsByMake(_Vehicle.MakeID);
            cboModel.DataSource = dtModels;
            cboModel.DisplayMember = "ModelName";
            cboModel.ValueMember = "ModelID";
            cboModel.SelectedValue = _Vehicle.ModelID;

            int modelID = _Vehicle.ModelID;
            int categoryID = _Vehicle.CategoryID;
            int fuelID = _Vehicle.FuelID;

            // Category
            cboCategory.DataSource = clsVehicle.GetCategoriesByModel(modelID);
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";
            cboCategory.SelectedValue = categoryID;

            // Fuel
            cboFuelType.DataSource = clsVehicle.GetFuelTypesByModelAndCategory(modelID, categoryID);
            cboFuelType.DisplayMember = "FuelTypeName";
            cboFuelType.ValueMember = "FuelTypeID";
            cboFuelType.SelectedValue = fuelID;

            // Year
            cboYear.DataSource = clsVehicle.GetYearsByModelCategoryAndFuel(modelID, categoryID, fuelID);
            cboYear.DisplayMember = "Year";
            cboYear.ValueMember = "Year";
            cboYear.SelectedValue = _Vehicle.Year;
        }

        private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            cboModel.DataSource = null;
            cboCategory.DataSource = null;
            cboYear.DataSource = null;
            cboFuelType.DataSource = null;

            if (cboMake.SelectedValue == null) return;

            int makeID;
            if (!int.TryParse(cboMake.SelectedValue.ToString(), out makeID)) return;

            DataTable dtModels = clsVehicle.GetModelsByMake(makeID);
            cboModel.DataSource = dtModels;
            cboModel.DisplayMember = "ModelName";
            cboModel.ValueMember = "ModelID";
            cboModel.SelectedIndex = -1;
        }

        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            cboCategory.DataSource = null;
            cboYear.DataSource = null;
            cboFuelType.DataSource = null;

            if (cboModel.SelectedValue == null) return;

            int modelID;
            if (!int.TryParse(cboModel.SelectedValue.ToString(), out modelID)) return;

            DataTable dtCategories = clsVehicle.GetCategoriesByModel(modelID);
            cboCategory.DataSource = dtCategories;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";
            cboCategory.SelectedIndex = -1;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            cboFuelType.DataSource = null;
            cboYear.DataSource = null;

            if (cboCategory.SelectedValue == null || cboModel.SelectedValue == null)
                return;

            int modelID, categoryID;

            if (!int.TryParse(cboModel.SelectedValue.ToString(), out modelID)) return;
            if (!int.TryParse(cboCategory.SelectedValue.ToString(), out categoryID)) return;

            DataTable dtFuel = clsVehicle.GetFuelTypesByModelAndCategory(modelID, categoryID);

            cboFuelType.DataSource = dtFuel;
            cboFuelType.DisplayMember = "FuelTypeName";
            cboFuelType.ValueMember = "FuelTypeID";
            cboFuelType.SelectedIndex = -1;
        }

        //private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (_isLoading) return;

        //    cboFuelType.DataSource = null;

        //    if (cboYear.SelectedValue == null || cboModel.SelectedValue == null)
        //        return;

        //    int modelID, year;

        //    if (!int.TryParse(cboModel.SelectedValue.ToString(), out modelID)) return;
        //    if (!int.TryParse(cboYear.SelectedValue.ToString(), out year)) return;

        //    DataTable dtFuels = clsVehicle.GetFuelTypes(modelID, year);
        //    cboFuelType.DataSource = dtFuels;
        //    cboFuelType.DisplayMember = "FuelTypeName";
        //    cboFuelType.ValueMember = "FuelTypeID";
        //    cboFuelType.SelectedIndex = -1;
        //}

        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (_Mode == enMode.AddNew)
            {
                _Vehicle = new clsVehicle();
                _Vehicle.Mode = clsVehicle.enMode.AddNew;
            }
            else
            {
                _Vehicle.Mode = clsVehicle.enMode.Update;
            }

            _Vehicle.MakeID = Convert.ToInt32(cboMake.SelectedValue);
            _Vehicle.ModelID = Convert.ToInt32(cboModel.SelectedValue);
            _Vehicle.CategoryID = Convert.ToInt32(cboCategory.SelectedValue);
            _Vehicle.Year = Convert.ToInt32(cboYear.SelectedValue);
            _Vehicle.FuelID = Convert.ToInt32(cboFuelType.SelectedValue);
            _Vehicle.Plate = txtLicensePlate.Text.Trim();
            _Vehicle.Mileage = Convert.ToInt32(txtMileage.Text);
            _Vehicle.Price = Convert.ToDecimal(txtDailyPrice.Text);
            _Vehicle.ImagePath = picVehicleImage.ImageLocation ?? "";

            if (_Vehicle.Save())
            {
                MessageBox.Show("Saved successfully.");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Save failed.");
            }
        }

        private bool ValidateForm()
        {
            if (cboMake.SelectedIndex == -1 ||
                cboModel.SelectedIndex == -1 ||
                cboCategory.SelectedIndex == -1 ||
                cboYear.SelectedIndex == -1 ||
                cboFuelType.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return false;
            }

            return true;
        }

        private void btnCancelClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void lnkSetVehicleImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialogImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialogImage.FilterIndex = 1;
            openFileDialogImage.RestoreDirectory = true;
            openFileDialogImage.Title = "Select Vehicle Image";

            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedFilePath = openFileDialogImage.FileName;
                    picVehicleImage.Load(selectedFilePath);
                    lnkRemoveImage.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to load the selected image: {ex.Message}",
                        "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void lnkRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picVehicleImage.ImageLocation = null;
            picVehicleImage.Image = null;
            lnkRemoveImage.Visible = false;
        }

        private void cboFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            cboYear.DataSource = null;

            if (cboFuelType.SelectedValue == null ||
                cboModel.SelectedValue == null ||
                cboCategory.SelectedValue == null)
                return;

            int modelID, categoryID, fuelID;

            if (!int.TryParse(cboModel.SelectedValue.ToString(), out modelID)) return;
            if (!int.TryParse(cboCategory.SelectedValue.ToString(), out categoryID)) return;
            if (!int.TryParse(cboFuelType.SelectedValue.ToString(), out fuelID)) return;

            DataTable dtYears = clsVehicle.GetYearsByModelCategoryAndFuel(modelID, categoryID, fuelID);

            cboYear.DataSource = dtYears;
            cboYear.DisplayMember = "Year";
            cboYear.ValueMember = "Year";
            cboYear.SelectedIndex = -1;
        }

       
    }
}