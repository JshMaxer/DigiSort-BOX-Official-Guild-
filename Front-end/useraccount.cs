﻿using DigiSort_Box.Model;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Forms
{
    public partial class useraccount : Form
    {
        MySqlConnection connection = Host.connection;
        public useraccount()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void useraccount_Load(object sender, EventArgs e)
        {
            //Database
            Database.useraccount acc = new Database.useraccount();
            acc.user(txtusername, txtfirstname, txtlastname, txtposition);
            acc.disreset(txtusername, btnreset, btnuserreset, btnconcern);
        }

        private void exitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            Front_end.reset_password reset = new Front_end.reset_password();
            DialogResult dr = MessageBox.Show("Are you sure you want to reset password?", "DigiSortBox", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                reset.lblusername.Text = txtusername.Text;
                reset.ShowDialog();
            }
            else
            {
                //ok.
            }
        }

        private void btnuserreset_Click(object sender, EventArgs e)
        {
            Front_end.Userreset user = new Front_end.Userreset();
            user.ShowDialog();
        }

        private void btnconcern_Click(object sender, EventArgs e)
        {
            Front_end.Concern crn = new Front_end.Concern();
            crn.ShowDialog();
        }
    }
}
