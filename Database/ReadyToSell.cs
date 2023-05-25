using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    class ReadyToSell
    {

        void clear(Guna2ComboBox product, Guna2ComboBox color, Guna2ComboBox shade, Guna2ComboBox size, Guna2TextBox quantity)
        {
            //clear
            product.SelectedIndex = 0;
            shade.SelectedIndex = 0;
            color.SelectedIndex = 0;
            size.SelectedIndex = 0;
            quantity.Text = null;
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

        void insert(Guna2ComboBox product, Guna2ComboBox color, Guna2ComboBox shade, Guna2ComboBox size, Guna2TextBox quantity)
        {
            //insert query
            string InsertQuery = "INSERT INTO ready_to_sell_items VALUES ('" + product.SelectedItem.ToString() + "', '" + color.SelectedItem.ToString() + "', '" + shade.SelectedItem.ToString() + "', '" + size.SelectedItem.ToString() + "', " + quantity.Text + ")";
            connection.Close();
            connection.Open();
            MySqlCommand command = new MySqlCommand(InsertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data added");
                    clear(product, color, shade, size, quantity);
                }
                else
                {
                    MessageBox.Show("Data Not added");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        public void ready(Guna2ComboBox product, Guna2ComboBox color, Guna2ComboBox shade, Guna2ComboBox size, Guna2TextBox quantity)
        {
            //update query add quantity
            string updateQuery = "UPDATE ready_to_sell_items SET quantity = quantity + '" + int.Parse(quantity.Text) + "' WHERE product_name = '" + product.SelectedItem.ToString() + "' AND color = '" + color.SelectedItem.ToString() + "' AND shade = '" + shade.SelectedItem.ToString() + "' AND size = '" + size.SelectedItem.ToString() + "'";
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
                    if (com.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data updated");
                        clear(product, color, shade, size, quantity);
                    }
                    else
                    {
                        insert(product, color, shade, size, quantity);
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
