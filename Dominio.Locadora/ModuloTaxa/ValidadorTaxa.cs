using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Locadora.Dominio.ModuloTaxa
{
    public class ValidadorTaxa : AbstractValidator<Taxa>
    {
       public ValidadorTaxa()
        {
            RuleFor(x => x.Descricao)
                 .NotNull()
                 .MaximumLength(60)
                 .Matches(new Regex(@"^([^0-9]*)$"))
                 .NotEmpty();
          
             RuleFor(x => x.TipoDeCalculo)
                 .NotNull();

            RuleFor(x => x.Valor)
                .NotNull()
                .GreaterThan(0m)
                .LessThanOrEqualTo(10000m);
                
        }
    }
}
