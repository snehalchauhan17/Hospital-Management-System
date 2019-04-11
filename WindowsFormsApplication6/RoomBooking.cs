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
    public partial class RoomBooking : Form
    {
        public RoomBooking()
        {
            InitializeComponent();
        }



        private void RoomBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            roomInformation r = DatabaseHelper.getRoom(Convert.ToInt32(txtpid.Text));
            switch (r.Roomtype)
            {
                case "Sharing":
                    rbnsharing.Checked = true;
                    break;
                case "Single":
                    rbnsingle.Checked = true;
                    break;
                case "Delux":
                    rbndelux.Checked = true;
                    break;
                case "Suite":
                    rbnsuite.Checked = true;
                    break;
            }


            txtroomno.Text = Convert.ToString(r.Roomno);
            txtstatus.Text = Convert.ToString(r.Status);
            txtstartdate.Text = Convert.ToString(r.Startdate);
            txtenddate.Text = Convert.ToString(r.Enddate);
            txtprice.Text = Convert.ToString(r.Price);


        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            roomInformation room = roomInfoFromForm();

            DatabaseHelper.addRoom(room);


            MessageBox.Show("Room Resistered successfully");

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            roomInformation room = roomInfoFromForm();
            DatabaseHelper.updateRoom(room);
            MessageBox.Show("Patient updated successfully");
        }
        private roomInformation roomInfoFromForm()
        {
            roomInformation room = new roomInformation();
            room.pid = Convert.ToInt32(txtpid.Text);



            if (rbnsharing.Checked)
                room.Roomtype = rbnsharing.Text;
            else if (rbnsingle.Checked)
                room.Roomtype = rbnsingle.Text;
            else if (rbndelux.Checked)
                room.Roomtype = rbndelux.Text;
            else
                room.Roomtype = rbnsuite.Text;
            room.Status = txtstatus.Text;
            room.Startdate = txtstartdate.Text;
            room.Enddate = txtenddate.Text;
            room.Roomno = Convert.ToInt32(txtroomno.Text);
            room.Price = Convert.ToInt32(txtprice.Text);
            return room;
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            DatabaseHelper.deleteRoom(Convert.ToInt32(txtpid.Text));
            MessageBox.Show("Patient deleted successfully");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            MainMenu f = new MainMenu();
            f.Show();
            this.Hide();
        }

    }
}

