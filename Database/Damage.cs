using DigiSort_Box.Model;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Crypto.Modes;
using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    public class Damage
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

         void raw(System.Windows.Forms.DataGridView rawdg)
        {
            connection.Close();
            connection.Open();

            //show raw
            string query = "SELECT * FROM raw_material";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRaw = new DataTable();
            dtRaw.Load(sdr);
            rawdg.DataSource = dtRaw;
        }
         void unprint(System.Windows.Forms.DataGridView unprintdg)
        {
            connection.Close();
            connection.Open();

            //unprinted shirts
            string query = "SELECT * FROM unprinted_shirts";
            MySqlCommand unprint = new MySqlCommand(query, connection);
            MySqlDataReader sdr = unprint.ExecuteReader();
            DataTable dtUnprint = new DataTable();
            dtUnprint.Load(sdr);
            unprintdg.DataSource = dtUnprint;
        }
         void ready(System.Windows.Forms.DataGridView readydg)
        {
            connection.Close();
            connection.Open();

            //ready
            string query = "SELECT * FROM ready_to_sell_items";
            MySqlCommand unprint = new MySqlCommand(query, connection);
            MySqlDataReader sdr = unprint.ExecuteReader();
            DataTable dtReady = new DataTable();
            dtReady.Load(sdr);
            readydg.DataSource = dtReady;
        }

        public void tbl(System.Windows.Forms.DataGridView dg, Guna2ComboBox cbtable)
        {
            if(cbtable.SelectedItem.Equals("Raw Materials"))
            {
                raw(dg);
                dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if(cbtable.SelectedItem.Equals("Unprinted Shirts"))
            {
                unprint(dg);
                dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {
                ready(dg);
                dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            }
        }

        void clear(Guna2TextBox txtissue, Guna2TextBox txtquan)
        {
            txtissue.Text = "";
            txtquan.Text = "";
        }

        public void issue(Guna2TextBox txtissue, Guna2TextBox txtquan, Guna2ComboBox cbtable, System.Windows.Forms.Label lbl1, System.Windows.Forms.Label lbl2, System.Windows.Forms.Label lbl3, System.Windows.Forms.Label lbl4)
        {

            if(cbtable.SelectedItem.Equals("Raw Materials"))
            {
                //insert query in raw
                string InsertQuery = "INSERT INTO raw_material_damage_items VALUES ('" + lbl1.Text + "', '" + lbl2.Text + "', '" + lbl3.Text + "', '" + int.Parse(txtquan.Text) + "', '" +  txtissue.Text + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(InsertQuery, connection);

                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Inserted");
                        clear(txtissue, txtquan);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();
            }
            else if(cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {
                //insert query
                string InsertQuery = "INSERT INTO ready_to_sell_items_damage_items VALUES ('" + lbl1.Text + "', '" + lbl2.Text + "', '" + lbl3.Text + "', '" + lbl4.Text + "', '" + int.Parse(txtquan.Text) + "', '" + txtissue.Text + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(InsertQuery, connection);

                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Inserted");
                        clear(txtissue, txtquan);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Inserted");
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
                //insert query
                string InsertQuery = "INSERT INTO unprinted_shirts_damage_items VALUES ('" + lbl1.Text + "', '" + lbl2.Text + "', '" + lbl3.Text + "', '" + int.Parse(txtquan.Text) + "', '" + txtissue.Text + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(InsertQuery, connection);

                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Inserted");
                        clear(txtissue, txtquan);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Inserted");
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
