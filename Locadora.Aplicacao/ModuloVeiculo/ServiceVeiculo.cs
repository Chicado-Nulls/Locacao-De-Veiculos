using FluentResults;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCarro;
using Locadora.Dominio.ModuloVeiculo;

namespace Locadora.Aplicacao.ModuloVeiculo
{
    public class ServiceVeiculo : ServiceBase<Veiculo, ValidadorVeiculo>
    {
        public ServiceVeiculo(IRepositorioBase<Veiculo> repositorio) : base(repositorio)
        {
        }

        public override Result ExisteCamposDuplicados(Veiculo registro)
        {
            return Result.Ok();
        }
    }
}
