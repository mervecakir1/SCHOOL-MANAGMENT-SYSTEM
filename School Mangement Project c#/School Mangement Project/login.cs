using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Mangement_Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void closepB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UnameTB.Text == "" || passwordTB.Text == "")
            {
                MessageBox.Show("Enter username and password plz");
            }
            else if(UnameTB.Text == "admin" && passwordTB.Text == "admin")
            {
                mainmenu obj = new mainmenu();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("wrong username or password");
                UnameTB.Text = "";
                passwordTB.Text = "";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            UnameTB.Text = "";
            passwordTB.Text = "";
        }

        private void closepB_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UnameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
