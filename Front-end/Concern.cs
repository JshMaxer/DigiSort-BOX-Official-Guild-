using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiSort_Box.Front_end
{
    public partial class Concern : Form
    {
        public Concern()
        {
            InitializeComponent();
        }

        private void Concern_Load(object sender, EventArgs e)
        {
            Database.Concern crn = new Database.Concern();
            crn.concern(dgconcern);
        }

        private void btnokay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
