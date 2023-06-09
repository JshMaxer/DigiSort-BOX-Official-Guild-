﻿using DigiSort_Box.Model;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Front_end
{
    public partial class Userreset : Form
    {
        MySqlConnection connection = Host.connection;
        public Userreset()
        {
            InitializeComponent();
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {
            Database.userreset rst = new Database.userreset();
            rst.resetpass(cbusername, txtpassword);
            this.Close();
        }

        private void Userreset_Load(object sender, EventArgs e)
        {
            Database.userreset rst = new Database.userreset();
            rst.user(cbusername);
        }

        private void cbusername_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtpassword.Enabled = true;

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text.Equals("") || txtpassword.Text == "" || txtpassword.Text == null)
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
