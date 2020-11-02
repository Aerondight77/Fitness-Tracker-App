using System;
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
    public partial class SleepForm : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtLogin_Table = new DataTable();

        public SleepForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtWentSleep.Text.Equals(""))
            {
                MessageBox.Show("Please enter the time that you went to sleep.");
            }
            else if (txtWokeUp.Text.Equals(""))
            {
                MessageBox.Show("Please enter the time that you woke up.");
            }
            else
            {
                int sleepStart = int.Parse(txtWentSleep.Text);
                int sleepEnd = int.Parse(txtWokeUp.Text);
            }

        }
    }
}
