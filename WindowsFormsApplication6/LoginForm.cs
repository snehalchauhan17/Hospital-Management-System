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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            User u = DatabaseHelper.getUser(txtusername.Text);

            if (txtpassword.Text == u.password)
            {
                MainMenu m = new MainMenu();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password \n Try Again");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
