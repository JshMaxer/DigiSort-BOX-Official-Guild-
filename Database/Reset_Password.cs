using DigiSort_Box.Model;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    class Reset_Password
    {
        public void reset(System.Windows.Forms.Label lbluser, Guna2TextBox txtpass, Guna2TextBox txtretype)
        {
            MySqlConnection connection = Host.connection;
            string updateuser = "UPDATE account SET password = MD5('" + txtpass.Text + "') WHERE username = '" + lbluser.Text + "'";
            connection.Close();
            connection.Open();
            MySqlCommand command = new MySqlCommand(updateuser, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Password successfully changed");
                    txtpass.Text = null;
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

        }

    }
}
