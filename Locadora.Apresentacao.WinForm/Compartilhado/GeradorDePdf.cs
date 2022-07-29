using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Apresentacao.WinForm.Compartilhado
{
    public interface GeradorDePdf
    {
       void ConfigurarDocumento();
       void GerarHeader(Document document);
       void GerarCorpo(Document document);
       void GerarRodaPe(Document document);
    }
}
