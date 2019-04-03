using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string a = "snehal";
            string b = "snehal1699";
            if (txtusername.Text == a && txtpassword.Text == b)
            {
                Form2 m = new Form2();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password \n Try Again");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
