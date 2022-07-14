using FluentResults;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCliente;
using System.Collections.Generic;

namespace Locadora.Aplicacao.ModuloCliente
{
    public class ServiceCliente : ServiceBase<Cliente, ValidadorCliente>
    {
        public ServiceCliente(IRepositorioBase<Cliente> repositorio) : base(repositorio)
        {
        }

        public override Result ExisteCamposDuplicados(Cliente registro)
        {
            return Result.Ok();
        }
    }
}
