using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DigiSort_Box.Forms
{
    public partial class useraccount : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");
        public useraccount()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void useraccount_Load(object sender, EventArgs e)
        {
            connection.Open();
            string account = "SELECT username, first_name, last_name, email, password FROM account WHERE username = '" + txtusername.Text + "'";
            MySqlCommand cmd = new MySqlCommand(account, connection);
            MySqlDataReader read = cmd.ExecuteReader();

            if(read.Read())
            {
                txtusername.Text = read["username"].ToString();
                txtfirstname.Text = read["first_name"].ToString();
                txtlastname.Text = read["last_name"].ToString();
                txtemail.Text = read["email"].ToString();
                txtpassword.Text = read["password"].ToString();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
