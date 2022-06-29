﻿using FluentValidation;
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
                 .MinimumLength(3)
                 .Matches(@"^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]*$").WithMessage("Caracteres especiais não são permitidos!")
                 .NotEmpty();

            RuleFor(x => x.TipoDeCalculo)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Valor)
                .NotNull()
                .GreaterThan(0m)
                .LessThanOrEqualTo(10000m);
                
        }
    }
}
