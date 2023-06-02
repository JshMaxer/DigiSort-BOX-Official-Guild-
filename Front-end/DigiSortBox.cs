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

        private void DigiSortBox_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("PLEASE FETCH FIRST AND THEN PULL BEFORE DOING CHANGES IN SYSTEM TO NOT MESSED UP THE COMMIT TIMELINE.\n\nBEFORE PUSHING THE GIT CHANGES, MAKE SURE YOU FETCH AND PULL FIRST.\n\nKINDLY REMOVE THIS MESSAGE ON PRESENTING OR DEFENSE DAY. ty :)\n-dev lead", "REMEMBER!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
