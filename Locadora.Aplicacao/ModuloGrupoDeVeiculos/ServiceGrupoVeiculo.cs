using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloGrupoDeVeiculo;

namespace Locadora.Aplicacao.ModuloGrupoDeVeiculos
{
    public class ServiceGrupoVeiculo : ServiceBase<GrupoVeiculo, ValidadorGrupoVeiculo>
    {
        public ServiceGrupoVeiculo(IRepositorioBase<GrupoVeiculo> repositorio) : base(repositorio)
        {

        }
        protected override string ObterIdentificadorLog(GrupoVeiculo registro)
        {
            return $"ID: {registro.Id} | Nome: {registro.Nome}";
        }
    }
}
