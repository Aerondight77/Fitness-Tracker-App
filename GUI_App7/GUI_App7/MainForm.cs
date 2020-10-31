using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
 
namespace GUI_App7
{
    public partial class MainForm : Form
    {
        [DllImport ("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );

        public MainForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,Width,Height,25,25));
            panelNav.Height = BtnDashboard.Height;
            panelNav.Top = BtnDashboard.Top;
            panelNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "Today's Summary";
            this.PnlFormLoader.Controls.Clear();
            DashboardForm dashboardForm_Vrb = new DashboardForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboardForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(dashboardForm_Vrb);
            dashboardForm_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFirstName.Text = LoginForm.firstName;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            panelNav.Height = BtnDashboard.Height;
            panelNav.Top = BtnDashboard.Top;
            panelNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            DashboardForm dashboardForm_Vrb = new DashboardForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboardForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(dashboardForm_Vrb);
            dashboardForm_Vrb.Show();

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnProfile.Height;
            panelNav.Top = btnProfile.Top;
            btnProfile.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "My Profile";
            this.PnlFormLoader.Controls.Clear();
            MyProfileForm myProfileForm_Vrb = new MyProfileForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnSummary.Height;
            panelNav.Top = btnSummary.Top;
            btnSummary.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "To-Do List";
            this.PnlFormLoader.Controls.Clear();
            SummaryForm myProfileForm_Vrb = new SummaryForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void btnProg_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnProg.Height;
            panelNav.Top = btnProg.Top;
            btnProg.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "Progress";
            this.PnlFormLoader.Controls.Clear();
            ProgressForm myProfileForm_Vrb = new ProgressForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
           // BtnDashboard.BackColor = Color.FromArgb(238, 238, 238);
            BtnDashboard.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnProfile_Leave(object sender, EventArgs e)
        {
            //btnProfile.BackColor = Color.FromArgb(238, 238, 238);
            btnProfile.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnSummary_Leave(object sender, EventArgs e)
        {
            //btnSummary.BackColor = Color.FromArgb(238, 238, 238);
            btnSummary.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnProg_Leave(object sender, EventArgs e)
        {
            //btnProg.BackColor = Color.FromArgb(238, 238, 238);
            btnProg.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Fix later on.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnProg.Height;
            panelNav.Top = btnProg.Top;
            btnProg.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "Weight";
            this.PnlFormLoader.Controls.Clear();
            WeightForm myProfileForm_Vrb = new WeightForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void btnWeight_Leave(object sender, EventArgs e)
        {
            btnProg.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}
