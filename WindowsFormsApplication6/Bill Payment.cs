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
    public partial class BillPayment : Form
    {
        public BillPayment()
        {
            InitializeComponent();
        }
        Bill b = new Bill();
        private void btnfetch_Click(object sender, EventArgs e)
            {
            PatientInformation pi = DatabaseHelper.getPatient(Convert.ToInt32(textPID.Text));
            roomInformation r = DatabaseHelper.getRoom(Convert.ToInt32(textPID.Text));
           
            b.pid = pi.pid;
            b.name = pi.name;
            b.Roomno = r.Roomno;
            b.Price = r.Price;
            textptname.Text = b.name;
            txtroomno.Text = Convert.ToString( b.Roomno);
            txtroomrent.Text = Convert.ToString(b.Price);

            }

        private void label7_Click(object sender, EventArgs e)
            {

            }

        private void btncalculate_Click(object sender, EventArgs e)
            {
                b.reportCharges = Convert.ToInt32(textRpt.Text);
                b.medicineCharges = Convert.ToInt32(textmdcn.Text);
                b.doctorCharges = Convert.ToInt32(textdoctor.Text);
                b.otherCharges = Convert.ToInt32(textOther.Text);
                b.total = b.Price + b.reportCharges + b.medicineCharges + b.doctorCharges + b.otherCharges;
                txttotal.Text =Convert.ToString( b.total);
            }

        private void BillPayment_Load(object sender, EventArgs e)
        {

        }

        
        

    }
}
