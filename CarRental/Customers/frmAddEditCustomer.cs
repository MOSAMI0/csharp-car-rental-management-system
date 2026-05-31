using BusinessLayer;
using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmAddEditCustomer : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private clsCustomer _Customer;
        private int _CustomerID;

        public frmAddEditCustomer(int customerID)
        {
            InitializeComponent();
            _CustomerID = customerID;

            if (_CustomerID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }

        private void LoadCustomerData()
        {
            if (_Mode == enMode.AddNew)
            {
                lblModeValue.Text = "Add New Customer";
                _Customer = new clsCustomer();
                return;
            }

            _Customer = clsCustomer.Find(_CustomerID);

            if (_Customer == null)
            {
                MessageBox.Show($"Customer with ID {_CustomerID} could not be found.",
                    "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblModeValue.Text = $"Edit Customer #{_Customer.CustomerID}";
            txtCustomerName.Text = _Customer.Name;
            txtContactInfo.Text = _Customer.ContactInformation;
            txtLicenseNumber.Text = _Customer.DriverLicenseNumber;

            if (!string.IsNullOrEmpty(_Customer.ImagePath))
            {
                try
                {
                    picCustomerImage.Load(_Customer.ImagePath);
                    lnkRemoveImage.Visible = true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error loading image: {ex.Message}");
                    lnkRemoveImage.Visible = false;
                }
            }
            else
            {
                lnkRemoveImage.Visible = false;
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter the customer's full name.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return false;
            }

            if (txtCustomerName.Text.Trim().Length < 2)
            {
                MessageBox.Show("Customer name must be at least 2 characters long.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                txtCustomerName.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContactInfo.Text))
            {
                MessageBox.Show("Please enter the customer's contact information.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactInfo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLicenseNumber.Text))
            {
                MessageBox.Show("Please enter the driver's license number.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLicenseNumber.Focus();
                return false;
            }

            if (txtLicenseNumber.Text.Trim().Length < 5)
            {
                MessageBox.Show("Driver's license number must be at least 5 characters long.",
                    "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLicenseNumber.Focus();
                txtLicenseNumber.SelectAll();
                return false;
            }

            return true;
        }

        private void SaveCustomer()
        {
            if (!ValidateForm())
                return;

            try
            {
      
                _Customer.Name = txtCustomerName.Text.Trim();
                _Customer.ContactInformation = txtContactInfo.Text.Trim();
                _Customer.DriverLicenseNumber = txtLicenseNumber.Text.Trim();

                
                if (picCustomerImage.ImageLocation != null && !string.IsNullOrEmpty(picCustomerImage.ImageLocation))
                    _Customer.ImagePath = picCustomerImage.ImageLocation;
                else
                    _Customer.ImagePath = "";

                if (_Customer.Save())
                {
                    MessageBox.Show("Customer information has been saved successfully.",
                        "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    _Mode = enMode.Update;
                    _CustomerID = _Customer.CustomerID;
                    lblModeValue.Text = $"Edit Customer #{_Customer.CustomerID}";

                    
                    lnkRemoveImage.Visible = !string.IsNullOrEmpty(_Customer.ImagePath);

                    
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("An error occurred while saving the customer information.",
                        "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddEditCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            SaveCustomer();
        }

        private void btnCancelClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lnkSetCustomerImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialogImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialogImage.FilterIndex = 1;
            openFileDialogImage.RestoreDirectory = true;
            openFileDialogImage.Title = "Select Customer Image";

            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedFilePath = openFileDialogImage.FileName;
                    picCustomerImage.Load(selectedFilePath);
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
            picCustomerImage.ImageLocation = null;
            picCustomerImage.Image = null;
            lnkRemoveImage.Visible = false;
        }

        
    }
}