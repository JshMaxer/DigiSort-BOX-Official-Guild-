using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    class Login
    {
        //searching all the accounts on Top admin and Floor admin database
        public void loginCODE(Guna2TextBox username, Guna2TextBox password)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

            //search account for top admin account
            try
            {
                string searchTop = "SELECT firstname, lastname, username, password FROM top_account WHERE username = '" + username + "' AND password = '" + password + "'";
                connection.Close();
                connection.Open();
                MySqlCommand cmdtop = new MySqlCommand(searchTop, connection);
                MySqlDataReader rowtop = (cmdtop.ExecuteReader());

                if (rowtop.HasRows)
                {
                    while (rowtop.Read())
                    {
                        string fname = rowtop["firstname"].ToString();
                        string lname = rowtop["lastname"].ToString();
                        string usename = rowtop["username"].ToString();

                        MessageBox.Show("Top admin Log-in Succesful!\nHello " + fname + " " + lname);

                        Forms.Dashboard dash = new Forms.Dashboard();
                        dash.txtname.Text = usename;
                        dash.Show();

                        //this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect Log-in Credentials!");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\t\tSQLServer is turned off");
            }


            //search account for floor admin account
            try
            {
                string searchFloor = "SELECT first_name, last_name, username, password FROM floor_account WHERE username = '" + username + "' AND password = '" + password + "'";
                connection.Close();
                connection.Open();
                MySqlCommand cmdfloor = new MySqlCommand(searchFloor, connection);
                MySqlDataReader rowfloor = (cmdfloor.ExecuteReader());

                if (rowfloor.HasRows)
                {
                    while (rowfloor.Read())
                    {
                        string fname = rowfloor["first_name"].ToString();
                        string lname = rowfloor["last_name"].ToString();
                        string usename = rowfloor["username"].ToString();

                        MessageBox.Show("Floor admin Log-in Succesful!\nHello " + fname + " " + lname);

                        Forms.Dashboard dash = new Forms.Dashboard();
                        dash.txtname.Text = usename;
                        dash.Show();

                        //this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect Log-in Credentials!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\t\tSQLServer is turned off");
            }

            connection.Close();
        }

    }
}

