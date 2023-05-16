using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace DigiSort_Box.Database
{
     class useraccount
    {
        public void user(Guna2TextBox username, Guna2TextBox firstname, Guna2TextBox lastname, Guna2TextBox position)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

            //Account
            connection.Close();
            connection.Open();
            string accounttop = "SELECT username, first_name, last_name, position FROM account WHERE username = '" + username.Text + "'";
            MySqlCommand cmdtop = new MySqlCommand(accounttop, connection);
            MySqlDataReader readtop = cmdtop.ExecuteReader();

            if (readtop.Read())
            {
                username.Text = readtop["username"].ToString();
                firstname.Text = readtop["first_name"].ToString();
                lastname.Text = readtop["last_name"].ToString();
                position.Text = readtop["position"].ToString();
            }       
        }

    }
}
