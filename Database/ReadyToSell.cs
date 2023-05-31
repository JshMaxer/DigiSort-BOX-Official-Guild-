﻿using DigiSort_Box.Model;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    class ReadyToSell
    {
        MySqlConnection connection = Host.connection;
        void insert(Guna2ComboBox material, Guna2ComboBox design, Guna2ComboBox color, Guna2ComboBox shade, Guna2ComboBox size, Guna2TextBox quantity)
        {
            //insert query
            string InsertQuery = "INSERT INTO ready_to_sell_items VALUES ('0', '" + material.SelectedItem.ToString() + "', '" + design.SelectedItem.ToString() +  "', '" + color.SelectedItem.ToString() + "', '" + shade.SelectedItem.ToString() + "', '" + size.SelectedItem.ToString() + "', '" + quantity.Text + "')";
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

        public void ready(Guna2ComboBox material, Guna2ComboBox design, Guna2ComboBox color, Guna2ComboBox shade, Guna2ComboBox size, Guna2TextBox quantity)
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
        public void rdy(Guna2ComboBox readymaterial, Guna2ComboBox readydesign, Guna2ComboBox readycolor, Guna2ComboBox readyshade, Guna2ComboBox readysize, Guna2TextBox quantity)
        {
            ready(readymaterial, readydesign, readycolor, readyshade, readysize, quantity);
            string rawquery = "UPDATE raw_material SET quantity = quantity - " + int.Parse(quantity.Text) + " WHERE material = '" + readymaterial.SelectedItem.ToString() +  "' AND design = '" + readydesign.SelectedItem.ToString() + "';";
            string unprintquery = "UPDATE unprinted_shirts SET quantity = quantity - " + int.Parse(quantity.Text) + " WHERE color = '" + readycolor.SelectedItem.ToString() + "' AND shade = '" + readyshade.SelectedItem.ToString() + "' AND size = '" + readysize.SelectedItem.ToString() + "';";
            
            connection.Close();
            connection.Open();
            MySqlCommand cmdraw = new MySqlCommand(rawquery, connection);
            MySqlCommand cmdunprint = new MySqlCommand(unprintquery, connection);

            cmdraw.ExecuteNonQuery();
            cmdunprint.ExecuteNonQuery();
            Database.Damage dmg = new Damage();
            dmg.quantityzero();
        }

    }
}
