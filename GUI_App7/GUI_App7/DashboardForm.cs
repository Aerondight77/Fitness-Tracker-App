﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_App7
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void SummaryPage_Click(object sender, EventArgs e)
        {
            //this opens a new window. NEED it to go to the summary tab, not a new window. FIX!

            // The summary part is supposed to be static, the information here is supposed to be a quick view of what's in the other tabs. -Bailey
            // SummaryForm myProfileForm_Vrb = new SummaryForm();
            // myProfileForm_Vrb.Show();

        }
    }
}