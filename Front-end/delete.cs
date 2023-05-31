using DigiSort_Box.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace DigiSort_Box.Forms
{
    public partial class delete : Form
    {
        MySqlConnection connection = Host.connection;
        public delete()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtid.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void raw()
        {
            //show raw
            string raw = "SELECT * FROM raw_material";
            MySqlCommand cmd = new MySqlCommand(raw, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgtable.DataSource = dtRecords;
        }

        void ready()
        {
            //show ready to sell items
            string ready = "SELECT * FROM ready_to_sell_items";
            MySqlCommand cmd = new MySqlCommand(ready, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgtable.DataSource = dtRecords;
        }

        void unprint()
        {
            //show unprinted shirts
            string unprint = "SELECT * FROM unprinted_shirts";
            MySqlCommand cmd = new MySqlCommand(unprint, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgtable.DataSource = dtRecords;
        }

        void history_raw()
        {
            //date
            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                connection.Close();
                connection.Open();
                string logs = "INSERT INTO activity_logs VALUES ('" + txtusername.Text + "', '" + "deleted items in Raw Material" + "', '" + date + "')";
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
                MessageBox.Show("Activities executed by SUPER ADMIN will not be added to Activity logs", "REMINDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        void history_unprint()
        {
            //date
            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                connection.Close();
                connection.Open();
                string logs = "INSERT INTO activity_logs VALUES ('" + txtusername.Text + "', '" + "deleted items in Unprinted Shirts" + "', '" + date + "')";
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
                MessageBox.Show("Activities executed by SUPER ADMIN will not be added to Activity logs", "REMINDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        void history_ready()
        {
            //date
            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                connection.Close();
                connection.Open();
                string logs = "INSERT INTO activity_logs VALUES ('" + txtusername.Text + "', '" + "deleted items in Ready to sell items" + "', '" + date + "')";
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
                MessageBox.Show("Activities executed by SUPER ADMIN will not be added to Activity logs", "REMINDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void cbtable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtable.SelectedItem.Equals("Raw Materials"))
            {
                clear();
                connection.Close();
                connection.Open();

                txt5.Enabled = false;
                txt6.Enabled = false;

                raw();

            }
            else if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {
                clear();
                connection.Close();
                connection.Open();

                txt5.Enabled = true;
                txt6.Enabled = true;

                ready();
            }
            else if (cbtable.SelectedItem.Equals("Unprinted Shirts"))
            {
                clear();
                connection.Close();
                connection.Open();

                txt5.Enabled = false;
                txt6.Enabled = false;

                unprint();
            }
        }

        private void dgtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {
                //click cell to show on Ready to Sell Items
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgtable.Rows[e.RowIndex];
                    txtid.Text = dgvRow.Cells[0].Value.ToString();
                    txt1.Text = dgvRow.Cells[1].Value.ToString();
                    txt2.Text = dgvRow.Cells[2].Value.ToString();
                    txt3.Text = dgvRow.Cells[3].Value.ToString();
                    txt4.Text = dgvRow.Cells[4].Value.ToString();
                    txt5.Text = dgvRow.Cells[5].Value.ToString();
                    txt6.Text = dgvRow.Cells[6].Value.ToString();
                }
            }
            else
            {
                //click cell to show
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgtable.Rows[e.RowIndex];
                    txtid.Text = dgvRow.Cells[0].Value.ToString();
                    txt1.Text = dgvRow.Cells[1].Value.ToString();
                    txt2.Text = dgvRow.Cells[2].Value.ToString();
                    txt3.Text = dgvRow.Cells[3].Value.ToString();
                    txt4.Text = dgvRow.Cells[4].Value.ToString();
                }
            }
        }

        private void exitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click_1(object sender, EventArgs e)
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
                    if (txt1.Text.Equals("") || txt2.Text.Equals("") || txt3.Text.Equals("") || txt4.Text.Equals(""))
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
                                raw();

                                //history
                                history_raw();

                                clear();
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
                                ready();

                                //history
                                history_ready();

                                clear();
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
                                unprint();

                                //history
                                history_unprint();

                                clear();
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