using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Apresentacao.WinForm.Compartilhado
{
    public class PdfLocação : GeradorDePdf
    {
        public void ConfigurarDocumento()
        {
            var pdf = new Document(PageSize.A4);
            var NomeArquivo = $"Locação{DateTime.Now}.pdf";
            var arquivo = new FileStream(NomeArquivo, FileMode.Create);
            var writer = PdfWriter.GetInstance(pdf, arquivo);

            pdf.Open();

             
        }

        public void GerarCorpo(Document document)
        {
          
        }

        public void GerarHeader(Document document)
        {
            
        }

        public void GerarRodaPe(Document document)
        {
            
        }
    }
}
