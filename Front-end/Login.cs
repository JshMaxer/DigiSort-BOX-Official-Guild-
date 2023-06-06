using DigiSort_Box.Model;
using DigiSort_Box.Mowdel;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DigiSort_Box.Forms
{
    public partial class Login : Form
    {
        MySqlConnection connection;
        public Login()
        {
            InitializeComponent();
            Host.InitializeConnection();
            connection = Host.connection;
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

        void signin()
        {
            // DATABASE -------------------------------------------------------------------
            if (txtusername.Text.Equals("") || txtpassword.Text.Equals(""))
            {
                MessageBox.Show("Log-in Form must be filled out completely!");
            }
            else
            {
                // Preview account - change restriction
                if (txtusername.Text.Equals(Back_end.Constants.prevusername) && (txtpassword.Text.Equals(Back_end.Constants.prevpassword)))
                {
                    MessageBox.Show("This account is for preview forms only. You cannot do anything on other forms; you are just previewing them.\nThis account is usually used only for the Front-End Developer.", "Front_End");

                    Forms.preview pv = new Forms.preview();
                    this.Close();
                    pv.Show();
                }
                else
                {
                    // Super admin log
                    Lageen lageen = new Lageen();
                    if (txtusername.Text.Equals(Back_end.Constants.username) && txtpassword.Text.Equals(Back_end.Constants.password))
                    {
                        MessageBox.Show("Log-in Successful!\nHello Super admin!", "Super_admin");

                        Forms.Dashboard dash = new Forms.Dashboard(lageen);
                        dash.txtname.Text = "SUPER ADMIN";
                        dash.Show();

                        this.Close();
                    }
                    else
                    {
                        // Searching all the accounts on Top admin and Floor admin database
                        try
                        {
                            string searchTop = "SELECT ID, first_name, last_name, username, password, position, activation FROM account WHERE username = @username AND password = MD5(@password)";
                            connection.Close();
                            connection.Open();

                            MySqlCommand cmdtop = new MySqlCommand(searchTop, connection);
                            cmdtop.Parameters.AddWithValue("@username", txtusername.Text);
                            cmdtop.Parameters.AddWithValue("@password", txtpassword.Text);

                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdtop);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                DataRow rowtop = dataTable.Rows[0];
                                lageen.ID = Convert.ToInt32(rowtop["ID"]);
                                lageen.Position = rowtop["position"].ToString();
                                lageen.Username = rowtop["username"].ToString();
                                lageen.Firstname = rowtop["first_name"].ToString();
                                lageen.Lastname = rowtop["last_name"].ToString();
                                lageen.Password = rowtop["password"].ToString();
                                lageen.Activation = rowtop["activation"].ToString();
                                Activity(lageen);
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
                        finally
                        {
                            connection.Close(); // Move connection.Close() inside the finally block to ensure the connection is closed even in case of an exception
                        }
                    }
                }
            }
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            signin();
        }

        private void lblforgot_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Contact the SUPER ADMIN for reset password?", "Forgot Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string input = Interaction.InputBox("Please enter username", "Username");

                if (!string.IsNullOrEmpty(input))
                {
                    // Search username
                    string selectQuery = "SELECT username FROM account WHERE username = @username";
                    connection.Close();
                    connection.Open();
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@username", input);
                    MySqlDataReader reader = selectCommand.ExecuteReader();

                    try
                    {
                        if (reader.HasRows)
                        {
                            reader.Close();
                            string checkQuery = "SELECT username FROM message_request WHERE username = @username";
                            MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                            checkCommand.Parameters.AddWithValue("@username", input);
                            MySqlDataReader checkReader = checkCommand.ExecuteReader();

                            if (checkReader.HasRows)
                            {
                                MessageBox.Show("Your concern is already submitted!");
                            }
                            else
                            {
                                checkReader.Close();
                                string insertQuery = "INSERT INTO message_request VALUES (@username, 'Wants to reset password')";
                                MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                                insertCommand.Parameters.AddWithValue("@username", input);
                                insertCommand.ExecuteNonQuery();
                                MessageBox.Show(input + ", Your concern has been submitted!");
                            }
                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("Username not found!");
                        }

                        connection.Close();
                    }
                    catch (Exception)
                    {
                        // Hide the error message
                    }
                }
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

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signin();

                e.Handled = true; // Mark the event as handled
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
