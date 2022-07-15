using FluentResults;
using FluentValidation.Results;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloPlanoCobranca;
using System;

namespace Locadora.Aplicacao.ModuloPlanoCobranca
{
    public class ServicePlanoCobranca : ServiceBase<PlanoCobranca, ValidadorPlanoCobranca>
    {
        public ServicePlanoCobranca(IRepositorioBase<PlanoCobranca> repositorio) : base(repositorio)
        {
        }

        public override Result ExisteCamposDuplicados(PlanoCobranca registro)
        {
            bool existeRegistroIgual = repositorio.ExisteRegistroIgual(registro, "");

            if (existeRegistroIgual == true)
            {
                string msgErro = "Registro duplicado";
                return Result.Fail(msgErro);
            }

            return Result.Ok();
        }

    }
}
