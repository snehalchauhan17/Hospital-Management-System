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
            this.Hide();
        }
        

          private void button1_Click(object sender, EventArgs e)
          {
              RoomBooking ro = new RoomBooking();
              ro.Show();
              this.Hide();
          }

          private void button2_Click(object sender, EventArgs e)
          {
              roomGrid ro = new roomGrid();
              ro.Show();
              this.Hide();
          }

          private void button5_Click(object sender, EventArgs e)
          {
              BillPayment b = new BillPayment();
              b.Show();
              this.Hide();
          }

          

          private void button4_Click(object sender, EventArgs e)
          {
              billGrid bi = new billGrid();
              bi.Show();
              this.Hide();
          }

          private void btnclose_Click(object sender, EventArgs e)
          {
              this.Close();
              Application.Exit();
          }
    }
}
