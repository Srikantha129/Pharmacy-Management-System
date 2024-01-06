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
    public partial class Pharmasist : Form
    {
        public Pharmasist()
        {
            InitializeComponent();
        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void BtnDashBoard_Click(object sender, EventArgs e)
        {
            uC_P_DashBoard1.Visible = true;
            uC_P_DashBoard1.BringToFront();
        }

        private void Pharmasist_Load(object sender, EventArgs e)
        {
            uC_P_DashBoard1.Visible = false;
            uC_P_Addmedicines1.Visible = false;
            uC_P_SellMedicine1.Visible = false;
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            uC_P_Addmedicines1.Visible = true;
            uC_P_Addmedicines1.BringToFront();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            uC_P_SellMedicine1.Visible = true;
            uC_P_SellMedicine1.BringToFront();
        }
    }
}
