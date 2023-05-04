using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DigiSort_Box.Forms
{
    public partial class update : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");
        public update()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void clear()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
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
                    lbltxt1.Text = txt1.Text;
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
                    lbltxt1.Text = txt1.Text;
                    txt2.Text = dgvRow.Cells[1].Value.ToString();
                    txt3.Text = dgvRow.Cells[2].Value.ToString();
                    txt4.Text = dgvRow.Cells[3].Value.ToString();
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            if (cbtable.SelectedItem.Equals("Raw Materials"))
            {
                connection.Close();
                connection.Open();
                //update query
                string updateQuery = "UPDATE raw_material SET material = '" + txt1.Text + "', design = '" + txt2.Text + "', color = '" + txt3.Text + "', quantity ='" + txt4.Text + "' WHERE material = '" + lbltxt1.Text + "'";
                MySqlCommand command = new MySqlCommand(updateQuery, connection);

                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        notifyIcon1.ShowBalloonTip(500, "DIGISORT BOX", "Data updated", ToolTipIcon.Info);
                        raw();
                    }
                    else
                    {
                        notifyIcon1.ShowBalloonTip(500, "DIGISORT BOX", "Data not updated", ToolTipIcon.Info);
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
                //update query
                string updateQuery = "UPDATE ready_to_sell_items SET product_name = '" + txt1.Text + "', color = '" + txt2.Text + "', shade = '" + txt3.Text + "', size ='" + txt4.Text + "', quantity ='" + txt5.Text + "' WHERE product_name = '" + lbltxt1.Text + "'";
                MySqlCommand command = new MySqlCommand(updateQuery, connection);

                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        notifyIcon1.ShowBalloonTip(500, "DIGISORT BOX", "Data updated", ToolTipIcon.Info);
                        ready();
                    }
                    else
                    {
                        notifyIcon1.ShowBalloonTip(500, "DIGISORT BOX", "Data not updated", ToolTipIcon.Info);
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
                string updateQuery = "UPDATE unprinted_shirts SET color = '" + txt1.Text + "', shade = '" + txt2.Text + "', size = '" + txt3.Text + "', quantity ='" + txt4.Text + "' WHERE color = '" + lbltxt1.Text + "'";
                MySqlCommand command = new MySqlCommand(updateQuery, connection);

                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        notifyIcon1.ShowBalloonTip(500, "DIGISORT BOX", "Data updated", ToolTipIcon.Info);
                        unprint();
                    }
                    else
                    {
                        notifyIcon1.ShowBalloonTip(500, "DIGISORT BOX", "Data not updated", ToolTipIcon.Info);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
