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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void closepB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
