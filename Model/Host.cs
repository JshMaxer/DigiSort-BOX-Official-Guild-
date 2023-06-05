using MySql.Data.MySqlClient;

namespace DigiSort_Box.Model
{
    public class Host
    {
        public static string DefaultConnectionString = "datasource=localhost;port=3306;Initial Catalog=digisortbox;username=root;password=";
        public static MySqlConnection connection { get; set; }

        // Example of initializing the connection with the default connection string
        public static void InitializeConnection()
        {
            connection = new MySqlConnection(DefaultConnectionString);
        }

        // Example of updating the connection string
        public static void UpdateConnectionString(string newConnectionString)
        {
            DefaultConnectionString = newConnectionString;
            InitializeConnection(); // Reinitialize the connection with the updated connection string
        }
    }
}
