using System;
using System.Windows.Forms;

namespace DigiSort_Box.Forms
{
    public partial class maindashboard : Form
    {

        public maindashboard()
        {
            InitializeComponent();
        }

        private void maindashboard_Load(object sender, EventArgs e)
        {
            Database.MainDashboard dash = new Database.MainDashboard();
            dash.floor(lblfloor);
            dash.top(lbltop);
            dash.unprint(lblunprinted);
            dash.raw(lblraw);
            dash.ready(lblready);
            dash.damage(lbldamage);
        }
    }
}
