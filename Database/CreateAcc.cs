using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    class CreateAcc
    {
        public void createAcc(Guna2TextBox firstname, Guna2TextBox lastname, Guna2TextBox paswword, Guna2TextBox retype, Guna2TextBox username, Guna2ComboBox cbusertype)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

            try
            {
                if (firstname.Text.Equals("") || lastname.Text.Equals("") || paswword.Text.Equals("") || retype.Text.Equals("") || username.Text.Equals(""))
                {
                    MessageBox.Show("Form must be filled-out completely!");
                }
                else if (!retype.Text.Equals(paswword.Text))
                {
                    MessageBox.Show("Password do not match!");
                }
                else
                {
                    //Floor admin account
                    if (cbusertype.SelectedItem.Equals("Floor admin"))
                    {
                        string InsertQuery = "INSERT INTO account VALUES ('0'" + ", '" + username.Text + "', '" + firstname.Text + "', '" + lastname.Text + "', '" + paswword.Text + "', '" + "Floor_Admin" + "', '" + "Active" + "')";
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(InsertQuery, connection);

                        try
                        {
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Account successfully created!");
                                Forms.Login log = new Forms.Login();
                                log.Show();
                                //Application.Exit();

                            }
                            else
                            {
                                MessageBox.Show("Account Unsuccessfully created!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            MessageBox.Show("Username is already used!");
                        }

                        connection.Close();
                    }
                    //Top admin
                    else if (cbusertype.SelectedItem.Equals("Top admin"))
                    {
                        string InsertQuery = "INSERT INTO account VALUES ('0'" + ", '" + username.Text + "', '" + firstname.Text + "', '" + lastname.Text + "', '" + paswword.Text + "', '" + "Top_Admin" + "', '" + "Active" + "')";
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(InsertQuery, connection);

                        try
                        {
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Account successfully created!");
                                Forms.Login log = new Forms.Login();
                                log.Show();
                                //Application.Exit();

                            }
                            else
                            {
                                MessageBox.Show("Account Unsuccessfully created!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Username is already used!");
                        }

                        connection.Close();
                    }

                }
            }
            //SQL
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\t\tSQLServer is turned off");
            }

        }

    }
}
