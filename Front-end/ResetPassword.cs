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

namespace DigiSort_Box.Front_end
{
    public partial class reset_password : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

        public reset_password()
        {
            InitializeComponent();
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            //DATABASE -------------------------------------------------------------------

            //Top account
            connection.Open();
            string searchTop = "SELECT username FROM top_account where username ='" + txtusername.Text + "'";
            MySqlCommand cmdTop = new MySqlCommand(searchTop, connection);
            MySqlDataReader rowTop = cmdTop.ExecuteReader();

            if (rowTop.HasRows)
            {
                while (rowTop.Read())
                {
                    txtpassword.Enabled = true;
                    txtretype.Enabled = true;
                }
            }
            else
            {
                txtpassword.Enabled = false;
                txtretype.Enabled = false;
            }

            connection.Close();


            //floor account
            //Top account
            connection.Open();
            string searchFloor = "SELECT username FROM top_account where username ='" + txtusername.Text + "'";
            MySqlCommand cmdFloor = new MySqlCommand(searchFloor, connection);
            MySqlDataReader rowFloor = cmdFloor.ExecuteReader();

            if (rowFloor.HasRows)
            {
                while (rowFloor.Read())
                {
                    txtpassword.Enabled = true;
                    txtretype.Enabled = true;
                }
            }
            else
            {
                txtpassword.Enabled = false;
                txtretype.Enabled = false;
            }

            connection.Close();


            //end of database -------------------------------------------------------------------
        }
    }
}
