
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DigiSort_Box.Front_end
{
    public partial class History : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=; convert zero datetime=true;allow user variables=true;");

        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            //database
            Database.History logs = new Database.History();
            logs.logs(dghistory);
        }

        private void btnokay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //database
            Database.History logs = new Database.History();
            logs.clear(dghistory);
        }
    }
}
