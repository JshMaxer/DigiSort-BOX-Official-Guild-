using DigiSort_Box.Model;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace DigiSort_Box.Database
{
    class History
    {
        MySqlConnection connection = Host.connection;
        void select(DataGridView dg)
        {
            connection.Close();
            connection.Open();

            string log = "SELECT * FROM activity_logs ORDER BY date_and_time DESC;";
            MySqlCommand cmd = new MySqlCommand(log, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dg.DataSource = dt;

            connection.Close();
        }

        public void logs(DataGridView dg)
        {
            select(dg);
        }

    }
}
