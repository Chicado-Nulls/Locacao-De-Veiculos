using FluentValidation.Results;
using Locadora.Dominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.ModuloFuncionario
{
    public class ServiceFuncionario
    {
        IRepositorioFuncionario repositorio;

        public ServiceFuncionario(IRepositorioFuncionario repositorioFuncionario)
        {
            this.repositorio=repositorioFuncionario;
        }

        public ValidationResult Inserir(Funcionario registro)
        {
            var validador = new ValidadorFuncionario();

            var resultado = validador.Validate(registro);

            if (resultado.IsValid)
            {
                repositorio.Inserir(registro);
            }
            return resultado;
        }
        public ValidationResult Editar(Funcionario registro)
        {
            var validador = new ValidadorFuncionario();

            var resultado = validador.Validate(registro);

            if (resultado.IsValid)
            {
                repositorio.Editar(registro);
            }
            return resultado;
        }
        public ValidationResult Excluir(Funcionario registro)
        {
            var validador = new ValidadorFuncionario();

            var resultado = validador.Validate(registro);

            if (resultado.IsValid)
            {
                repositorio.Excluir(registro);
            }
            return resultado;
        }
        public Funcionario SelecionarPorId(int id)
        {
            return repositorio.SelecionarPorId(id);
        }
        public List<Funcionario> SelecionarTodos()
        {
            return repositorio.SelecionarTodos();
        }
    }
}
