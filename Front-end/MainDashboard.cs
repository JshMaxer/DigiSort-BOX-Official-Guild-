using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
