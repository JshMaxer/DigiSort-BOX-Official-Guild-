using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace DigiSort_Box.Database
{
    public class Concern
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

        public void concern(Guna2DataGridView dgcon)
        {
            string SearchQuery = "SELECT * FROM message_request";
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(SearchQuery, connection);
            MySqlDataReader adp = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(adp);
            dgcon.DataSource = table;

            connection.Close();
        }

    }
}
