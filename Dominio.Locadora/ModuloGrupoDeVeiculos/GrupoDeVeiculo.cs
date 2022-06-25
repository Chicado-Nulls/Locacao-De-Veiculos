using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCarro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.ModuloGrupoDeVeiculos
{
    public class GrupoDeVeiculo : EntidadeBase<GrupoDeVeiculo>
    {


        public GrupoDeVeiculo() { }
        public GrupoDeVeiculo(string nome)
        {
           this.Nome = nome;    
        }
        
        public override void Atualizar(GrupoDeVeiculo registro)
        {
               Nome = registro.Nome;
        }

        public string Nome { get; set; }
        public List<Carro> ListaDeCarros { get; set; }

        public override bool Equals(object obj)
        {
            return obj is GrupoDeVeiculo grupoDeVeiculo &&
                   Nome == grupoDeVeiculo.Nome;                  
        }
        
    }
}
