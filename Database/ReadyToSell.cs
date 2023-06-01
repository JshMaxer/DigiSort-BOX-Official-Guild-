using DigiSort_Box.Model;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    class ReadyToSell
    {
        MySqlConnection connection = Host.connection;

        void clear(Guna2ComboBox material, Guna2ComboBox design, Guna2ComboBox color, Guna2ComboBox shade, Guna2ComboBox size, Guna2TextBox quantity)
        {
            //clear
            material.Text = "";
            design.Text = "";
            color.Text = "";
            shade.Items.Clear();
            size.Text = "";
            quantity.Text = "";
        }

        void insert(Guna2ComboBox material, Guna2ComboBox design, Guna2ComboBox color, Guna2ComboBox shade, Guna2ComboBox size, Guna2TextBox quantity)
        {
            //insert query
            string InsertQuery = "INSERT INTO ready_to_sell_items VALUES ('0', '" + material.SelectedItem.ToString() + "', '" + design.SelectedItem.ToString() + "', '" + color.SelectedItem.ToString() + "', '" + shade.SelectedItem.ToString() + "', '" + size.SelectedItem.ToString() + "', '" + quantity.Text + "')";
            connection.Close();
            connection.Open();
            MySqlCommand command = new MySqlCommand(InsertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Item added successfully!");
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

        void update(Guna2ComboBox material, Guna2ComboBox design, Guna2ComboBox color, Guna2ComboBox shade, Guna2ComboBox size, Guna2TextBox quantity)
        {
            //update query add quantity
            string updateQuery = "UPDATE ready_to_sell_items SET quantity = quantity + '" + int.Parse(quantity.Text) + "' WHERE material = '" + material.SelectedItem.ToString() + "' AND design = '" + design.SelectedItem.ToString() + "' AND color = '" + color.SelectedItem.ToString() + "' AND shade = '" + shade.SelectedItem.ToString() + "' AND size = '" + size.SelectedItem.ToString() + "'";
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
                        MessageBox.Show("Item added successfully!");
                        Database.Damage dmg = new Damage();
                        dmg.quantityzero();
                    }
                    else
                    {
                        insert(material, design, color, shade, size, quantity);
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
        void minus(Guna2ComboBox readymaterial, Guna2ComboBox readydesign, Guna2ComboBox readycolor, Guna2ComboBox readyshade, Guna2ComboBox readysize, Guna2TextBox quantity)
        {
            update(readymaterial, readydesign, readycolor, readyshade, readysize, quantity);
            string rawquery = "UPDATE raw_material SET quantity = quantity - " + int.Parse(quantity.Text) + " WHERE material = '" + readymaterial.SelectedItem.ToString() + "' AND design = '" + readydesign.SelectedItem.ToString() + "';";
            string unprintquery = "UPDATE unprinted_shirts SET quantity = quantity - " + int.Parse(quantity.Text) + " WHERE color = '" + readycolor.Text + "' AND shade = '" + readyshade.Text + "' AND size = '" + readysize.Text + "';";

            connection.Close();
            connection.Open();
            MySqlCommand cmdraw = new MySqlCommand(rawquery, connection);
            MySqlCommand cmdunprint = new MySqlCommand(unprintquery, connection);

            cmdraw.ExecuteNonQuery();
            cmdunprint.ExecuteNonQuery();
            Database.Damage dmg = new Damage();
            dmg.quantityzero();

        }

        //restrictions
        void restriction(Guna2ComboBox material, Guna2ComboBox design, Guna2ComboBox color, Guna2ComboBox shade, Guna2ComboBox size, Guna2TextBox quantity)
        {
            string rawquant = "SELECT quantity FROM Raw_Material WHERE Material = '" + material.Text + "'AND design = '" + design.Text + "'";
            string unprintquant = "SELECT quantity FROM unprinted_shirts WHERE color = '" + color.Text + "'AND shade = '" + shade.Text + "' AND size = '" + size.Text + "'";

            connection.Close();
            connection.Open();

            MySqlCommand rawcmd = new MySqlCommand(rawquant, connection);
            MySqlCommand unprintcmd = new MySqlCommand(unprintquant, connection);
            MySqlDataReader rawrd = rawcmd.ExecuteReader();

            if (rawrd.HasRows)
            {
                while (rawrd.Read())
                {
                    int rawquan = int.Parse(rawrd["quantity"].ToString());

                    // Condition if the quantity exceeds
                    if (int.Parse(quantity.Text) > rawquan)
                    {
                        rawrd.Close(); // Close the first reader
                        MessageBox.Show("Quantity exceeds for materials");
                        return; // Exit the method if the quantity exceeds
                    }
                }

                rawrd.Close(); // Close the first reader

                MySqlDataReader unprintrd = unprintcmd.ExecuteReader();

                if (unprintrd.HasRows)
                {
                    while (unprintrd.Read())
                    {
                        int unprintquan = int.Parse(unprintrd["quantity"].ToString());

                        // Condition if the quantity exceeds
                        if (int.Parse(quantity.Text) > unprintquan)
                        {
                            unprintrd.Close(); // Close the second reader
                            MessageBox.Show("Quantity exceeds for materials");
                            return; // Exit the method if the quantity exceeds
                        }
                    }

                    unprintrd.Close(); // Close the second reader

                    // Quantity does not exceed, proceed with the minus method
                    minus(material, design, color, shade, size, quantity);
                }
            }

            connection.Close();
        }


        //Check if the data is existing before making transaction
        public void check(Guna2ComboBox material, Guna2ComboBox design, Guna2ComboBox color, Guna2ComboBox shade, Guna2ComboBox size, Guna2TextBox quantity)
        {
            string checkraw = "SELECT COUNT(*) FROM Raw_Material WHERE material ='" + material.Text + "' AND design ='" + design.Text + "'";
            string checkunprint = "SELECT COUNT(*) FROM unprinted_shirts WHERE color ='" + color.Text + "' AND shade ='" + shade.Text + "'";

            connection.Close();
            connection.Open();
            MySqlCommand Rawcmd = new MySqlCommand(checkraw, connection);
            MySqlCommand UnprintCmd = new MySqlCommand(checkunprint, connection);

            int rawCount = Convert.ToInt32(Rawcmd.ExecuteScalar());
            int unpintCount = Convert.ToInt32(UnprintCmd.ExecuteScalar());

            if (rawCount > 0 && unpintCount > 0)
            {
                restriction(material, design, color, shade, size, quantity);
                clear(material, design, color, shade, size, quantity);
            }
            else
            {
                MessageBox.Show("Materials does not exist to make transaction");
            }

            connection.Close();
        }

    }
}
/* 6
 * 1
 * 2023
*/