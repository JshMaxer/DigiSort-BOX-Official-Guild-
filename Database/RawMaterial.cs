using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    class RawMaterial
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

        void insert(Guna2ComboBox material, Guna2ComboBox design, Guna2ComboBox color, Guna2TextBox quantity, Guna2Button add)
        {
            //insert query
            string InsertQuery = "INSERT INTO raw_material VALUES ('" + material.SelectedItem.ToString() + "', '" + design.SelectedItem.ToString() + "', '" + color.SelectedItem.ToString() + "', '" + quantity.Text + "')";
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

        public void raw(Guna2ComboBox material, Guna2ComboBox design, Guna2ComboBox color, Guna2TextBox quantity, Guna2Button add)
        {
            //update query add quantity
            string updateQuery = "UPDATE raw_material SET quantity = quantity + '" + int.Parse(quantity.Text) + "' WHERE material = '" + material.SelectedItem.ToString() + "' AND design = '" + design.SelectedItem.ToString() + "' AND color = '" + color.SelectedItem.ToString() + "'";
            connection.Close();
            connection.Open();
            MySqlCommand com = new MySqlCommand(updateQuery, connection);

            try
            {
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data updated");
                }
                else
                {
                    insert(material, design, color, quantity, add);
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
