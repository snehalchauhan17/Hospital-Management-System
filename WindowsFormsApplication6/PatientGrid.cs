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
        string connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Users\vipul\Documents\hmsdb.mdf;Integrated Security=True;Connect Timeout=30";
        public PatientGrid()
        {
            InitializeComponent();
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlDataAdapter sqa = new SqlDataAdapter("select * from patientInfo", cnn);
            DataTable dbt = new DataTable();
            sqa.Fill(dbt);
            this.dataGridView1.DataSource = dbt;            
            cnn.Close();
        }
    }
}
