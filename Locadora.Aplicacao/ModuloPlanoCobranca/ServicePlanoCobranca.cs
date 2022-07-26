using FluentResults;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloPlanoCobranca;

namespace Locadora.Aplicacao.ModuloPlanoCobranca
{
    public class ServicePlanoCobranca : ServiceBase<PlanoCobranca, ValidadorPlanoCobranca>
    {
        public ServicePlanoCobranca(IRepositorioPlanoCobranca repositorio, IContextoPersistencia contexto) : base(repositorio, contexto)
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
