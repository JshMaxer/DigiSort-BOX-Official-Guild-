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
        MySqlConnection connection = Host.connection;
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

        public void issue(Guna2TextBox txtissue, Guna2TextBox txtquan, Guna2ComboBox cbtable, System.Windows.Forms.Label lblid, System.Windows.Forms.Label lbl1, System.Windows.Forms.Label lbl2, System.Windows.Forms.Label lbl3, System.Windows.Forms.Label lbl4)
        {
            if (cbtable.SelectedItem.Equals("Raw Materials"))
            {
                //insert query in raw //itm should return data to insert on database.
                string InsertQuery = "INSERT INTO raw_material_damage_items VALUES ('" + lblid.Text + "', '" + lbl1.Text + "', '" + lbl2.Text + "', '" + lbl3.Text + "', '" + int.Parse(txtquan.Text) + "', '" +  txtissue.Text + "')";
                string UpdateQuery = "UPDATE raw_material SET quantity = quantity - 1 WHERE id = " + lblid.Text;
                connection.Close();
                connection.Open();
                MySqlCommand command = new MySqlCommand(InsertQuery, connection);
                MySqlCommand updateCommand = new MySqlCommand(UpdateQuery, connection);
                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Inserted");
                        clear(txtissue, txtquan);
                        updateCommand.ExecuteNonQuery();
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
                //insert query //itm should return data to insert on database.
                string InsertQuery = "INSERT INTO ready_to_sell_items_damage_items VALUES ('" + lblid.Text + "', '" + lbl1.Text + "', '" + lbl2.Text + "', '" + lbl3.Text + "', '" + lbl4.Text + "', '" + int.Parse(txtquan.Text) + "', '" + txtissue.Text + "')";
                string UpdateQuery = "UPDATE ready_to_sell_items SET quantity = quantity - 1 WHERE id = " + lblid.Text;
                connection.Close();
                connection.Open();
                MySqlCommand command = new MySqlCommand(InsertQuery, connection);
                MySqlCommand updateCommand = new MySqlCommand(UpdateQuery, connection);
                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Inserted");
                        clear(txtissue, txtquan);
                        updateCommand.ExecuteNonQuery();
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
                //insert query //itm should return data to insert on database.
                string InsertQuery = "INSERT INTO unprinted_shirts_damage_items VALUES ('" + lblid.Text + "', '" + lbl1.Text + "', '" + lbl2.Text + "', '" + lbl3.Text + "', '" + int.Parse(txtquan.Text) + "', '" + txtissue.Text + "')";
                string UpdateQuery = "UPDATE unprinted_shirts SET quantity = quantity - 1 WHERE id = " + lblid.Text;
                connection.Close();
                connection.Open();
                MySqlCommand command = new MySqlCommand(InsertQuery, connection);
                MySqlCommand updateCommand = new MySqlCommand(UpdateQuery, connection);
                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Inserted");
                        clear(txtissue, txtquan);
                        updateCommand.ExecuteNonQuery();
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
