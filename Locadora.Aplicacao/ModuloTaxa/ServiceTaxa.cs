using FluentResults;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloTaxa;
using System.Collections.Generic;
using System.Linq;

namespace Locadora.Aplicacao.ModuloTaxa
{
    public class ServiceTaxa : ServiceBase<Taxa, ValidadorTaxa>
    {
        public ServiceTaxa(IRepositorioTaxa repositorio) : base(repositorio)
        {
        }

        public override Result ExisteCamposDuplicados(Taxa registro)
        {
            List<Error> erros = new List<Error>();

            var resultado = repositorio.ExisteRegistroIgual(registro, "aaa");

            if (resultado)
            {
                erros.Add(new Error("Descrição Dever ser Diferente"));
            }

            if (erros.Any())
                return Result.Fail(erros);

               return Result.Ok();
        }
    }
}
