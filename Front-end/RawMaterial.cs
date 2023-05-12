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
            cbmaterial.SelectedIndex = 0;
            cbdesign.SelectedIndex = 0;
            cbcolor.SelectedIndex = 0;
            txtquantity.Text = null;
        }
    }
}
