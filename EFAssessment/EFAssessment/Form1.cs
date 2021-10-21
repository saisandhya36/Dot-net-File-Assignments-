using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace EFAssessment
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=Training;Integrated Security=True");
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            //parameterized query
            string sql = "select count(*) from userdata where username=@name and password=@pwd";
            SqlCommand command = new SqlCommand(sql, connection);
            //pass value for the parameter
            command.Parameters.AddWithValue("name", txtUserName.Text);
            command.Parameters.AddWithValue("pwd", txtPassword.Text);
            //open connection
            connection.Open();
            int count = (int)command.ExecuteScalar();
            connection.Close();
            if (count == 1)
            {
                lblMsg.Text = "valid User";
                lblMsg.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblMsg.Text = "Invalid Username or password";
                lblMsg.ForeColor = Color.Red;
            }
        }
    }
}
