using DigiSort_Box.Model;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    class Unprinted
    {
        MySqlConnection connection = Host.connection;
        void clear(Guna2ComboBox color, Guna2ComboBox shade, Guna2ComboBox size, Guna2TextBox quantity)
        {
            //clear
            color.SelectedIndex = 0;
            shade.Text = null;
            size.SelectedIndex = 0;
            quantity.Text = null;
        }

        void insert(Guna2ComboBox color, Guna2ComboBox shade, Guna2ComboBox size, Guna2TextBox quantity)
        {
            //insert query
            string InsertQuery = "INSERT INTO unprinted_shirts VALUES ('0', '" + color.SelectedItem.ToString() + "', '" + shade.SelectedItem.ToString() + "', '" + size.SelectedItem.ToString() + "', " + quantity.Text + ")";
            connection.Close();
            connection.Open();
            MySqlCommand command = new MySqlCommand(InsertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Item added successfully!");
                    clear(color, shade, size, quantity);
                }
                else
                {
                    MessageBox.Show("Item added Unsuccessfully!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        public void unprint(Guna2ComboBox color, Guna2ComboBox shade, Guna2ComboBox size, Guna2TextBox quantity)
        {
            //update query add quantity
            string updateQuery = "UPDATE unprinted_shirts SET quantity = quantity + '" + int.Parse(quantity.Text) + "' WHERE color = '" + color.SelectedItem.ToString() + "' AND shade = '" + shade.SelectedItem.ToString() + "' AND size = '" + size.SelectedItem.ToString() + "'";
            connection.Close();
            connection.Open();
            MySqlCommand com = new MySqlCommand(updateQuery, connection);

            try
            {
                //quantity
                int quan = int.Parse(quantity.Text);

                if (quan <= 0)
                {
                    MessageBox.Show("Quantity must not be equal to 0!");
                }
                else
                {
                    //If quantity  <= 0
                    if (com.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Item added successfully!");
                        clear(color, shade, size, quantity);
                        Database.Damage dmg = new Damage();
                        dmg.quantityzero();
                    }
                    else
                    {
                        insert(color, shade, size, quantity);
                    }
                }

            }
            catch (Exception exs)
            {
                MessageBox.Show(exs.Message);
            }

            connection.Close();
        }

    }
}
