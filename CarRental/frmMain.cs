using BusinessLayer;
using CarRental.Booking;
using CarRental.Return;
using CarRental.Transaction;
using CarRental.Maintenance;
using System;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Drawing;

namespace CarRental
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (frmLogin.CurrentUser != null)
            {
                lblUserValue.Text = frmLogin.CurrentUser.Username;
                lblRoleValue.Text = frmLogin.CurrentUser.Role;
                tsslUserStatus.Text = $"Logged in as: {frmLogin.CurrentUser.Username}";
            }
            else
            {
                lblUserValue.Text = "Guest";
                lblRoleValue.Text = "Viewer";
                tsslUserStatus.Text = "Guest access";
            }

            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy  |  hh:mm:ss tt");
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            using (frmListCustomers frm = new frmListCustomers())
            {
                frm.ShowDialog();
            }
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            using (frmListVehicles frm = new frmListVehicles())
            {
                frm.ShowDialog();
            }
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            using (frmListBooking frm = new frmListBooking())
            {
                frm.ShowDialog();
            }
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            using (frmListReturns frm = new frmListReturns())
            {
                frm.ShowDialog();
            }
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            using (frmListTransactions frm = new frmListTransactions())
            {
                frm.ShowDialog();
            }
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            using (frmListMaintenance frm = new frmListMaintenance())
            {
                frm.ShowDialog();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                pnlHeader.ClientRectangle,
                System.Drawing.Color.FromArgb(17, 24, 39),
                System.Drawing.Color.FromArgb(30, 41, 59),
                0F))
            {
                e.Graphics.FillRectangle(brush, pnlHeader.ClientRectangle);
            }

            using (System.Drawing.SolidBrush lineBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(59, 130, 246)))
            {
                e.Graphics.FillRectangle(lineBrush, 0, pnlHeader.Height - 4, pnlHeader.Width, 4);
            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(6, 255, 255, 255), 1.5F))
            {
                e.Graphics.DrawEllipse(pen, pnlHeader.Width - 150, -80, 200, 200);
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.FromArgb(0, 102, 204);
            btn.ForeColor = Color.White;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.White;
            btn.ForeColor = Color.FromArgb(20, 33, 61);
        }


    }
}