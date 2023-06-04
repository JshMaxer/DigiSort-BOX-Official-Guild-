using DigiSort_Box.Model;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            if (cbtable.SelectedItem.Equals("Raw Materials"))
            {
                raw(dg);
                dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (cbtable.SelectedItem.Equals("Unprinted Shirts"))
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

        //issue for top and floor admin
        void issuetopfloor(Guna2TextBox txtissue, Guna2TextBox txtquan, Guna2ComboBox cbtable, System.Windows.Forms.Label lblid, System.Windows.Forms.Label lbl1, System.Windows.Forms.Label lbl2, System.Windows.Forms.Label lbl3, System.Windows.Forms.Label lbl4, System.Windows.Forms.Label lbl5, System.Windows.Forms.Label lbl6, System.Windows.Forms.Label txtusername)
        {
            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd HH:mm:ss");

            if (cbtable.SelectedItem.Equals("Raw Materials"))
            {
                //Restriction
                string rawquant = "SELECT quantity FROM Raw_Material WHERE Material = '" + lbl1.Text + "'AND design = '" + lbl2.Text + "'";
                connection.Close();
                connection.Open();

                MySqlCommand rawcmd = new MySqlCommand(rawquant, connection);
                MySqlDataReader rawrd = rawcmd.ExecuteReader();

                if (rawrd.HasRows)
                {
                    while (rawrd.Read())
                    {
                        int rawquan = int.Parse(rawrd["quantity"].ToString());

                        // Condition if the quantity exceeds
                        if (int.Parse(txtquan.Text) > rawquan)
                        {
                            MessageBox.Show("Quantity exceeds for materials");
                            return; // Exit the method if the quantity exceeds
                        }
                    }

                    rawrd.Close(); // Close the rawrd reader

                    //Raw Code here
                    //activity_logs
                    string idquery = "SELECT id FROM account where username = '" + txtusername.Text + "'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmdid = new MySqlCommand(idquery, connection);
                    MySqlDataReader row = cmdid.ExecuteReader();

                    try
                    {

                        if (row.HasRows)
                        {
                            while (row.Read())
                            {
                                string id = row["id"].ToString();

                                //insert query in raw //itm should return data to insert on database.
                                string InsertQuery = "INSERT INTO raw_material_damage_items VALUES ('" + lblid.Text + "', '" + lbl1.Text + "', '" + lbl2.Text + "', " + int.Parse(txtquan.Text) + ", '" + txtissue.Text + "', '" + date + "')";
                                string UpdateQuery = "UPDATE raw_material SET quantity = quantity - " + int.Parse(txtquan.Text) + " WHERE id = '" + lblid.Text + "'";
                                string userandid = "INSERT INTO activity_logs VALUES ('" + int.Parse(id) + "', '" + txtusername.Text + "', '" + "added raw materials as damage items" + "', '" + date + "')";
                                connection.Close();
                                connection.Open();

                                MySqlCommand command = new MySqlCommand(InsertQuery, connection);
                                MySqlCommand updateCommand = new MySqlCommand(UpdateQuery, connection);
                                MySqlCommand cmd = new MySqlCommand(userandid, connection);

                                try
                                {
                                    if (command.ExecuteNonQuery() == 1)
                                    {
                                        MessageBox.Show("Item added successfully!");
                                        cmd.ExecuteNonQuery();
                                        clear(txtissue, txtquan);
                                        updateCommand.ExecuteNonQuery();
                                        quantityzero();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Item added Un-successfull!");
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
                    catch (Exception)
                    {
                        //catch the error
                    }
                }

            }
            else if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {
                //Restriction
                string rawquant = "SELECT quantity FROM ready_to_sell_items WHERE material = '" + lbl1.Text + "'AND design = '" + lbl2.Text + "' AND color = '" + lbl3.Text + "' AND shade = '" + lbl4.Text + "' AND size = '" + lbl5.Text + "'";
                connection.Close();
                connection.Open();

                MySqlCommand rawcmd = new MySqlCommand(rawquant, connection);
                MySqlDataReader rawrd = rawcmd.ExecuteReader();

                if (rawrd.HasRows)
                {
                    while (rawrd.Read())
                    {
                        int rawquan = int.Parse(rawrd["quantity"].ToString());

                        // Condition if the quantity exceeds
                        if (int.Parse(txtquan.Text) > rawquan)
                        {
                            MessageBox.Show("Quantity exceeds for materials");
                            return; // Exit the method if the quantity exceeds
                        }
                    }

                    rawrd.Close();

                    //Code here
                    //activity_logs
                    string idquery = "SELECT id FROM account where username = '" + txtusername.Text + "'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmdid = new MySqlCommand(idquery, connection);
                    MySqlDataReader row = cmdid.ExecuteReader();

                    try
                    {

                        if (row.HasRows)
                        {
                            while (row.Read())
                            {
                                string id = row["id"].ToString();

                                //insert query //itm should return data to insert on database.
                                string InsertQuery = "INSERT INTO ready_to_sell_items_damage_items VALUES ('" + lblid.Text + "', '" + lbl1.Text + "', '" + lbl2.Text + "', '" + lbl3.Text + "', '" + lbl4.Text + "', '" + int.Parse(txtquan.Text) + "', '" + txtissue.Text + "', '" + date + "')";
                                string UpdateQuery = "UPDATE ready_to_sell_items SET quantity = quantity - " + int.Parse(txtquan.Text) + " WHERE id = '" + lblid.Text + "'";
                                string userandid = "INSERT INTO activity_logs VALUES ('" + int.Parse(id) + "', '" + txtusername.Text + "', '" + "added ready to sell items as damage items" + "', '" + date + "')";

                                connection.Close();
                                connection.Open();

                                MySqlCommand command = new MySqlCommand(InsertQuery, connection);
                                MySqlCommand updateCommand = new MySqlCommand(UpdateQuery, connection);
                                MySqlCommand cmd = new MySqlCommand(userandid, connection);

                                try
                                {
                                    if (command.ExecuteNonQuery() == 1)
                                    {
                                        MessageBox.Show("Item added successfully!");
                                        cmd.ExecuteNonQuery();
                                        clear(txtissue, txtquan);
                                        updateCommand.ExecuteNonQuery();
                                        quantityzero();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Item added Un-successfull!");
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
                    catch (Exception)
                    {
                        //catch the error
                    }
                }


            }
            else if (cbtable.SelectedItem.Equals("Unprinted Shirts"))
            {
                //Restriction
                string rawquant = "SELECT quantity FROM unprinted_shirts WHERE color = '" + lbl1.Text + "' AND shade = '" + lbl2.Text + "' AND size = '" + lbl3.Text + "'";
                connection.Close();
                connection.Open();

                MySqlCommand rawcmd = new MySqlCommand(rawquant, connection);
                MySqlDataReader rawrd = rawcmd.ExecuteReader();

                if (rawrd.HasRows)
                {
                    while (rawrd.Read())
                    {
                        int rawquan = int.Parse(rawrd["quantity"].ToString());

                        // Condition if the quantity exceeds
                        if (int.Parse(txtquan.Text) > rawquan)
                        {
                            MessageBox.Show("Quantity exceeds for materials");
                            return; // Exit the method if the quantity exceeds
                        }
                    }

                    //Code here
                    //activity_logs
                    string idquery = "SELECT id FROM account where username = '" + txtusername.Text + "'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmdid = new MySqlCommand(idquery, connection);
                    MySqlDataReader row = cmdid.ExecuteReader();

                    try
                    {

                        if (row.HasRows)
                        {
                            while (row.Read())
                            {
                                string id = row["id"].ToString();

                                //insert query //itm should return data to insert on database.
                                string InsertQuery = "INSERT INTO unprinted_shirts_damage_items VALUES ('" + lblid.Text + "', '" + lbl1.Text + "', '" + lbl2.Text + "', '" + lbl3.Text + "', '" + int.Parse(txtquan.Text) + "', '" + txtissue.Text + "', '" + date + "')";
                                string UpdateQuery = "UPDATE unprinted_shirts SET quantity = quantity - " + int.Parse(txtquan.Text) + " WHERE id = '" + lblid.Text + "'";
                                string userandid = "INSERT INTO activity_logs VALUES ('" + int.Parse(id) + "', '" + txtusername.Text + "', '" + "added unprinted shirts as damage items" + "', '" + date + "')";

                                connection.Close();
                                connection.Open();

                                MySqlCommand command = new MySqlCommand(InsertQuery, connection);
                                MySqlCommand updateCommand = new MySqlCommand(UpdateQuery, connection);
                                MySqlCommand cmd = new MySqlCommand(userandid, connection);

                                try
                                {
                                    if (command.ExecuteNonQuery() == 1)
                                    {
                                        MessageBox.Show("Item added successfully!");
                                        cmd.ExecuteNonQuery();
                                        clear(txtissue, txtquan);
                                        updateCommand.ExecuteNonQuery();
                                        quantityzero();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Item added Un-successfull!");
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
                    catch (Exception)
                    {
                        //catch the error
                    }

                }
            }
        }

        //issue for super admin
        void issuesuper(Guna2TextBox txtissue, Guna2TextBox txtquan, Guna2ComboBox cbtable, System.Windows.Forms.Label lblid, System.Windows.Forms.Label lbl1, System.Windows.Forms.Label lbl2, System.Windows.Forms.Label lbl3, System.Windows.Forms.Label lbl4, System.Windows.Forms.Label lbl5, System.Windows.Forms.Label lbl6, System.Windows.Forms.Label txtusername)
        {
            DateTime dateTimeVariable = DateTime.Now;
            string date = dateTimeVariable.ToString("yyyy-MM-dd HH:mm:ss");

            if (cbtable.SelectedItem.Equals("Raw Materials"))
            {
                //Restriction
                string rawquant = "SELECT quantity FROM Raw_Material WHERE Material = '" + lbl1.Text + "'AND design = '" + lbl2.Text + "'";
                connection.Close();
                connection.Open();

                MySqlCommand rawcmd = new MySqlCommand(rawquant, connection);
                MySqlDataReader rawrd = rawcmd.ExecuteReader();

                if (rawrd.HasRows)
                {
                    while (rawrd.Read())
                    {
                        int rawquan = int.Parse(rawrd["quantity"].ToString());

                        // Condition if the quantity exceeds
                        if (int.Parse(txtquan.Text) > rawquan)
                        {
                            MessageBox.Show("Quantity exceeds for materials");
                            return; // Exit the method if the quantity exceeds
                        }
                    }

                    rawrd.Close(); // Close the rawrd reader


                    //insert query in raw //itm should return data to insert on database.
                    string InsertQuery = "INSERT INTO raw_material_damage_items VALUES ('" + lblid.Text + "', '" + lbl1.Text + "', '" + lbl2.Text + "', " + int.Parse(txtquan.Text) + ", '" + txtissue.Text + "', '" + date + "')";
                    string UpdateQuery = "UPDATE raw_material SET quantity = quantity - " + int.Parse(txtquan.Text) + " WHERE id = '" + lblid.Text + "'";
                    connection.Close();
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(InsertQuery, connection);
                    MySqlCommand updateCommand = new MySqlCommand(UpdateQuery, connection);

                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Item added successfully!");
                            clear(txtissue, txtquan);
                            updateCommand.ExecuteNonQuery();
                            quantityzero();
                        }
                        else
                        {
                            MessageBox.Show("Item added Un-successfull!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();

                }

            }



            else if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {
                //Restriction
                string rawquant = "SELECT quantity FROM ready_to_sell_items WHERE material = '" + lbl1.Text + "'AND design = '" + lbl2.Text + "' AND color = '" + lbl3.Text + "' AND shade = '" + lbl4.Text + "' AND size = '" + lbl5.Text + "'";
                connection.Close();
                connection.Open();

                MySqlCommand rawcmd = new MySqlCommand(rawquant, connection);
                MySqlDataReader rawrd = rawcmd.ExecuteReader();

                if (rawrd.HasRows)
                {
                    while (rawrd.Read())
                    {
                        int rawquan = int.Parse(rawrd["quantity"].ToString());

                        // Condition if the quantity exceeds
                        if (int.Parse(txtquan.Text) > rawquan)
                        {
                            MessageBox.Show("Quantity exceeds for materials");
                            return; // Exit the method if the quantity exceeds
                        }
                    }

                    rawrd.Close();

                    //Code here
                    //activity_logs
                    string idquery = "SELECT id FROM account where username = '" + txtusername.Text + "'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmdid = new MySqlCommand(idquery, connection);
                    MySqlDataReader row = cmdid.ExecuteReader();

                    try
                    {

                        if (row.HasRows)
                        {
                            while (row.Read())
                            {
                                string id = row["id"].ToString();

                                //insert query //itm should return data to insert on database.
                                string InsertQuery = "INSERT INTO ready_to_sell_items_damage_items VALUES ('" + lblid.Text + "', '" + lbl1.Text + "', '" + lbl2.Text + "', '" + lbl3.Text + "', '" + lbl4.Text + "', '" + int.Parse(txtquan.Text) + "', '" + txtissue.Text + "', '" + date + "')";
                                string UpdateQuery = "UPDATE ready_to_sell_items SET quantity = quantity - " + int.Parse(txtquan.Text) + " WHERE id = '" + lblid.Text + "'";

                                connection.Close();
                                connection.Open();

                                MySqlCommand command = new MySqlCommand(InsertQuery, connection);
                                MySqlCommand updateCommand = new MySqlCommand(UpdateQuery, connection);

                                try
                                {
                                    if (command.ExecuteNonQuery() == 1)
                                    {
                                        MessageBox.Show("Item added successfully!");
                                        clear(txtissue, txtquan);
                                        updateCommand.ExecuteNonQuery();
                                        quantityzero();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Item added Un-successfull!");
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
                    catch (Exception e)
                    {
                        //catch the error
                        MessageBox.Show(e.Message);
                    }
                }


            }
            else if (cbtable.SelectedItem.Equals("Unprinted Shirts"))
            {
                //Restriction
                string rawquant = "SELECT quantity FROM unprinted_shirts WHERE color = '" + lbl1.Text + "' AND shade = '" + lbl2.Text + "' AND size = '" + lbl3.Text + "'";
                connection.Close();
                connection.Open();

                MySqlCommand rawcmd = new MySqlCommand(rawquant, connection);
                MySqlDataReader rawrd = rawcmd.ExecuteReader();

                if (rawrd.HasRows)
                {
                    while (rawrd.Read())
                    {
                        int rawquan = int.Parse(rawrd["quantity"].ToString());

                        // Condition if the quantity exceeds
                        if (int.Parse(txtquan.Text) > rawquan)
                        {
                            MessageBox.Show("Quantity exceeds for materials");
                            return; // Exit the method if the quantity exceeds
                        }
                    }

                    //Code here
                    //activity_logs
                    string idquery = "SELECT id FROM account where username = '" + txtusername.Text + "'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmdid = new MySqlCommand(idquery, connection);
                    MySqlDataReader row = cmdid.ExecuteReader();

                    try
                    {

                        if (row.HasRows)
                        {
                            while (row.Read())
                            {
                                string id = row["id"].ToString();

                                //insert query //itm should return data to insert on database.
                                string InsertQuery = "INSERT INTO unprinted_shirts_damage_items VALUES ('" + lblid.Text + "', '" + lbl1.Text + "', '" + lbl2.Text + "', '" + lbl3.Text + "', '" + int.Parse(txtquan.Text) + "', '" + txtissue.Text + "', '" + date + "')";
                                string UpdateQuery = "UPDATE unprinted_shirts SET quantity = quantity - " + int.Parse(txtquan.Text) + " WHERE id = '" + lblid.Text + "'";

                                connection.Close();
                                connection.Open();

                                MySqlCommand command = new MySqlCommand(InsertQuery, connection);
                                MySqlCommand updateCommand = new MySqlCommand(UpdateQuery, connection);

                                try
                                {
                                    if (command.ExecuteNonQuery() == 1)
                                    {
                                        MessageBox.Show("Item added successfully!");
                                        clear(txtissue, txtquan);
                                        updateCommand.ExecuteNonQuery();
                                        quantityzero();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Item added Un-successfull!");
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
                    catch (Exception e)
                    {
                        //catch the error
                        MessageBox.Show(e.Message);
                    }

                }
            }
        }

        public void issue(Guna2TextBox txtissue, Guna2TextBox txtquan, Guna2ComboBox cbtable, System.Windows.Forms.Label lblid, System.Windows.Forms.Label lbl1, System.Windows.Forms.Label lbl2, System.Windows.Forms.Label lbl3, System.Windows.Forms.Label lbl4, System.Windows.Forms.Label lbl5, System.Windows.Forms.Label lbl6, System.Windows.Forms.Label txtusername)
        {
            if (txtusername.Text.Equals("SUPER ADMIN"))
            {
                issuesuper(txtissue, txtquan, cbtable, lblid, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, txtusername);
            }
            else
            {
                issuetopfloor(txtissue, txtquan, cbtable, lblid, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, txtusername);
            }
        }

        public void quantityzero()
        {
            string rawquan = "DELETE FROM raw_material WHERE quantity <= 0";
            string readyquan = "DELETE FROM ready_to_sell_items WHERE quantity <= 0";
            string unprintquan = "DELETE FROM unprinted_shirts WHERE quantity <= 0";
            MySqlCommand rawcmd = new MySqlCommand(rawquan, connection);
            MySqlCommand readycmd = new MySqlCommand(readyquan, connection);
            MySqlCommand unprintcmd = new MySqlCommand(unprintquan, connection);
            rawcmd.ExecuteNonQuery();
            readycmd.ExecuteNonQuery();
            unprintcmd.ExecuteNonQuery();
        }

    }
}
