using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Web;

namespace DigiSort_Box.Forms
{
    public partial class Inventory : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = digisortbox;username=root;password=");
        DataTable dtRaw = new DataTable();
        DataTable dtUnprint = new DataTable();
        DataTable dtReady = new DataTable();
        public Inventory()
        {
            InitializeComponent();
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            //show Database table
            connection.Close();
            connection.Open();

            raw();
            unprint();
            ready();

            connection.Close();
        }
        private void raw()
        {
            connection.Close();
            connection.Open();
            //show raw
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM raw_material";
            MySqlDataReader sdr = cmd.ExecuteReader();
            dtRaw.Load(sdr);
            dgrawmaterial.DataSource = dtRaw;
        }
        private void unprint()
        {
            connection.Close();
            connection.Open();
            //unprinted shirts
            MySqlCommand unprint = connection.CreateCommand();
            unprint.CommandText = "SELECT * FROM unprinted_shirts";
            MySqlDataReader sdr = unprint.ExecuteReader();
            dtUnprint.Load(sdr);
            dgunprinted.DataSource = dtUnprint;
        }
        private void ready()
        {
            connection.Close();
            connection.Open();
            //ready
            MySqlCommand unprint = connection.CreateCommand();
            unprint.CommandText = "SELECT * FROM ready_to_sell_items";
            MySqlDataReader sdr = unprint.ExecuteReader();
            dtReady.Load(sdr);
            dgready.DataSource = dtReady;
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raw();
            unprint();
            ready();
        }
        private void txtunprinted_TextChanged_1(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            if (txtunprinted.Text.Equals(""))
            {
                string searchquery = "SELECT * FROM unprinted_shirts";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgunprinted.DataSource = tbl;
            }
            else
            {
                string searchquery = "SELECT * FROM unprinted_shirts WHERE color LIKE '" + txtunprinted.Text + "%'";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgunprinted.DataSource = tbl;
            }
        }
        private void txtready_TextChanged(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            if (txtready.Text.Equals(""))
            {
                string searchquery = "SELECT * FROM ready_to_sell_items";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgready.DataSource = tbl;
            }
            else
            {
                string searchquery = "SELECT * FROM ready_to_sell_items WHERE product_name LIKE '" + txtready.Text + "%'";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgready.DataSource = tbl;
            }
        }
        private void txtraw_TextChanged(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            if (txtraw.Text.Equals(""))
            {
                string searchquery = "SELECT * FROM raw_material";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgrawmaterial.DataSource = tbl;
            }
            else
            {
                string searchquery = "SELECT * FROM raw_material WHERE material LIKE '" + txtraw.Text + "%'";
                MySqlDataAdapter adp = new MySqlDataAdapter(searchquery, connection);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgrawmaterial.DataSource = tbl;
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            Forms.update up = new Forms.update();
            up.txtusername.Text = txtusername.Text;
            up.ShowDialog();
        }
        private void btndelete_Click_1(object sender, EventArgs e)
        {
            Forms.delete de = new Forms.delete();
            de.txtusername.Text = txtusername.Text;
            de.ShowDialog();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            ExportToPdf(dtRaw, dtUnprint, dtReady);
        }
        public void ExportToPdf(DataTable myDataTableRaw, DataTable myDataTableUnprinted, DataTable myDataTableReady)
        {
            DataTable dtRaw = myDataTableRaw;
            DataTable dtUnprinted = myDataTableUnprinted;
            DataTable dtReady = myDataTableReady;

            Document pdfDoc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            iTextSharp.text.Font font13 = FontFactory.GetFont("ARIAL", 13);
            iTextSharp.text.Font font18 = FontFactory.GetFont("ARIAL", 18);

            string documentsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsFolderPath, "Inventory.pdf");

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                pdfDoc.Open();

                if (dtRaw.Rows.Count > 0)
                {
                    PdfPTable PdfTable = new PdfPTable(1);
                    PdfTable.TotalWidth = 200f;
                    PdfTable.LockedWidth = true;

                    PdfPCell PdfPCell = new PdfPCell(new Phrase(new iTextSharp.text.Chunk("Raw Materials", font18)));
                    PdfPCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    PdfTable.AddCell(PdfPCell);
                    pdfDoc.Add(PdfTable);

                    PdfTable = new PdfPTable(dtRaw.Columns.Count);
                    PdfTable.SpacingBefore = 20f;

                    for (int columns = 0; columns <= dtRaw.Columns.Count - 1; columns++)
                    {
                        PdfPCell = new PdfPCell(new Phrase(new iTextSharp.text.Chunk(dtRaw.Columns[columns].ColumnName, font18)));
                        PdfTable.AddCell(PdfPCell);
                    }

                    for (int rows = 0; rows <= dtRaw.Rows.Count - 1; rows++)
                    {
                        for (int column = 0; column <= dtRaw.Columns.Count - 1; column++)
                        {
                            PdfPCell = new PdfPCell(new Phrase(new iTextSharp.text.Chunk(dtRaw.Rows[rows][column].ToString(), font13)));
                            PdfTable.AddCell(PdfPCell);
                        }
                    }

                    pdfDoc.Add(PdfTable);

                    PdfTable = new PdfPTable(1);
                    PdfTable.TotalWidth = 200f;
                    PdfTable.LockedWidth = true;
                    PdfTable.SpacingBefore = 30f;

                    PdfPCell PdfPCell1 = new PdfPCell(new Phrase(new iTextSharp.text.Chunk("Unprinted Shirts", font18)));
                    PdfPCell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    PdfTable.AddCell(PdfPCell1);

                    pdfDoc.Add(PdfTable);

                    PdfTable = new PdfPTable(dtUnprinted.Columns.Count);
                    PdfTable.SpacingBefore = 20f;

                    for (int columns = 0; columns <= dtUnprinted.Columns.Count - 1; columns++)
                    {
                        PdfPCell = new PdfPCell(new Phrase(new iTextSharp.text.Chunk(dtUnprinted.Columns[columns].ColumnName, font18)));
                        PdfTable.AddCell(PdfPCell);
                    }

                    for (int rows = 0; rows <= dtUnprinted.Rows.Count - 1; rows++)
                    {
                        for (int column = 0; column <= dtUnprinted.Columns.Count - 1; column++)
                        {
                            PdfPCell = new PdfPCell(new Phrase(new iTextSharp.text.Chunk(dtUnprinted.Rows[rows][column].ToString(), font13)));
                            PdfTable.AddCell(PdfPCell);
                        }
                    }

                    pdfDoc.Add(PdfTable);

                    PdfTable = new PdfPTable(1);
                    PdfTable.TotalWidth = 200f;
                    PdfTable.LockedWidth = true;
                    PdfTable.SpacingBefore = 30f;

                    PdfPCell PdfPCell2 = new PdfPCell(new Phrase(new iTextSharp.text.Chunk("Ready to sell items", font18)));
                    PdfPCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    PdfTable.AddCell(PdfPCell2);

                    pdfDoc.Add(PdfTable);

                    PdfTable = new PdfPTable(dtReady.Columns.Count);
                    PdfTable.SpacingBefore = 20f;

                    for (int columns = 0; columns <= dtReady.Columns.Count - 1; columns++)
                    {
                        PdfPCell = new PdfPCell(new Phrase(new iTextSharp.text.Chunk(dtReady.Columns[columns].ColumnName, font18)));
                        PdfTable.AddCell(PdfPCell);
                    }

                    for (int rows = 0; rows <= dtReady.Rows.Count - 1; rows++)
                    {
                        for (int column = 0; column <= dtReady.Columns.Count - 1; column++)
                        {
                            PdfPCell = new PdfPCell(new Phrase(new iTextSharp.text.Chunk(dtReady.Rows[rows][column].ToString(), font13)));
                            PdfTable.AddCell(PdfPCell);
                        }
                    }

                    pdfDoc.Add(PdfTable);


                }
                pdfDoc.Close();
                MessageBox.Show("The file is now ready for printing. \nYour file is saved on C:\\Users\\YourComputerName\\Documents");
            }
            catch (DocumentException de)
            {
            }
            // System.Web.HttpContext.Current.Response.Write(de.Message)
            catch (IOException ioEx)
            {
            }
            // System.Web.HttpContext.Current.Response.Write(ioEx.Message)
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

