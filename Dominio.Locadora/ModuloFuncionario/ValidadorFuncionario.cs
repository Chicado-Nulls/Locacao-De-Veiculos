using FluentValidation;
using System;
using System.Text.RegularExpressions;

namespace Locadora.Dominio.ModuloFuncionario
{
    public class ValidadorFuncionario : AbstractValidator<Funcionario>
    {
        public ValidadorFuncionario()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .MaximumLength(60)
                .Matches(new Regex(@"^([^0-9]*)$"))
                .NotEmpty();

            RuleFor(x => x.Login)
                .NotNull()
                .MinimumLength(6);

            RuleFor(x => x.Senha)
                .NotNull()
                .MinimumLength(6);
        }
    }
}
