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
using System.ComponentModel.Design;

namespace GUI_App7
{
    public partial class FoodForm : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtLogin_Table = new DataTable();

        public FoodForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int mon = int.Parse(txtIntakeMon.Text);
            int tues = int.Parse(txtIntakeTues.Text);
            int wed = int.Parse(txtIntakeWed.Text);
            int thu = int.Parse(txtIntakeThu.Text);
            int fri = int.Parse(txtIntakeFri.Text);
            int sat = int.Parse(txtIntakeSat.Text);
            int sun = int.Parse(txtIntakeSun.Text);
            int total = mon + tues + wed + thu + fri + sat + sun;

            string query =
                    "Update Login_Table SET CalIntakeMon = '" + @mon + "', CalIntakeTues = '" + @tues + "', CalIntakeWed = '" + @wed + "', CalIntakeThur = '" + @thu +
                    "', CalIntakeFri = '" + @fri + "', CalIntakeSat = '" + @sat + "', CalIntakeSun = '" + @sun + "', CalIntakeTotal = '"
                    + @total + "' where ID = '" + LoginForm.id + "'";

            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@mon", @mon);
            updateCommand.Parameters.AddWithValue("@tues", @tues);
            updateCommand.Parameters.AddWithValue("@wed", @wed);
            updateCommand.Parameters.AddWithValue("@thu", @thu);
            updateCommand.Parameters.AddWithValue("@fri", @fri);
            updateCommand.Parameters.AddWithValue("@sat", @sat);
            updateCommand.Parameters.AddWithValue("@sun", @sun);
            updateCommand.Parameters.AddWithValue("@total", @total);

            int row = objDBAccess.executeQuery(updateCommand);
            if (row == 1)
            {
                txtTotalCalIntake.Clear();
                txtTotalCalIntake.AppendText(total.ToString());
            }
            else
            {
                MessageBox.Show("Failed to save/update information.");
            }
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            int mon, tues, wed, thur, fri, sat, sun, total;

            string query =
                    "SELECT CalIntakeMon,CalIntakeTues,CalIntakeWed,CalIntakeThur,CalIntakeFri,CalIntakeSat,CalIntakeSun,CalIntakeTotal FROM Login_Table where ID = '" +
                    LoginForm.id + "'";

            objDBAccess.readDatathroughAdapter(query, dtLogin_Table);

            if (dtLogin_Table.Rows.Count == 1)
            {
                mon = int.Parse(dtLogin_Table.Rows[0]["CalIntakeMon"].ToString());
                tues = int.Parse(dtLogin_Table.Rows[0]["CalIntakeTues"].ToString());
                wed = int.Parse(dtLogin_Table.Rows[0]["CalIntakeWed"].ToString());
                thur = int.Parse(dtLogin_Table.Rows[0]["CalIntakeThur"].ToString());
                fri = int.Parse(dtLogin_Table.Rows[0]["CalIntakeFri"].ToString());
                sat = int.Parse(dtLogin_Table.Rows[0]["CalIntakeSat"].ToString());
                sun = int.Parse(dtLogin_Table.Rows[0]["CalIntakeSun"].ToString());
                total = int.Parse(dtLogin_Table.Rows[0]["CalIntakeTotal"].ToString());

                objDBAccess.closeConn();

                txtIntakeMon.AppendText(mon.ToString());
                txtIntakeTues.AppendText(tues.ToString());
                txtIntakeWed.AppendText(wed.ToString());
                txtIntakeThu.AppendText(thur.ToString());
                txtIntakeFri.AppendText(fri.ToString());
                txtIntakeSat.AppendText(sat.ToString());
                txtIntakeSun.AppendText(sun.ToString());
                txtTotalCalIntake.AppendText(total.ToString());
            }
            else
            {
                MessageBox.Show("Error loading food intake data.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            int empty = 0;
            string query = "Update Login_Table SET CalIntakeMon = '" + @empty + "', CalIntakeTues = '" + @empty + "', CalIntakeWed = '" + @empty + "', CalIntakeThur = '"
                + @empty + "', CalIntakeFri = '" + @empty + "', CalIntakeSat = '" + @empty + "', CalIntakeSun = '" + @empty + "', CalIntakeTotal = '" + @empty + 
                "' where ID = '" + LoginForm.id + "'";

            SqlCommand updateCommand = new SqlCommand(query);

            updateCommand.Parameters.AddWithValue("@empty", @empty);

            int row = objDBAccess.executeQuery(updateCommand);

            if (row == 1)
            {
                txtIntakeMon.Clear();
                txtIntakeMon.AppendText(empty.ToString());
                txtIntakeTues.Clear();
                txtIntakeTues.AppendText(empty.ToString());
                txtIntakeWed.Clear();
                txtIntakeWed.AppendText(empty.ToString());
                txtIntakeThu.Clear();
                txtIntakeThu.AppendText(empty.ToString());
                txtIntakeFri.Clear();
                txtIntakeFri.AppendText(empty.ToString());
                txtIntakeSat.Clear();
                txtIntakeSat.AppendText(empty.ToString());
                txtIntakeSun.Clear();
                txtIntakeSun.AppendText(empty.ToString());
                txtTotalCalIntake.Clear();
            }
            else
            {
                MessageBox.Show("Error in resetting food intake data.");
            }
        }
    }
}
