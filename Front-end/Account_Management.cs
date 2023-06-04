using System;
using System.Windows.Forms;

namespace DigiSort_Box.Front_end
{
    public partial class Account_Management : Form
    {

        public Account_Management()
        {
            InitializeComponent();
        }

        private void Account_Management_Load(object sender, EventArgs e)
        {
            Database.Account_Management am = new Database.Account_Management();
            am.account(txtuser, cbposition, dgaccounts);

            dgaccounts.Columns[0].HeaderText = "ID";
            dgaccounts.Columns[1].HeaderText = "USERNAME";
            dgaccounts.Columns[2].HeaderText = "FIRSTNAME";
            dgaccounts.Columns[3].HeaderText = "LASTNAME";
            dgaccounts.Columns[4].HeaderText = "POSITION";
            dgaccounts.Columns[5].HeaderText = "STATUS";
        }

        private void dgaccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnupdate.Enabled = false;
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgrow = dgaccounts.Rows[e.RowIndex];
                txtuser.Text = dgrow.Cells[1].Value.ToString();
                cbposition.Text = dgrow.Cells[4].Value.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cbposition.Text.Equals("InActive"))
            {
                DialogResult = MessageBox.Show("Are you sure you want to deactivate this account?", "Deactivate?", MessageBoxButtons.YesNo);

                if (DialogResult == DialogResult.Yes)
                {
                    Database.Account_Management am = new Database.Account_Management();
                    am.updatedeact(txtuser, cbposition);
                }
                else if (DialogResult == DialogResult.No)
                {
                    //ok
                }

            }
            else if (cbposition.Text.Equals("Active"))
            {
                DialogResult = MessageBox.Show("Are you sure you want to reactivate this account?", "Re-activate?", MessageBoxButtons.YesNo);

                if (DialogResult == DialogResult.Yes)
                {
                    Database.Account_Management am = new Database.Account_Management();
                    am.updatereact(txtuser, cbposition);
                }
                else if (DialogResult == DialogResult.No)
                {
                    //ok
                }
            }
        }

        private void cbposition_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnupdate.Enabled = true;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Database.Account_Management am = new Database.Account_Management();
            am.search(dgaccounts, txtsearch);
        }
    }
}
