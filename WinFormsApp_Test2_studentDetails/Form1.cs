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

namespace WinFormsApp_Test2_studentDetails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Sql_Test_2;Integrated Security=True");

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string stuName = txtName.Text;
            int english = int.Parse(txtEnglish.Text);
            int maths = int.Parse(txtMaths.Text);
            int science = int.Parse(txtScience.Text);
            int total = english+maths+science;
            int average = total/3;
            con.Open();
            SqlCommand cmd = new SqlCommand("exec Insert_Details '" + stuName + "','" + english + "','" +maths + "','" +science+ "','" + total + "','" + average + "'", con);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully inserted.....!");

            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("First_Rank", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            cmd.Parameters.Add(new SqlParameter("@empname", SqlDbType.VarChar, 20, ParameterDirection.Output, false, 0, 20, "ename", DataRowVersion.Default, null));
            cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Int, 20, ParameterDirection.Output, false, 0, 10, "total", DataRowVersion.Default, null));  
            cmd.UpdatedRowSource = UpdateRowSource.OutputParameters;
            cmd.ExecuteNonQuery();
            string name = (string)cmd.Parameters["@empname"].Value;
            int total = Convert.ToInt32(cmd.Parameters["@total"].Value);
            txtName1Rank.Text = name.ToString();
            txtTotal1Rank.Text = total.ToString();

            con.Close();

        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
          
            SqlCommand cmd = new SqlCommand("Second_Rank", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@empname", SqlDbType.VarChar, 20, ParameterDirection.Output, false, 0, 20, "ename", DataRowVersion.Default, null));
            cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Int, 20, ParameterDirection.Output, false, 0, 10, "total", DataRowVersion.Default, null));

            cmd.UpdatedRowSource = UpdateRowSource.OutputParameters;
            cmd.ExecuteNonQuery();
            string name = (string)cmd.Parameters["@empname"].Value;
            int total = Convert.ToInt32(cmd.Parameters["@total"].Value);
            txtName2Rank.Text = name.ToString();
            txtTotal2Rank.Text = total.ToString();

            con.Close();

           
        }

        private void btnThird_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Third_Rank", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();


            cmd.Parameters.Add(new SqlParameter("@empname", SqlDbType.VarChar, 20, ParameterDirection.Output, false, 0, 20, "ename", DataRowVersion.Default, null));
            cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Int, 20, ParameterDirection.Output, false, 0, 10, "total", DataRowVersion.Default, null));

            cmd.UpdatedRowSource = UpdateRowSource.OutputParameters;
            cmd.ExecuteNonQuery();
            string name = (string)cmd.Parameters["@empname"].Value;
            int total = Convert.ToInt32(cmd.Parameters["@total"].Value);
            txtName3Rank.Text = name.ToString();
            txtTotal3Rank.Text = total.ToString();

            con.Close();
        }
    }
}
