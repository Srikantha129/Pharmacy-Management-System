using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_DashBoard1.Visible = false;
            uC_AddUser1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e) //logout button
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void BtnDashBoard_Click(object sender, EventArgs e)
        {
            uC_DashBoard1.Visible = true;
            uC_DashBoard1.BringToFront();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }
    }
}
