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
        public void user(Guna2TextBox username, Guna2TextBox firstname, Guna2TextBox lastname, Guna2TextBox password)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

            connection.Open();
            string account = "SELECT username, first_name, last_name, password FROM floor_account WHERE username = '" + username.Text + "'";
            MySqlCommand cmd = new MySqlCommand(account, connection);
            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                username.Text = read["username"].ToString();
                firstname.Text = read["first_name"].ToString();
                lastname.Text = read["last_name"].ToString();
                password.Text = read["password"].ToString();
            }
        }

    }
}
