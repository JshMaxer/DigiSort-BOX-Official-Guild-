using System;
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
            //database
            Database.RawMaterial rm = new Database.RawMaterial();
            rm.raw(cbmaterial, cbdesign, cbcolor, txtquantity, btnadd);
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            //disable
            if (cbmaterial.Text.Equals("") || cbdesign.Text.Equals("") || cbcolor.Text.Equals("") || txtquantity.Text.Equals(""))
            {
                btnadd.Enabled = false;
            }
            else
            {
                btnadd.Enabled = true;
            }
        }

        private void cbmaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            //disable
            if (cbmaterial.Text.Equals("") || cbdesign.Text.Equals("") || cbcolor.Text.Equals("") || txtquantity.Text.Equals(""))
            {
                btnadd.Enabled = false;
            }
            else
            {
                btnadd.Enabled = true;
            }
        }

        private void cbdesign_SelectedIndexChanged(object sender, EventArgs e)
        {
            //disable
            if (cbmaterial.Text.Equals("") || cbdesign.Text.Equals("") || cbcolor.Text.Equals("") || txtquantity.Text.Equals(""))
            {
                btnadd.Enabled = false;
            }
            else
            {
                btnadd.Enabled = true;
            }
        }

        private void cbcolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //disable
            if (cbmaterial.Text.Equals("") || cbdesign.Text.Equals("") || cbcolor.Text.Equals("") || txtquantity.Text.Equals(""))
            {
                btnadd.Enabled = false;
            }
            else
            {
                btnadd.Enabled = true;
            }
        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }
    }
}
