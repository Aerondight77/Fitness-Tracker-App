using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_App7
{
    public partial class WeightForm : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtLogin_Table = new DataTable();
        DataTable dtLogin_Table2 = new DataTable();

        public WeightForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCurrWeight.Text.Equals(""))
            {
                MessageBox.Show("Please input valid \"Current Weight.\"");
            }
            else if (txtWeightGoal.Text.Equals(""))
            {
                MessageBox.Show("Please input valid \"Weight goal.\"");
            }
            else
            {
                int currWeight = int.Parse(txtCurrWeight.Text);
                int weightGoal = int.Parse(txtWeightGoal.Text);
                string query = "Update Login_Table SET Weight = '" + @currWeight + "', WeightGoal = '" + @weightGoal + "' where ID = '" + LoginForm.id + "'";

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@currWeight", @currWeight);
                updateCommand.Parameters.AddWithValue("@weightGoal", @weightGoal);

                int row = objDBAccess.executeQuery(updateCommand);

                if (row == 1)
                {
                    txtLastWeight.Clear();
                    txtLastWeight.AppendText(currWeight.ToString());
                    txtCurrWeight.Clear();
                    txtWeightDiff.Clear();
                    int diff = Math.Abs(weightGoal - currWeight);
                    txtWeightDiff.AppendText(diff.ToString());
                }
                else
                {
                    MessageBox.Show("Error occurred. Please check your inputs.");
                }
            }
        }

        private void WeightForm_Load(object sender, EventArgs e)
        {
            int lastWeight, weightGoal;

            string query = "SELECT Weight,WeightGoal FROM Login_Table where ID = '" + LoginForm.id + "'";
            SqlCommand getCommand = new SqlCommand(query);

            objDBAccess.readDatathroughAdapter(query, dtLogin_Table);

            if (dtLogin_Table.Rows.Count == 1)
            {
                lastWeight = int.Parse(dtLogin_Table.Rows[0]["Weight"].ToString());
                weightGoal = int.Parse(dtLogin_Table.Rows[0]["WeightGoal"].ToString());
                objDBAccess.closeConn();
                txtLastWeight.AppendText(lastWeight.ToString());
                txtWeightGoal.AppendText(weightGoal.ToString());
                int diff = Math.Abs(lastWeight - weightGoal);
                txtWeightDiff.Clear();
                txtWeightDiff.AppendText(diff.ToString());
            }
        }

        public int getWeight()
        {
            string query = "SELECT Weight FROM Login_Table where ID = '" + LoginForm.id + "'";
            SqlCommand getCommand = new SqlCommand(query);
            objDBAccess.readDatathroughAdapter(query, dtLogin_Table2);
            int weightVal;
            if (dtLogin_Table2.Rows.Count == 1)
            {
                weightVal = int.Parse(dtLogin_Table2.Rows[0]["Weight"].ToString());
                objDBAccess.closeConn();
                return weightVal;
            }
            else
            {
                // Debug purposes.
                MessageBox.Show("Unable to get weight. (WeightForm)");
                return 0;
            }
        }
    }
}
