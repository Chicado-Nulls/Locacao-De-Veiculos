using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCarro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.ModuloGrupoDeVeiculo
{
    public class GrupoVeiculo : EntidadeBase<GrupoVeiculo>
    {


        public GrupoVeiculo() { }
        public GrupoVeiculo(string nome)
        {
           this.Nome = nome;    
        }
        
        public override void Atualizar(GrupoVeiculo registro)
        {
               Nome = registro.Nome;
        }

        public string Nome { get; set; }
        public List<Veiculo> ListaDeVeiculo{ get; set; }

        public override bool Equals(object obj)
        {
            return obj is GrupoVeiculo grupoDeVeiculo &&
                   Nome == grupoDeVeiculo.Nome;                  
        }
        
    }
}
