using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiSort_Box.Back_end
{
    public class Print
    {
        public void ExportToPdf(DataGridView dgraw, DataGridView dgunprint, DataGridView dgready)
        {
            // Create a new DataTable for each DataGridView
            DataTable dataTable1 = GetDataTableFromDataGridView(dgraw);
            DataTable dataTable2 = GetDataTableFromDataGridView(dgunprint);
            DataTable dataTable3 = GetDataTableFromDataGridView(dgready);

            // Create a new document
            Document pdfDoc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            iTextSharp.text.Font font13 = FontFactory.GetFont("ARIAL", 13);
            iTextSharp.text.Font font18 = FontFactory.GetFont("ARIAL", 18);

            string documentsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsFolderPath, "DigiSort Box - Inventory.pdf");

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                pdfDoc.Open();

                // Export DataGridView 1
                ExportDataGridViewToPdf(dataTable1, "Raw Materials", font18, font13, pdfDoc);

                // Export DataGridView 2
                ExportDataGridViewToPdf(dataTable2, "Unprinted Shirts", font18, font13, pdfDoc);

                // Export DataGridView 3
                ExportDataGridViewToPdf(dataTable3, "Ready to Sell Items", font18, font13, pdfDoc);

                pdfDoc.Close();
                MessageBox.Show("The file is now saved as a PDF in your documents folder.", "PDF Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DocumentException)
            {
                // Handle any document-related exceptions here
            }
            catch (IOException)
            {
                // Handle any I/O-related exceptions here
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataTable GetDataTableFromDataGridView(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            // Create columns in the DataTable
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }

            // Populate the DataTable with rows from the DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                List<string> rowData = new List<string>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    rowData.Add(cell.Value.ToString());
                }
                dataTable.Rows.Add(rowData.ToArray());
            }

            return dataTable;
        }

        private void ExportDataGridViewToPdf(DataTable dataTable, string title, iTextSharp.text.Font titleFont, iTextSharp.text.Font dataFont, Document pdfDoc)
        {
            if (dataTable.Rows.Count > 0)
            {
                // Add title to the PDF document
                PdfPTable titleTable = new PdfPTable(1);
                titleTable.TotalWidth = 200f;
                titleTable.LockedWidth = true;

                PdfPCell titleCell = new PdfPCell(new Phrase(new iTextSharp.text.Chunk(title, titleFont)));
                titleCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                titleTable.AddCell(titleCell);
                pdfDoc.Add(titleTable);

                // Add data table to the PDF document
                PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);
                pdfTable.SpacingBefore = 20f;

                // Add column headers
                foreach (DataColumn column in dataTable.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(new iTextSharp.text.Chunk(column.ColumnName, titleFont)));
                    pdfTable.AddCell(headerCell);
                }

                // Add rows and cells
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(new iTextSharp.text.Chunk(item.ToString(), dataFont)));
                        pdfTable.AddCell(cell);
                    }
                }

                pdfDoc.Add(pdfTable);
            }
        }

    }
}
