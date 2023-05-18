using DigiSort_Box.Front_end;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static DigiSort_Box.Back_end.Login;

namespace DigiSort_Box.Forms
{
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");

        public Login()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Forms.DigiSortBox dsb = new Forms.DigiSortBox();
            dsb.Show();
            this.Close();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            //preview account - change restriction
            if (txtusername.Text.Equals("Preview") || txtusername.Text.Equals("preview") && (txtpassword.Text.Equals("Admin") || txtpassword.Text.Equals("admin")))
            {
                MessageBox.Show("This account is for preview forms only. You cannot do anything on other forms you just previewing them.\nThis account is usually used only for Front-End Developer");
                Forms.preview pv = new Forms.preview();
                this.Close();
                pv.Show();
            }
            else
            {
                /*
                Database.Login logss = new Database.Login();
                logss.loginCODE(txtusername, txtpassword);
                */


                //search account for top admin account
                try
                {
                    string searchTop = "SELECT firstname, lastname, username, password FROM top_account WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmdtop = new MySqlCommand(searchTop, connection);
                    MySqlDataReader rowtop = (cmdtop.ExecuteReader());

                    if (rowtop.HasRows)
                    {
                        while (rowtop.Read())
                        {
                            string fname = rowtop["firstname"].ToString();
                            string lname = rowtop["lastname"].ToString();
                            string usename = rowtop["username"].ToString();

                            MessageBox.Show("Top admin Log-in Succesful!\nHello " + fname + " " + lname);

                            Forms.Dashboard dash = new Forms.Dashboard();
                            dash.txtname.Text = usename;
                            dash.Show();

                            //this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Log-in Credentials!");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\t\tSQLServer is turned off");
                }
            }
        }

        private void lblreset_Click(object sender, EventArgs e)
        {
            reset_password reset = new reset_password();
            DialogResult dr = MessageBox.Show("Are you sure you want to reset password?", "DigiSortBox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                reset.ShowDialog();
            }
            else
            {
                //ok.
            }

        }
        static void Main() {

            Login login = new Login();
        }
    }
}
