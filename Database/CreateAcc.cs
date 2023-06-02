using DigiSort_Box.Model;
using DigiSort_Box.Mowdel;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    class CreateAcc
    {

        public void createAcc(Guna2TextBox firstname, Guna2TextBox lastname, Guna2TextBox paswword, Guna2TextBox retype, Guna2TextBox username, Guna2ComboBox cbusertype, System.Windows.Forms.Label lbl, Guna2Button btncreate)
        {
            MySqlConnection connection = Host.connection;
            try
            {
                if (firstname.Text.Equals("") || lastname.Text.Equals("") || paswword.Text.Equals("") || retype.Text.Equals("") || username.Text.Equals(""))
                {
                    btncreate.Enabled = false;
                    lbl.Text = "filled";
                }
                else if (!retype.Text.Equals(paswword.Text))
                {
                    MessageBox.Show("Password does not match!");
                    lbl.Text = "dontmatch";
                }
                else
                {
                    DateTime dateTimeVariable = DateTime.Now;
                    string date = dateTimeVariable.ToString("yyyy-MM-dd");

                    //Floor admin account
                    if (cbusertype.SelectedItem.Equals("Floor admin"))
                    {
                        string InsertQuery = "INSERT INTO account VALUES ('0'" + ", '" + username.Text + "', '" + firstname.Text + "', '" + lastname.Text + "', MD5('" + paswword.Text + "'), '" + "Floor_Admin" + "', '" + "Active" + "', '" + date + "')";
                        connection.Close();
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(InsertQuery, connection);

                        try
                        {
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Account successfully created!");
                                Forms.Login log = new Forms.Login();
                                log.Show();
                                lbl.Text = "success";
                            }
                            else
                            {
                                MessageBox.Show("Account Unsuccessfully created!");
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Username is already used!\nTry Another.");
                            lbl.Text = "already";
                        }

                        connection.Close();
                    }
                    //Top admin
                    else if (cbusertype.SelectedItem.Equals("Top admin"))
                    {
                        string InsertQuery = "INSERT INTO account VALUES ('0'" + ", '" + username.Text + "', '" + firstname.Text + "', '" + lastname.Text + "', MD5('" + paswword.Text + "'), '" + "Top_Admin" + "', '" + "Active" + "', '" + date + "')";
                        connection.Close();
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(InsertQuery, connection);
                        
                        try
                        {
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Account successfully created!");
                                Forms.Login log = new Forms.Login();
                                log.Show(); 
                                lbl.Text = "success";
                            }
                            else
                            {
                                MessageBox.Show("Account Unsuccessfully created!");
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Username is already used!\nTry Another.");
                            lbl.Text = "already";
                        }

                        connection.Close();
                    }

                }
            }
            //SQL
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\t\tSQLServer is turned off");
                btncreate.Enabled = false;
            }

        }

    }
}
