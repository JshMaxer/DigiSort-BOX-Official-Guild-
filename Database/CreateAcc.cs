using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    class CreateAcc
    {
        public void createAcc(Guna2TextBox firstname, Guna2TextBox lastname, Guna2TextBox paswword, Guna2TextBox retype, Guna2TextBox username)
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
                    string InsertQuery = "INSERT INTO account VALUES ('" + username.Text + "', '" + firstname.Text + "', '" + lastname.Text + "', '" + paswword.Text + "')";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\t\tSQLServer is turned off");
            }
        }


    }
}
