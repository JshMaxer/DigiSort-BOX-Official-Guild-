using DigiSort_Box.Model;
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
            Items itm = new Items();

            if (cbtable.SelectedItem.Equals("Ready to Sell Items"))
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgvitems.Rows[e.RowIndex];
                    lblid.Text = dgvRow.Cells[0].Value.ToString();  // id
                    label1.Text = dgvRow.Cells[1].Value.ToString(); // product name
                    label2.Text = dgvRow.Cells[2].Value.ToString(); // color
                    label3.Text = dgvRow.Cells[3].Value.ToString(); // shade
                    label4.Text = dgvRow.Cells[4].Value.ToString(); // size
                    itm.item1 = dgvRow.Cells[0].Value.ToString();
                    MessageBox.Show(itm.item1);

                }
            }
            else
            {
                //click cell to show
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgvitems.Rows[e.RowIndex];
                    lblid.Text = dgvRow.Cells[0].Value.ToString(); // id
                    label1.Text = dgvRow.Cells[1].Value.ToString();
                    label2.Text = dgvRow.Cells[2].Value.ToString();
                    label3.Text = dgvRow.Cells[3].Value.ToString();
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Database.Damage dmg = new Database.Damage();
            dmg.issue(txtissue, txtquantity, cbtable, lblid, label1, label2, label3, label4);
        }
    }
}
