using MySql.Data.MySqlClient;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Principal;
using Guna.UI2.WinForms;
using System.Web.UI.WebControls;
using System.Data;
using System.Windows.Forms;
using System;

namespace DigiSort_Box.Database
{
    public class Account_Management
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

        public void account(System.Windows.Forms.Label user,Guna2ComboBox pos, Guna2DataGridView dgacc)
        {
            //Account
            connection.Close();
            connection.Open();
            string accounttop = "SELECT username, first_name, last_name, password, position, activation FROM account";
            MySqlCommand cmd = new MySqlCommand(accounttop, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(sdr);
            dgacc.DataSource = table;
        }

        public void updatedeact(System.Windows.Forms.Label user, Guna2ComboBox activ)
        {
            connection.Close();
            connection.Open();
            string updateQuery = "UPDATE account SET activation = '" + activ.SelectedItem.ToString() + "' WHERE username = '" + user.Text + "'";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Account deactivated!");
                }
                else
                {
                    MessageBox.Show("Data Not updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        public void updatereact(System.Windows.Forms.Label user, Guna2ComboBox activ)
        {
            connection.Close();
            connection.Open();
            string updateQuery = "UPDATE account SET activation = '" + activ.SelectedItem.ToString() + "' WHERE username = '" + user.Text + "'";
            MySqlCommand command = new MySqlCommand(updateQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Account reactivated!");
                }
                else
                {
                    MessageBox.Show("Data Not updated");
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
