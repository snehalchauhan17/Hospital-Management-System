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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            SqlConnection con = new SqlConnection("server=localhost;User Id=root;password=;database=medical;Persist Security Info=True;");
            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select pat_name,room from patient where pat_id=" + Convert.ToInt32(textBox1.Text) + " ;";      // saving new custmer info

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox2.Text = dr.GetValue(0).ToString();
                        textBox3.Text = dr.GetValue(1).ToString();
                    }
                    else
                    {
                        MessageBox.Show(" Sorry ,,This ID, " + textBox1.Text + " customer is not Available.   ");
                        textBox1.Text = "";
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(@"server=localhost;User Id=root;Password=;database=medical;Persist Security Info=True;");
            con.Open();
            try
            {
                string str = " insert into bill values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(bill_id) from bill ;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("bill saved Successfully. ");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
             if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrEmpty(textBox8.Text))
                textBox10.Text = (Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox8.Text)).ToString();
    

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrEmpty(textBox8.Text))
                textBox10.Text = (Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox8.Text)).ToString();
        
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrEmpty(textBox8.Text))
                textBox10.Text = (Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox8.Text)).ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        
        if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrEmpty(textBox8.Text))
                textBox10.Text = (Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox8.Text)).ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrEmpty(textBox8.Text))
                textBox10.Text = (Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox8.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        

    }
}
