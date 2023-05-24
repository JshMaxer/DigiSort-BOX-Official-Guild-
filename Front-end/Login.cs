using DigiSort_Box.Back_end;
using DigiSort_Box.Mowdel;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

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

        void Activity(Lageen lageen)
        {
            if (lageen.Activation.Equals("InActive"))
            {
                MessageBox.Show("Sorry, the account you're trying to log is Inactive.", "Log-in Denied");
            }
            else
            {
                MessageBox.Show("Log-in Succesful!\nHello " + lageen.Firstname + " " + lageen.Lastname, lageen.Position);

                Forms.Dashboard dash = new Forms.Dashboard(lageen);
                dash.txtname.Text = lageen.Username;
                dash.Show();

                this.Close();
            }

        }
        private void btnsignin_Click(object sender, EventArgs e)
        {
            //DATABASE -------------------------------------------------------------------
            if (txtusername.Text.Equals("") || txtpassword.Text.Equals(""))
            {
                MessageBox.Show("Log-in Form must be filled-out completely!");
            }
            else
            {
                //preview account - change restriction
                if (txtusername.Text.Equals(Constants.prevusername) && (txtpassword.Text.Equals(Constants.prevpassword)))
                {
                    MessageBox.Show("This account is for preview forms only. You cannot do anything on other forms you just previewing them.\nThis account is usually used only for Front-End Developer", "Front_End");
                    Forms.preview pv = new Forms.preview();
                    this.Close();
                    pv.Show();
                }
                else
                {

                    //super admin log
                    Lageen lageen = new Lageen();
                    if (txtusername.Text.Equals(Constants.username) && txtpassword.Text.Equals(Constants.password))
                    {
                        MessageBox.Show("Log-in Succesful!\nHello Super admin!", "Super_admin");

                        Forms.Dashboard dash = new Forms.Dashboard(lageen);
                        dash.txtname.Text = "SUPER ADMIN";
                        dash.Show();

                        this.Close();
                    }
                    else
                    {

                        //searching all the accounts on Top admin and Floor admin database
                        try
                        {
                            string searchTop = "SELECT ID, first_name, last_name, username, password, position, activation FROM account WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'";
                            connection.Close();
                            connection.Open();
                            MySqlCommand cmdtop = new MySqlCommand(searchTop, connection);
                            MySqlDataReader rowtop = (cmdtop.ExecuteReader());

                            if (rowtop.HasRows)
                            {
                                while (rowtop.Read())
                                {
                                    lageen.ID = Convert.ToInt32(rowtop["ID"]);
                                    lageen.Position = rowtop["position"].ToString();
                                    lageen.Username = rowtop["username"].ToString();
                                    lageen.Firstname = rowtop["first_name"].ToString();
                                    lageen.Lastname = rowtop["last_name"].ToString();
                                    lageen.Password = rowtop["password"].ToString();
                                    lageen.Activation = rowtop["activation"].ToString();
                                    Activity(lageen);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Log-in Credentials!");
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        connection.Close();
                    }
                }
            }
        }
    }
}
