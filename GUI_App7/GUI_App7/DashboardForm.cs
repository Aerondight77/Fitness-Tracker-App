using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_App7
{
    public partial class DashboardForm : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtLogin_Table = new DataTable();

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

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Add more later on when others are implemented.
            int numCups, calBurned, weight, calIntake, activeTime;
            float bmi, sleep;

            // Add more later on when others are implemented.
            string query = "SELECT Weight,BMI,Sleep,NoOfCups,CalBurnedTotal,CalIntakeTotal,ActiveTime FROM Login_Table where ID = '" + LoginForm.id + "'";

            objDBAccess.readDatathroughAdapter(query, dtLogin_Table);

            if (dtLogin_Table.Rows.Count == 1)
            {
                numCups = int.Parse(dtLogin_Table.Rows[0]["NoOfCups"].ToString());
                calBurned = int.Parse(dtLogin_Table.Rows[0]["CalBurnedTotal"].ToString());
                weight = int.Parse(dtLogin_Table.Rows[0]["Weight"].ToString());
                bmi = int.Parse(dtLogin_Table.Rows[0]["BMI"].ToString());
                sleep = int.Parse(dtLogin_Table.Rows[0]["Sleep"].ToString());
                calIntake = int.Parse(dtLogin_Table.Rows[0]["CalIntakeTotal"].ToString());
                activeTime = int.Parse(dtLogin_Table.Rows[0]["ActiveTime"].ToString());

                objDBAccess.closeConn();

                txtCupsWater.AppendText(numCups.ToString());
                txtCalBurned.AppendText(calBurned.ToString());
                txtWeight.AppendText(weight.ToString());
                txtBMI.AppendText(bmi.ToString());
                txtHoursSlept.AppendText(sleep.ToString());
                txtCalIntake.AppendText(calIntake.ToString());
                txtActiveTime.AppendText(activeTime.ToString());
            }
            else
            {
                // Debug purposes.
                MessageBox.Show("Error retrieving and loading data from database.");
            }
        }
    }
}
