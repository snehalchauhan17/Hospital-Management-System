using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication6
{
   
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
   


      private void btnsubmit_Click(object sender, EventArgs e)
        {
            PatientInformation patient = patientInfoFromForm();

            DatabaseHelper.addPatient(patient);
           

            MessageBox.Show("Patient Resistered successfully");
            
        }

      private PatientInformation patientInfoFromForm()
      {
          PatientInformation patient = new PatientInformation();
          patient.pid = Convert.ToInt32(txtpid.Text);
          patient.date = textBox2.Text;

          patient.name = txtname.Text;
          if (rbnmale.Checked)
              patient.gender = rbnmale.Text;
          else
              patient.gender = rbnfemale.Text;
          patient.age = Convert.ToInt32(txtage.Text);
          patient.address = rtaddress.Text;
          patient.disease = txtdisease.Text;
          return patient;
      }

        private void btnback_Click(object sender, EventArgs e)
        {
            MainMenu f = new MainMenu();
            f.Show();
            this.Hide();
        }

  
        private void btnfetch(object sender, EventArgs e)
        {
            PatientInformation pi = DatabaseHelper.getPatient(Convert.ToInt32(txtpid.Text));
            textBox2.Text = pi.date;
            txtname.Text=pi.name;
            switch(pi.gender){
                case "male" :
                    rbnmale.Checked = true;
                    break;
                case "female" :
                    rbnfemale.Checked = true;
                    break;
            }
           
          
            txtage.Text =Convert.ToString(pi.age);
            rtaddress.Text = pi.address;
            txtdisease.Text = pi.disease;
        
        }

        private void btnupdate(object sender, EventArgs e)
        {
            PatientInformation patient = patientInfoFromForm();
            DatabaseHelper.updatePatient(patient);
            MessageBox.Show("Patient updated successfully");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DatabaseHelper.deletePatient(Convert.ToInt32(txtpid.Text));
            MessageBox.Show("Patient deleted successfully");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

      


       
    }
}
