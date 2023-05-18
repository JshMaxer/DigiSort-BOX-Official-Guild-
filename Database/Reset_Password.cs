using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace DigiSort_Box.Database
{
     class Reset_Password
    {
        public void reset(Guna2TextBox user, Guna2TextBox password, Guna2TextBox retype)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

            

        }

    }
}
