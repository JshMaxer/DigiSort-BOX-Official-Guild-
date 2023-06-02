using System;
using System.Windows.Forms;

namespace DigiSort_Box.Forms
{
    public partial class preview : Form
    {
        public preview()
        {
            InitializeComponent();
        }

        private void btnraw_Click(object sender, EventArgs e)
        {
            Forms.RawMaterial raw = new Forms.RawMaterial();
            raw.btnadd.Enabled = false;
            raw.btnback.Visible = true;
            raw.Show();
            this.Visible = false;
        }

        private void btnunprint_Click(object sender, EventArgs e)
        {
            Forms.Unprinted unprint = new Forms.Unprinted();
            unprint.btnadd.Enabled = false;
            unprint.btnback.Visible = true;
            unprint.Show();
            this.Visible = false;
        }

        private void btnready_Click(object sender, EventArgs e)
        {
            Forms.ReadytoSell ready = new Forms.ReadytoSell();
            ready.btnadd.Enabled = false;
            ready.btnback.Visible = true;
            ready.Show();
            this.Visible = false;
        }

        private void preview_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.DigiSortBox dg = new Forms.DigiSortBox();
            dg.Show();
        }

        private void preview_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
