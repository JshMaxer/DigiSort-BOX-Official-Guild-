using DigiSort_Box.Model;
using DigiSort_Box.Mowdel;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DigiSort_Box.Forms
{
    public partial class Dashboard : Form
    {
        MySqlConnection connection = Host.connection;
        private Lageen model = new Lageen();

        public Dashboard(Lageen lageen)
        {
            model = lageen;
            InitializeComponent();
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                if (model != null)
                {
                    switch (model.Position)
                    {
                        case "Top_Admin":
                            btndamageitems.Visible = false;
                            btnrawmaterials.Visible = false;
                            btnunprintedshirts.Visible = false;
                            btnreadytosell.Visible = false;
                            btninvent.Visible = true;
                            btndeact.Visible = false;
                            btnactivity.Visible = false;
                            break;
                        case "Floor_Admin":
                            btnrawmaterials.Visible = true;
                            btnunprintedshirts.Visible = true;
                            btnreadytosell.Visible = true;
                            btndamageitems.Visible = true;
                            btninvent.Visible = false;
                            btndeact.Visible = false;
                            btnactivity.Visible = false;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



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
            dmg.txtusername.Text = txtname.Text;
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
            //username
            inv.txtusername.Text = txtname.Text;

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Forms.DigiSortBox digi = new Forms.DigiSortBox();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log-out?", "Logging out?", MessageBoxButtons.YesNo);
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
            if (txtname.Text.Equals("SUPER ADMIN"))
            {
                user.txtusername.Text = "DIGI";
                user.txtfirstname.Text = "SORT";
                user.txtlastname.Text = "BOX";
                user.txtposition.Text = txtname.Text;
            }
            else
            {
                user.txtusername.Text = txtname.Text;
            }

            user.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnactivity_Click(object sender, EventArgs e)
        {
            Front_end.History his = new Front_end.History();
            his.ShowDialog();
        }

        private void btndeact_Click(object sender, EventArgs e)
        {
            Front_end.Account_Management am = new Front_end.Account_Management();
            am.ShowDialog();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
