using DigiSort_Box.Front_end;
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
                if (txtusername.Text.Equals("Preview") || txtusername.Text.Equals("preview") && (txtpassword.Text.Equals("Admin") || txtpassword.Text.Equals("admin")))
                {
                    MessageBox.Show("This account is for preview forms only. You cannot do anything on other forms you just previewing them.\nThis account is usually used only for Front-End Developer");
                    Forms.preview pv = new Forms.preview();
                    this.Close();
                    pv.Show();
                }
                else
                {
                    //searching all the accounts on Top admin and Floor admin database
                    try
                    {
                        string searchTop = "SELECT first_name, last_name, username, password, position, activation FROM account WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'";
                        connection.Close();
                        connection.Open();
                        MySqlCommand cmdtop = new MySqlCommand(searchTop, connection);
                        MySqlDataReader rowtop = (cmdtop.ExecuteReader());

                        if (rowtop.HasRows)
                        {
                            while (rowtop.Read())
                            {
                                string fname = rowtop["first_name"].ToString();
                                string lname = rowtop["last_name"].ToString();
                                string usename = rowtop["username"].ToString();
                                string pos = rowtop["position"].ToString();
                                string active = rowtop["activation"].ToString();

                                if(active.Equals("InActive"))
                                {
                                    MessageBox.Show("Sorry, the account you're trying is Inactive.", "Log-in Denied");
                                }
                                else
                                {
                                    MessageBox.Show("Log-in Succesful!\nHello " + fname + " " + lname, pos);

                                    Forms.Dashboard dash = new Forms.Dashboard();
                                    dash.txtname.Text = usename;
                                    dash.Show();

                                    this.Close();
                                }
                                
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
                //end of database -------------------------------------------------------------------
            }
        }
    }
