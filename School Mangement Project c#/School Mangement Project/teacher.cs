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
    public partial class teacher : Form
    {
        public teacher()
        {
            InitializeComponent();
            DisplayTeachers();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abadr\Documents\ITschool.mdf;Integrated Security=True;Connect Timeout=30");   //يتم اضافة الاتصال الخاص بقاعدة البيانات
        private void DisplayTeachers()
        {
            Con.Open();
            string Query = "select * from teacherTB";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TData.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            TName.Text = "";
            TPhone.Text = "";
            TAddress.SelectedIndex = -1;
            TGender.SelectedIndex = -1;
            TSub.SelectedIndex = -1;
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
            if (TName.Text == "" || TPhone.Text == "" || TAddress.SelectedIndex == -1 || TGender.SelectedIndex == -1 || TSub.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into teacherTB(T_name,T_gender,T_phone,T_subject,T_address,T_DOB)values(@tname,@tgender,@tphone,@tsub,@taddress,@tDOB)", Con);
                    cmd.Parameters.AddWithValue("@tname", TName.Text);
                    cmd.Parameters.AddWithValue("@tgender", TGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@tphone", TPhone.Text);
                    cmd.Parameters.AddWithValue("@tsub", TSub.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@taddress", TAddress.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@tDOB", TDOB.Value.Date);

                    cmd.ExecuteNonQuery();                   
                    Con.Close();
                    DisplayTeachers();
                    MessageBox.Show("Teacher Added");
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        int key = 0;
        private void dele_button_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Teacher");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from teacherTB where TId=@tkey", Con);
                    cmd.Parameters.AddWithValue("@tkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Deleted");
                    Con.Close();
                    DisplayTeachers();
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
            if (TName.Text == "" || TPhone.Text == "" || TAddress.SelectedIndex == -1 || TGender.SelectedIndex == -1 || TSub.SelectedIndex == -1)
            {
                MessageBox.Show("Select Teacher");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update teacherTB set T_name=@tname,T_gender=@tgender,T_phone=@tphone,T_subject=@tsub,T_address=@taddress,T_DOB=@tDOB where TId=@tid", Con);
                    cmd.Parameters.AddWithValue("@tname", TName.Text);
                    cmd.Parameters.AddWithValue("@tgender", TGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@tphone", TPhone.Text);
                    cmd.Parameters.AddWithValue("@tsub", TSub.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@taddress", TAddress.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@tDOB", TDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@tid", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Updated");
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void TName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TName.Text = TData.SelectedRows[0].Cells[1].Value.ToString();
            TGender.SelectedItem = TData.SelectedRows[0].Cells[2].Value.ToString();
            TPhone.Text = TData.SelectedRows[0].Cells[3].Value.ToString();
            TSub.SelectedItem = TData.SelectedRows[0].Cells[4].Value.ToString();
            TAddress.SelectedItem = TData.SelectedRows[0].Cells[5].Value.ToString();
            TDOB.Text = TData.SelectedRows[0].Cells[6].Value.ToString();

            if (TName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TData.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void TDOB_ValueChanged(object sender, EventArgs e)
        {
            TDOB.MaxDate = DateTime.Now;
        }

        private void TPhone_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
