using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    class ReadyToSell
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

        void insert(Guna2ComboBox product, Guna2ComboBox color, Guna2ComboBox shade, Guna2ComboBox size, Guna2TextBox quantity)
        {
            //insert query
            string InsertQuery = "INSERT INTO ready_to_sell_items VALUES ('0', '" + product.SelectedItem.ToString() + "', '" + color.SelectedItem.ToString() + "', '" + shade.SelectedItem.ToString() + "', '" + size.SelectedItem.ToString() + "', '" + quantity.Text + "')";
            connection.Close();
            connection.Open();
            MySqlCommand command = new MySqlCommand(InsertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data added");
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

        //increase the ready to sell and decrease to raw and unprint
        public void rdy(Guna2ComboBox readyproduct, Guna2ComboBox readycolor, Guna2ComboBox readyshade, Guna2ComboBox readysize, Guna2TextBox quantity)
        {
            ready(readyproduct, readycolor, readyshade, readysize, quantity);
            string rawquery = "UPDATE raw_material SET quantity = quantity - " + int.Parse(quantity.Text) + " WHERE design = '" + readyproduct.SelectedItem.ToString() + "';";
            string unprintquery = "UPDATE unprinted_shirts SET quantity = quantity - " + int.Parse(quantity.Text) + " WHERE color = '" + readycolor.SelectedItem.ToString() + "' AND shade = '" + readyshade.SelectedItem.ToString() + "' AND size = '" + readysize.SelectedItem.ToString() + "';";
            
            connection.Close();
            connection.Open();
            MySqlCommand cmdraw = new MySqlCommand(rawquery, connection);
            MySqlCommand cmdunprint = new MySqlCommand(unprintquery, connection);

            cmdraw.ExecuteNonQuery();
            cmdunprint.ExecuteNonQuery();

        }

    }
}
