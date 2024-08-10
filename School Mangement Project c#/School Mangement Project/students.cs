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
    public partial class students : Form
    {
        public students()
        {
            InitializeComponent();
            DisplayStudent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abadr\Documents\ITschool.mdf;Integrated Security=True;Connect Timeout=30");   //يتم اضافة الاتصال الخاص بقاعدة البيانات
        private void DisplayStudent()
        {
            Con.Open();
            string Query = "select * from studentTB";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SData.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void closepB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            mainmenu obj = new mainmenu();
            obj.Show();
            this.Hide();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (SName.Text == "" || SFees.Text == "" || SAddress.SelectedIndex == -1 || SGender.SelectedIndex == -1 || SClass.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into studentTB(S_name,S_gender,S_DOB,S_class,S_fees,S_address)values(@stname,@stgender,@stDOB,@stclass,@stfees,@staddress)", Con);
                    cmd.Parameters.AddWithValue("@stname", SName.Text);
                    cmd.Parameters.AddWithValue("@stgender", SGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@stDOB", SDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@stclass", SClass.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@stfees", SFees.Text);
                    cmd.Parameters.AddWithValue("@staddress", SAddress.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();             
                    Con.Close();
                    DisplayStudent();
                    MessageBox.Show("Student Added");
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        private void Reset()
        {
            key = 0;
            SName.Text = "";
            SFees.Text = "";
            SAddress.SelectedIndex = -1;
            SGender.SelectedIndex = -1;
            SClass.SelectedIndex = -1;
        }
        int key = 0;

        private void dele_button_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Student");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from studentTB where S_id=@stkey", Con);
                    cmd.Parameters.AddWithValue("@stkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted");
                    Con.Close();
                    DisplayStudent();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (SName.Text == "" || SFees.Text == "" || SAddress.SelectedIndex == -1 || SGender.SelectedIndex == -1 || SClass.SelectedIndex == -1)
            {
                MessageBox.Show("Select Student");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update studentTB set S_name=@stname,S_gender=@stgender,S_DOB=@stDOB,S_class=@stclass,S_fees=@stfees,S_address=@staddress where S_id=@sid", Con);
                    cmd.Parameters.AddWithValue("@stname", SName.Text);
                    cmd.Parameters.AddWithValue("@stgender", SGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@stDOB", SDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@stclass", SClass.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@stfees", SFees.Text);
                    cmd.Parameters.AddWithValue("@staddress", SAddress.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@sid", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

        }

        private void SName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void SData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                SName.Text = SData.SelectedRows[0].Cells[1].Value.ToString();
                SGender.SelectedItem = SData.SelectedRows[0].Cells[2].Value.ToString();
                SDOB.Text = SData.SelectedRows[0].Cells[3].Value.ToString();
                SClass.SelectedItem = SData.SelectedRows[0].Cells[4].Value.ToString();
                SFees.Text = SData.SelectedRows[0].Cells[5].Value.ToString();
                SAddress.SelectedItem = SData.SelectedRows[0].Cells[6].Value.ToString();

                if (SName.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(SData.SelectedRows[0].Cells[0].Value.ToString());
                }
            
        }

        private void SDOB_ValueChanged(object sender, EventArgs e)
        {
            SDOB.MaxDate = DateTime.Now;
        }


        private void SFees_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SFees_TextChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}
