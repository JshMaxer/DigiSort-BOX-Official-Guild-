using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DigiSort_Box
{
    public partial class CreateAcc : Form
    {
        public CreateAcc()
        {
            InitializeComponent();
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
            Account.createAcc(txtfirstname, txtlastname, txtpassword, txtretype, txtusername, cbaccount);

            //Form close
            Forms.Login log = new Forms.Login();
            if (log != null)
            {
                this.Close();
            }

        }
       
    }
}
