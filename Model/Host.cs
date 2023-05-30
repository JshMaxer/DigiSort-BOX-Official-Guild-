using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DigiSort_Box.Model
{
    public class Host
    {
        public static MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");
        //public static MySqlConnection connection = new MySqlConnection("datasource=192.168.22.21;port=3306;Initial Catalog = digisortbox;username=root;password=");
    }
}
