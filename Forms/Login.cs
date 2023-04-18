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
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string searchQuery = "SELECT first_name, last_name, username, password FROM account WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(searchQuery, connection);
            MySqlDataReader row = (cmd.ExecuteReader());

            if(row.HasRows)
            {
                while (row.Read())
                {
                    string firstname = row["first_name"].ToString();
                    string lastname = row["last_name"].ToString();
                    MessageBox.Show("Account Succesfully Login \nHello " + firstname + " " + lastname);
                    Forms.Dashboard dash = new Dashboard();
                    dash.txtname.Text = firstname + " " + lastname;
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
    }
}
