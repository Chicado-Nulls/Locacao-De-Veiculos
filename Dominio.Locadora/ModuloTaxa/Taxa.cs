using Locadora.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.ModuloTaxa
{
    public class Taxa : EntidadeBase<Taxa>
    {
        public override void Atualizar(Taxa registro)
        {
            
        }
        public decimal Valor { get; set; }

        public string Descricao { get; set; }

        public TipoDeCalculo TipoDeCalculo { get; set; }    
            

    }
}
