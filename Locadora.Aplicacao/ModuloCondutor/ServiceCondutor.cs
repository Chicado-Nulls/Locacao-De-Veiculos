using FluentValidation.Results;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCondutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.ModuloCondutor
{
    public class ServiceCondutor : ServiceBase<Condutor, ValidadorCondutor>
    {
        public ServiceCondutor(IRepositorioBase<Condutor> repositorio) : base(repositorio)
        {
        }

        protected override string ObterIdentificadorLog(Condutor registro)
        {
            return $"ID: {registro.Id} | Nome: {registro.Nome}";
        }
    }
}
