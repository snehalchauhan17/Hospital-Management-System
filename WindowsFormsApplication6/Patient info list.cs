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
    public partial class Patient_info_list : Form
    {
        public Patient_info_list()
        {
            InitializeComponent();
            MessageBox.Show(Database.patientList[0].name);
            dataGridView1.DataSource = Database.patientList;

        }

       

        private void btnback_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
