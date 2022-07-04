using FluentValidation;
using FluentValidation.Results;
using Locadora.Dominio.Compartilhado;
using Locadora.Infra.BancoDados.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.Compartilhado
{
    public abstract  class ServiceBase<T,TValidador> 
        where T : EntidadeBase<T>
         where TValidador : AbstractValidator<T>, new()
    {
        IRepositorioBase<T> repositorio;

        public ServiceBase(IRepositorioBase<T> repositorio)
        {
            this.repositorio = repositorio;
        }

        public virtual ValidationResult Inserir(T registro)
        {
            var validador = new TValidador();

            var resultado = validador.Validate(registro);
            if (!resultado.IsValid)
                return resultado;  
            
            var existeRepetido = repositorio.ExisteRegistroIgual(registro, "Inserir");

            if (existeRepetido)
                return GerarErroRepetido();

            if (resultado.IsValid)
            {
                repositorio.Inserir(registro);
            }
            return resultado;
        }

        

        public virtual ValidationResult Editar(T registro)
        {
            var validador = new TValidador();

            var resultado = validador.Validate(registro);

            if (!resultado.IsValid)
                return resultado;

            var existeRepetido = repositorio.ExisteRegistroIgual(registro,"Editar");

            if (existeRepetido)
            {
                return GerarErroRepetido();
            }

            if (resultado.IsValid)
            {
                repositorio.Editar(registro);
            }
            return resultado;
        }
        public virtual ValidationResult Excluir(T registro)
        {
            var validador = new TValidador();
           
            var resultado = validador.Validate(registro);

            if (resultado.IsValid)
            {
                repositorio.Excluir(registro);
            }
            return resultado;
        }

        public virtual T SelecionarPorId(int id)
        {
            return repositorio.SelecionarPorId(id);
        }
        public virtual List<T> SelecionarTodos()
        {
            return repositorio.SelecionarTodos();
        }

        protected virtual ValidationResult GerarErroRepetido()
        {
            ValidationResult erro = new ValidationResult();

            erro.Errors.Add(new ValidationFailure("", "Campos com '*' precisam ser únicos"));

            return erro;
        }
    }
}
