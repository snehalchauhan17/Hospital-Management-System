﻿using System;
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
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
            DatabaseHelper.initializeConnection();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnpatientresistration_Click(object sender, EventArgs e)
        {
            Form3 n = new Form3();
            n.Show();
            this.Hide();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            //Patient_info_list p = new Patient_info_list();
            PatientGrid p = new PatientGrid();
            p.Show();
        }
          private void btnlogout_Click(object sender, EventArgs e)
        {
            DatabaseHelper.closeConnection();
        }

       
    }
}
