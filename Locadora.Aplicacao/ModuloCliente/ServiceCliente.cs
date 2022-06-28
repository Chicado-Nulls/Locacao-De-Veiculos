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
            var validador = new ValidadorCliente();

            var resultado = validador.Validate(registro);

            if (resultado.IsValid)
            {
                repositorio.Inserir(registro);
            }
            return resultado;
        }
        public ValidationResult Editar(Cliente registro)
        {
            var validador = new ValidadorCliente();

            var resultado = validador.Validate(registro);

            if (resultado.IsValid)
            {
                repositorio.Editar(registro);
            }
            return resultado;
        }
        public ValidationResult Excluir(Cliente registro)
        {
            var validador = new ValidadorCliente();

            var resultado = validador.Validate(registro);

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
    }
}
