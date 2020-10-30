﻿using System;
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
    public partial class MyProfileForm : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtLogin_Table = new DataTable();

        public MyProfileForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int formAge = int.Parse(txtAge.Text);
            int heightFT = int.Parse(txtHeightFT.Text);
            int heightIN = int.Parse(txtHeightIN.Text);
            string dob = txtDOB.Text;
            string gender = txtGender.Text;

            if (heightFT.Equals(0))
            {
                MessageBox.Show("Please type your height in \"ft.\"");
            }
            else if (heightIN.Equals(0))
            {
                MessageBox.Show("Please type your height in \"in.\"");
            }
            else if (dob.Equals(""))
            {
                MessageBox.Show("Please type your date of birth in \"Date of Birth\"");
            }
            else if (gender.Equals(""))
            {
                MessageBox.Show("Please type your gender in \"Gender\"");
            }
            else if (formAge.Equals(0))
            {
                MessageBox.Show("Please type your age in \"Age\"");
            }
            else
            {
                string query = "Update Login_Table SET Gender = '" + @gender + "', Age = '" + @formAge + "', DOB = '" + @dob + "', HeightFT = '" + @heightFT +
                    "', HeightIN = '" + @heightIN + "' where Username = '" + LoginForm.username + "'";

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@gender", @gender);
                updateCommand.Parameters.AddWithValue("@formAge", @formAge);
                updateCommand.Parameters.AddWithValue("@dob", @dob);
                updateCommand.Parameters.AddWithValue("@heightFT", @heightFT);
                updateCommand.Parameters.AddWithValue("@heightIN", @heightIN);

                int row = objDBAccess.executeQuery(updateCommand);

                if (row == 1)
                {
                    // Message for debug purposes. [MIGHT NEED TO REMOVE LATER ON]
                    MessageBox.Show("Personal info updated in DB.");
                }
            }
        }

        private void MyProfileForm_Load(object sender, EventArgs e)
        {
            int formAge, heightFT, heightIN;
            string dob, gender;

            string query = "SELECT Gender,Age,DOB,HeightFT,HeightIN FROM Login_Table where Username = '" + LoginForm.username + "'";

            SqlCommand getCommand = new SqlCommand(query);

            objDBAccess.readDatathroughAdapter(query, dtLogin_Table);

            if (dtLogin_Table.Rows.Count == 1)
            {
                heightFT = int.Parse(dtLogin_Table.Rows[0]["HeightFT"].ToString());
                heightIN = int.Parse(dtLogin_Table.Rows[0]["HeightIN"].ToString());
                formAge = int.Parse(dtLogin_Table.Rows[0]["Age"].ToString());
                dob = dtLogin_Table.Rows[0]["DOB"].ToString();
                gender = dtLogin_Table.Rows[0]["Gender"].ToString();

                objDBAccess.closeConn();

                txtHeightFT.AppendText(heightFT.ToString());
                txtHeightIN.AppendText(heightIN.ToString());
                txtDOB.AppendText(dob);
                txtGender.AppendText(gender);
                txtAge.AppendText(formAge.ToString());
            }
        }
    }
}
