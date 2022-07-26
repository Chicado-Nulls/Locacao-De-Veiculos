using FluentResults;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCliente;

namespace Locadora.Aplicacao.ModuloCliente
{
    public class ServiceCliente : ServiceBase<Cliente, ValidadorCliente>
    {
        public ServiceCliente(IRepositorioCliente repositorio, IContextoPersistencia contexto) : base(repositorio, contexto)
        {
        }

        public override Result ExisteCamposDuplicados(Cliente registro)
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
