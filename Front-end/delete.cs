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

        private void cbtable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtable.SelectedItem.Equals("Raw Materials"))
            {
                clear();
                connection.Close();
                connection.Open();

                txt4.Enabled = false;
                txt5.Enabled = false;
                txt6.Enabled = false;

                raw();

            }
            else if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {
                clear();
                connection.Close();
                connection.Open();

                txt4.Enabled = true;
                txt5.Enabled = true;
                txt6.Enabled = true;

                ready();
            }
            else if (cbtable.SelectedItem.Equals("Unprinted Shirts"))
            {
                clear();
                connection.Close();
                connection.Open();

                txt4.Enabled = true;
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
            else if (cbtable.SelectedItem.Equals("Raw Materials"))
            {
                //click cell to show
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgtable.Rows[e.RowIndex];
                    txtid.Text = dgvRow.Cells[0].Value.ToString();
                    txt1.Text = dgvRow.Cells[1].Value.ToString();
                    txt2.Text = dgvRow.Cells[2].Value.ToString();
                    txt3.Text = dgvRow.Cells[3].Value.ToString();
                }
            }
            else if (cbtable.SelectedItem.Equals("Unprinted Shirts"))
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
            //Database
            Database.delete dlt = new Database.delete();
            dlt.dlt(cbtable, txt1, txt2, txt3, txt4, txt5, txt6, txtid, txtusername, dgtable);

        }

    }
}