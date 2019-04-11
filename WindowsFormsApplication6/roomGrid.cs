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
    public partial class roomGrid : Form
    {
        public roomGrid()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = DatabaseHelper.getRooms(); 
 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            MainMenu f = new MainMenu();
            f.Show();
            this.Hide();
        }

        private void roomGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
