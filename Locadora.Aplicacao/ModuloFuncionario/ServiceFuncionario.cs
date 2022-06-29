using FluentValidation.Results;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.ModuloFuncionario
{
    public class ServiceFuncionario : ServiceBase<Funcionario, ValidadorFuncionario>
    {
        public ServiceFuncionario(IRepositorioBase<Funcionario> repositorio) : base(repositorio)
        {
        }
    }
}
