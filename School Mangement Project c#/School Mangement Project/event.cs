using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Mangement_Project
{
    public partial class @event : Form
    {
        public @event()
        {
            InitializeComponent();
            DisplayEvents();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abadr\Documents\ITschool.mdf;Integrated Security=True;Connect Timeout=30");    
        {
            Con.Open();
            string Query = "select * from eventTB";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EData.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            EDesc.Text = "";
            EHours.Text = "";
        }

        int key = 0;
        private void edit_button_Click(object sender, EventArgs e)
        {
            if (EDesc.Text == "" || EHours.Text == "")
            {
                MessageBox.Show("Select Event");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update eventTB set E_desc=@evdesc,E_date=@evdate,E_hour=@evhour where EId=@evid", Con);
                    cmd.Parameters.AddWithValue("@evdesc", EDesc.Text);
                    cmd.Parameters.AddWithValue("@evdate", EDate.Value.Date);
                    cmd.Parameters.AddWithValue("@evhour", EHours.Text);
                    cmd.Parameters.AddWithValue("@evid", key);
                    cmd.ExecuteNonQuery();                    
                    Con.Close();
                    DisplayEvents();
                    MessageBox.Show("Event Updated");
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
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
            if (EDesc.Text == "" || EHours.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into eventTB(E_desc,E_date,E_hour)values(@evdesc,@evdate,@evhour)", Con);
                    cmd.Parameters.AddWithValue("@evdesc", EDesc.Text);
                    cmd.Parameters.AddWithValue("@evdate", EDate.Value.Date);
                    cmd.Parameters.AddWithValue("@evhour", EHours.Text);
                    cmd.ExecuteNonQuery();                    
                    Con.Close();
                    DisplayEvents();
                    MessageBox.Show("Event Added");
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void dele_button_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Event");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from eventTB where EId=@evkey", Con);
                    cmd.Parameters.AddWithValue("@evkey", key);
                    cmd.ExecuteNonQuery();    
                    Con.Close();
                    DisplayEvents();
                    MessageBox.Show("Event Deleted");
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EDesc.Text = EData.SelectedRows[0].Cells[1].Value.ToString();
            EDate.Text = EData.SelectedRows[0].Cells[2].Value.ToString();
            EHours.Text = EData.SelectedRows[0].Cells[3].Value.ToString();

            if (EDesc.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EData.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EDate_ValueChanged(object sender, EventArgs e)
        {
            EDate.MaxDate = DateTime.Now;
        }

        private void EHours_KeyPress(object sender, KeyPressEventArgs e)
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

        private void EDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
