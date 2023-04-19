using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DigiSort_Box.Forms
{
    public partial class Inventory : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            //show Database table
            connection.Close();
            connection.Open();

            raw();
            unprint();
            ready();

            connection.Close();
        }


        private void raw()
        {
            //show raw
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM raw_material";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgrawmaterial.DataSource = dtRecords;
        }

        private void unprint()
        {
            //unprinted shirts
            MySqlCommand unprint = connection.CreateCommand();
            unprint.CommandText = "SELECT * FROM unprinted_shirts";
            MySqlDataReader sdr = unprint.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgunprinted.DataSource = dtRecords;
        }

        private void ready()
        {
            //ready
            MySqlCommand unprint = connection.CreateCommand();
            unprint.CommandText = "SELECT * FROM ready_to_sell_items";
            MySqlDataReader sdr = unprint.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgready.DataSource = dtRecords;
        }

        private void btndeleteready_Click(object sender, EventArgs e)
        {

        }

        private void btnupdateready_Click(object sender, EventArgs e)
        {

        }

        private void txtunprinted_TextChanged(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            if (txtunprinted.Text.Equals(""))
            {
                string searchquery = "SELECT * FROM unprinted_shirts";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgunprinted.DataSource = tbl;
            }
            else
            {
                string searchquery = "SELECT * FROM unprinted_shirts WHERE color LIKE '" + txtunprinted.Text + "%'";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgunprinted.DataSource = tbl;
            }
            
        }

        private void txtsearchready_TextChanged(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            if (txtsearchready.Text.Equals(""))
            {
                string searchquery = "SELECT * FROM ready_to_sell_items";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgready.DataSource = tbl;
            }
            else
            {
                string searchquery = "SELECT * FROM ready_to_sell_items WHERE product_name LIKE '" + txtsearchready.Text + "%'";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgready.DataSource = tbl;
            }
        }

        private void txtsearchraw_TextChanged(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            if (txtsearchraw.Text.Equals(""))
            {
                string searchquery = "SELECT * FROM raw_material";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgrawmaterial.DataSource = tbl;
            }
            else
            {
                string searchquery = "SELECT * FROM raw_material WHERE material LIKE '" + txtsearchraw.Text + "%'";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgrawmaterial.DataSource = tbl;
            }
        }
    }
}
