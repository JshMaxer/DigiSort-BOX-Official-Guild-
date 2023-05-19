using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DigiSort_Box.Forms
{
    public partial class update : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=; convert zero datetime=true;allow user variables=true;");
        public update()
        {
            InitializeComponent();
        }

        void clear()
        {
            cb1.Text = "";
            cb1.Items.Clear();
            cb2.Text = "";
            cb2.Items.Clear();
            cb3.Text = "";
            cb3.Items.Clear();
            cb4.Text = "";
            cb4.Items.Clear();
            txt5.Text = "";
        }

        void raw()
        {
            //show raw
            string query = "SELECT * FROM raw_material"; ;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgtable.DataSource = dtRecords;
        }

        void ready()
        {
            //show ready to sell items
            string query = "SELECT * FROM ready_to_sell_items"; ;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgtable.DataSource = dtRecords;
        }

        void unprint()
        {
            //show unprinted shirts
            string query = "SELECT * FROM unprinted_shirts"; ;
            MySqlCommand cmd = new MySqlCommand(query, connection);
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

            connection.Close();
            connection.Open();
            string logs = "INSERT INTO activity_logs VALUES ('" + txtusername.Text + "', '" + "updated items in Raw Material" + "', '" +  date + "')";
            MySqlCommand cmd = new MySqlCommand(logs, connection);

            if(cmd.ExecuteNonQuery() == 1)
            {
                //MessageBox.Show("Logs");
            }
            else
            {
                //MessageBox.Show("Meow");
            }

            connection.Close();
        }

        void history_unprint()
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

        void history_ready()
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

        private void exitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            if (cb1.Text.Equals("") || cb2.Text.Equals("") || cb3.Text.Equals("") || cb4.Text.Equals(""))
            {
                MessageBox.Show("Field is blank!");
            }
            else
            {
                if (cbtable.SelectedItem.Equals("Raw Materials")) //Raw Materials
                {
                    connection.Close();
                    connection.Open();
                    //update query
                    string updateQuery = "UPDATE raw_material SET material = '" + cb1.Text + "', design = '" + cb2.Text + "', color = '" + cb3.Text + "', quantity ='" + txt5.Text + "' WHERE material = '" + lbltxt1.Text + "'";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);

                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Data updated", "Successful");
                            raw();

                            //history
                            history_raw();
                        }
                        else
                        {
                            MessageBox.Show("Data not-updated", "UnSuccessful");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }
                else if (cbtable.SelectedItem.Equals("Ready to Sell Items")) //Ready to sell items
                {
                    connection.Close();
                    connection.Open();
                    //update query
                    string updateQuery = "UPDATE ready_to_sell_items SET product_name = '" + cb1.Text + "', color = '" + cb2.Text + "', shade = '" + cb3.Text + "', size ='" + cb4.Text + "', quantity ='" + txt5.Text + "' WHERE product_name = '" + lbltxt1.Text + "'";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);

                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Data updated", "Successful");
                            ready();

                            //history
                            history_ready();
                        }
                        else
                        {
                            MessageBox.Show("Data not-updated", "UnSuccessful");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }
                else if (cbtable.SelectedItem.Equals("Unprinted Shirts")) //Unprinted Shirts
                {
                    connection.Close();
                    connection.Open();
                    //update query
                    string updateQuery = "UPDATE unprinted_shirts SET color = '" + cb1.Text + "', shade = '" + cb2.Text + "', size = '" + cb3.Text + "', quantity ='" + txt5.Text + "' WHERE color = '" + lbltxt1.Text + "'";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);

                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Data updated", "Successful");
                            unprint();

                            //history
                            history_unprint();
                        }
                        else
                        {
                            MessageBox.Show("Data not-updated", "UnSuccessful");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }
            }

        }

        private void cbtable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtable.SelectedItem.Equals("Raw Materials"))
            {
                clear();
                txt5.Visible = false;
                connection.Close();
                connection.Open();

                raw();

            }
            else if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {
                clear();
                txt5.Visible = true;
                connection.Close();
                connection.Open();

                ready();

            }
            else if (cbtable.SelectedItem.Equals("Unprinted Shirts"))
            {
                clear();
                txt5.Visible = false;
                connection.Close();
                connection.Open();

                unprint();
            }
        }

        private void dgtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgtable.Rows[e.RowIndex];

                    //Add items on combobox

                    //Product name
                    cb1.Items.Clear();
                    cb1.Items.Add("SpyXFamily");
                    cb1.Items.Add("Naruto");
                    cb1.Items.Add("OnePiece");
                    cb1.Items.Add("Black Clover");
                    cb1.Items.Add("Kimetsu no Yaiba");
                    cb1.Items.Add("Bleach");
                    cb1.Items.Add("Boku no tige");
                    cb1.Text = dgvRow.Cells[0].Value.ToString();
                    lbltxt1.Text = cb1.Text;

                    //Color
                    cb2.Items.Clear();
                    cb2.Items.Add("Red");
                    cb2.Items.Add("Orange");
                    cb2.Items.Add("Yellow");
                    cb2.Items.Add("Green");
                    cb2.Items.Add("Blue");
                    cb2.Items.Add("Purple");
                    cb2.Items.Add("White");
                    cb2.Items.Add("Brown");
                    cb2.Items.Add("Gray");
                    cb2.Items.Add("Black");
                    cb2.Text = dgvRow.Cells[1].Value.ToString();

                    /*
                    //shade
                    cb3.Items.Clear();
                    cb3.Items.Add("Red");
                    cb3.Items.Add("Orange");
                    cb3.Items.Add("Yellow");
                    cb3.Items.Add("Green");
                    cb3.Items.Add("Blue");
                    cb3.Items.Add("Purple");
                    cb3.Items.Add("White");
                    cb3.Items.Add("Brown");
                    cb3.Items.Add("Gray");
                    cb3.Items.Add("Black");
                    cb3.Text = dgvRow.Cells[2].Value.ToString();
                    */

                    //size
                    cb4.Visible = true;
                    cb4.Items.Clear();
                    cb4.Items.Add("Small");
                    cb4.Items.Add("Medium");
                    cb4.Items.Add("Large");
                    cb4.Items.Add("Extra Large");
                    cb4.Items.Add("2XL");
                    cb4.Items.Add("3XL");
                    cb4.Items.Add("4XL");
                    cb4.Items.Add("5XL");
                    cb4.Text = dgvRow.Cells[3].Value.ToString();

                    //Quantity
                    txt5.Text = dgvRow.Cells[4].Value.ToString();
                    txt5.Visible = true;

                }
            }
            else if(cbtable.SelectedItem.Equals("Raw Materials"))
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgtable.Rows[e.RowIndex];

                    //Add items on combobox

                    //Materials
                    cb1.Items.Clear();
                    cb1.Items.Add("Vinyl");
                    cb1.Items.Add("Sticker paper");
                    cb1.Items.Add("Laminating film");
                    cb1.Items.Add("DTP.");
                    cb1.Text = dgvRow.Cells[0].Value.ToString();
                    lbltxt1.Text = cb1.Text;

                    //Design
                    cb2.Items.Clear();
                    cb2.Items.Add("SpyXFamily");
                    cb2.Items.Add("Naruto");
                    cb2.Items.Add("OnePiece");
                    cb2.Items.Add("Black Clover");
                    cb2.Items.Add("Kimetsu no Yaiba");
                    cb2.Items.Add("Bleach");
                    cb2.Items.Add("Boku no tige");
                    cb2.Text = dgvRow.Cells[1].Value.ToString();

                    //Color
                    cb3.Items.Clear();
                    cb3.Items.Add("Red");
                    cb3.Items.Add("Orange");
                    cb3.Items.Add("Yellow");
                    cb3.Items.Add("Green");
                    cb3.Items.Add("Blue");
                    cb3.Items.Add("Purple");
                    cb3.Items.Add("White");
                    cb3.Items.Add("Brown");
                    cb3.Items.Add("Gray");
                    cb3.Items.Add("Black");
                    cb3.Text = dgvRow.Cells[2].Value.ToString();

                    //visible
                    cb4.Items.Clear();
                    cb4.Visible = false;

                    //Quantity
                    txt5.Text = dgvRow.Cells[3].Value.ToString();
                    txt5.Visible = true;
                }
            }
            else if(cbtable.SelectedItem.Equals("Unprinted Shirts"))
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgtable.Rows[e.RowIndex];

                    //Add items on combobox

                    //Color
                    cb1.Items.Clear();
                    cb1.Items.Add("Red");
                    cb1.Items.Add("Orange");
                    cb1.Items.Add("Yellow");
                    cb1.Items.Add("Green");
                    cb1.Items.Add("Blue");
                    cb1.Items.Add("Purple");
                    cb1.Items.Add("White");
                    cb1.Items.Add("Brown");
                    cb1.Items.Add("Gray");
                    cb1.Items.Add("Black");
                    cb1.Text = dgvRow.Cells[0].Value.ToString();

                    /*
                    //shade
                    cb2.Items.Clear();
                    cb2.Items.Add("SpyXFamily");
                    cb2.Items.Add("Naruto");
                    cb2.Items.Add("OnePiece");
                    cb2.Items.Add("Black Clover");
                    cb2.Items.Add("Kimetsu no Yaiba");
                    cb2.Items.Add("Bleach");
                    cb2.Items.Add("Boku no tige");
                    cb2.Text = dgvRow.Cells[1].Value.ToString();
                    */

                    //size
                    cb3.Items.Clear();
                    cb3.Items.Add("Small");
                    cb3.Items.Add("Medium");
                    cb3.Items.Add("Large");
                    cb3.Items.Add("Extra Large");
                    cb3.Items.Add("2XL");
                    cb3.Items.Add("3XL");
                    cb3.Items.Add("4XL");
                    cb3.Items.Add("5XL");
                    cb3.Text = dgvRow.Cells[2].Value.ToString();

                    //visible
                    cb4.Items.Clear();
                    cb4.Visible = false;

                    //Quantity
                    txt5.Text = dgvRow.Cells[3].Value.ToString();
                    txt5.Visible = true;
                }
            }

        }
    }
}
