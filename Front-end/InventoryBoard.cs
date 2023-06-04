using System;
using System.Windows.Forms;

namespace DigiSort_Box.Forms
{
    public partial class Inventory : Form
    {

        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            //show Database table
            Database.Inventory inv = new Database.Inventory();
            inv.InvLoad(dgrawmaterial, dgunprinted, dgready, dgrawdamage, dgreadydamage, dgunprinteddamage);
        }


        private void txtunprinted_TextChanged_1(object sender, EventArgs e)
        {
            Database.Inventory inv = new Database.Inventory();
            inv.unprintSearch(txtsearch, dgunprinted);
            inv.readySearch(txtsearch, dgready);
            inv.rawSearch(txtsearch, dgrawmaterial);
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            Forms.update up = new Forms.update();
            up.txtusername.Text = txtusername.Text;
            up.ShowDialog();
        }
        private void btndelete_Click_1(object sender, EventArgs e)
        {
            Forms.delete de = new Forms.delete();
            de.txtusername.Text = txtusername.Text;
            de.ShowDialog();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Database.Inventory inv = new Database.Inventory();
            Back_end.Print pr = new Back_end.Print();
            pr.ExportToPdf(dgready, dgunprinted, dgready);
        }

    }
}

