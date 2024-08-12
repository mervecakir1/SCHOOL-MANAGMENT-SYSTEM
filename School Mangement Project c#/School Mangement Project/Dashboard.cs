using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Mangement_Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abadr\Documents\ITschool.mdf;Integrated Security=True;Connect Timeout=30");   //The connection to the database is added
        {
            Application.Exit();
        }

        private void CountStudent()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from studentTB", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            stdLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountTeacher()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from teacherTB", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            tchLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountEvent()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from eventTB", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            evLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void SumFee()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(Amt) from feeTB", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            label7.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountStudent();
            CountTeacher();
            CountEvent();
            SumFee();
        }

        private void back_ToLogin_Click(object sender, EventArgs e)
        {
            mainmenu obj = new mainmenu();
            obj.Show();
            this.Hide();
        }

        private void tchLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
