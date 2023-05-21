using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigiSort_Box.Front_end;
using MySql.Data.MySqlClient;

namespace DigiSort_Box.Database
{
     class History
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=; convert zero datetime=true;allow user variables=true;");

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

        public void clear(DataGridView dg)
        {
            connection.Close();
            connection.Open();

            string clear = "DELETE FROM activity_logs";
            MySqlCommand cmd = new MySqlCommand(clear, connection);
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dg.DataSource = dt;

            //select *
            select(dg);

            connection.Close();
        }
    }
}
