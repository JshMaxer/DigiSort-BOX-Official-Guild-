using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiSort_Box.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnunprinted_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Forms.Unprinted unprint = new Forms.Unprinted() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainpanel.Controls.Add(unprint);
            unprint.Show();
        }

        private void btnraw_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Forms.RawMaterial raw = new Forms.RawMaterial() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainpanel.Controls.Add(raw);
            raw.Show();
        }

        private void btnready_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Forms.ReadytoSell ready = new Forms.ReadytoSell() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainpanel.Controls.Add(ready);
            ready.Show();
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Forms.Inventory inv = new Forms.Inventory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainpanel.Controls.Add(inv);
            inv.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtlogout_Click(object sender, EventArgs e)
        {
            Forms.DigiSortBox digi = new Forms.DigiSortBox();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Logging out?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                digi.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
            
        }

       

        private void btndash_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Forms.maindashboard maindash = new Forms.maindashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainpanel.Controls.Add(maindash);
            maindash.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Forms.maindashboard maindash = new Forms.maindashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainpanel.Controls.Add(maindash);
            maindash.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.DigiSortBox digi = new Forms.DigiSortBox();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Logging out?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                digi.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
