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
    public partial class fee : Form
    {
        public fee()
        {
            InitializeComponent();
            DisplayFees();
            FillStudID();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abadr\Documents\ITschool.mdf;Integrated Security=True;Connect Timeout=30");   //يتم اضافة الاتصال الخاص بقاعدة البيانات
        private void DisplayFees()
        {
            Con.Open();
            string Query = "select * from feeTB";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FData.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FillStudID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select S_id from studentTB", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("S_id", typeof(int));
            dt.Load(rdr);
            FId.ValueMember = "S_id";
            FId.DataSource = dt;
            Con.Close();

        }
        private void GetStudName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from studentTB where S_id = @SID", Con);
            cmd.Parameters.AddWithValue("@SID", FId.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FName.Text = dr["S_name"].ToString();
            }
            Con.Close();
        }
        private void Resest()
        {
            FAmount.Text = "";
            FName.Text = "";
            FId.SelectedIndex = -1;

        }


        private void closepB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FPeriod_ValueChanged(object sender, EventArgs e)
        {
            FPeriod.MaxDate = DateTime.Now;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mainmenu obj = new mainmenu();
            obj.Show();
            this.Hide();
        }

        private void FAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        
        private void FId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }

        private void FAmount_TextChanged(object sender, EventArgs e)
        {
            if (FAmount.Text == "0")
            {
                try
                {
                    MessageBox.Show("Amount cannot be 0 plz try again");
                }
                catch
                { }
            }
        }

        private void FData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (FName.Text == "" || FAmount.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string paymentperiode;
                paymentperiode = FPeriod.Value.Month.ToString() + "/" + FPeriod.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from feeTB where Stid= '" + FId.SelectedValue.ToString() + "' and Month = '" + paymentperiode.ToString() + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("There is No Due for This Month");
                }
                else
                {
                    SqlCommand Cmd = new SqlCommand("insert into feeTB(Stid,StName,Month,Amt)values(@sid,@sname,@mon,@amt)", Con);
                    Cmd.Parameters.AddWithValue("@sid", FId.SelectedValue.ToString());
                    Cmd.Parameters.AddWithValue("@sname", FName.Text);
                    Cmd.Parameters.AddWithValue("@mon", paymentperiode);
                    Cmd.Parameters.AddWithValue("@amt", FAmount.Text);
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Fees Successfuly Paid");

                }
                Con.Close();
                DisplayFees();
                Resest();
            }
        }

    }
}
