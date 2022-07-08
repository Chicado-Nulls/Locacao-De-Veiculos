using FluentValidation.Results;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloTaxa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.ModuloTaxa
{
    public class ServiceTaxa : ServiceBase<Taxa, ValidadorTaxa>
    {
        public ServiceTaxa(IRepositorioBase<Taxa> repositorio) : base(repositorio)
        {
        }

        protected override string ObterIdentificadorLog(Taxa registro)
        {
            return $"ID: {registro.Id} | Nome: {registro.Descricao}";
        }
    }
}
