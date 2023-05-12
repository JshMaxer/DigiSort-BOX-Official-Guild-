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

            //top account
            connection.Close();
            connection.Open();
            string accounttop = "SELECT username, firstname, lastname, password FROM top_account WHERE username = '" + username.Text + "'";
            MySqlCommand cmdtop = new MySqlCommand(accounttop, connection);
            MySqlDataReader readtop = cmdtop.ExecuteReader();

            if (readtop.Read())
            {
                username.Text = readtop["username"].ToString();
                firstname.Text = readtop["firstname"].ToString();
                lastname.Text = readtop["lastname"].ToString();
                password.Text = readtop["password"].ToString();
            }


            //floor account
            connection.Close();
            connection.Open();
            string accountfloor = "SELECT username, first_name, last_name, password FROM floor_account WHERE username = '" + username.Text + "'";
            MySqlCommand cmdfloor = new MySqlCommand(accountfloor, connection);
            MySqlDataReader readfloor = cmdfloor.ExecuteReader();

            if (readfloor.Read())
            {
                username.Text = readfloor["username"].ToString();
                firstname.Text = readfloor["first_name"].ToString();
                lastname.Text = readfloor["last_name"].ToString();
                password.Text = readfloor["password"].ToString();
            }


            
        }

    }
}
