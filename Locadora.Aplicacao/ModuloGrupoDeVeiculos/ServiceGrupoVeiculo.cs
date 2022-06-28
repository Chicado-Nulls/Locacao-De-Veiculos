using FluentValidation.Results;
using Locadora.Dominio.ModuloGrupoDeVeiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.ModuloGrupoDeVeiculos
{
    public class ServiceGrupoVeiculo
    {
        IRepositorioGrupoVeiculo repositorio;

        public ServiceGrupoVeiculo(IRepositorioGrupoVeiculo repositorio)
        {
            this.repositorio=repositorio;
        }

        public ValidationResult Inserir(GrupoVeiculo registro)
        {
            var validador = new ValidadorGrupoVeiculo();

            var resultado = validador.Validate(registro);

            if (resultado.IsValid)
            {
                repositorio.Inserir(registro);
            }
            return resultado;
        }
        public ValidationResult Editar(GrupoVeiculo registro)
        {
            var validador = new ValidadorGrupoVeiculo();

            var resultado = validador.Validate(registro);

            if (resultado.IsValid)
            {
                repositorio.Editar(registro);
            }
            return resultado;
        }
        public ValidationResult Excluir(GrupoVeiculo registro)
        {
            var validador = new ValidadorGrupoVeiculo();

            var resultado = validador.Validate(registro);

            if (resultado.IsValid)
            {
                repositorio.Excluir(registro);
            }
            return resultado;
        }
        public GrupoVeiculo SelecionarPorId(int id)
        {
            return repositorio.SelecionarPorId(id);
        }
        public List<GrupoVeiculo> SelecionarTodos()
        {
            return repositorio.SelecionarTodos();
        }
    }
}
