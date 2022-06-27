using FluentValidation;

namespace Locadora.Dominio.ModuloCliente
{
    public class ValidadorCliente : AbstractValidator<Cliente>
    {
        public ValidadorCliente()
        {
            //RuleFor(x => x.TipoCadastro)
            //  .NotNull()
            //  .NotEmpty();
            
            RuleFor(x => x.Nome)
              .NotNull()
              .NotEmpty();
            
            RuleFor(x => x.Endereco)
              .NotNull()
              .NotEmpty();

            RuleFor(x => x.Telefone)
              .NotNull()
              .NotEmpty();

            RuleFor(x => x.Email)
              .NotNull()
              .NotEmpty();
        }

    }
}
