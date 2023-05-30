using DigiSort_Box.Model;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System.Data;

namespace DigiSort_Box.Database
{
    public class Concern
    {
        MySqlConnection connection = Host.connection;
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
