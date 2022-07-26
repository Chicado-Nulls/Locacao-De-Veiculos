using FluentResults;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloGrupoDeVeiculo;

namespace Locadora.Aplicacao.ModuloGrupoDeVeiculos
{
    public class ServiceGrupoVeiculo : ServiceBase<GrupoVeiculo, ValidadorGrupoVeiculo>
    {
        public ServiceGrupoVeiculo(IRepositorioGrupoVeiculo repositorio, IContextoPersistencia contexto) : base(repositorio, contexto)
        {

        }

        public override Result ExisteCamposDuplicados(GrupoVeiculo registro)
        {

            bool existeRegistroIgual= repositorio.ExisteRegistroIgual(registro, "");

            if(existeRegistroIgual == true)
            {
                string errorMsg = "Esse grupo de veículo já existe.";
                return Result.Fail(errorMsg);
            }
            return Result.Ok();
        }
    }
}
