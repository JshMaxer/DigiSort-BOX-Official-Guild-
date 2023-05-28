using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

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
            //DATABASE
            Database.Reset_Password rst = new Database.Reset_Password();
            rst.reset(lblusername, txtpassword, txtretype);
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text.Equals("") || txtretype.Text.Equals(""))
            {
                btnproceed.Enabled = false;
            }
            else if (!txtpassword.Text.Equals(txtretype.Text))
            {
                btnproceed.Enabled = false;
            }
            else
            {
                btnproceed.Enabled = true;
            }
        }

        private void txtretype_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text.Equals("") || txtretype.Text.Equals(""))
            {
                btnproceed.Enabled = false;
            }
            else if (!txtpassword.Text.Equals(txtretype.Text))
            {
                btnproceed.Enabled = false;
            }
            else
            {
                btnproceed.Enabled = true;
            }
        }
    }
}
