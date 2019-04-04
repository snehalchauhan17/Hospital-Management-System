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
    public partial class PatientGrid : Form
    {
        string connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vipul-Home\Documents\Visual Studio 2013\Projects\Hospital Management System\Hospital-Management-System\sql\hmsdb.mdf;Integrated Security=True;Connect Timeout=30";
         string PID ;
            string Date;
                string Name;
                string Gender;
                string Age;
                string Address;
                string Disease;
        public PatientGrid()
        {
           
            InitializeComponent();

            this.dataGridView1.DataSource = DatabaseHelper.LoadPatientData(); 
 
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
