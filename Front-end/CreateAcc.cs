using DigiSort_Box.Model;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace DigiSort_Box
{
    public partial class CreateAcc : Form
    {
        MySqlConnection connection;

        public CreateAcc()
        {
            InitializeComponent();
            Host.InitializeConnection();
            connection = Host.connection;
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            Forms.DigiSortBox dsb = new Forms.DigiSortBox();
            dsb.Show();
            this.Close();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            //database
            Database.CreateAcc Account = new Database.CreateAcc();
            Account.createAcc(txtfirstname, txtlastname, txtpassword, txtretype, txtusername, cbaccount, lblstatus, btncreate);

            if (lblstatus.Text.Equals("success"))
            {
                //Form close
                Forms.Login log = new Forms.Login();
                if (log != null)
                {
                    this.Close();
                }
            }
            else
            {
                //ok
            }

        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {
            if (txtfirstname.Text.Equals("") || txtlastname.Text.Equals("") || txtpassword.Text.Equals("") || txtretype.Text.Equals("") || txtusername.Text.Equals(""))
            {
                btncreate.Enabled = false;
            }
            else
            {
                btncreate.Enabled = true;
            }
        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {
            if (txtfirstname.Text.Equals("") || txtlastname.Text.Equals("") || txtpassword.Text.Equals("") || txtretype.Text.Equals("") || txtusername.Text.Equals(""))
            {
                btncreate.Enabled = false;
            }
            else
            {
                btncreate.Enabled = true;
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            if (txtfirstname.Text.Equals("") || txtlastname.Text.Equals("") || txtpassword.Text.Equals("") || txtretype.Text.Equals("") || txtusername.Text.Equals(""))
            {
                btncreate.Enabled = false;
            }
            else
            {
                btncreate.Enabled = true;
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtfirstname.Text.Equals("") || txtlastname.Text.Equals("") || txtpassword.Text.Equals("") || txtretype.Text.Equals("") || txtusername.Text.Equals(""))
            {
                btncreate.Enabled = false;
            }
            else
            {
                btncreate.Enabled = true;
            }
        }

        private void txtretype_TextChanged(object sender, EventArgs e)
        {
            if (txtfirstname.Text.Equals("") || txtlastname.Text.Equals("") || txtpassword.Text.Equals("") || txtretype.Text.Equals("") || txtusername.Text.Equals(""))
            {
                btncreate.Enabled = false;
            }
            else
            {
                btncreate.Enabled = true;
            }
        }
    }
}
