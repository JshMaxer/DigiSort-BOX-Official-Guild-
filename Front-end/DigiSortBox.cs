using System;
using System.Windows.Forms;

namespace DigiSort_Box.Forms
{
    public partial class DigiSortBox : Form
    {
        public DigiSortBox()
        {
            InitializeComponent();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            Forms.Login log = new Forms.Login();
            log.Show();
            this.Visible = false;
        }

        private void btncreateaccount_Click(object sender, EventArgs e)
        {
            CreateAcc create = new CreateAcc();
            create.Show();
            this.Visible = false;
        }

        private void exitform_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            //IPCONFIG

            Model.IPConfig conf = new Model.IPConfig();
            conf.ShowDialog();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("CREATED AND DESIGN BY: SORTECH CORP.\n\nJAMES BRYAN TIGUE - FRONT-END\nJOSHUA CAMBAL - DATABASE ADMIN\nLESTER MIGUEL RAPADA - BACK-END\n\nSPECIAL THANKS TO, ALONA EVANGELISTA - BUSINESS ANALYST" +
            "\n\n\nDigiSort Box all rights reserved 2023", "DEVELOPERS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
