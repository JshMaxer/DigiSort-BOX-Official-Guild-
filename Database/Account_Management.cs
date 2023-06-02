using DigiSort_Box.Forms;
using DigiSort_Box.Model;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    public class Account_Management
    {
        MySqlConnection connection = Host.connection;
        public void account(System.Windows.Forms.Label user, Guna2ComboBox pos, Guna2DataGridView dgacc)
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

        public void search(Guna2DataGridView dgacc, Guna2TextBox search)
        {
            connection.Close();
            connection.Open();
            if (search.Text.Equals(""))
            {
                string searchall = "SELECT * FROM account";
                MySqlDataAdapter all = new MySqlDataAdapter(searchall, connection);
                DataTable tblall = new DataTable();
                all.Fill(tblall);
                dgacc.DataSource = tblall;
            }
            else
            {
                //search
                string searchquery = "SELECT * FROM account WHERE username LIKE '" + search.Text + "%'";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgacc.DataSource = tbl;
            }

        }

    }
}
