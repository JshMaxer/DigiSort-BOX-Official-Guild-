﻿using System;
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
        //-IP FOR LOCALHOST
        //public static MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");
     
        //-IP FOR PEER TO PEER
        public static MySqlConnection connection = new MySqlConnection("datasource=192.168.22.21;port=3306;Initial Catalog = digisortbox;username=root;password=");
        
        //-IP FOR SOHO
        //public static MySqlConnection connection = new MySqlConnection("datasource=192.168.100.41;port=3306;Initial Catalog = digisortbox;username=root;password=");

    }
}
