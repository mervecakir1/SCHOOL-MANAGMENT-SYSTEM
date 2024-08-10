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
    public partial class attendance : Form
    {
        public attendance()
        {
            InitializeComponent();
            DisplayAttendance();
            FillStudID();
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
            AId.ValueMember = "S_id";
            AId.DataSource = dt;
            Con.Close();

        }
        private void GetStudName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from studentTB where S_id = @SID", Con);
            cmd.Parameters.AddWithValue("@SID", AId.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                AName.Text = dr["S_name"].ToString();
            }
            Con.Close();
        }
        private void Reset()
        {
            AId.SelectedIndex = -1;
            AStatus.SelectedIndex = -1;
            AName.Text = "";

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abadr\Documents\ITschool.mdf;Integrated Security=True;Connect Timeout=30");   //يتم اضافة الاتصال الخاص بقاعدة البيانات
        private void DisplayAttendance()
        {
            Con.Open();
            string Query = "select * from attendanceTB";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AData.DataSource = ds.Tables[0];
            Con.Close();
        }
        
        private void ADate_ValueChanged(object sender, EventArgs e)
        {
            ADate.MaxDate = DateTime.Now;
        }

        private void closepB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mainmenu obj = new mainmenu();
            obj.Show();
            this.Hide();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (AName.Text == "" || AStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into attendanceTB(AttStId,AttStName,AttDate,AttStatus)values(@StId,@StName,@Date,@Status)", Con);
                    cmd.Parameters.AddWithValue("@StId", AId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", AName.Text);
                    cmd.Parameters.AddWithValue("@Date", ADate.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", AStatus.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    DisplayAttendance();
                    MessageBox.Show("Attendance Taken");
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        int key = 0;
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (AName.Text == "" || AStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Select Attendance");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update attendanceTB set AttStId=@StId,AttStName=@StName,AttDate=@Date,AttStatus=@Status where AttStId=@ANum", Con);
                    cmd.Parameters.AddWithValue("@StId", AId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", AName.Text);
                    cmd.Parameters.AddWithValue("@Date", ADate.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", AStatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ANum", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Updated");
                    Con.Close();
                    DisplayAttendance();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void AData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AId.SelectedValue = AData.SelectedRows[0].Cells[1].Value.ToString();
            AName.Text = AData.SelectedRows[0].Cells[2].Value.ToString();
            ADate.Text = AData.SelectedRows[0].Cells[3].Value.ToString();
            AStatus.SelectedItem = AData.SelectedRows[0].Cells[4].Value.ToString();

            if (AName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AData.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void AId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }

        private void attendance_Load(object sender, EventArgs e)
        {

        }
    }
}
