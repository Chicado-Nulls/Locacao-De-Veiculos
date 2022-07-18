using FluentResults;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCliente;
using System.Collections.Generic;
using Locadora.Infra.BancoDados.Compartilhado;

namespace Locadora.Aplicacao.ModuloCliente
{
    public class ServiceCliente : ServiceBase<Cliente, ValidadorCliente>
    {
        public ServiceCliente(IRepositorioCliente repositorio) : base(repositorio)
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
