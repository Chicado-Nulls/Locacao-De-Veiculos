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

        protected override ValidationResult GerarErroRepetido()
        {
            ValidationResult erro = new ValidationResult();

            erro.Errors.Add(new ValidationFailure("", "Condutor ja cadastrado para o cliente selecionado!"));

            return erro;
        }
    }
}
