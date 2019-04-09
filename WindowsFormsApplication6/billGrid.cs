using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hms
{
    public partial class billGrid : Form
    {
        public billGrid()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = DatabaseHelper.getBills();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            MainMenu f = new MainMenu();
            f.show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
    }
}
