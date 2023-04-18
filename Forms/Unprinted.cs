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

        private void btnaddmore_Click(object sender, EventArgs e)
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
