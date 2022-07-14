using FluentResults;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloTaxa;

namespace Locadora.Aplicacao.ModuloTaxa
{
    public class ServiceTaxa : ServiceBase<Taxa, ValidadorTaxa>
    {
        public ServiceTaxa(IRepositorioBase<Taxa> repositorio) : base(repositorio)
        {
        }

        public override Result ExisteCamposDuplicados(Taxa registro)
        {
            return Result.Ok();
        }
    }
}
