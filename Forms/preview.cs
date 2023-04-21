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
    public partial class preview : Form
    {
        public preview()
        {
            InitializeComponent();
        }

        private void btnraw_Click(object sender, EventArgs e)
        {
            Forms.RawMaterial raw = new Forms.RawMaterial();
            raw.btnaddmore.Enabled = false;
            raw.btnback.Visible = true;
            raw.Show();
            this.Visible = false;
        }

        private void btnunprint_Click(object sender, EventArgs e)
        {
            Forms.Unprinted unprint = new Forms.Unprinted();
            unprint.btnaddmore.Enabled = false;
            unprint.btnback.Visible = true;
            unprint.Show();
            this.Close();
        }

        private void btnready_Click(object sender, EventArgs e)
        {
            Forms.ReadytoSell ready = new Forms.ReadytoSell();
            ready.btnaddmore.Enabled = false;
            ready.btnback.Visible = true;
            ready.Show();
            this.Close();
        }

        private void preview_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.DigiSortBox dg = new Forms.DigiSortBox();
            dg.Show();
        }

        private void preview_Load(object sender, EventArgs e)
        {

        }
    }
}
