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
            PatientInformation patient = new PatientInformation();
            patient.no =Convert.ToInt32(textBox1.Text);
            patient.date = textBox2.Text;
            patient.pid = Convert.ToInt32(txtpid.Text);
            patient.name = txtname.Text;
            if(rbnmale.Checked)
                patient.gender = rbnmale.Text;
            else
                patient.gender = rbnfemale.Text;
            patient.age = Convert.ToInt32(txtage.Text);
            patient.address = rtaddress.Text;
            patient.disease = txtdisease.Text;

            // insert patient to database patient info table. 


            MessageBox.Show("Patient Resistered successfully");
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            MainMenu f = new MainMenu();
            f.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
