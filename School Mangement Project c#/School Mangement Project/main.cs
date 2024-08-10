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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 5;
            progressBar1.Value = startpoint;
            percentagelabel.Text = startpoint + "%";
            if(progressBar1.Value==100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                login obj = new login();
                this.Hide();
                obj.Show();
            }

        }

        private void main_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
