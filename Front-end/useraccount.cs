using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            //insert code here

            Database.useraccount acc = new Database.useraccount();
            acc.user(txtusername, txtfirstname, txtlastname, txtemail, txtpassword);

        }

        private void exitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
