using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ReproductorG2_2026_I
{
    public partial class FormTopMusic : Form
    {

        private void addData()
        {
            Random rankingAleatorio = new Random();

            for (int i = 0; i < 10; i++)
            {
                chartMusic.Series["Series1"].Points.AddXY(
                     i + 1, rankingAleatorio.Next(0, 100));
            }

        }


        public FormTopMusic()
        {
            InitializeComponent();

            addData();
        }

        private void exportarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document docPdf = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Archivos PDF|*.pdf";

            if ( sf.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    PdfWriter pdfwriter = PdfWriter.GetInstance(docPdf, new FileStream(sf.FileName, FileMode.Append));
                    docPdf.Open();
                    MemoryStream ms = new MemoryStream();
                    chartMusic.SaveImage(ms, System.Drawing.Imaging.ImageFormat.Png);
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ms.GetBuffer());
                    docPdf.Add(img);
                    docPdf.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar la imagen: " + ex.Message);
                }
                
            }


        }
    }
}
