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
    public partial class Unprinted : Form
    {
        public Unprinted()
        {
            InitializeComponent();
        }

        private void cbothercolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbothercolor.SelectedItem.Equals(""))
            {
                cbotheshade.Items.Clear();
            }
            else if(cbothercolor.SelectedItem.Equals("Purple"))
            {
                cbotheshade.Items.Clear();
                cbotheshade.Items.Add("");
                cbotheshade.Items.Add("Lavender");
                cbotheshade.Items.Add("Lilac");
                cbotheshade.Items.Add("Mauve");
                cbotheshade.Items.Add("Plum");
                cbotheshade.Items.Add("Grape");
                cbotheshade.Items.Add("Violet");
                cbotheshade.Items.Add("Amethyst");
                cbotheshade.Items.Add("Eggplant");
                cbotheshade.Items.Add("Magenta");
                cbotheshade.Items.Add("Mulberry");
            }
            else if(cbothercolor.SelectedItem.Equals("White"))
            {
                cbotheshade.Items.Clear();
                cbotheshade.Items.Add("");
                cbotheshade.Items.Add("Snow");
                cbotheshade.Items.Add("Ivory");
                cbotheshade.Items.Add("Pearl");
                cbotheshade.Items.Add("Creamy");
                cbotheshade.Items.Add("Off-white");
                cbotheshade.Items.Add("Eggshell");
                cbotheshade.Items.Add("Pure white");
                cbotheshade.Items.Add("Antique ");
                cbotheshade.Items.Add("Linen");
                cbotheshade.Items.Add("Champagne ");
            }
            else if (cbothercolor.SelectedItem.Equals("Brown"))
            {
                cbotheshade.Items.Clear();
                cbotheshade.Items.Add("");
                cbotheshade.Items.Add("Beige");
                cbotheshade.Items.Add("Tan");
                cbotheshade.Items.Add("Taupe");
                cbotheshade.Items.Add("Caramel");
                cbotheshade.Items.Add("Chestnut");
                cbotheshade.Items.Add("Coffee");
                cbotheshade.Items.Add("Mahogany");
                cbotheshade.Items.Add("Rust");
                cbotheshade.Items.Add("Sienna");
                cbotheshade.Items.Add("Umber");
            }
            else if (cbothercolor.SelectedItem.Equals("Gray"))
            {
                cbotheshade.Items.Clear();
                cbotheshade.Items.Add("");
                cbotheshade.Items.Add("Silver");
                cbotheshade.Items.Add("Rain");
                cbotheshade.Items.Add("Blue Gray");
                cbotheshade.Items.Add("Dark");
                cbotheshade.Items.Add("Medium");
                cbotheshade.Items.Add("Light slate");
                cbotheshade.Items.Add("Battleship");
                cbotheshade.Items.Add("Cool");
                cbotheshade.Items.Add("Gray-blue");
                cbotheshade.Items.Add("Gray-green");
            }
            else if (cbothercolor.SelectedItem.Equals("Black"))
            {
                cbotheshade.Items.Clear();
                cbotheshade.Items.Add("");
                cbotheshade.Items.Add("Jet");
                cbotheshade.Items.Add("Onyx");
                cbotheshade.Items.Add("Midnight");
                cbotheshade.Items.Add("Ebony");
                cbotheshade.Items.Add("Licorice");
                cbotheshade.Items.Add("Charcoal");
                cbotheshade.Items.Add("Coal");
                cbotheshade.Items.Add("Raven");
                cbotheshade.Items.Add("Pitch");
                cbotheshade.Items.Add("Ink");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Forms.preview pv = new Forms.preview();
            this.Close();
            pv.Visible = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            cbothercolor.SelectedIndex = 0;

            cbredshade.Text = null;
            cbblueshade.Text = null;
            cbgreenshade.Text = null;
            cborangeshade.Text = null;
            cbyellowshade.Text = null;
            cbotheshade.Text = null;

            cbredsize.Text = null;
            cbbluesize.Text = null;
            cbgreensize.Text = null;
            cborangesize.Text = null;
            cbyellowsize.Text = null;
            cbothersize.Text = null;

            txtbluequan.Text = null;
            txtgreenquan.Text = null;
            txtorangequan.Text = null;
            txtredquan.Text = null;
            txtyellowquan.Text = null;
            txtotherquan.Text = null;
        }
    }
}
