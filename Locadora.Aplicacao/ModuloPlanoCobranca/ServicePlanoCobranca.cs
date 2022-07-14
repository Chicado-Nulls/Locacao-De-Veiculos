using FluentResults;
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

        public override Result ExisteCamposDuplicados(PlanoCobranca registro)
        {
            return Result.Ok();
        }
    }
}
