using System;
using System.Windows.Forms;

namespace DigiSort_Box
{
    public partial class CreateAcc : Form
    {
        public CreateAcc()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            Database.CreateAcc Account = new Database.CreateAcc();
            Account.createAcc(txtfirstname, txtfirstname, txtpassword, txtretype, txtusername, txtemail);

            if (((Forms.Login)Application.OpenForms["Login"]).Visible == true)
            {
                this.Close();
            }
            else
            {
                //nothing
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Forms.DigiSortBox dsb = new Forms.DigiSortBox();
            dsb.Show();
            this.Close();
        }
    }
}
