using FluentValidation.TestHelper;
using Locadora.Dominio.ModuloGrupoDeVeiculos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Test.Unit.ModuloGrupoDeVeiculos
{
    [TestClass]
    public class ValidadorGrupoDeVeiculosTest
    {

        ValidadorGrupoDeVeiculos validador;

        GrupoDeVeiculo grupoDeVeiculo;

        public ValidadorGrupoDeVeiculosTest()
        {
            validador = new ValidadorGrupoDeVeiculos();
            grupoDeVeiculo = new GrupoDeVeiculo()
            {
                Id = 1,
                Nome = "a3434434"
            };
        }

        [TestMethod]

        public void Nome_Nao_Pode_Ser_Null()
        {
            grupoDeVeiculo.Nome = null;

            var resultado = validador.TestValidate(grupoDeVeiculo);

            resultado.ShouldHaveValidationErrorFor(x => x.Nome);
        }
        [TestMethod]
        public void Nome_Nao_Pode_Ter_Numero()
        {
            grupoDeVeiculo.Nome = "11111";

            var resultado = validador.TestValidate(grupoDeVeiculo);

            resultado.ShouldHaveValidationErrorFor(x => x.Nome);
        }        
    }
}
