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
                MessageBox.Show("Activities executed by SUPER ADMIN will not be added to Activity logs", "REMINDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        void history_unprint()
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
                MessageBox.Show("Activities executed by SUPER ADMIN will not be added to Activity logs", "REMINDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        void history_ready()
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
                MessageBox.Show("Activities executed by SUPER ADMIN will not be added to Activity logs", "REMINDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void exitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            //field is blank
            if (cbtable.Text.Equals("") && (cb1.Text.Equals("") || cb2.Text.Equals("") || cb3.Text.Equals("") || cb4.Text.Equals("") || txt5.Text.Equals("")))
            {
                MessageBox.Show("Field is blank!");
            }
            else
            {

                if (cbtable.SelectedItem.Equals("Raw Materials")) //Raw Materials
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
                    if (cb1.Text.Equals("") || cb2.Text.Equals("") || cb3.Text.Equals("") || cb4.Text.Equals("") || txt5.Text.Equals(""))
                    {
                        MessageBox.Show("Field is blank!");
                    }
                    else
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

        private void cbtable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtable.SelectedItem.Equals("Raw Materials"))
            {
                clear();
                connection.Close();
                connection.Open();

                raw();

            }
            else if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {
                clear();
                connection.Close();
                connection.Open();

                ready();

            }
            else if (cbtable.SelectedItem.Equals("Unprinted Shirts"))
            {
                clear();
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

                    //shade
                    cb3.Text = dgvRow.Cells[2].Value.ToString();

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
            else if (cbtable.SelectedItem.Equals("Raw Materials"))
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
            else if (cbtable.SelectedItem.Equals("Unprinted Shirts"))
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
                    lbltxt1.Text = cb1.Text;

                    //shade
                    cb2.Text = dgvRow.Cells[1].Value.ToString();

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

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {

                if (cb2.SelectedItem.Equals("Red"))
                {
                    cb3.Items.Clear();
                    cb3.Text = "";
                    cb3.Items.Add("Scarlet");
                    cb3.Items.Add("Crimson");
                    cb3.Items.Add("Magenta");
                    cb3.Items.Add("Cardinal");
                    cb3.Items.Add("Cherry");
                }
                else if (cb2.SelectedItem.Equals("Orange"))
                {
                    cb3.Items.Clear();
                    cb3.Text = "";
                    cb3.Items.Add("Tangerine ");
                    cb3.Items.Add("Rust");
                    cb3.Items.Add("Bronze");
                    cb3.Items.Add("Neon");
                    cb3.Items.Add("Fire");
                }
                else if (cb2.SelectedItem.Equals("Yellow"))
                {
                    cb3.Items.Clear();
                    cb3.Text = "";
                    cb3.Items.Add("Mustard");
                    cb3.Items.Add("Corn");
                    cb3.Items.Add("Pineapple");
                    cb3.Items.Add("Marigold");
                    cb3.Items.Add("Royal");
                }
                else if (cb2.SelectedItem.Equals("Green"))
                {
                    cb3.Items.Clear();
                    cb3.Text = "";
                    cb3.Items.Add("Moss");
                    cb3.Items.Add("Pine");
                    cb3.Items.Add("Military");
                    cb3.Items.Add("Evergreen");
                    cb3.Items.Add("Emerald");
                }
                else if (cb2.SelectedItem.Equals("Blue"))
                {
                    cb3.Items.Clear();
                    cb3.Text = "";
                    cb3.Items.Add("Sky");
                    cb3.Items.Add("Iris");
                    cb3.Items.Add("Royal");
                    cb3.Items.Add("Navy");
                    cb3.Items.Add("Carolina");
                }
                else if (cb2.SelectedItem.Equals("Purple"))
                {
                    cb3.Items.Clear();
                    cb3.Text = "";
                    cb3.Items.Add("Lavender");
                    cb3.Items.Add("Lilac");
                    cb3.Items.Add("Mauve");
                    cb3.Items.Add("Plum");
                    cb3.Items.Add("Grape");
                    cb3.Items.Add("Violet");
                    cb3.Items.Add("Amethyst");
                    cb3.Items.Add("Eggplant");
                    cb3.Items.Add("Magenta");
                    cb3.Items.Add("Mulberry");
                }
                else if (cb2.SelectedItem.Equals("White"))
                {
                    cb3.Items.Clear();
                    cb3.Text = "";
                    cb3.Items.Add("Snow");
                    cb3.Items.Add("Ivory");
                    cb3.Items.Add("Pearl");
                    cb3.Items.Add("Creamy");
                    cb3.Items.Add("Off-white");
                    cb3.Items.Add("Eggshell");
                    cb3.Items.Add("Pure white");
                    cb3.Items.Add("Antique ");
                    cb3.Items.Add("Linen");
                    cb3.Items.Add("Champagne ");
                }
                else if (cb2.SelectedItem.Equals("Brown"))
                {
                    cb3.Items.Clear();
                    cb3.Text = "";
                    cb3.Items.Add("Beige");
                    cb3.Items.Add("Tan");
                    cb3.Items.Add("Taupe");
                    cb3.Items.Add("Caramel");
                    cb3.Items.Add("Chestnut");
                    cb3.Items.Add("Coffee");
                    cb3.Items.Add("Mahogany");
                    cb3.Items.Add("Rust");
                    cb3.Items.Add("Sienna");
                    cb3.Items.Add("Umber");
                }
                else if (cb2.SelectedItem.Equals("Gray"))
                {
                    cb3.Items.Clear();
                    cb3.Text = "";
                    cb3.Items.Add("Silver");
                    cb3.Items.Add("Rain");
                    cb3.Items.Add("Blue Gray");
                    cb3.Items.Add("Dark");
                    cb3.Items.Add("Medium");
                    cb3.Items.Add("Light slate");
                    cb3.Items.Add("Battleship");
                    cb3.Items.Add("Cool");
                    cb3.Items.Add("Gray-blue");
                    cb3.Items.Add("Gray-green");
                }
                else if (cb2.SelectedItem.Equals("Black"))
                {
                    cb3.Items.Clear();
                    cb3.Text = "";
                    cb3.Items.Add("Jet");
                    cb3.Items.Add("Onyx");
                    cb3.Items.Add("Midnight");
                    cb3.Items.Add("Ebony");
                    cb3.Items.Add("Licorice");
                    cb3.Items.Add("Charcoal");
                    cb3.Items.Add("Coal");
                    cb3.Items.Add("Raven");
                    cb3.Items.Add("Pitch");
                    cb3.Items.Add("Ink");
                }
            }

        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtable.SelectedItem.Equals("Unprinted Shirts"))
            {
                if (cb1.SelectedItem.Equals("Red"))
                {
                    cb2.Items.Clear();
                    cb2.Text = "";
                    cb2.Items.Add("Scarlet");
                    cb2.Items.Add("Crimson");
                    cb2.Items.Add("Magenta");
                    cb2.Items.Add("Cardinal");
                    cb2.Items.Add("Cherry");
                }
                else if (cb1.SelectedItem.Equals("Orange"))
                {
                    cb2.Items.Clear();
                    cb2.Text = "";
                    cb2.Items.Add("Tangerine ");
                    cb2.Items.Add("Rust");
                    cb2.Items.Add("Bronze");
                    cb2.Items.Add("Neon");
                    cb2.Items.Add("Fire");
                }
                else if (cb1.SelectedItem.Equals("Yellow"))
                {
                    cb2.Items.Clear();
                    cb2.Text = "";
                    cb2.Items.Add("Mustard");
                    cb2.Items.Add("Corn");
                    cb2.Items.Add("Pineapple");
                    cb2.Items.Add("Marigold");
                    cb2.Items.Add("Royal");
                }
                else if (cb1.SelectedItem.Equals("Green"))
                {
                    cb2.Items.Clear();
                    cb2.Text = "";
                    cb2.Items.Add("Moss");
                    cb2.Items.Add("Pine");
                    cb2.Items.Add("Military");
                    cb2.Items.Add("Evergreen");
                    cb2.Items.Add("Emerald");
                }
                else if (cb1.SelectedItem.Equals("Blue"))
                {
                    cb2.Items.Clear();
                    cb2.Text = "";
                    cb2.Items.Add("Sky");
                    cb2.Items.Add("Iris");
                    cb2.Items.Add("Royal");
                    cb2.Items.Add("Navy");
                    cb2.Items.Add("Carolina");
                }
                else if (cb1.SelectedItem.Equals("Purple"))
                {
                    cb2.Items.Clear();
                    cb2.Text = "";
                    cb2.Items.Add("Lavender");
                    cb2.Items.Add("Lilac");
                    cb2.Items.Add("Mauve");
                    cb2.Items.Add("Plum");
                    cb2.Items.Add("Grape");
                    cb2.Items.Add("Violet");
                    cb2.Items.Add("Amethyst");
                    cb2.Items.Add("Eggplant");
                    cb2.Items.Add("Magenta");
                    cb2.Items.Add("Mulberry");
                }
                else if (cb1.SelectedItem.Equals("White"))
                {
                    cb2.Items.Clear();
                    cb2.Text = "";
                    cb2.Items.Add("Snow");
                    cb2.Items.Add("Ivory");
                    cb2.Items.Add("Pearl");
                    cb2.Items.Add("Creamy");
                    cb2.Items.Add("Off-white");
                    cb2.Items.Add("Eggshell");
                    cb2.Items.Add("Pure white");
                    cb2.Items.Add("Antique ");
                    cb2.Items.Add("Linen");
                    cb2.Items.Add("Champagne ");
                }
                else if (cb1.SelectedItem.Equals("Brown"))
                {
                    cb2.Items.Clear();
                    cb2.Text = "";
                    cb2.Items.Add("Beige");
                    cb2.Items.Add("Tan");
                    cb2.Items.Add("Taupe");
                    cb2.Items.Add("Caramel");
                    cb2.Items.Add("Chestnut");
                    cb2.Items.Add("Coffee");
                    cb2.Items.Add("Mahogany");
                    cb2.Items.Add("Rust");
                    cb2.Items.Add("Sienna");
                    cb2.Items.Add("Umber");
                }
                else if (cb1.SelectedItem.Equals("Gray"))
                {
                    cb2.Items.Clear();
                    cb2.Text = "";
                    cb2.Items.Add("Silver");
                    cb2.Items.Add("Rain");
                    cb2.Items.Add("Blue Gray");
                    cb2.Items.Add("Dark");
                    cb2.Items.Add("Medium");
                    cb2.Items.Add("Light slate");
                    cb2.Items.Add("Battleship");
                    cb2.Items.Add("Cool");
                    cb2.Items.Add("Gray-blue");
                    cb2.Items.Add("Gray-green");
                }
                else if (cb1.SelectedItem.Equals("Black"))
                {
                    cb2.Items.Clear();
                    cb2.Text = "";
                    cb2.Items.Add("Jet");
                    cb2.Items.Add("Onyx");
                    cb2.Items.Add("Midnight");
                    cb2.Items.Add("Ebony");
                    cb2.Items.Add("Licorice");
                    cb2.Items.Add("Charcoal");
                    cb2.Items.Add("Coal");
                    cb2.Items.Add("Raven");
                    cb2.Items.Add("Pitch");
                    cb2.Items.Add("Ink");
                }
            }
        }
    }
}
