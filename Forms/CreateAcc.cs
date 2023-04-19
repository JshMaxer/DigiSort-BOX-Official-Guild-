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

namespace DigiSort_Box
{
    public partial class CreateAcc : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");
        public CreateAcc()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfirstname.Text.Equals("") || txtlastname.Text.Equals("") || txtpassword.Text.Equals("") || txtretype.Text.Equals("") || txtusername.Text.Equals(""))
                {
                    MessageBox.Show("Field is blank!");
                }
                else if (!txtretype.Text.Equals(txtpassword.Text))
                {
                    MessageBox.Show("Password not same");
                }
                else
                {
                    string InsertQuery = "INSERT INTO account VALUES ('" + txtusername.Text + "', '" + txtfirstname.Text + "', '" + txtlastname.Text + "', '" + txtemail.Text + "', '" + txtpassword.Text + "')";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(InsertQuery, connection);

                    try
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Account Created Succesful");
                            Forms.Login log = new Forms.Login();
                            log.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Account Created UnSuccesful");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\t\tSQLServer is turned off");
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Forms.DigiSortBox dsb = new Forms.DigiSortBox();
            dsb.Show();
            this.Close();
        }
    }
}
