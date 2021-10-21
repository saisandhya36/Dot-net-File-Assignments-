using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDem
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
        private void btnsignin_Click(object sender, EventArgs e)
        {
               // username - admin and password - 123

                //txtUserName.Text --- username
                //txtpwd.Text  ------password

                //lblMsg.Text = "valid user";
                //lblMsg.Text = "Invalid username or password";

            if (txtUserName.Text =="admin" && txtpwd.Text=="123")
            {
                lblMsg.Text = "Invalid username or password";
            }
            else
            {
                lblMsg.Text = "Invalid username or password";
            }
        }
    }
}
