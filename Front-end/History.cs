
using DigiSort_Box.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DigiSort_Box.Front_end
{
    public partial class History : Form
    {
        MySqlConnection connection = Host.connection;
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
    }
}
