using DigiSort_Box.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    public class delete
    {
        MySqlConnection connection = Host.connection;

        void clear(System.Windows.Forms.ComboBox cbtable, System.Windows.Forms.TextBox txt1, System.Windows.Forms.TextBox txt2, System.Windows.Forms.TextBox txt3, System.Windows.Forms.TextBox txt4, System.Windows.Forms.TextBox txt5, System.Windows.Forms.TextBox txt6, System.Windows.Forms.TextBox txtid, System.Windows.Forms.Label txtusername, System.Windows.Forms.DataGridView dgtable)
        {
            txtid.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
        }

        void raw(System.Windows.Forms.DataGridView dgtable)
        {
            //show raw
            string raw = "SELECT * FROM raw_material";
            MySqlCommand cmd = new MySqlCommand(raw, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgtable.DataSource = dtRecords;
        }

        void ready(System.Windows.Forms.DataGridView dgtable)
        {
            //show ready to sell items
            string ready = "SELECT * FROM ready_to_sell_items";
            MySqlCommand cmd = new MySqlCommand(ready, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgtable.DataSource = dtRecords;
        }

        void unprint(System.Windows.Forms.DataGridView dgtable)
        {
            //show unprinted shirts
            string unprint = "SELECT * FROM unprinted_shirts";
            MySqlCommand cmd = new MySqlCommand(unprint, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgtable.DataSource = dtRecords;
        }

        void history_raw(System.Windows.Forms.Label txtusername)
        {
            //id
            connection.Close();
            connection.Open();
            string id = "SELECT id FROM account WHERE username = '" + txtusername.Text + "'";
            MySqlCommand idcmd = new MySqlCommand(id, connection);
            MySqlDataReader row = idcmd.ExecuteReader();

            if (row.Read())
            {
                string ids = row["id"].ToString();

                //date
                DateTime dateTimeVariable = DateTime.Now;
                string date = dateTimeVariable.ToString("yyyy-MM-dd HH:mm:ss");

                try
                {
                    row.Close();
                    connection.Close();
                    connection.Open();
                    string logs = "INSERT INTO activity_logs VALUES ('" + ids + "', '" + txtusername.Text + "', '" + "deleted items in Raw Material" + "', '" + date + "')";
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
                catch (Exception e)
                {
                    //MessageBox.Show("Activities executed by SUPER ADMIN will not be added to Activity logs", "REMINDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }




        }

        void history_unprint(System.Windows.Forms.Label txtusername)
        {
            //id
            connection.Close();
            connection.Open();
            string id = "SELECT id FROM account WHERE username = '" + txtusername.Text + "'";
            MySqlCommand idcmd = new MySqlCommand(id, connection);
            MySqlDataReader row = idcmd.ExecuteReader();

            if (row.Read())
            {
                string ids = row["id"].ToString();

                //date
                DateTime dateTimeVariable = DateTime.Now;
                string date = dateTimeVariable.ToString("yyyy-MM-dd HH:mm:ss");

                try
                {
                    connection.Close();
                    connection.Open();
                    string logs = "INSERT INTO activity_logs VALUES ('" + ids + "', '" + txtusername.Text + "', '" + "deleted items in Unprinted Shirts" + "', '" + date + "')";
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
        }

        void history_ready(System.Windows.Forms.Label txtusername)
        {
            //id
            connection.Close();
            connection.Open();
            string id = "SELECT id FROM account WHERE username = '" + txtusername.Text + "'";
            MySqlCommand idcmd = new MySqlCommand(id, connection);
            MySqlDataReader row = idcmd.ExecuteReader();

            if (row.Read())
            {
                string ids = row["id"].ToString();

                //date
                DateTime dateTimeVariable = DateTime.Now;
                string date = dateTimeVariable.ToString("yyyy-MM-dd HH:mm:ss");

                try
                {
                    connection.Close();
                    connection.Open();
                    string logs = "INSERT INTO activity_logs VALUES ('" + ids + "', '" + txtusername.Text + "', '" + "deleted items in Ready to sell items" + "', '" + date + "')";
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
        }

        public void dlt(System.Windows.Forms.ComboBox cbtable, System.Windows.Forms.TextBox txt1, System.Windows.Forms.TextBox txt2, System.Windows.Forms.TextBox txt3, System.Windows.Forms.TextBox txt4, System.Windows.Forms.TextBox txt5, System.Windows.Forms.TextBox txt6, System.Windows.Forms.TextBox txtid, System.Windows.Forms.Label txtusername, System.Windows.Forms.DataGridView dgtable)
        {
            //field is blank
            if (cbtable.Text.Equals("") && (txt1.Text.Equals("") || txt2.Text.Equals("") || txt3.Text.Equals("") || txt4.Text.Equals("") || txt5.Text.Equals("")))
            {
                MessageBox.Show("Field is blank!");
            }
            else
            {
                if (cbtable.SelectedItem.Equals("Raw Materials"))
                {
                    //field is blank
                    if (txt1.Text.Equals("") || txt2.Text.Equals("") || txt3.Text.Equals(""))
                    {
                        MessageBox.Show("Field is blank!");
                    }
                    else
                    {
                        connection.Close();
                        connection.Open();
                        //update query
                        string deleteQuery = "DELETE FROM raw_material WHERE id = '" + txtid.Text + "'";
                        MySqlCommand command = new MySqlCommand(deleteQuery, connection);

                        try
                        {
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Data successfully deleted!", "Successful");
                                raw(dgtable);

                                //history
                                history_raw(txtusername);

                                clear(cbtable, txt1, txt2, txt3, txt4, txt5, txt6, txtid, txtusername, dgtable);
                            }
                            else
                            {
                                MessageBox.Show("Data Unsuccessfully deleted!", "UnSuccessful");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    connection.Close();
                }
                else if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
                {
                    //field is blank
                    if (txt1.Text.Equals("") || txt2.Text.Equals("") || txt3.Text.Equals("") || txt4.Text.Equals("") || txt5.Text.Equals(""))
                    {
                        MessageBox.Show("Field is blank!");
                    }
                    else
                    {
                        connection.Close();
                        connection.Open();
                        //delete query
                        string updateQuery = "DELETE FROM ready_to_sell_items WHERE id = '" + txtid.Text + "'";
                        MySqlCommand command = new MySqlCommand(updateQuery, connection);

                        try
                        {
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Data successfully deleted!", "Successful");
                                ready(dgtable);

                                //history
                                history_ready(txtusername);

                                clear(cbtable, txt1, txt2, txt3, txt4, txt5, txt6, txtid, txtusername, dgtable);
                            }
                            else
                            {
                                MessageBox.Show("Data Unsuccessfully deleted!", "UnSuccessful");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    connection.Close();
                }
                else if (cbtable.SelectedItem.Equals("Unprinted Shirts"))
                {
                    //field is blank
                    if (txt1.Text.Equals("") || txt2.Text.Equals("") || txt3.Text.Equals("") || txt4.Text.Equals(""))
                    {
                        MessageBox.Show("Field is blank!");
                    }
                    else
                    {
                        connection.Close();
                        connection.Open();
                        //update query
                        string updateQuery = "DELETE FROM unprinted_shirts WHERE id = '" + txtid.Text + "'";
                        MySqlCommand command = new MySqlCommand(updateQuery, connection);

                        try
                        {
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Data successfully deleted!", "Successful");
                                unprint(dgtable);

                                //history
                                history_unprint(txtusername);

                                clear(cbtable, txt1, txt2, txt3, txt4, txt5, txt6, txtid, txtusername, dgtable);
                            }
                            else
                            {
                                MessageBox.Show("Data Unsuccessfully deleted!", "UnSuccessful");
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
