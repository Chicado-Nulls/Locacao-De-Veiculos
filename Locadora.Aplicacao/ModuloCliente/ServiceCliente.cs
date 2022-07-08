using FluentValidation.Results;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.ModuloCliente
{
    public class ServiceCliente : ServiceBase<Cliente, ValidadorCliente>
    {
        public ServiceCliente(IRepositorioBase<Cliente> repositorio) : base(repositorio)
        {
        }

        protected override string ObterIdentificadorLog(Cliente registro)
        {
            return $"ID: {registro.Id} | Nome: {registro.Nome}";
        }
    }
}
