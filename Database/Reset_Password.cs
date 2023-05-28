using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace DigiSort_Box.Database
{
     class Reset_Password
    {
        public void reset(System.Windows.Forms.Label lbluser, Guna2TextBox txtpass, Guna2TextBox txtretype)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

            string updateuser = "UPDATE account SET password = MD5('" + txtpass.Text + "') WHERE username = '" + lbluser.Text + "'";
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
