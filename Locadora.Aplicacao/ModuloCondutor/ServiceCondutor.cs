using FluentResults;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCondutor;

namespace Locadora.Aplicacao.ModuloCondutor
{
    public class ServiceCondutor : ServiceBase<Condutor, ValidadorCondutor>
    {
        public ServiceCondutor(IRepositorioBase<Condutor> repositorio) : base(repositorio)
        {
        }

        public override Result ExisteCamposDuplicados(Condutor registro)
        {
            return Result.Ok();
        }
    }
}
