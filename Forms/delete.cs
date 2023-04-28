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
    public partial class delete : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");
        public delete()
        {
            InitializeComponent();
        }
        void clear()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
        }
        
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void raw()
        {
            //show raw
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM raw_material";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgtable.DataSource = dtRecords;
        }

        void ready()
        {
            //show ready to sell items
            MySqlCommand unprint = connection.CreateCommand();
            unprint.CommandText = "SELECT * FROM ready_to_sell_items";
            MySqlDataReader sdr = unprint.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgtable.DataSource = dtRecords;
        }

        void unprint()
        {
            //show unprinted shirts
            MySqlCommand unprint = connection.CreateCommand();
            unprint.CommandText = "SELECT * FROM unprinted_shirts";
            MySqlDataReader sdr = unprint.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dgtable.DataSource = dtRecords;
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
                //click cell to show on Ready to Sell Items
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgtable.Rows[e.RowIndex];
                    txt1.Text = dgvRow.Cells[0].Value.ToString();
                    txt2.Text = dgvRow.Cells[1].Value.ToString();
                    txt3.Text = dgvRow.Cells[2].Value.ToString();
                    txt4.Text = dgvRow.Cells[3].Value.ToString();
                    txt5.Text = dgvRow.Cells[4].Value.ToString();
                }
            }
            else
            {
                //click cell to show
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgtable.Rows[e.RowIndex];
                    txt1.Text = dgvRow.Cells[0].Value.ToString();
                    txt2.Text = dgvRow.Cells[1].Value.ToString();
                    txt3.Text = dgvRow.Cells[2].Value.ToString();
                    txt4.Text = dgvRow.Cells[3].Value.ToString();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (cbtable.SelectedItem.Equals("Raw Materials"))
            {
                connection.Close();
                connection.Open();
                //update query
                string updateQuery = "DELETE FROM raw_material WHERE material = '" + txt1.Text + "'";
                MySqlCommand command = new MySqlCommand(updateQuery, connection);

                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        notifyIcon1.ShowBalloonTip(500, "DIGISORT BOX", "Data deleted", ToolTipIcon.Info);
                        raw();
                        clear();
                    }
                    else
                    {
                        notifyIcon1.ShowBalloonTip(500, "DIGISORT BOX", "Data not deleted", ToolTipIcon.Info);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();
            }
            else if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {
                connection.Close();
                connection.Open();
                //delete query
                string updateQuery = "DELETE FROM ready_to_sell_items WHERE product_name = '" + txt1.Text + "'";
                MySqlCommand command = new MySqlCommand(updateQuery, connection);

                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        notifyIcon1.ShowBalloonTip(500, "DIGISORT BOX", "Data deleted", ToolTipIcon.Info);
                        ready();
                        clear();
                    }
                    else
                    {
                        notifyIcon1.ShowBalloonTip(500, "DIGISORT BOX", "Data not deleted", ToolTipIcon.Info);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();
            }
            else if (cbtable.SelectedItem.Equals("Unprinted Shirts"))
            {
                connection.Close();
                connection.Open();
                //update query
                string updateQuery = "DELETE FROM unprinted_shirts WHERE color = '" + txt1.Text + "'";
                MySqlCommand command = new MySqlCommand(updateQuery, connection);

                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        notifyIcon1.ShowBalloonTip(500, "DIGISORT BOX", "Data deleted", ToolTipIcon.Info);
                        unprint();
                        clear();
                    }
                    else
                    {
                        notifyIcon1.ShowBalloonTip(500, "DIGISORT BOX", "Data not deleted", ToolTipIcon.Info);
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
}
