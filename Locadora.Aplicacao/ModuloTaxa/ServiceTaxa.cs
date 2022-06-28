using FluentValidation.Results;
using Locadora.Dominio.ModuloTaxa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.ModuloTaxa
{
    public class ServiceTaxa
    {
        IRepositorioTaxa repositorio;

        public ServiceTaxa(IRepositorioTaxa repositorioTaxa)
        {
            this.repositorio=repositorioTaxa;
        }

        public ValidationResult Inserir(Taxa registro)
        {
            var validador = new ValidadorTaxa();

            var resultado = validador.Validate(registro);

            if (resultado.IsValid)
            {
                repositorio.Inserir(registro);
            }
            return resultado;
        }
        public ValidationResult Editar(Taxa registro)
        {
            var validador = new ValidadorTaxa();

            var resultado = validador.Validate(registro);

            if (resultado.IsValid)
            {
                repositorio.Editar(registro);
            }
            return resultado;
        }
        public ValidationResult Excluir(Taxa registro)
        {
            var validador = new ValidadorTaxa();

            var resultado = validador.Validate(registro);

            if (resultado.IsValid)
            {
                repositorio.Excluir(registro);
            }
            return resultado;
        }
        public Taxa SelecionarPorId(int id)
        {
            return  repositorio.SelecionarPorId(id);
        }
        public List<Taxa> SelecionarTodos()
        {
            return repositorio.SelecionarTodos();
        }
    }
}
