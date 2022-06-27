using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Locadora.Dominio.ModuloGrupoDeVeiculos
{
    public class ValidadorGrupoDeVeiculos : AbstractValidator<GrupoDeVeiculo>
    {
        public ValidadorGrupoDeVeiculos()
        {
            RuleFor(x => x.Nome)
               .NotNull()
               .MaximumLength(60)
               .MinimumLength(2)
               .Matches(new Regex(@"^([^0-9]*)$"))
               .NotEmpty();
        }
    }
}
