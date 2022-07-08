using FluentValidation.Results;
using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloGrupoDeVeiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.ModuloGrupoDeVeiculos
{
    public class ServiceGrupoVeiculo : ServiceBase<GrupoVeiculo, ValidadorGrupoVeiculo>
    {
        public ServiceGrupoVeiculo(IRepositorioBase<GrupoVeiculo> repositorio) : base(repositorio)
        {

        }
        protected override string ObterIdentificadorLog(GrupoVeiculo registro)
        {
            return $"ID: {registro.Id} | Nome: {registro.Nome}";
        }       
    }
}
