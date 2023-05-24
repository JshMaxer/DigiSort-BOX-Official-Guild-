using System;
using System.Windows.Forms;

namespace DigiSort_Box.Forms
{
    public partial class ReadytoSell : Form
    {
        public ReadytoSell()
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
            Database.ReadyToSell ready = new Database.ReadyToSell();
            ready.ready(cbproduct, cbcolor, cbshade, cbsize, txtquantity);

            //clear
            cbproduct.SelectedIndex = 0;
            cbshade.SelectedIndex = 0;
            cbcolor.SelectedIndex = 0;
            cbsize.SelectedIndex = 0;
            txtquantity.Text = null;
            btnadd.Enabled = false;
            
        }

        private void cbcolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbproduct.Text.Equals("") || cbcolor.Text.Equals("") || cbshade.Text.Equals("") || cbsize.Text.Equals("") || txtquantity.Text.Equals(""))
            {
                btnadd.Enabled = false;
            }
            else
            {
                btnadd.Enabled = true;
            }


            if (cbcolor.SelectedIndex == 0)
            {
                cbshade.Items.Clear();
            }
            else if (cbcolor.SelectedItem.Equals("Purple"))
            {
                cbshade.Items.Clear();
                cbshade.Items.Add("");
                cbshade.Items.Add("Lavender");
                cbshade.Items.Add("Lilac");
                cbshade.Items.Add("Mauve");
                cbshade.Items.Add("Plum");
                cbshade.Items.Add("Grape");
                cbshade.Items.Add("Violet");
                cbshade.Items.Add("Amethyst");
                cbshade.Items.Add("Eggplant");
                cbshade.Items.Add("Magenta");
                cbshade.Items.Add("Mulberry");
            }
            else if (cbcolor.SelectedItem.Equals("White"))
            {
                cbshade.Items.Clear();
                cbshade.Items.Add("");
                cbshade.Items.Add("Snow");
                cbshade.Items.Add("Ivory");
                cbshade.Items.Add("Pearl");
                cbshade.Items.Add("Creamy");
                cbshade.Items.Add("Off-white");
                cbshade.Items.Add("Eggshell");
                cbshade.Items.Add("Pure white");
                cbshade.Items.Add("Antique ");
                cbshade.Items.Add("Linen");
                cbshade.Items.Add("Champagne ");
            }
            else if (cbcolor.SelectedItem.Equals("Brown"))
            {
                cbshade.Items.Clear();
                cbshade.Items.Add("");
                cbshade.Items.Add("Beige");
                cbshade.Items.Add("Tan");
                cbshade.Items.Add("Taupe");
                cbshade.Items.Add("Caramel");
                cbshade.Items.Add("Chestnut");
                cbshade.Items.Add("Coffee");
                cbshade.Items.Add("Mahogany");
                cbshade.Items.Add("Rust");
                cbshade.Items.Add("Sienna");
                cbshade.Items.Add("Umber");
            }
            else if (cbcolor.SelectedItem.Equals("Gray"))
            {
                cbshade.Items.Clear();
                cbshade.Items.Add("");
                cbshade.Items.Add("Silver");
                cbshade.Items.Add("Rain");
                cbshade.Items.Add("Blue Gray");
                cbshade.Items.Add("Dark");
                cbshade.Items.Add("Medium");
                cbshade.Items.Add("Light slate");
                cbshade.Items.Add("Battleship");
                cbshade.Items.Add("Cool");
                cbshade.Items.Add("Gray-blue");
                cbshade.Items.Add("Gray-green");
            }
            else if (cbcolor.SelectedItem.Equals("Black"))
            {
                cbshade.Items.Clear();
                cbshade.Items.Add("");
                cbshade.Items.Add("Jet");
                cbshade.Items.Add("Onyx");
                cbshade.Items.Add("Midnight");
                cbshade.Items.Add("Ebony");
                cbshade.Items.Add("Licorice");
                cbshade.Items.Add("Charcoal");
                cbshade.Items.Add("Coal");
                cbshade.Items.Add("Raven");
                cbshade.Items.Add("Pitch");
                cbshade.Items.Add("Ink");
            }
            else if (cbcolor.SelectedItem.Equals("Red"))
            {
                cbshade.Items.Clear();
                cbshade.Items.Add("");
                cbshade.Items.Add("Scarlet");
                cbshade.Items.Add("Crimson");
                cbshade.Items.Add("Magenta");
                cbshade.Items.Add("Cardinal");
                cbshade.Items.Add("Cherry");
            }
            else if (cbcolor.SelectedItem.Equals("Orange"))
            {
                cbshade.Items.Clear();
                cbshade.Items.Add("");
                cbshade.Items.Add("Tangerine ");
                cbshade.Items.Add("Rust");
                cbshade.Items.Add("Bronze");
                cbshade.Items.Add("Neon");
                cbshade.Items.Add("Fire");
            }
            else if (cbcolor.SelectedItem.Equals("Yellow"))
            {
                cbshade.Items.Clear();
                cbshade.Items.Add("");
                cbshade.Items.Add("Mustard");
                cbshade.Items.Add("Corn");
                cbshade.Items.Add("Pineapple");
                cbshade.Items.Add("Marigold");
                cbshade.Items.Add("Royal");
            }
            else if (cbcolor.SelectedItem.Equals("Green"))
            {
                cbshade.Items.Clear();
                cbshade.Items.Add("");
                cbshade.Items.Add("Moss");
                cbshade.Items.Add("Pine");
                cbshade.Items.Add("Military");
                cbshade.Items.Add("Evergreen");
                cbshade.Items.Add("Emerald");
            }
            else if (cbcolor.SelectedItem.Equals("Blue"))
            {
                cbshade.Items.Clear();
                cbshade.Items.Add("");
                cbshade.Items.Add("Sky");
                cbshade.Items.Add("Iris");
                cbshade.Items.Add("Royal");
                cbshade.Items.Add("Navy");
                cbshade.Items.Add("Carolina");
            }
        }

        private void cbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbproduct.Text.Equals("") || cbcolor.Text.Equals("") || cbshade.Text.Equals("") || cbsize.Text.Equals("") || txtquantity.Text.Equals(""))
            {
                btnadd.Enabled = false;
            }
            else
            {
                btnadd.Enabled = true;
            }
        }

        private void cbshade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbproduct.Text.Equals("") || cbcolor.Text.Equals("") || cbshade.Text.Equals("") || cbsize.Text.Equals("") || txtquantity.Text.Equals(""))
            {
                btnadd.Enabled = false;
            }
            else
            {
                btnadd.Enabled = true;
            }
        }

        private void cbsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbproduct.Text.Equals("") || cbcolor.Text.Equals("") || cbshade.Text.Equals("") || cbsize.Text.Equals("") || txtquantity.Text.Equals(""))
            {
                btnadd.Enabled = false;
            }
            else
            {
                btnadd.Enabled = true;
            }
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if (cbproduct.Text.Equals("") || cbcolor.Text.Equals("") || cbshade.Text.Equals("") || cbsize.Text.Equals("") || txtquantity.Text.Equals(""))
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
