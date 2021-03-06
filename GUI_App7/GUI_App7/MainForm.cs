﻿using System;
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

            lbITitle.Text = "Today's Summary";
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

        private void button2_Click(object sender, EventArgs e)
        {
            panelNav.Height = btn_Weight.Height;
            panelNav.Top = btn_Weight.Top;
            btn_Weight.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "Weight";
            this.PnlFormLoader.Controls.Clear();
            WeightForm myProfileForm_Vrb = new WeightForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnSleep.Height;
            panelNav.Top = btnSleep.Top;
            btnSleep.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "Sleep Tracking";
            this.PnlFormLoader.Controls.Clear();
            SleepForm myProfileForm_Vrb = new SleepForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnWater.Height;
            panelNav.Top = btnWater.Top;
            btnWater.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "Daily Water Intake Tracking";
            this.PnlFormLoader.Controls.Clear();
            WaterForm myProfileForm_Vrb = new WaterForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnFood.Height;
            panelNav.Top = btnFood.Top;
            btnFood.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "Daily Food Intake Calorie Tracking";
            this.PnlFormLoader.Controls.Clear();
            FoodForm myProfileForm_Vrb = new FoodForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnAccountSettings.Height;
            panelNav.Top = btnAccountSettings.Top;
            btnAccountSettings.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "Account Settings";
            this.PnlFormLoader.Controls.Clear();
            AccountSettings myProfileForm_Vrb = new AccountSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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

        private void btnWeight_Leave(object sender, EventArgs e)
        {
            btn_Weight.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnSleep_Leave(object sender, EventArgs e)
        {
            btnSleep.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnWater_Leave(object sender, EventArgs e)
        {
            btnWater.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnFood_Leave(object sender, EventArgs e)
        {
            btnFood.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnAccSettings_Leave(object sender, EventArgs e)
        {
            btnAccountSettings.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(255, 255, 255);
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

        private void btnActiveTime_Leave(object sender, EventArgs e)
        {
            btnActiveTime.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnActiveTime_Click_1(object sender, EventArgs e)
        {
            panelNav.Height = btnActiveTime.Height;
            panelNav.Top = btnActiveTime.Top;
            btnActiveTime.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "Active Time";
            this.PnlFormLoader.Controls.Clear();
            ActiveTimeForm myProfileForm_Vrb = new ActiveTimeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void btnWorkoutPlans_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnWorkoutPlans.Height;
            panelNav.Top = btnWorkoutPlans.Top;
            btnWorkoutPlans.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "Workout Recommendations";
            this.PnlFormLoader.Controls.Clear();
            WorkoutPlansForm myProfileForm_Vrb = new WorkoutPlansForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void btnWorkoutPlans_Leave(object sender, EventArgs e)
        {
            btnWorkoutPlans.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnPrescripTrack_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnPrescripTrack.Height;
            panelNav.Top = btnPrescripTrack.Top;
            btnPrescripTrack.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "Pills tracking";
            this.PnlFormLoader.Controls.Clear();
            PrescriptionTrackerForm myProfileForm_Vrb = new PrescriptionTrackerForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void btnPrescripTrack_Leave(object sender, EventArgs e)
        {
            btnPrescripTrack.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnRecomFood_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnRecomFood.Height;
            panelNav.Top = btnRecomFood.Top;
            btnRecomFood.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "Food Recommendations";
            this.PnlFormLoader.Controls.Clear();
            RecommendFoodForm myProfileForm_Vrb = new RecommendFoodForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void btnRecomFood_Leave(object sender, EventArgs e)
        {
            btnRecomFood.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnWorkoutCalc_Click(object sender, EventArgs e)
        {
            panelNav.Height = btnWorkoutCalc.Height;
            panelNav.Top = btnWorkoutCalc.Top;
            btnWorkoutCalc.BackColor = Color.FromArgb(245, 245, 245);

            lbITitle.Text = "Workout Calculator";
            this.PnlFormLoader.Controls.Clear();
            WorkoutCalcForm myProfileForm_Vrb = new WorkoutCalcForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            myProfileForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(myProfileForm_Vrb);
            myProfileForm_Vrb.Show();
        }

        private void btnWorkoutCalc_Leave(object sender, EventArgs e)
        {
            btnWorkoutCalc.BackColor = Color.FromArgb(255, 255, 255);
        }
    }

}
