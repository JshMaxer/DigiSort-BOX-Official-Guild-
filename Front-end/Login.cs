using DigiSort_Box.Model;
using DigiSort_Box.Mowdel;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Forms
{
    public partial class Login : Form
    {
        MySqlConnection connection = Host.connection;
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
                if (txtusername.Text.Equals(Back_end.Constants.prevusername) && (txtpassword.Text.Equals(Back_end.Constants.prevpassword)))
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
                    if (txtusername.Text.Equals(Back_end.Constants.username) && txtpassword.Text.Equals(Back_end.Constants.password))
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
                            string searchTop = "SELECT ID, first_name, last_name, username, password, position, activation FROM account WHERE username = '" + txtusername.Text + "' AND password = MD5('" + txtpassword.Text + "')";
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

        private void lblforgot_Click(object sender, EventArgs e)
        {

            DialogResult = MessageBox.Show("Contact the SUPER ADMIN for reset password?", "Forgot Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                string input = Interaction.InputBox("Please enter username", "Username");

                if (!string.IsNullOrEmpty(input))
                {
                    //search username
                    string ad = "SELECT username FROM account where username = '" + input + "'";
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(ad, connection);
                    MySqlDataReader row = cmd.ExecuteReader();

                    try
                    {
                        if (row.HasRows)
                        {
                            while (row.Read())
                            {
                                string user = row["username"].ToString();

                                //contact
                                row.Close();
                                string InsertQuery = "INSERT INTO message_request VALUES ('" + user + "', 'Wants to reset password'" + ")";
                                MySqlCommand command = new MySqlCommand(InsertQuery, connection);
                                command.ExecuteNonQuery();

                                MessageBox.Show(user + ", Your concern has been submitted");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username not found");
                        }

                        connection.Close();
                    }
                    catch (Exception)
                    {
                        //Hide the error message
                    }
                }
                //else
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            if (txtusername.Text.Equals("") || txtpassword.Text.Equals(""))
            {
                btnsignin.Enabled = false;
            }
            else
            {
                btnsignin.Enabled = true;
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtusername.Text.Equals("") || txtpassword.Text.Equals(""))
            {
                btnsignin.Enabled = false;
            }
            else
            {
                btnsignin.Enabled = true;
            }
        }
    }
}
