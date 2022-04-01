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
            SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();

            int result = (int)returnParameter.Value;
            txt1Rank.Text = result.ToString();

            con.Close();
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Second_Rank", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();

            int result = (int)returnParameter.Value;
            txt2Rank.Text = result.ToString();

            con.Close();
        }

        private void btnThird_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Third_Rank", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();

            int result = (int)returnParameter.Value;
            txt3Rank.Text = result.ToString();

            con.Close();
        }
    }
}
