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
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void closepB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TeacherpicB_Click(object sender, EventArgs e)
        {
            teacher obj = new teacher();
            obj.Show();
            this.Hide();
        }

        private void StudentpicB_Click(object sender, EventArgs e)
        {
            students obj = new students();
            obj.Show();
            this.Hide();
        }

        private void back_ToLogin_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void event_pictureBox4_Click(object sender, EventArgs e)
        {
            @event obj = new @event();
            obj.Show();
            this.Hide();
        }

        private void dash_pictureBox5_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void Fee_pictureBox_Click(object sender, EventArgs e)
        {
            fee obj = new fee();
            obj.Show();
            this.Hide();
        }

        private void attendance_pictureBox1_Click(object sender, EventArgs e)
        {
            attendance obj = new attendance();
            obj.Show();
            this.Hide();
        }
    }
}
