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
        public Taxa()
        {

        }

        public Taxa(decimal? valor, string descricao, TipoDeCalculo? tipoDeCalculo)
        {
            Valor=valor;
            Descricao=descricao;
            TipoDeCalculo=tipoDeCalculo;
        }

        public override void Atualizar(Taxa registro)
        {
            
        }
        public decimal? Valor { get; set; }

        public string Descricao { get; set; }

        public TipoDeCalculo? TipoDeCalculo { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Taxa Taxa &&
                   Valor == Taxa.Valor &&
                   Descricao == Taxa.Descricao &&                   
                   TipoDeCalculo == Taxa.TipoDeCalculo;
        }
        public Taxa Clone()
        {
            return MemberwiseClone() as Taxa;
        }
    }
}
