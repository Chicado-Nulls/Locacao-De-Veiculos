﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Locadora.Dominio.ModuloGrupoDeVeiculo
{
    public class ValidadorGrupoVeiculo : AbstractValidator<GrupoVeiculo>
    {
        public ValidadorGrupoVeiculo()
        {
            RuleFor(x => x.Nome)
               .NotNull()
               .MaximumLength(60)
               .MinimumLength(2)
               .Matches(@"^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]*$").WithMessage("Caracteres especiais não são permitidos!")
               .NotEmpty();
        }
    }
}
