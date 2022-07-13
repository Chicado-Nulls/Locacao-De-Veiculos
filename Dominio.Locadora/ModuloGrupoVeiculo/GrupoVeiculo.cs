using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCarro;
using System.Collections.Generic;

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

        public override string ToString()
        {
            return $"ID: {Id} | Nome: {Nome}";
        }

        public string Nome { get; set; }
        public List<Veiculo> ListaDeVeiculo { get; set; }

        public override bool Equals(object obj)
        {
            return obj is GrupoVeiculo grupoDeVeiculo &&
                   Nome == grupoDeVeiculo.Nome;
        }
    }
}
