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
    public partial class DigiSortBox : Form
    {
        public DigiSortBox()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            Forms.Login log = new Forms.Login();
            log.Show();
            this.Visible = false;
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            CreateAcc create = new CreateAcc();
            create.Show();
            this.Visible = false;
        }

        private void DigiSortBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
