using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.ModuloPlanoCobranca
{
    public class ValidadorPlanoCobranca : AbstractValidator<PlanoCobranca>
    {
        public ValidadorPlanoCobranca()
        {
            RuleFor(x => x.GrupoVeiculo)
              .NotNull()
              .NotEmpty();

            RuleFor(x => x.DiarioDiaria)
              .NotNull()
              .NotEmpty()
              .GreaterThan(0);

            RuleFor(x => x.DiarioPorKm)
              .NotNull()
              .NotEmpty()
              .GreaterThan(0); 


            RuleFor(x => x.LivreDiaria)
              .NotNull()
              .NotEmpty()
              .GreaterThan(0);

            RuleFor(x => x.ControladoDiaria)
              .NotNull()
              .NotEmpty()
              .GreaterThan(0);

            RuleFor(x => x.ControladoPorKm)
              .NotNull()
              .NotEmpty()
              .GreaterThan(0);

            RuleFor(x => x.ControladoLimiteKm)
              .NotNull()
              .NotEmpty()
              .GreaterThan(0);


        }
    }
}
