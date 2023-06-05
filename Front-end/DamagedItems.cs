using System;
using System.Windows.Forms;


namespace DigiSort_Box.Front_end
{
    public partial class Damaged_Items : Form
    {

        public Damaged_Items()
        {
            InitializeComponent();
        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }



        private void cbtable_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Database
            Database.Damage dmg = new Database.Damage();
            dmg.tbl(dgvitems, cbtable);
        }

        private void Damaged_Items_Load(object sender, EventArgs e)
        {
            //Database
            Database.Damage dmg = new Database.Damage();
            dmg.tbl(dgvitems, cbtable);
        }

        private void dgvitems_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgvitems.Rows[e.RowIndex];
                    lblid.Text = dgvRow.Cells[0].Value.ToString();  // id
                    label1.Text = dgvRow.Cells[1].Value.ToString(); // material
                    label2.Text = dgvRow.Cells[2].Value.ToString(); // design
                    label3.Text = dgvRow.Cells[3].Value.ToString(); // color
                    label4.Text = dgvRow.Cells[4].Value.ToString(); // shade
                    label5.Text = dgvRow.Cells[5].Value.ToString(); // size
                    label6.Text = dgvRow.Cells[6].Value.ToString(); // quantity
                }
            }
            else if (cbtable.SelectedItem.Equals("Raw Materials"))
            {
                //click cell to show
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgvitems.Rows[e.RowIndex];
                    lblid.Text = dgvRow.Cells[0].Value.ToString(); // id
                    label1.Text = dgvRow.Cells[1].Value.ToString(); // material
                    label2.Text = dgvRow.Cells[2].Value.ToString(); //design
                }
            }
            else if (cbtable.SelectedItem.Equals("Unprinted Shirts"))
            {
                //click cell to show
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgvitems.Rows[e.RowIndex];
                    lblid.Text = dgvRow.Cells[0].Value.ToString(); // id
                    label1.Text = dgvRow.Cells[1].Value.ToString(); // color
                    label2.Text = dgvRow.Cells[2].Value.ToString(); // shade
                    label3.Text = dgvRow.Cells[3].Value.ToString(); // size
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Database.Damage dmg = new Database.Damage();
            dmg.issue(txtissue, txtquantity, cbtable, lblid, label1, label2, label3, label4, label5, label6, txtusername, dgvitems);
        }

        private void txtissue_TextChanged(object sender, EventArgs e)
        {
            if (txtissue.Text.Equals("") || txtquantity.Text.Equals("") || lblid.Text == "")
            {
                btnadd.Enabled = false;
            }
            else
            {
                btnadd.Enabled = true;
            }
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if (txtissue.Text.Equals("") || txtquantity.Text.Equals("") || lblid.Text == "")
            {
                btnadd.Enabled = false;
            }
            else
            {
                btnadd.Enabled = true;
            }
        }
    }
}
