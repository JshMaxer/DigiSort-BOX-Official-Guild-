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
    public partial class RawMaterial : Form
    {
        public RawMaterial()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Forms.preview pv = new Forms.preview();
            this.Close();
            pv.Visible = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            cbmaterial1.Text = null;
            cbmaterial2.Text = null;
            cbmaterial3.Text = null;
            cbmaterial4.Text = null;

            cbdesign1.Text = null;
            cbdesign2.Text = null;
            cbdesign3.Text = null;
            cbdesign4.Text = null;

            cbcolor1.SelectedIndex = 0;
            cbcolor2.SelectedIndex = 0;
            cbcolor3.SelectedIndex = 0;
            cbcolor4.SelectedIndex = 0;

            txtquan1.Text = null;
            txtquan2.Text = null;
            txtquan3.Text = null;
            txtquan4.Text = null;
        }
    }
}
