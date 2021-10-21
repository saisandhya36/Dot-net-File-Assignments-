using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinFormsAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {



        }
        private void btnsignun_click(object sender, EventArgs e)
        {
            //username - admin and password - 123
            //txtUserName.Text --- username
            //txtpwd.Text ---- password

            //lblMsg

            if (txtUserName.Text == "admin" && txtPassword.Text == "123")
            {
                lblMsg.Text = "Valid";
            }
            else if (txtUserName.Text != "admin")
            {
                lblMsg.Text = "User Name is Invalid";
            }
            else if (txtPassword.Text != "admin")
            {
                lblMsg.Text = "Password is Invalid";
            }





        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }
    }
}


