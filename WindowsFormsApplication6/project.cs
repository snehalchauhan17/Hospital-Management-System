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
            PatientInformation p = new PatientInformation();
            p.no =Convert.ToInt32(textBox1.Text);
            p.date = textBox2.Text;
            p.pid = Convert.ToInt32(txtpid.Text);
            p.name = txtname.Text;
            if(rbnmale.Checked)
                p.gender = rbnmale.Text;
            else
                p.gender = rbnfemale.Text;
            p.age = Convert.ToInt32(txtage.Text);
            p.address = rtaddress.Text;
            p.disease = txtdisease.Text;
           Database.patientList[Database.index] = p;
            Database.index++;
            MessageBox.Show("Patient Resistered successfully");
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

       
    }
}
