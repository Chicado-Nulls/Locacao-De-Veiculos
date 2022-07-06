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

            RuleFor(x => x.DiarioValorDiario)
              .NotNull()
              .NotEmpty()
              .GreaterThan(0);

            RuleFor(x => x.DiarioValorPorKm)
              .NotNull()
              .NotEmpty()
              .GreaterThan(0); 


            RuleFor(x => x.LivreValorDiario)
              .NotNull()
              .NotEmpty()
              .GreaterThan(0);

            RuleFor(x => x.ControladoValorDiario)
              .NotNull()
              .NotEmpty()
              .GreaterThan(0);

            RuleFor(x => x.ControladoValorPorKm)
              .NotNull()
              .NotEmpty()
              .GreaterThan(0);

            RuleFor(x => x.ControladoLimiteDeKm)
              .NotNull()
              .NotEmpty()
              .GreaterThan(0);


        }
    }
}
