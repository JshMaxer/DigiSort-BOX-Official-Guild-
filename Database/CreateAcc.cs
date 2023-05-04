using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DigiSort_Box.Database
{
     class CreateAcc
    {
        public void createAcc(TextBox firstname, TextBox lastname, TextBox paswword, TextBox retype, TextBox username, TextBox email)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

            try
            {
                if (firstname.Text.Equals("") || lastname.Text.Equals("") || paswword.Text.Equals("") || retype.Text.Equals("") || username.Text.Equals("") || email.Text.Equals(""))
                {
                    MessageBox.Show("Field is blank!");
                }
                else if (!retype.Text.Equals(paswword.Text))
                {
                    MessageBox.Show("Password not same");
                }
                else
                {
                    string InsertQuery = "INSERT INTO account VALUES ('" + username.Text + "', '" + firstname.Text + "', '" + lastname.Text + "', '" + email.Text + "', '" + paswword.Text + "')";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(InsertQuery, connection);

                    try
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Account Created Succesful");
                            Forms.Login log = new Forms.Login();
                            log.Show();
                        }
                        else
                        {
                            MessageBox.Show("Account Created UnSuccesful");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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
