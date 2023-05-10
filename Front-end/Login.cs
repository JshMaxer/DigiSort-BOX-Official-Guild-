using DigiSort_Box.Front_end;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Forms
{
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

        public Login()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Forms.DigiSortBox dsb = new Forms.DigiSortBox();
            dsb.Show();
            this.Close();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            //preview account
            if (txtusername.Text.Equals("Preview") || txtusername.Text.Equals("preview") && (txtpassword.Text.Equals("Admin") || txtpassword.Text.Equals("admin")))
            {
                MessageBox.Show("This account is for preview forms only. You cannot do anything on other forms you just previewing them.\nThis account is usually used only for Front-End Developer");
                Forms.preview pv = new Forms.preview();
                this.Close();
                pv.Show();

            }
            else
            {
                try
                {
                    string searchQuery = "SELECT first_name, last_name, username, password FROM account WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(searchQuery, connection);
                    MySqlDataReader row = (cmd.ExecuteReader());

                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            string firstname = row["first_name"].ToString();
                            string lastname = row["last_name"].ToString();
                            string username = row["username"].ToString();
                            MessageBox.Show("Account Succesfully Login \nHello " + firstname + " " + lastname);
                            Forms.Dashboard dash = new Dashboard();
                            dash.txtname.Text = username;
                            dash.Show();
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\t\tSQLServer is turned off");
                }
            }
        }

        private void lblreset_Click(object sender, EventArgs e)
        {
            reset_password reset = new reset_password();
            DialogResult dr = MessageBox.Show("Are you sure you want to reset password?", "DigiSortBox" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(dr == DialogResult.Yes)
            {
                reset.ShowDialog();
            }
            else
            {
                //ok.
            }
            
        }
    }
}
