using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using QRCoderProject;
using iText;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace QRCoderProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
/*            QRCodeGenerator monQrCode = new QRCodeGenerator();
            QRCodeData qRCodeData = monQrCode.CreateQrCode("http://www.facebook.com", QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qRCodeData);
            Bitmap monImage = qRCode.GetGraphic(10, Color.Red, Color.Blue, true);
            PictureBox maPictureBox = new PictureBox();
            maPictureBox.Width = 800;
            maPictureBox.Height = 800;
            maPictureBox.Image = monImage;
            this.Controls.Add(maPictureBox);*/
        }

        private void bt_generer_Click(object sender, EventArgs e)
        {
            string monTexte = richTextBox1.Text;
            var writer = new PdfWriter(@"c:\Temp\Test.pdf");
            var pdf = new PdfDocument(writer);
            var document = new Document(pdf);
            document.Add(new Paragraph(monTexte));
            document.Close();
        }
    }
}
