using DigiSort_Box.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DigiSort_Box.Forms
{
    public partial class update : Form
    {
        MySqlConnection connection = Host.connection;
        public update()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtid.Text = "";
            cb1.Text = "";
            cb1.Items.Clear();
            cb2.Text = "";
            cb2.Items.Clear();
            cb3.Text = "";
            cb3.Items.Clear();
            cb4.Text = "";
            cb4.Items.Clear();
            cb5.Text = "";
            cb5.Items.Clear();
            txt5.Text = "";
            btnupdate.Enabled = false;
        }

        void raw()
        {
            //show raw
            string query = "SELECT * FROM raw_material";
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



        private void exitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            //Database
            Database.Update upt = new Database.Update();
            upt.update(cbtable, cb1, cb2, cb3, cb4, cb5, txt5, txtid, dgtable, txtusername);

        }

        private void cbtable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtable.SelectedItem.Equals("Raw Materials"))
            {
                clear();
                connection.Close();
                connection.Open();

                cb3.Enabled = false;
                cb4.Enabled = false;
                cb5.Enabled = false;

                raw();

            }
            else if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {
                clear();
                connection.Close();
                connection.Open();

                cb3.Enabled = true;
                cb4.Enabled = true;
                cb5.Enabled = true;

                ready();

            }
            else if (cbtable.SelectedItem.Equals("Unprinted Shirts"))
            {
                clear();
                connection.Close();
                connection.Open();

                cb3.Enabled = true;
                cb4.Enabled = false;
                cb5.Enabled = false;

                unprint();
            }
        }

        private void dgtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnupdate.Enabled = true;
            if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgtable.Rows[e.RowIndex];

                    //Add items on combobox

                    //Id
                    txtid.Text = "";
                    txtid.Text = dgvRow.Cells[0].Value.ToString();

                    //Material
                    cb1.Items.Clear();
                    cb1.Items.Add("");
                    cb1.Items.Add("Vinyl");
                    cb1.Items.Add("Sticker paper");
                    cb1.Items.Add("Laminating film");
                    cb1.Text = dgvRow.Cells[1].Value.ToString();
                    lbltxt1.Text = cb1.Text;

                    //design
                    cb2.Items.Clear();
                    cb2.Items.Add("");
                    cb2.Items.Add("SpyXFamily");
                    cb2.Items.Add("Naruto");
                    cb2.Items.Add("OnePiece");
                    cb2.Items.Add("Black Clover");
                    cb2.Items.Add("Kimetsu no Yaiba");
                    cb2.Items.Add("Bleach");
                    cb2.Items.Add("Boku no tige");
                    cb2.Text = dgvRow.Cells[2].Value.ToString();

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
                    cb3.Text = dgvRow.Cells[3].Value.ToString();

                    //shade
                    cb4.Text = dgvRow.Cells[4].Value.ToString();

                    //size
                    cb5.Items.Clear();
                    cb5.Items.Add("Small");
                    cb5.Items.Add("Medium");
                    cb5.Items.Add("Large");
                    cb5.Items.Add("Extra Large");
                    cb5.Items.Add("2XL");
                    cb5.Items.Add("3XL");
                    cb5.Items.Add("4XL");
                    cb5.Items.Add("5XL");
                    cb5.Text = dgvRow.Cells[5].Value.ToString();

                    //Quantity
                    txt5.Text = dgvRow.Cells[6].Value.ToString();

                }
            }
            else if (cbtable.SelectedItem.Equals("Raw Materials"))
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgtable.Rows[e.RowIndex];

                    //Add items on combobox

                    //Id
                    txtid.Text = "";
                    txtid.Text = dgvRow.Cells[0].Value.ToString();

                    //Materials
                    cb1.Items.Clear();
                    cb1.Items.Add("Vinyl");
                    cb1.Items.Add("Sticker paper");
                    cb1.Items.Add("Laminating film");
                    cb1.Items.Add("DTP.");
                    cb1.Text = dgvRow.Cells[1].Value.ToString();
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
                    cb2.Text = dgvRow.Cells[2].Value.ToString();

                    cb4.Items.Clear();

                    //Quantity
                    txt5.Text = dgvRow.Cells[3].Value.ToString();
                }
            }
            else if (cbtable.SelectedItem.Equals("Unprinted Shirts"))
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgtable.Rows[e.RowIndex];

                    //Add items on combobox

                    //Id
                    txtid.Text = "";
                    txtid.Text = dgvRow.Cells[0].Value.ToString();

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
                    cb1.Text = dgvRow.Cells[1].Value.ToString();
                    lbltxt1.Text = cb1.Text;

                    //shade
                    cb2.Text = dgvRow.Cells[2].Value.ToString();

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
                    cb3.Text = dgvRow.Cells[3].Value.ToString();

                    cb4.Items.Clear();

                    //Quantity
                    txt5.Text = dgvRow.Cells[4].Value.ToString(); ;
                }
            }

        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {


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

        private void cb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {

                if (cb3.SelectedItem.Equals("Red"))
                {
                    cb4.Items.Clear();
                    cb4.Text = "";
                    cb4.Items.Add("Scarlet");
                    cb4.Items.Add("Crimson");
                    cb4.Items.Add("Magenta");
                    cb4.Items.Add("Cardinal");
                    cb4.Items.Add("Cherry");
                }
                else if (cb3.SelectedItem.Equals("Orange"))
                {
                    cb4.Items.Clear();
                    cb4.Text = "";
                    cb4.Items.Add("Tangerine ");
                    cb4.Items.Add("Rust");
                    cb4.Items.Add("Bronze");
                    cb4.Items.Add("Neon");
                    cb4.Items.Add("Fire");
                }
                else if (cb3.SelectedItem.Equals("Yellow"))
                {
                    cb4.Items.Clear();
                    cb4.Text = "";
                    cb4.Items.Add("Mustard");
                    cb4.Items.Add("Corn");
                    cb4.Items.Add("Pineapple");
                    cb4.Items.Add("Marigold");
                    cb4.Items.Add("Royal");
                }
                else if (cb3.SelectedItem.Equals("Green"))
                {
                    cb4.Items.Clear();
                    cb4.Text = "";
                    cb4.Items.Add("Moss");
                    cb4.Items.Add("Pine");
                    cb4.Items.Add("Military");
                    cb4.Items.Add("Evergreen");
                    cb4.Items.Add("Emerald");
                }
                else if (cb3.SelectedItem.Equals("Blue"))
                {
                    cb4.Items.Clear();
                    cb4.Text = "";
                    cb4.Items.Add("Sky");
                    cb4.Items.Add("Iris");
                    cb4.Items.Add("Royal");
                    cb4.Items.Add("Navy");
                    cb4.Items.Add("Carolina");
                }
                else if (cb3.SelectedItem.Equals("Purple"))
                {
                    cb4.Items.Clear();
                    cb4.Text = "";
                    cb4.Items.Add("Lavender");
                    cb4.Items.Add("Lilac");
                    cb4.Items.Add("Mauve");
                    cb4.Items.Add("Plum");
                    cb4.Items.Add("Grape");
                    cb4.Items.Add("Violet");
                    cb4.Items.Add("Amethyst");
                    cb4.Items.Add("Eggplant");
                    cb4.Items.Add("Magenta");
                    cb4.Items.Add("Mulberry");
                }
                else if (cb3.SelectedItem.Equals("White"))
                {
                    cb4.Items.Clear();
                    cb4.Text = "";
                    cb4.Items.Add("Snow");
                    cb4.Items.Add("Ivory");
                    cb4.Items.Add("Pearl");
                    cb4.Items.Add("Creamy");
                    cb4.Items.Add("Off-white");
                    cb4.Items.Add("Eggshell");
                    cb4.Items.Add("Pure white");
                    cb4.Items.Add("Antique ");
                    cb4.Items.Add("Linen");
                    cb4.Items.Add("Champagne ");
                }
                else if (cb3.SelectedItem.Equals("Brown"))
                {
                    cb4.Items.Clear();
                    cb4.Text = "";
                    cb4.Items.Add("Beige");
                    cb4.Items.Add("Tan");
                    cb4.Items.Add("Taupe");
                    cb4.Items.Add("Caramel");
                    cb4.Items.Add("Chestnut");
                    cb4.Items.Add("Coffee");
                    cb4.Items.Add("Mahogany");
                    cb4.Items.Add("Rust");
                    cb4.Items.Add("Sienna");
                    cb4.Items.Add("Umber");
                }
                else if (cb3.SelectedItem.Equals("Gray"))
                {
                    cb4.Items.Clear();
                    cb4.Text = "";
                    cb4.Items.Add("Silver");
                    cb4.Items.Add("Rain");
                    cb4.Items.Add("Blue Gray");
                    cb4.Items.Add("Dark");
                    cb4.Items.Add("Medium");
                    cb4.Items.Add("Light slate");
                    cb4.Items.Add("Battleship");
                    cb4.Items.Add("Cool");
                    cb4.Items.Add("Gray-blue");
                    cb4.Items.Add("Gray-green");
                }
                else if (cb3.SelectedItem.Equals("Black"))
                {
                    cb4.Items.Clear();
                    cb4.Text = "";
                    cb4.Items.Add("Jet");
                    cb4.Items.Add("Onyx");
                    cb4.Items.Add("Midnight");
                    cb4.Items.Add("Ebony");
                    cb4.Items.Add("Licorice");
                    cb4.Items.Add("Charcoal");
                    cb4.Items.Add("Coal");
                    cb4.Items.Add("Raven");
                    cb4.Items.Add("Pitch");
                    cb4.Items.Add("Ink");
                }
            }
        }
    }
}
