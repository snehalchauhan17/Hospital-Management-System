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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string a = groupBox1.Text;
            string b= 
            if (groupBox1.Text== "" && groupBox2.Text == "")
            {
                Form2 s = new Form2();
                s.Show();
                this.Hide();
            } 
            else
            { 
                MessageBox.Show("enter the details");
            }
        }

       
    }
}
