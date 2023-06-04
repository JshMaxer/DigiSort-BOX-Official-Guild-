using DigiSort_Box.Model;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System.Data;

namespace DigiSort_Box.Database
{
    public class Inventory
    {
        MySqlConnection connection = Host.connection;

        DataTable dtRaw = new DataTable();
        DataTable dtUnprinted = new DataTable();
        DataTable dtReady = new DataTable();
        DataTable dtrawdamage = new DataTable();
        DataTable dtunprintdamage = new DataTable();
        DataTable dtreadydamage = new DataTable();

        public void InvLoad(System.Windows.Forms.DataGridView dgrawmaterial, System.Windows.Forms.DataGridView dgunprinted, System.Windows.Forms.DataGridView dgready, System.Windows.Forms.DataGridView dgrawdamage, System.Windows.Forms.DataGridView dgreadydamage, System.Windows.Forms.DataGridView dgunprinteddamage)
        {
            connection.Close();
            connection.Open();

            raw(dgrawmaterial);
            unprint(dgunprinted);
            ready(dgready);
            rawdamage(dgrawdamage);
            unprintdamage(dgunprinteddamage);
            readydamage(dgreadydamage);

            connection.Close();
        }

        void raw(System.Windows.Forms.DataGridView dgrawmaterial)
        {
            connection.Close();
            connection.Open();

            string query = "SELECT * FROM raw_material";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtRaw.Load(sdr);
            dgrawmaterial.DataSource = dtRaw;

            connection.Close();
        }
        void unprint(System.Windows.Forms.DataGridView dgunprinted)
        {
            connection.Close();
            connection.Open();

            string query = "SELECT * FROM unprinted_shirts";
            MySqlCommand unprint = new MySqlCommand(query, connection);
            MySqlDataReader sdr = unprint.ExecuteReader();
            dtUnprinted.Load(sdr);
            dgunprinted.DataSource = dtUnprinted;

            connection.Close();
        }
        void ready(System.Windows.Forms.DataGridView dgready)
        {
            connection.Close();
            connection.Open();

            string query = "SELECT * FROM ready_to_sell_items";
            MySqlCommand unprint = new MySqlCommand(query, connection);
            MySqlDataReader sdr = unprint.ExecuteReader();
            dtReady.Load(sdr);
            dgready.DataSource = dtReady;

            connection.Close();
        }

        void rawdamage(System.Windows.Forms.DataGridView dgrawdamage)
        {
            connection.Close();
            connection.Open();

            string rawdamage = "SELECT * FROM raw_material_damage_items";
            MySqlCommand cmd = new MySqlCommand(rawdamage, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtrawdamage.Load(sdr);
            dgrawdamage.DataSource = dtrawdamage;

            connection.Close();
        }
        void readydamage(System.Windows.Forms.DataGridView dgreadydamage)
        {
            connection.Close();
            connection.Open();

            string readydamage = "SELECT * FROM ready_to_sell_items_damage_items";
            MySqlCommand cmd = new MySqlCommand(readydamage, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtreadydamage.Load(sdr);
            dgreadydamage.DataSource = dtreadydamage;

            connection.Close();
        }
        void unprintdamage(System.Windows.Forms.DataGridView dgunprinteddamage)
        {
            connection.Close();
            connection.Open();

            string unprintdamage = "SELECT * FROM unprinted_shirts_damage_items";
            MySqlCommand cmd = new MySqlCommand(unprintdamage, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtunprintdamage.Load(sdr);
            dgunprinteddamage.DataSource = dtunprintdamage;

            connection.Close();
        }


        public void rawSearch(Guna2TextBox txtsearch, System.Windows.Forms.DataGridView dgrawmaterial)
        {
            connection.Close();
            connection.Open();
            if (txtsearch.Text.Equals(""))
            {
                string searchquery = "SELECT * FROM raw_material";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgrawmaterial.DataSource = tbl;
            }
            else
            {
                string searchquery = "SELECT * FROM raw_material WHERE material LIKE '" + txtsearch.Text + "%'";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgrawmaterial.DataSource = tbl;
            }
        }

        public void readySearch(Guna2TextBox txtsearch, System.Windows.Forms.DataGridView dgready)
        {
            connection.Close();
            connection.Open();
            if (txtsearch.Text.Equals(""))
            {
                string searchquery = "SELECT * FROM ready_to_sell_items";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgready.DataSource = tbl;
            }
            else
            {
                string searchquery = "SELECT * FROM ready_to_sell_items WHERE material LIKE '" + txtsearch.Text + "%'";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgready.DataSource = tbl;
            }
        }

        public void unprintSearch(Guna2TextBox txtsearch, System.Windows.Forms.DataGridView dgunprinted)
        {
            connection.Close();
            connection.Open();
            if (txtsearch.Text.Equals(""))
            {
                string searchquery = "SELECT * FROM unprinted_shirts";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgunprinted.DataSource = tbl;
            }
            else
            {
                string searchquery = "SELECT * FROM unprinted_shirts WHERE color LIKE '" + txtsearch.Text + "%'";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgunprinted.DataSource = tbl;
            }
        }

    }
}
