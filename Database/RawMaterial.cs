using DigiSort_Box.Model;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    class RawMaterial
    {
        MySqlConnection connection = Host.connection;
        void clear(Guna2ComboBox material, Guna2ComboBox design, Guna2TextBox quantity)
        {
            //clear
            material.SelectedIndex = 0;
            design.Text = null;
            quantity.Text = null;
        }

        //this to insert to the database.
        void insert(Guna2ComboBox material, Guna2ComboBox design, Guna2TextBox quantity, Guna2Button add)
        {
            //insert query
            string InsertQuery = "INSERT INTO raw_material VALUES ('0', '" + material.SelectedItem.ToString() + "', '" + design.SelectedItem.ToString() + "', '" + quantity.Text + "')";
            connection.Close();
            connection.Open();
            MySqlCommand command = new MySqlCommand(InsertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Item added successfully!");
                    clear(material, design, quantity);
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

        //this to update items if it's existing on the database if not then it will insert.
        public void raw(Guna2ComboBox material, Guna2ComboBox design, Guna2TextBox quantity, Guna2Button add)
        {
            //update query add quantity
            string updateQuery = "UPDATE raw_material SET quantity = quantity + '" + int.Parse(quantity.Text) + "' WHERE material = '" + material.SelectedItem.ToString() + "' AND design = '" + design.SelectedItem.ToString() + "'";
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
                        clear(material, design, quantity);
                        Database.Damage dmg = new Damage();
                        dmg.quantityzero();
                    }
                    else
                    {
                        insert(material, design, quantity, add);
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
