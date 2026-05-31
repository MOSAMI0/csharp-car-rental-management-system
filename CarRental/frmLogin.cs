using BusinessLayer;
using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmLogin : Form
    {
        public static clsUser CurrentUser;
        private int _failedAttempts = 0;
        private const int MAX_FAILED_ATTEMPTS = 3;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            lblErrorMessage.Visible = false;

            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            btnLogin.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                clsUser user = clsUser.Find(
                    txtUsername.Text.Trim(),
                    txtPassword.Text.Trim()
                );

                if (user != null)
                {
                    CurrentUser = user;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    _failedAttempts++;
                    HandleFailedLogin();
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"An error occurred: {ex.Message}");
            }
            finally
            {
                btnLogin.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CurrentUser = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = '●';
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (lblErrorMessage.Visible)
            {
                ClearErrorMessage();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (lblErrorMessage.Visible)
            {
                ClearErrorMessage();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ShowErrorMessage("Please enter your username.");
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowErrorMessage("Please enter your password.");
                txtPassword.Focus();
                return false;
            }

            if (_failedAttempts >= MAX_FAILED_ATTEMPTS)
            {
                ShowErrorMessage("Too many failed attempts. Please restart the application.");
                btnLogin.Enabled = false;
                return false;
            }

            return true;
        }

        private void HandleFailedLogin()
        {
            int remainingAttempts = MAX_FAILED_ATTEMPTS - _failedAttempts;

            string errorMessage = "Invalid username or password.";

            if (remainingAttempts > 0)
            {
                errorMessage = $"Invalid username or password.\n\n{remainingAttempts} attempt(s) remaining.";
            }
            else
            {
                errorMessage = "Too many failed attempts. Please restart the application.";
                btnLogin.Enabled = false;
            }

            ShowErrorMessage(errorMessage);

            txtPassword.Clear();
            txtPassword.Focus();
        }

        private void ShowErrorMessage(string message)
        {
            lblErrorMessage.Text = message;
            lblErrorMessage.Visible = true;
        }

        private void ClearErrorMessage()
        {
            lblErrorMessage.Visible = false;
            lblErrorMessage.Text = string.Empty;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtPassword.Clear();
        }

        private void pnlBranding_Paint(object sender, PaintEventArgs e)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                pnlBranding.ClientRectangle,
                System.Drawing.Color.FromArgb(17, 24, 39),
                System.Drawing.Color.FromArgb(30, 41, 59),
                45F))
            {
                e.Graphics.FillRectangle(brush, pnlBranding.ClientRectangle);
            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(8, 255, 255, 255), 2))
            {
                e.Graphics.DrawEllipse(pen, -100, -100, 320, 320);
                e.Graphics.DrawEllipse(pen, -60, -60, 240, 240);

                e.Graphics.DrawEllipse(pen, 150, 350, 300, 300);
            }
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}