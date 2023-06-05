using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiSort_Box.Model
{
    public partial class IPConfig : Form
    {
        public IPConfig()
        {
            InitializeComponent();
        }
        private void btntxt_Click(object sender, EventArgs e)
        {
            string newConnectionString = $"datasource={txtip.Text};port=3306;Initial Catalog=digisortbox;username={txtusername.Text};password=";
            if (!string.IsNullOrEmpty(txtip.Text))
            {
                Host.UpdateConnectionString(newConnectionString);
            }

            MessageBox.Show("Your Connectiion is\n" + Host.DefaultConnectionString, "Connection Successfull Changed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Connectiion is\n\n" + Host.DefaultConnectionString, "Active Connection");
        }

        private void btncb_Click(object sender, EventArgs e)
        {
            if (cbip.SelectedIndex == 0) //localhost
            {
                string newConnectionString = "datasource=localhost;port=3306;Initial Catalog=digisortbox;username=root;password=";
                Host.UpdateConnectionString(newConnectionString);
            }
            else if (cbip.SelectedIndex == 1)//soho
            {
                string newConnectionString = "datasource=192.168.100.41;port=3306;Initial Catalog=digisortbox;username=SOHO;password=";
                Host.UpdateConnectionString(newConnectionString);
            }
            else if (cbip.SelectedIndex == 2)//peer to peer
            {
                string newConnectionString = "datasource=192.168.22.21;port=3306;Initial Catalog=digisortbox;username=DIGISORTBOX;password=";
                Host.UpdateConnectionString(newConnectionString);
            }
            else if (cbip.SelectedIndex == 3)//public ip
            {
                string newConnectionString = "datasource=152.32.112.48;port=3306;Initial Catalog=digisortbox;username=PUBLICIP;password=";
                Host.UpdateConnectionString(newConnectionString);
            }
            else if (cbip.SelectedIndex == 4)//tunnel
            {
                string newConnectionString = $"datasource=billowingsound5850.cotunnel.com;port=3306;Initial Catalog=digisortbox;username=TUNNEL;password=";
                Host.UpdateConnectionString(newConnectionString);
            }
            MessageBox.Show("Your Connectiion is\n\n" + Host.DefaultConnectionString, "Connection Successfull Changed");
        }

        private void txtip_TextChanged(object sender, EventArgs e)
        {
            if (txtip.Text.Equals("") || txtusername.Text.Equals(""))
            {
                btntxt.Enabled = false;
            }
            else
            {
                btntxt.Enabled = true;
            }

            //filter
            string input = txtip.Text;

            // Remove any characters that are not numbers or dots
            string filteredInput = new string(input.Where(c => char.IsDigit(c) || c == '.').ToArray());

            // Limit the input to a maximum of 12 numbers and 3 dots
            if (filteredInput.Length > 15)
                filteredInput = filteredInput.Substring(0, 15);
            if (filteredInput.Count(c => c == '.') > 3)
                filteredInput = filteredInput.Replace(".", string.Empty).Insert(12, ".");

            // Update the TextBox text with the filtered input
            txtip.Text = filteredInput;
            txtip.SelectionStart = filteredInput.Length;
        }

        private void cbip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbip.Text.Equals(""))
            {
                btncb.Enabled = false;
            }
            else
            {
                btncb.Enabled = true;
            }
        }

        private void txtip_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow deletion (backspace or delete key)
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                return;

            // Check if the pressed key is a number or a dot
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // Cancel the key press event
                e.Handled = true;
                return;
            }

            // Count the number of dots in the current text
            int dotCount = txtip.Text.Count(c => c == '.');

            // Check if the pressed key is a dot
            if (e.KeyChar == '.')
            {
                // Cancel the key press event if there are already 3 dots
                if (dotCount >= 3)
                    e.Handled = true;
            }
            else
            {
                // Cancel the key press event if the total length (including dots) exceeds 12
                if (txtip.TextLength - dotCount >= 12)
                    e.Handled = true;
            }
        }


        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            if (txtip.Text.Equals("") || txtusername.Text.Equals(""))
            {
                btntxt.Enabled = false;
            }
            else
            {
                btntxt.Enabled = true;
            }
        }
    }
}
