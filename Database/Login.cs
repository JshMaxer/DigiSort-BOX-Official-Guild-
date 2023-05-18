using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    class Login
    {
        
        public void loginCODE(Guna2TextBox username, Guna2TextBox password)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");
            
        }

    }
}

