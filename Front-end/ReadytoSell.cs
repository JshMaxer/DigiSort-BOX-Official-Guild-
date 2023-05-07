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
    public partial class ReadytoSell : Form
    {
        public ReadytoSell()
        {
            InitializeComponent();
        }

        private void cbcolor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbcolor1.SelectedIndex == 0)
            {
                cbshade1.Items.Clear();
            }
            else if(cbcolor1.SelectedIndex == 1)
            {
                cbshade1.Items.Clear();
                cbshade1.Items.Add("");
                cbshade1.Items.Add("Scarlet");
                cbshade1.Items.Add("Crimson");
                cbshade1.Items.Add("Magenta");
                cbshade1.Items.Add("Cardinal");
                cbshade1.Items.Add("Cherry");
            }
            else if(cbcolor1.SelectedItem.Equals("Orange"))
            {
                cbshade1.Items.Clear();
                cbshade1.Items.Add("");
                cbshade1.Items.Add("Tangerine");
                cbshade1.Items.Add("Rust");
                cbshade1.Items.Add("Bronze");
                cbshade1.Items.Add("Neon");
                cbshade1.Items.Add("Fire");
            }
            else if (cbcolor1.SelectedItem.Equals("Yellow"))
            {
                cbshade1.Items.Clear();
                cbshade1.Items.Add("");
                cbshade1.Items.Add("Mustard");
                cbshade1.Items.Add("Corn");
                cbshade1.Items.Add("Pineapple");
                cbshade1.Items.Add("Marigold");
                cbshade1.Items.Add("Royal");
            }
            else if (cbcolor1.SelectedItem.Equals("Green"))
            {
                cbshade1.Items.Clear();
                cbshade1.Items.Add("");
                cbshade1.Items.Add("Moss");
                cbshade1.Items.Add("Pine");
                cbshade1.Items.Add("Military");
                cbshade1.Items.Add("Evergreen");
                cbshade1.Items.Add("Emerald");
            }
            else if (cbcolor1.SelectedItem.Equals("Blue"))
            {
                cbshade1.Items.Clear();
                cbshade1.Items.Add("");
                cbshade1.Items.Add("Sky");
                cbshade1.Items.Add("Iris");
                cbshade1.Items.Add("Royal");
                cbshade1.Items.Add("Navy");
                cbshade1.Items.Add("Carolina");
            }
            else if (cbcolor1.SelectedItem.Equals("Purple"))
            {
                cbshade1.Items.Clear();
                cbshade1.Items.Add("");
                cbshade1.Items.Add("Lavender");
                cbshade1.Items.Add("Lilac");
                cbshade1.Items.Add("Mauve");
                cbshade1.Items.Add("Plum");
                cbshade1.Items.Add("Grape");
                cbshade1.Items.Add("Violet");
                cbshade1.Items.Add("Amethyst");
                cbshade1.Items.Add("Eggplant");
                cbshade1.Items.Add("Magenta");
                cbshade1.Items.Add("Mulberry");
            }
            else if (cbcolor1.SelectedItem.Equals("White"))
            {
                cbshade1.Items.Clear();
                cbshade1.Items.Add("");
                cbshade1.Items.Add("Snow");
                cbshade1.Items.Add("Ivory");
                cbshade1.Items.Add("Pearl");
                cbshade1.Items.Add("Creamy");
                cbshade1.Items.Add("Off-white");
                cbshade1.Items.Add("Eggshell");
                cbshade1.Items.Add("Pure white");
                cbshade1.Items.Add("Antique ");
                cbshade1.Items.Add("Linen");
                cbshade1.Items.Add("Champagne ");
            }
            else if (cbcolor1.SelectedItem.Equals("Brown"))
            {
                cbshade1.Items.Clear();
                cbshade1.Items.Add("");
                cbshade1.Items.Add("Beige");
                cbshade1.Items.Add("Tan");
                cbshade1.Items.Add("Taupe");
                cbshade1.Items.Add("Caramel");
                cbshade1.Items.Add("Chestnut");
                cbshade1.Items.Add("Coffee");
                cbshade1.Items.Add("Mahogany");
                cbshade1.Items.Add("Rust");
                cbshade1.Items.Add("Sienna");
                cbshade1.Items.Add("Umber");
            }
            else if (cbcolor1.SelectedItem.Equals("Gray"))
            {
                cbshade1.Items.Clear();
                cbshade1.Items.Add("");
                cbshade1.Items.Add("Silver");
                cbshade1.Items.Add("Rain");
                cbshade1.Items.Add("Blue Gray");
                cbshade1.Items.Add("Dark");
                cbshade1.Items.Add("Medium");
                cbshade1.Items.Add("Light slate");
                cbshade1.Items.Add("Battleship");
                cbshade1.Items.Add("Cool");
                cbshade1.Items.Add("Gray-blue");
                cbshade1.Items.Add("Gray-green");
            }
            else if (cbcolor1.SelectedItem.Equals("Black"))
            {
                cbshade1.Items.Clear();
                cbshade1.Items.Add("");
                cbshade1.Items.Add("Jet");
                cbshade1.Items.Add("Onyx");
                cbshade1.Items.Add("Midnight");
                cbshade1.Items.Add("Ebony");
                cbshade1.Items.Add("Licorice");
                cbshade1.Items.Add("Charcoal");
                cbshade1.Items.Add("Coal");
                cbshade1.Items.Add("Raven");
                cbshade1.Items.Add("Pitch");
                cbshade1.Items.Add("Ink");
            }
        }

        private void cbcolor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbcolor2.SelectedIndex == 0)
            {
                cbshade2.Items.Clear();
            }
            else if (cbcolor2.SelectedIndex == 1)
            {
                cbshade2.Items.Clear();
                cbshade2.Items.Add("");
                cbshade2.Items.Add("Scarlet");
                cbshade2.Items.Add("Crimson");
                cbshade2.Items.Add("Magenta");
                cbshade2.Items.Add("Cardinal");
                cbshade2.Items.Add("Cherry");
            }
            else if (cbcolor2.SelectedItem.Equals("Orange"))
            {
                cbshade2.Items.Clear();
                cbshade2.Items.Add("");
                cbshade2.Items.Add("Tangerine");
                cbshade2.Items.Add("Rust");
                cbshade2.Items.Add("Bronze");
                cbshade2.Items.Add("Neon");
                cbshade2.Items.Add("Fire");
            }
            else if (cbcolor2.SelectedItem.Equals("Yellow"))
            {
                cbshade2.Items.Clear();
                cbshade2.Items.Add("");
                cbshade2.Items.Add("Mustard");
                cbshade2.Items.Add("Corn");
                cbshade2.Items.Add("Pineapple");
                cbshade2.Items.Add("Marigold");
                cbshade2.Items.Add("Royal");
            }
            else if (cbcolor2.SelectedItem.Equals("Green"))
            {
                cbshade2.Items.Clear();
                cbshade2.Items.Add("");
                cbshade2.Items.Add("Moss");
                cbshade2.Items.Add("Pine");
                cbshade2.Items.Add("Military");
                cbshade2.Items.Add("Evergreen");
                cbshade2.Items.Add("Emerald");
            }
            else if (cbcolor2.SelectedItem.Equals("Blue"))
            {
                cbshade2.Items.Clear();
                cbshade2.Items.Add("");
                cbshade2.Items.Add("Sky");
                cbshade2.Items.Add("Iris");
                cbshade2.Items.Add("Royal");
                cbshade2.Items.Add("Navy");
                cbshade2.Items.Add("Carolina");
            }
            else if (cbcolor2.SelectedItem.Equals("Purple"))
            {
                cbshade2.Items.Clear();
                cbshade2.Items.Add("");
                cbshade2.Items.Add("Lavender");
                cbshade2.Items.Add("Lilac");
                cbshade2.Items.Add("Mauve");
                cbshade2.Items.Add("Plum");
                cbshade2.Items.Add("Grape");
                cbshade2.Items.Add("Violet");
                cbshade2.Items.Add("Amethyst");
                cbshade2.Items.Add("Eggplant");
                cbshade2.Items.Add("Magenta");
                cbshade2.Items.Add("Mulberry");
            }
            else if (cbcolor2.SelectedItem.Equals("White"))
            {
                cbshade2.Items.Clear();
                cbshade2.Items.Add("");
                cbshade2.Items.Add("Snow");
                cbshade2.Items.Add("Ivory");
                cbshade2.Items.Add("Pearl");
                cbshade2.Items.Add("Creamy");
                cbshade2.Items.Add("Off-white");
                cbshade2.Items.Add("Eggshell");
                cbshade2.Items.Add("Pure white");
                cbshade2.Items.Add("Antique ");
                cbshade2.Items.Add("Linen");
                cbshade2.Items.Add("Champagne ");
            }
            else if (cbcolor2.SelectedItem.Equals("Brown"))
            {
                cbshade2.Items.Clear();
                cbshade2.Items.Add("");
                cbshade2.Items.Add("Beige");
                cbshade2.Items.Add("Tan");
                cbshade2.Items.Add("Taupe");
                cbshade2.Items.Add("Caramel");
                cbshade2.Items.Add("Chestnut");
                cbshade2.Items.Add("Coffee");
                cbshade2.Items.Add("Mahogany");
                cbshade2.Items.Add("Rust");
                cbshade2.Items.Add("Sienna");
                cbshade2.Items.Add("Umber");
            }
            else if (cbcolor2.SelectedItem.Equals("Gray"))
            {
                cbshade2.Items.Clear();
                cbshade2.Items.Add("");
                cbshade2.Items.Add("Silver");
                cbshade2.Items.Add("Rain");
                cbshade2.Items.Add("Blue Gray");
                cbshade2.Items.Add("Dark");
                cbshade2.Items.Add("Medium");
                cbshade2.Items.Add("Light slate");
                cbshade2.Items.Add("Battleship");
                cbshade2.Items.Add("Cool");
                cbshade2.Items.Add("Gray-blue");
                cbshade2.Items.Add("Gray-green");
            }
            else if (cbcolor2.SelectedItem.Equals("Black"))
            {
                cbshade2.Items.Clear();
                cbshade2.Items.Add("");
                cbshade2.Items.Add("Jet");
                cbshade2.Items.Add("Onyx");
                cbshade2.Items.Add("Midnight");
                cbshade2.Items.Add("Ebony");
                cbshade2.Items.Add("Licorice");
                cbshade2.Items.Add("Charcoal");
                cbshade2.Items.Add("Coal");
                cbshade2.Items.Add("Raven");
                cbshade2.Items.Add("Pitch");
                cbshade2.Items.Add("Ink");
            }
        }

        private void cbcolor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbcolor3.SelectedIndex == 0)
            {
                cbshade3.Items.Clear();
            }
            else if (cbcolor3.SelectedIndex == 1)
            {
                cbshade3.Items.Clear();
                cbshade3.Items.Add("");
                cbshade3.Items.Add("Scarlet");
                cbshade3.Items.Add("Crimson");
                cbshade3.Items.Add("Magenta");
                cbshade3.Items.Add("Cardinal");
                cbshade3.Items.Add("Cherry");
            }
            else if (cbcolor3.SelectedItem.Equals("Orange"))
            {
                cbshade3.Items.Clear();
                cbshade3.Items.Add("");
                cbshade3.Items.Add("Tangerine");
                cbshade3.Items.Add("Rust");
                cbshade3.Items.Add("Bronze");
                cbshade3.Items.Add("Neon");
                cbshade3.Items.Add("Fire");
            }
            else if (cbcolor3.SelectedItem.Equals("Yellow"))
            {
                cbshade3.Items.Clear();
                cbshade3.Items.Add("");
                cbshade3.Items.Add("Mustard");
                cbshade3.Items.Add("Corn");
                cbshade3.Items.Add("Pineapple");
                cbshade3.Items.Add("Marigold");
                cbshade3.Items.Add("Royal");
            }
            else if (cbcolor3.SelectedItem.Equals("Green"))
            {
                cbshade3.Items.Clear();
                cbshade3.Items.Add("");
                cbshade3.Items.Add("Moss");
                cbshade3.Items.Add("Pine");
                cbshade3.Items.Add("Military");
                cbshade3.Items.Add("Evergreen");
                cbshade3.Items.Add("Emerald");
            }
            else if (cbcolor3.SelectedItem.Equals("Blue"))
            {
                cbshade3.Items.Clear();
                cbshade3.Items.Add("");
                cbshade3.Items.Add("Sky");
                cbshade3.Items.Add("Iris");
                cbshade3.Items.Add("Royal");
                cbshade3.Items.Add("Navy");
                cbshade3.Items.Add("Carolina");
            }
            else if (cbcolor3.SelectedItem.Equals("Purple"))
            {
                cbshade3.Items.Clear();
                cbshade3.Items.Add("");
                cbshade3.Items.Add("Lavender");
                cbshade3.Items.Add("Lilac");
                cbshade3.Items.Add("Mauve");
                cbshade3.Items.Add("Plum");
                cbshade3.Items.Add("Grape");
                cbshade3.Items.Add("Violet");
                cbshade3.Items.Add("Amethyst");
                cbshade3.Items.Add("Eggplant");
                cbshade3.Items.Add("Magenta");
                cbshade3.Items.Add("Mulberry");
            }
            else if (cbcolor3.SelectedItem.Equals("White"))
            {
                cbshade3.Items.Clear();
                cbshade3.Items.Add("");
                cbshade3.Items.Add("Snow");
                cbshade3.Items.Add("Ivory");
                cbshade3.Items.Add("Pearl");
                cbshade3.Items.Add("Creamy");
                cbshade3.Items.Add("Off-white");
                cbshade3.Items.Add("Eggshell");
                cbshade3.Items.Add("Pure white");
                cbshade3.Items.Add("Antique ");
                cbshade3.Items.Add("Linen");
                cbshade3.Items.Add("Champagne ");
            }
            else if (cbcolor3.SelectedItem.Equals("Brown"))
            {
                cbshade3.Items.Clear();
                cbshade3.Items.Add("");
                cbshade3.Items.Add("Beige");
                cbshade3.Items.Add("Tan");
                cbshade3.Items.Add("Taupe");
                cbshade3.Items.Add("Caramel");
                cbshade3.Items.Add("Chestnut");
                cbshade3.Items.Add("Coffee");
                cbshade3.Items.Add("Mahogany");
                cbshade3.Items.Add("Rust");
                cbshade3.Items.Add("Sienna");
                cbshade3.Items.Add("Umber");
            }
            else if (cbcolor3.SelectedItem.Equals("Gray"))
            {
                cbshade3.Items.Clear();
                cbshade3.Items.Add("");
                cbshade3.Items.Add("Silver");
                cbshade3.Items.Add("Rain");
                cbshade3.Items.Add("Blue Gray");
                cbshade3.Items.Add("Dark");
                cbshade3.Items.Add("Medium");
                cbshade3.Items.Add("Light slate");
                cbshade3.Items.Add("Battleship");
                cbshade3.Items.Add("Cool");
                cbshade3.Items.Add("Gray-blue");
                cbshade3.Items.Add("Gray-green");
            }
            else if (cbcolor3.SelectedItem.Equals("Black"))
            {
                cbshade3.Items.Clear();
                cbshade3.Items.Add("");
                cbshade3.Items.Add("Jet");
                cbshade3.Items.Add("Onyx");
                cbshade3.Items.Add("Midnight");
                cbshade3.Items.Add("Ebony");
                cbshade3.Items.Add("Licorice");
                cbshade3.Items.Add("Charcoal");
                cbshade3.Items.Add("Coal");
                cbshade3.Items.Add("Raven");
                cbshade3.Items.Add("Pitch");
                cbshade3.Items.Add("Ink");
            }
        }

        private void cbcolor4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbcolor4.SelectedIndex == 0)
            {
                cbshade4.Items.Clear();
            }
            else if (cbcolor4.SelectedIndex == 1)
            {
                cbshade4.Items.Clear();
                cbshade4.Items.Add("");
                cbshade4.Items.Add("Scarlet");
                cbshade4.Items.Add("Crimson");
                cbshade4.Items.Add("Magenta");
                cbshade4.Items.Add("Cardinal");
                cbshade4.Items.Add("Cherry");
            }
            else if (cbcolor4.SelectedItem.Equals("Orange"))
            {
                cbshade4.Items.Clear();
                cbshade4.Items.Add("");
                cbshade4.Items.Add("Tangerine");
                cbshade4.Items.Add("Rust");
                cbshade4.Items.Add("Bronze");
                cbshade4.Items.Add("Neon");
                cbshade4.Items.Add("Fire");
            }
            else if (cbcolor4.SelectedItem.Equals("Yellow"))
            {
                cbshade4.Items.Clear();
                cbshade4.Items.Add("");
                cbshade4.Items.Add("Mustard");
                cbshade4.Items.Add("Corn");
                cbshade4.Items.Add("Pineapple");
                cbshade4.Items.Add("Marigold");
                cbshade4.Items.Add("Royal");
            }
            else if (cbcolor4.SelectedItem.Equals("Green"))
            {
                cbshade4.Items.Clear();
                cbshade4.Items.Add("");
                cbshade4.Items.Add("Moss");
                cbshade4.Items.Add("Pine");
                cbshade4.Items.Add("Military");
                cbshade4.Items.Add("Evergreen");
                cbshade4.Items.Add("Emerald");
            }
            else if (cbcolor4.SelectedItem.Equals("Blue"))
            {
                cbshade4.Items.Clear();
                cbshade4.Items.Add("");
                cbshade4.Items.Add("Sky");
                cbshade4.Items.Add("Iris");
                cbshade4.Items.Add("Royal");
                cbshade4.Items.Add("Navy");
                cbshade4.Items.Add("Carolina");
            }
            else if (cbcolor4.SelectedItem.Equals("Purple"))
            {
                cbshade4.Items.Clear();
                cbshade4.Items.Add("");
                cbshade4.Items.Add("Lavender");
                cbshade4.Items.Add("Lilac");
                cbshade4.Items.Add("Mauve");
                cbshade4.Items.Add("Plum");
                cbshade4.Items.Add("Grape");
                cbshade4.Items.Add("Violet");
                cbshade4.Items.Add("Amethyst");
                cbshade4.Items.Add("Eggplant");
                cbshade4.Items.Add("Magenta");
                cbshade4.Items.Add("Mulberry");
            }
            else if (cbcolor4.SelectedItem.Equals("White"))
            {
                cbshade4.Items.Clear();
                cbshade4.Items.Add("");
                cbshade4.Items.Add("Snow");
                cbshade4.Items.Add("Ivory");
                cbshade4.Items.Add("Pearl");
                cbshade4.Items.Add("Creamy");
                cbshade4.Items.Add("Off-white");
                cbshade4.Items.Add("Eggshell");
                cbshade4.Items.Add("Pure white");
                cbshade4.Items.Add("Antique ");
                cbshade4.Items.Add("Linen");
                cbshade4.Items.Add("Champagne ");
            }
            else if (cbcolor4.SelectedItem.Equals("Brown"))
            {
                cbshade4.Items.Clear();
                cbshade4.Items.Add("");
                cbshade4.Items.Add("Beige");
                cbshade4.Items.Add("Tan");
                cbshade4.Items.Add("Taupe");
                cbshade4.Items.Add("Caramel");
                cbshade4.Items.Add("Chestnut");
                cbshade4.Items.Add("Coffee");
                cbshade4.Items.Add("Mahogany");
                cbshade4.Items.Add("Rust");
                cbshade4.Items.Add("Sienna");
                cbshade4.Items.Add("Umber");
            }
            else if (cbcolor4.SelectedItem.Equals("Gray"))
            {
                cbshade4.Items.Clear();
                cbshade4.Items.Add("");
                cbshade4.Items.Add("Silver");
                cbshade4.Items.Add("Rain");
                cbshade4.Items.Add("Blue Gray");
                cbshade4.Items.Add("Dark");
                cbshade4.Items.Add("Medium");
                cbshade4.Items.Add("Light slate");
                cbshade4.Items.Add("Battleship");
                cbshade4.Items.Add("Cool");
                cbshade4.Items.Add("Gray-blue");
                cbshade4.Items.Add("Gray-green");
            }
            else if (cbcolor4.SelectedItem.Equals("Black"))
            {
                cbshade4.Items.Clear();
                cbshade4.Items.Add("");
                cbshade4.Items.Add("Jet");
                cbshade4.Items.Add("Onyx");
                cbshade4.Items.Add("Midnight");
                cbshade4.Items.Add("Ebony");
                cbshade4.Items.Add("Licorice");
                cbshade4.Items.Add("Charcoal");
                cbshade4.Items.Add("Coal");
                cbshade4.Items.Add("Raven");
                cbshade4.Items.Add("Pitch");
                cbshade4.Items.Add("Ink");
            }
        }

        private void cbcolor5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbcolor5.SelectedIndex == 0)
            {
                cbshade5.Items.Clear();
            }
            else if (cbcolor5.SelectedIndex == 1)
            {
                cbshade5.Items.Clear();
                cbshade5.Items.Add("");
                cbshade5.Items.Add("Scarlet");
                cbshade5.Items.Add("Crimson");
                cbshade5.Items.Add("Magenta");
                cbshade5.Items.Add("Cardinal");
                cbshade5.Items.Add("Cherry");
            }
            else if (cbcolor5.SelectedItem.Equals("Orange"))
            {
                cbshade5.Items.Clear();
                cbshade5.Items.Add("");
                cbshade5.Items.Add("Tangerine");
                cbshade5.Items.Add("Rust");
                cbshade5.Items.Add("Bronze");
                cbshade5.Items.Add("Neon");
                cbshade5.Items.Add("Fire");
            }
            else if (cbcolor5.SelectedItem.Equals("Yellow"))
            {
                cbshade5.Items.Clear();
                cbshade5.Items.Add("");
                cbshade5.Items.Add("Mustard");
                cbshade5.Items.Add("Corn");
                cbshade5.Items.Add("Pineapple");
                cbshade5.Items.Add("Marigold");
                cbshade5.Items.Add("Royal");
            }
            else if (cbcolor5.SelectedItem.Equals("Green"))
            {
                cbshade5.Items.Clear();
                cbshade5.Items.Add("");
                cbshade5.Items.Add("Moss");
                cbshade5.Items.Add("Pine");
                cbshade5.Items.Add("Military");
                cbshade5.Items.Add("Evergreen");
                cbshade5.Items.Add("Emerald");
            }
            else if (cbcolor5.SelectedItem.Equals("Blue"))
            {
                cbshade5.Items.Clear();
                cbshade5.Items.Add("");
                cbshade5.Items.Add("Sky");
                cbshade5.Items.Add("Iris");
                cbshade5.Items.Add("Royal");
                cbshade5.Items.Add("Navy");
                cbshade5.Items.Add("Carolina");
            }
            else if (cbcolor5.SelectedItem.Equals("Purple"))
            {
                cbshade5.Items.Clear();
                cbshade5.Items.Add("");
                cbshade5.Items.Add("Lavender");
                cbshade5.Items.Add("Lilac");
                cbshade5.Items.Add("Mauve");
                cbshade5.Items.Add("Plum");
                cbshade5.Items.Add("Grape");
                cbshade5.Items.Add("Violet");
                cbshade5.Items.Add("Amethyst");
                cbshade5.Items.Add("Eggplant");
                cbshade5.Items.Add("Magenta");
                cbshade5.Items.Add("Mulberry");
            }
            else if (cbcolor5.SelectedItem.Equals("White"))
            {
                cbshade5.Items.Clear();
                cbshade5.Items.Add("");
                cbshade5.Items.Add("Snow");
                cbshade5.Items.Add("Ivory");
                cbshade5.Items.Add("Pearl");
                cbshade5.Items.Add("Creamy");
                cbshade5.Items.Add("Off-white");
                cbshade5.Items.Add("Eggshell");
                cbshade5.Items.Add("Pure white");
                cbshade5.Items.Add("Antique ");
                cbshade5.Items.Add("Linen");
                cbshade5.Items.Add("Champagne ");
            }
            else if (cbcolor5.SelectedItem.Equals("Brown"))
            {
                cbshade5.Items.Clear();
                cbshade5.Items.Add("");
                cbshade5.Items.Add("Beige");
                cbshade5.Items.Add("Tan");
                cbshade5.Items.Add("Taupe");
                cbshade5.Items.Add("Caramel");
                cbshade5.Items.Add("Chestnut");
                cbshade5.Items.Add("Coffee");
                cbshade5.Items.Add("Mahogany");
                cbshade5.Items.Add("Rust");
                cbshade5.Items.Add("Sienna");
                cbshade5.Items.Add("Umber");
            }
            else if (cbcolor5.SelectedItem.Equals("Gray"))
            {
                cbshade5.Items.Clear();
                cbshade5.Items.Add("");
                cbshade5.Items.Add("Silver");
                cbshade5.Items.Add("Rain");
                cbshade5.Items.Add("Blue Gray");
                cbshade5.Items.Add("Dark");
                cbshade5.Items.Add("Medium");
                cbshade5.Items.Add("Light slate");
                cbshade5.Items.Add("Battleship");
                cbshade5.Items.Add("Cool");
                cbshade5.Items.Add("Gray-blue");
                cbshade5.Items.Add("Gray-green");
            }
            else if (cbcolor5.SelectedItem.Equals("Black"))
            {
                cbshade5.Items.Clear();
                cbshade5.Items.Add("");
                cbshade5.Items.Add("Jet");
                cbshade5.Items.Add("Onyx");
                cbshade5.Items.Add("Midnight");
                cbshade5.Items.Add("Ebony");
                cbshade5.Items.Add("Licorice");
                cbshade5.Items.Add("Charcoal");
                cbshade5.Items.Add("Coal");
                cbshade5.Items.Add("Raven");
                cbshade5.Items.Add("Pitch");
                cbshade5.Items.Add("Ink");
            }
        }

        private void cbcolor6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbcolor6.SelectedIndex == 0)
            {
                cbshade6.Items.Clear();
            }
            else if (cbcolor6.SelectedIndex == 1)
            {
                cbshade6.Items.Clear();
                cbshade6.Items.Add("");
                cbshade6.Items.Add("Scarlet");
                cbshade6.Items.Add("Crimson");
                cbshade6.Items.Add("Magenta");
                cbshade6.Items.Add("Cardinal");
                cbshade6.Items.Add("Cherry");
            }
            else if (cbcolor6.SelectedItem.Equals("Orange"))
            {
                cbshade6.Items.Clear();
                cbshade6.Items.Add("");
                cbshade6.Items.Add("Tangerine");
                cbshade6.Items.Add("Rust");
                cbshade6.Items.Add("Bronze");
                cbshade6.Items.Add("Neon");
                cbshade6.Items.Add("Fire");
            }
            else if (cbcolor6.SelectedItem.Equals("Yellow"))
            {
                cbshade6.Items.Clear();
                cbshade6.Items.Add("");
                cbshade6.Items.Add("Mustard");
                cbshade6.Items.Add("Corn");
                cbshade6.Items.Add("Pineapple");
                cbshade6.Items.Add("Marigold");
                cbshade6.Items.Add("Royal");
            }
            else if (cbcolor6.SelectedItem.Equals("Green"))
            {
                cbshade6.Items.Clear();
                cbshade6.Items.Add("");
                cbshade6.Items.Add("Moss");
                cbshade6.Items.Add("Pine");
                cbshade6.Items.Add("Military");
                cbshade6.Items.Add("Evergreen");
                cbshade6.Items.Add("Emerald");
            }
            else if (cbcolor6.SelectedItem.Equals("Blue"))
            {
                cbshade6.Items.Clear();
                cbshade6.Items.Add("");
                cbshade6.Items.Add("Sky");
                cbshade6.Items.Add("Iris");
                cbshade6.Items.Add("Royal");
                cbshade6.Items.Add("Navy");
                cbshade6.Items.Add("Carolina");
            }
            else if (cbcolor6.SelectedItem.Equals("Purple"))
            {
                cbshade6.Items.Clear();
                cbshade6.Items.Add("");
                cbshade6.Items.Add("Lavender");
                cbshade6.Items.Add("Lilac");
                cbshade6.Items.Add("Mauve");
                cbshade6.Items.Add("Plum");
                cbshade6.Items.Add("Grape");
                cbshade6.Items.Add("Violet");
                cbshade6.Items.Add("Amethyst");
                cbshade6.Items.Add("Eggplant");
                cbshade6.Items.Add("Magenta");
                cbshade6.Items.Add("Mulberry");
            }
            else if (cbcolor6.SelectedItem.Equals("White"))
            {
                cbshade6.Items.Clear();
                cbshade6.Items.Add("");
                cbshade6.Items.Add("Snow");
                cbshade6.Items.Add("Ivory");
                cbshade6.Items.Add("Pearl");
                cbshade6.Items.Add("Creamy");
                cbshade6.Items.Add("Off-white");
                cbshade6.Items.Add("Eggshell");
                cbshade6.Items.Add("Pure white");
                cbshade6.Items.Add("Antique ");
                cbshade6.Items.Add("Linen");
                cbshade6.Items.Add("Champagne ");
            }
            else if (cbcolor6.SelectedItem.Equals("Brown"))
            {
                cbshade6.Items.Clear();
                cbshade6.Items.Add("");
                cbshade6.Items.Add("Beige");
                cbshade6.Items.Add("Tan");
                cbshade6.Items.Add("Taupe");
                cbshade6.Items.Add("Caramel");
                cbshade6.Items.Add("Chestnut");
                cbshade6.Items.Add("Coffee");
                cbshade6.Items.Add("Mahogany");
                cbshade6.Items.Add("Rust");
                cbshade6.Items.Add("Sienna");
                cbshade6.Items.Add("Umber");
            }
            else if (cbcolor6.SelectedItem.Equals("Gray"))
            {
                cbshade6.Items.Clear();
                cbshade6.Items.Add("");
                cbshade6.Items.Add("Silver");
                cbshade6.Items.Add("Rain");
                cbshade6.Items.Add("Blue Gray");
                cbshade6.Items.Add("Dark");
                cbshade6.Items.Add("Medium");
                cbshade6.Items.Add("Light slate");
                cbshade6.Items.Add("Battleship");
                cbshade6.Items.Add("Cool");
                cbshade6.Items.Add("Gray-blue");
                cbshade6.Items.Add("Gray-green");
            }
            else if (cbcolor6.SelectedItem.Equals("Black"))
            {
                cbshade6.Items.Clear();
                cbshade6.Items.Add("");
                cbshade6.Items.Add("Jet");
                cbshade6.Items.Add("Onyx");
                cbshade6.Items.Add("Midnight");
                cbshade6.Items.Add("Ebony");
                cbshade6.Items.Add("Licorice");
                cbshade6.Items.Add("Charcoal");
                cbshade6.Items.Add("Coal");
                cbshade6.Items.Add("Raven");
                cbshade6.Items.Add("Pitch");
                cbshade6.Items.Add("Ink");
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
            txtproduct1.Text = null;
            txtproduct2.Text = null;
            txtproduct3.Text = null;
            txtproduct4.Text = null;
            txtproduct5.Text = null;
            txtproduct6.Text = null;

            cbcolor1.SelectedIndex = 0;
            cbshade1.Items.Clear();

            cbcolor2.SelectedIndex = 0;
            cbshade2.Items.Clear();

            cbcolor3.SelectedIndex = 0;
            cbshade3.Items.Clear();

            cbcolor4.SelectedIndex = 0;
            cbshade4.Items.Clear();

            cbcolor5.SelectedIndex = 0;
            cbshade5.Items.Clear();

            cbcolor6.SelectedIndex = 0;
            cbshade6.Items.Clear();

            cbsize1.Text = null;
            cbsize2.Text = null;
            cbsize3.Text = null;
            cbsize4.Text = null;
            cbsize5.Text = null;
            cbsize6.Text = null;

            txtquan1.Text = null;
            txtquan2.Text = null;
            txtquan3.Text = null;
            txtquan4.Text = null;
            txtquan5.Text = null;
            txtquan6.Text = null;
        }
    }
}
