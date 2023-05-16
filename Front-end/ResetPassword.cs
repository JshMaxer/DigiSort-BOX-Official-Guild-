using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Front_end
{
    public partial class reset_password : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

        public reset_password()
        {
            InitializeComponent();
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {
            //DATABASE -------------------------------------------------------------------

            //Account
            connection.Open();
            string updateuser = "UPDATE account SET password = '" + txtpassword.Text + "' WHERE username = '" + lblusername.Text + "'";
            MySqlCommand command = new MySqlCommand(updateuser, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Password successfully changed");
                    txtpassword.Text = null;
                    txtretype.Text = null;
                }
                else
                {
                    MessageBox.Show("Password Unsuccessfully changed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();

            //end of database -------------------------------------------------------------------
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text.Equals("") || txtretype.Text.Equals(""))
            {
                btnproceed.Enabled = false;
            }
            else if (!txtpassword.Text.Equals(txtretype.Text))
            {
                btnproceed.Enabled = false;
            }
            else
            {
                btnproceed.Enabled = true;
            }
        }
    }
}
