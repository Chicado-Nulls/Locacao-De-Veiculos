using FluentValidation.Results;
using Locadora.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.ModuloCliente
{
    public class ServiceCliente
    {
        IRepositorioCliente repositorio;

        public ServiceCliente(IRepositorioCliente repositorio)
        {
            this.repositorio=repositorio;
        }

        public ValidationResult Inserir(Cliente registro)
        {
            var resultado = ValidarCliente(registro, "Inserir");
            
            if (resultado.IsValid)
            {
                repositorio.Inserir(registro);
            }
            return resultado;
        }
        public ValidationResult Editar(Cliente registro)
        {
            var resultado = ValidarCliente(registro, "Editar");

            if (resultado.IsValid)
            {
                repositorio.Editar(registro);
            }
            return resultado;
        }
        public ValidationResult Excluir(Cliente registro)
        {
            var validador = new ValidadorCliente();

            var registroEncontrado = repositorio.SelecionarPorId(registro.Id);

            var resultado = validador.Validate(registroEncontrado);

            if (resultado.IsValid)
            {
                repositorio.Excluir(registro);
            }
            return resultado;
        }
        public Cliente SelecionarPorId(int id)
        {
            return repositorio.SelecionarPorId(id);
        }
        public List<Cliente> SelecionarTodos()
        {
            return repositorio.SelecionarTodos();
        }

        public ValidationResult ValidarCliente(Cliente registro, string Tipo)
        {
            var validador = new ValidadorCliente();

            var resultado = validador.Validate(registro);

            bool registroDuplicado = repositorio.ExisteRegistroIgual(registro, Tipo);

            if (registroDuplicado)
                resultado.Errors.Add(new ValidationFailure("Campos", "Campos com * precisam ser únicos"));

            return resultado;
        }
    }
}
