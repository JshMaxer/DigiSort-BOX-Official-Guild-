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
            
        }

        private void btnraw_Click(object sender, EventArgs e)
        {
            
        }

        private void btnready_Click(object sender, EventArgs e)
        {
            
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            
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
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //checked image
            btdashboard.Image = Properties.Resources.dashboard__1_;

            //disable other image color
            btnrawmaterials.Image = Properties.Resources.raw_materials;
            btnunprintedshirts.Image = Properties.Resources.cloth;
            btnreadytosell.Image = Properties.Resources.trade;
            btndamageitems.Image = Properties.Resources.package;
            btninvent.Image = Properties.Resources.inventory;

            mainpanel.Controls.Clear();
            Forms.maindashboard maindash = new Forms.maindashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainpanel.Controls.Add(maindash);
            maindash.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void btdashboard_Click(object sender, EventArgs e)
        {
            //checked image
            btdashboard.Image = Properties.Resources.dashboard__1_;

            //disable other image color
            btnrawmaterials.Image = Properties.Resources.raw_materials;
            btnunprintedshirts.Image = Properties.Resources.cloth;
            btnreadytosell.Image = Properties.Resources.trade;
            btndamageitems.Image = Properties.Resources.package;
            btninvent.Image = Properties.Resources.inventory;

            mainpanel.Controls.Clear();
            Forms.maindashboard maindash = new Forms.maindashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainpanel.Controls.Add(maindash);
            maindash.Show();
        }

        private void btnunprintedshirts_Click(object sender, EventArgs e)
        {
            //checked image
            btnunprintedshirts.Image = Properties.Resources.cloth__1_;
            

            //disable other image color
            btnrawmaterials.Image = Properties.Resources.raw_materials;
            btdashboard.Image = Properties.Resources.dashboard;
            btnreadytosell.Image = Properties.Resources.trade;
            btndamageitems.Image = Properties.Resources.package;
            btninvent.Image = Properties.Resources.inventory;

            mainpanel.Controls.Clear();
            Forms.Unprinted unprint = new Forms.Unprinted() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainpanel.Controls.Add(unprint);
            unprint.Show();
        }

        private void btnrawmaterials_Click(object sender, EventArgs e)
        {
            //checked image
            btnrawmaterials.Image = Properties.Resources.raw_materials__1_;

            //disable other image color
            btnunprintedshirts.Image = Properties.Resources.cloth;
            btdashboard.Image = Properties.Resources.dashboard;
            btnreadytosell.Image = Properties.Resources.trade;
            btndamageitems.Image = Properties.Resources.package;
            btninvent.Image = Properties.Resources.inventory;

            mainpanel.Controls.Clear();
            Forms.RawMaterial raw = new Forms.RawMaterial() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainpanel.Controls.Add(raw);
            raw.Show();
        }

        private void btnreadytosell_Click(object sender, EventArgs e)
        {
            //checked image
            btnreadytosell.Image = Properties.Resources.trade__1_;
            
            //disable other image color
            btnunprintedshirts.Image = Properties.Resources.cloth;
            btdashboard.Image = Properties.Resources.dashboard;
            btnrawmaterials.Image = Properties.Resources.raw_materials;
            btndamageitems.Image = Properties.Resources.package;
            btninvent.Image = Properties.Resources.inventory;

            mainpanel.Controls.Clear();
            Forms.ReadytoSell ready = new Forms.ReadytoSell() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainpanel.Controls.Add(ready);
            ready.Show();
        }

        private void btndamageitems_Click(object sender, EventArgs e)
        {
            //checked image
            btndamageitems.Image = Properties.Resources.package__1_;

            //disable other image color
            btnunprintedshirts.Image = Properties.Resources.cloth;
            btdashboard.Image = Properties.Resources.dashboard;
            btnrawmaterials.Image = Properties.Resources.raw_materials;
            btnreadytosell.Image = Properties.Resources.trade;
            btninvent.Image = Properties.Resources.inventory;

            mainpanel.Controls.Clear();
            Front_end.Damaged_Items dmg = new Front_end.Damaged_Items() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainpanel.Controls.Add(dmg);
            dmg.Show();
        }

        private void btninvent_Click(object sender, EventArgs e)
        {
            //checked image
            btninvent.Image = Properties.Resources.inventory__1_;

            //disable other image color
            btnunprintedshirts.Image = Properties.Resources.cloth;
            btdashboard.Image = Properties.Resources.dashboard;
            btnrawmaterials.Image = Properties.Resources.raw_materials;
            btnreadytosell.Image = Properties.Resources.trade;
            btndamageitems.Image = Properties.Resources.package;

            mainpanel.Controls.Clear();
            Forms.Inventory inv = new Forms.Inventory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.mainpanel.Controls.Add(inv);
            inv.Show();
        }

        private void btnnlogout_Click(object sender, EventArgs e)
        {
            
        }

        private void btnuseraccount_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlogout_Click(object sender, EventArgs e)
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

        private void btuseraccount_Click(object sender, EventArgs e)
        {
            Forms.useraccount user = new useraccount();
            user.txtusername.Text = txtname.Text;
            user.ShowDialog();
        }
    }
}
