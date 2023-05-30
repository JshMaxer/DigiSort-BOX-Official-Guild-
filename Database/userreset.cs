using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigiSort_Box.Model;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace DigiSort_Box.Database
{
    public class userreset
    {
        MySqlConnection connection = Host.connection;
        public void user(Guna2ComboBox cbuser)
        {
            string SearchQuery = "SELECT username FROM account";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(SearchQuery, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    cbuser.Items.Add(row["username"].ToString());
                }

            }
            else
            {
                MessageBox.Show("Can't found data");
            }

            connection.Close();
        }

        public void resetpass(Guna2ComboBox cbuser, Guna2TextBox txtpass)
        {
            //update query
            string updateQuery = "UPDATE account SET password = MD5('" + txtpass.Text + "')" + "WHERE username = '" + cbuser.SelectedItem.ToString() + "'";
            string DeleteQuery = "DELETE FROM message_request WHERE username = '" + cbuser.SelectedItem.ToString() + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(updateQuery, connection);
            MySqlCommand cmd = new MySqlCommand(DeleteQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1 && cmd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Password successfully changed");
                    MessageBox.Show("Concern for resetting password has been completed");
                }
                else
                {
                    MessageBox.Show("Can't change password without request!");
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
