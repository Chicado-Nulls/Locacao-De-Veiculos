using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloPlanoCobranca;

namespace Locadora.Aplicacao.ModuloPlanoCobranca
{
    public class ServicePlanoCobranca : ServiceBase<PlanoCobranca, ValidadorPlanoCobranca>
    {
        public ServicePlanoCobranca(IRepositorioBase<PlanoCobranca> repositorio) : base(repositorio)
        {

        }

        protected override string ObterIdentificadorLog(PlanoCobranca registro)
        {
            return $"Plano de cobrança - ID: {registro.Id} | Nome: {registro.GrupoVeiculo.Nome}";
        }
    }
}
