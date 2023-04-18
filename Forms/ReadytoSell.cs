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

        private void btnaddmore_Click(object sender, EventArgs e)
        {
            txtproduct1.Text = null;
            txtproduct2.Text = null;
            txtproduct3.Text = null;
            txtproduct4.Text = null;
            txtproduct5.Text = null;
            txtproduct6.Text = null;

            cbcolor1.Text = null;
            cbcolor2.Text = null;
            cbcolor3.Text = null;
            cbcolor4.Text = null;
            cbcolor5.Text = null;
            cbcolor6.Text = null;

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
