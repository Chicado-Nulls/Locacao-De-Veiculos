using FluentResults;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCarro;
using Locadora.Dominio.ModuloVeiculo;
using System.Collections.Generic;
using System.Linq;

namespace Locadora.Aplicacao.ModuloVeiculo
{
    public class ServiceVeiculo : ServiceBase<Veiculo, ValidadorVeiculo>
    {
        public ServiceVeiculo(IRepositorioBase<Veiculo> repositorio) : base(repositorio)
        {



        }

        public override Result ExisteCamposDuplicados(Veiculo registro)
        {
            List<Error> erros = new List<Error>();

            var resultado = repositorio.ExisteRegistroIgual(registro,"aaaa");

            if (resultado)
            {
                erros.Add(new Error("Placa do Veiculo Duplicada"));
            }

            if (erros.Any())
                return Result.Fail(erros);

            return Result.Ok();
        }
    }
}
