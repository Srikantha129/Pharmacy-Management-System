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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TextUserName.Clear();
            TextPassword.Clear();
        }

        private void BtnSignin_Click(object sender, EventArgs e)
        {
            if(TextUserName.Text== "Srikantha" && TextPassword.Text== "1234")
            {
                Administrator am = new Administrator();
                am.Show();
                this.Hide();
            }
            else if (TextUserName.Text == "Sri" && TextPassword.Text == "12345")
            {
                Pharmasist Bm = new Pharmasist();
                Bm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Incorrect Username Or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            
            
        }
    }
}
