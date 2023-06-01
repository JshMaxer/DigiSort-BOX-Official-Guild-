using DigiSort_Box.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    public class Update
    {
        MySqlConnection connection = Host.connection;
        Forms.update upt = new Forms.update();

        void raw(System.Windows.Forms.DataGridView dgtable)
        {
            //show raw
            string query = "SELECT * FROM raw_material";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgtable.DataSource = dtRecords;
        }

        void ready(System.Windows.Forms.DataGridView dgtable)
        {
            //show ready to sell items
            string query = "SELECT * FROM ready_to_sell_items"; ;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgtable.DataSource = dtRecords;
        }

        void unprint(System.Windows.Forms.DataGridView dgtable)
        {
            //show unprinted shirts
            string query = "SELECT * FROM unprinted_shirts"; ;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgtable.DataSource = dtRecords;
        }

        void history_raw(System.Windows.Forms.Label txtusername)
        {
            try
            {
                //date
                DateTime dateTimeVariable = DateTime.Now;
                string date = dateTimeVariable.ToString("yyyy-MM-dd HH:mm:ss");

                connection.Close();
                connection.Open();
                string logs = "INSERT INTO activity_logs VALUES ('" + txtusername.Text + "', '" + "updated items in Raw Material" + "', '" + date + "')";
                MySqlCommand cmd = new MySqlCommand(logs, connection);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Logs");
                }
                else
                {
                    //MessageBox.Show("Meow");
                }

                connection.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Activities executed by SUPER ADMIN will not be added to Activity logs", "REMINDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        void history_unprint(System.Windows.Forms.Label txtusername)
        {
            try
            {
                //date
                DateTime dateTimeVariable = DateTime.Now;
                string date = dateTimeVariable.ToString("yyyy-MM-dd HH:mm:ss");

                connection.Close();
                connection.Open();
                string logs = "INSERT INTO activity_logs VALUES ('" + txtusername.Text + "', '" + "updated items in Unprinted Shirts" + "', '" + date + "')";
                MySqlCommand cmd = new MySqlCommand(logs, connection);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Logs");
                }
                else
                {
                    //MessageBox.Show("Meow");
                }

                connection.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Activities executed by SUPER ADMIN will not be added to Activity logs", "REMINDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        void history_ready(System.Windows.Forms.Label txtusername)
        {
            try
            {
                //date
                DateTime dateTimeVariable = DateTime.Now;
                string date = dateTimeVariable.ToString("yyyy-MM-dd HH:mm:ss");

                connection.Close();
                connection.Open();
                string logs = "INSERT INTO activity_logs VALUES ('" + txtusername.Text + "', '" + "updated items in Ready to sell items" + "', '" + date + "')";
                MySqlCommand cmd = new MySqlCommand(logs, connection);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Logs");
                }
                else
                {
                    //MessageBox.Show("Meow");
                }

                connection.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Activities executed by SUPER ADMIN will not be added to Activity logs", "REMINDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void update(System.Windows.Forms.ComboBox cbtable, System.Windows.Forms.ComboBox cb1, System.Windows.Forms.ComboBox cb2, System.Windows.Forms.ComboBox cb3, System.Windows.Forms.ComboBox cb4, System.Windows.Forms.ComboBox cb5, System.Windows.Forms.TextBox txt5, System.Windows.Forms.TextBox txtid, System.Windows.Forms.DataGridView dgtable, System.Windows.Forms.Label txtusername)
        {
            //field is blank
            if (cbtable.Text.Equals("") && (cb1.Text.Equals("") || cb2.Text.Equals("") || cb3.Text.Equals("") || cb4.Text.Equals("") || cb5.Text.Equals("") || txt5.Text.Equals("")))
            {
                MessageBox.Show("Field is blank!");
            }
            else
            {

                if (cbtable.SelectedItem.Equals("Raw Materials")) //Raw Materials
                {

                    //field is blank
                    if (cb1.Text.Equals("") || cb2.Text.Equals("") || txt5.Text.Equals(""))
                    {
                        MessageBox.Show("Field is blank!");
                    }
                    else
                    {
                        connection.Close();
                        connection.Open();
                        //update query
                        string updateQuery = "UPDATE raw_material SET material = '" + cb1.Text + "', design = '" + cb2.Text + "', quantity ='" + txt5.Text + "' WHERE id = '" + txtid.Text + "'";
                        MySqlCommand command = new MySqlCommand(updateQuery, connection);

                        try
                        {
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Data successfully changed!", "Successful");
                                raw(dgtable);

                                //history
                                history_raw(txtusername);
                            }
                            else
                            {
                                MessageBox.Show("Data Unsuccessfully changed!", "UnSuccessful");
                                MessageBox.Show("It seems like the data is glitching and having some error.\nTry contacting the super admin for the fix", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    connection.Close();
                }
                else if (cbtable.SelectedItem.Equals("Ready to Sell Items")) //Ready to sell items
                {

                    //field is blank
                    if (cb1.Text.Equals("") || cb2.Text.Equals("") || cb3.Text.Equals("") || cb4.Text.Equals("") || cb5.Text.Equals("") || txt5.Text.Equals(""))
                    {
                        MessageBox.Show("Field is blank!");
                    }
                    else
                    {
                        connection.Close();
                        connection.Open();
                        //update query
                        string updateQuery = "UPDATE ready_to_sell_items SET material = '" + cb1.Text + "', design = '" + cb2.Text + "', color = '" + cb3.Text + "', shade = '" + cb4.Text + "', size ='" + cb5.Text + "', quantity ='" + txt5.Text + "' WHERE id = '" + txtid.Text + "'";
                        MySqlCommand command = new MySqlCommand(updateQuery, connection);

                        try
                        {
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Data successfully changed!", "Successful");
                                ready(dgtable);

                                //history
                                history_ready(txtusername);
                            }
                            else
                            {
                                MessageBox.Show("Data Unsuccessfully changed!", "UnSuccessful");
                                MessageBox.Show("It seems like the data is glitching and having some error.\nTry contacting the super admin for the fix", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    connection.Close();
                }
                else if (cbtable.SelectedItem.Equals("Unprinted Shirts")) //Unprinted Shirts
                {

                    //field is blank
                    if (cb1.Text.Equals("") || cb2.Text.Equals("") || cb3.Text.Equals("") || txt5.Text.Equals(""))
                    {
                        MessageBox.Show("Field is blank!");
                    }
                    else
                    {
                        connection.Close();
                        connection.Open();
                        //update query
                        string updateQuery = "UPDATE unprinted_shirts SET color = '" + cb1.Text + "', shade = '" + cb2.Text + "', size = '" + cb3.Text + "', quantity ='" + txt5.Text + "' WHERE id = '" + txtid.Text + "'";
                        MySqlCommand command = new MySqlCommand(updateQuery, connection);

                        try
                        {
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Data successfully changed!", "Successful");
                                unprint(dgtable);

                                //history
                                history_unprint(txtusername);
                            }
                            else
                            {
                                MessageBox.Show("Data Unsuccessfully changed!", "UnSuccessful");
                                MessageBox.Show("It seems like the data is glitching and having some error.\nTry contacting the super admin for the fix", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    connection.Close();
                }
            }
        }
    }
}

