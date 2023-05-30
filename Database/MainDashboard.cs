using DigiSort_Box.Model;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    public class MainDashboard
    {
        MySqlConnection connection = Host.connection;
        public void floor(System.Windows.Forms.Label floorad)
        {
            connection.Close();
            connection.Open();
            string user = "SELECT COUNT(*) FROM account WHERE position = 'Floor_Admin'";
            MySqlCommand cmd = new MySqlCommand(user, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    floorad.Text = row[0].ToString();
                }

            }
            else
            {
                floorad.Text = "ERROR";
            }
            connection.Close();
        }

        public void top(System.Windows.Forms.Label topad)
        {
            connection.Close();
            connection.Open();
            string user = "SELECT COUNT(*) FROM account WHERE position = 'Top_Admin'";
            MySqlCommand cmd = new MySqlCommand(user, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    topad.Text = row[0].ToString();
                }

            }
            else
            {
                topad.Text = "ERROR";
            }
            connection.Close();
        }

        public void unprint(System.Windows.Forms.Label lblunprint)
        {
            connection.Close();
            connection.Open();
            string unprint = "SELECT SUM(quantity) FROM unprinted_shirts";
            MySqlCommand cmd = new MySqlCommand(unprint, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    lblunprint.Text = row[0].ToString();
                }

            }
            else
            {
                lblunprint.Text = "ERROR";
            }
            connection.Close();
        }

        public void raw(System.Windows.Forms.Label lblraw)
        {
            connection.Close();
            connection.Open();
            string raw = "SELECT SUM(quantity) FROM raw_material";
            MySqlCommand cmd = new MySqlCommand(raw, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    lblraw.Text = row[0].ToString();
                }

            }
            else
            {
                lblraw.Text = "ERROR";
            }
            connection.Close();
        }

        public void ready(System.Windows.Forms.Label lblready)
        {
            connection.Close();
            connection.Open();
            string ready = "SELECT SUM(quantity) FROM ready_to_sell_items";
            MySqlCommand cmd = new MySqlCommand(ready, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    lblready.Text = row[0].ToString();
                }

            }
            else
            {
                lblready.Text = "ERROR";
            }
            connection.Close();
        }

        public void damage(System.Windows.Forms.Label lbldamage)
        {
            connection.Close();
            connection.Open();
            string dmg = "SELECT SUM(quantity) AS total_quantity\r\nFROM (\r\n    SELECT quantity FROM raw_material_damage_items\r\n    UNION ALL\r\n    SELECT quantity FROM unprinted_shirts_damage_items\r\n    UNION ALL\r\n    SELECT quantity FROM ready_to_sell_items_damage_items\r\n) AS combined_data;\r\n";
            MySqlCommand cmd = new MySqlCommand(dmg, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    lbldamage.Text = row[0].ToString();
                }

            }
            else
            {
                lbldamage.Text = "ERROR";
            }
            connection.Close();
        }

    }
}
