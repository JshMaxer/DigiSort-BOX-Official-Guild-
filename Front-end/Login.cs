using DigiSort_Box.Front_end;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Forms
{
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

        public Login()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Forms.DigiSortBox dsb = new Forms.DigiSortBox();
            dsb.Show();
            this.Close();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            //preview account - change restriction
            if (txtusername.Text.Equals("Preview") || txtusername.Text.Equals("preview") && (txtpassword.Text.Equals("Admin") || txtpassword.Text.Equals("admin")))
            {
                MessageBox.Show("This account is for preview forms only. You cannot do anything on other forms you just previewing them.\nThis account is usually used only for Front-End Developer");
                Forms.preview pv = new Forms.preview();
                this.Close();
                pv.Show();
            }
            else
            {
                Database.Login logss = new Database.Login();
                logss.loginCODE(txtusername, txtpassword);
            }


        }

        private void lblreset_Click(object sender, EventArgs e)
        {
            reset_password reset = new reset_password();
            DialogResult dr = MessageBox.Show("Are you sure you want to reset password?", "DigiSortBox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                reset.ShowDialog();
            }
            else
            {
                //ok.
            }

        }
    }
}
