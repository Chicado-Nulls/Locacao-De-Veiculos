
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using FluentValidation.Results;
using FluentValidation.TestHelper;
using Locadora.Dominio.ModuloTaxa;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Locadora.Test.Unit.ModuloTaxa
{
    [TestClass]
    public class ValidadorTaxaTest
    {
        private ValidadorTaxa validador;
        private Taxa taxa; 

        public ValidadorTaxaTest()
        {
           this.validador = new ValidadorTaxa();
            this.taxa = new ()
            {
                Id = 1,
                Descricao = "Ar condicionado",
                Valor = 100,
                TipoDeCalculo =TipoDeCalculo.CalculoFixo
            };
        }
        [TestMethod]
        public void Descricao_Nao_Pode_Ser_Nula()
        {
            taxa.Descricao = null;

           var resultado =validador.TestValidate(taxa);

            resultado.ShouldHaveValidationErrorFor(x => x.Descricao);
        }
        [TestMethod]
        public void Tipo_Calculo_Nao_Pode_Ser_Nulo()
        {
            taxa.TipoDeCalculo = null;

            var resultado = validador.TestValidate(taxa);

            resultado.ShouldHaveValidationErrorFor(x => x.TipoDeCalculo);
        }
        [TestMethod]
        public void Valor_Nao_Poder_Ser_Null()
        {
            taxa.Valor = null;

            var resultado = validador.TestValidate(taxa);

            resultado.ShouldHaveValidationErrorFor(x => x.Valor);
        }
        [TestMethod]
        public void Valor_Nao_Poder_Ser_0()
        {
            taxa.Valor = 0;

            var resultado = validador.TestValidate(taxa);

            resultado.ShouldHaveValidationErrorFor(x => x.Valor);

        }
        [TestMethod]
        public void Valor_Nao_Poder_Ser_Menor_0()
        {
            taxa.Valor = -1;

            var resultado = validador.TestValidate(taxa);

            resultado.ShouldHaveValidationErrorFor(x => x.Valor);
        }
        [TestMethod]
        public void Valor_Nao_Poder_Ser_Menor_10000()
        {
            taxa.Valor = 10001;

            var resultado = validador.TestValidate(taxa);

            resultado.ShouldHaveValidationErrorFor(x => x.Valor);
        }

    }                                                
}
