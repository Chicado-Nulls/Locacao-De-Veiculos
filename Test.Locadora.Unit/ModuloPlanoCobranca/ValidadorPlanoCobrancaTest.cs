using Locadora.Dominio.ModuloGrupoDeVeiculo;
using Locadora.Dominio.ModuloPlanoCobranca;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentValidation.TestHelper;

namespace Locadora.Test.Unit.ModuloPlanoCobranca
{
    [TestClass]
    public class ValidadorPlanoCobrancaTest
    {
        GrupoVeiculo _grupoVeiculo;
        PlanoCobranca _planoCobranca;
        ValidadorPlanoCobranca _validador;
        public ValidadorPlanoCobrancaTest()
        {
            _grupoVeiculo = new GrupoVeiculo("SUV");
            
            _planoCobranca = new()
            {
                GrupoVeiculo = _grupoVeiculo,
                DiarioValorDiario = 100,
                DiarioValorPorKm = 4,
                LivreValorDiario = 5,
                ControladoValorDiario = 2,
                ControladoValorPorKm = 3,
                ControladoLimiteDeKm = 8
            };

            _validador = new ValidadorPlanoCobranca();
        }
        [TestMethod]
        public void Diario_valor_diario_nao_deve_ser_nulo()
        {
            // arrange
            _planoCobranca.DiarioValorDiario = default;

            // action
            var resultado = _validador.TestValidate(_planoCobranca);

            // assert
            resultado.ShouldHaveValidationErrorFor(f => f.DiarioValorDiario);
        }
        [TestMethod]
        public void Diario_valor_diario_deve_ser_maior_que_zero()
        {
            // arrange
            _planoCobranca.DiarioValorDiario = 0;

            // action
            var resultado = _validador.TestValidate(_planoCobranca);

            // assert
            resultado.ShouldHaveValidationErrorFor(f => f.DiarioValorDiario);
        }

        [TestMethod]
        public void Diario_valor_por_km_nao_deve_ser_nulo()
        {
            // arrange
            _planoCobranca.DiarioValorPorKm = default;

            // action
            var resultado = _validador.TestValidate(_planoCobranca);

            // assert
            resultado.ShouldHaveValidationErrorFor(f => f.DiarioValorPorKm);
        }
        [TestMethod]
        public void Diario_valor_por_km_deve_ser_maior_que_zero()
        {
            // arrange
            _planoCobranca.DiarioValorPorKm = 0;

            // action
            var resultado = _validador.TestValidate(_planoCobranca);

            // assert
            resultado.ShouldHaveValidationErrorFor(f => f.DiarioValorPorKm);
        }

        [TestMethod]
        public void Livre_valor_diario_nao_deve_ser_nulo()
        {
            // arrange
            _planoCobranca.LivreValorDiario = default;

            // action
            var resultado = _validador.TestValidate(_planoCobranca);

            // assert
            resultado.ShouldHaveValidationErrorFor(f => f.LivreValorDiario);
        }
        [TestMethod]
        public void Livre_valor_diario_deve_ser_maior_que_zero()
        {
            // arrange
            _planoCobranca.LivreValorDiario = 0;

            // action
            var resultado = _validador.TestValidate(_planoCobranca);

            // assert
            resultado.ShouldHaveValidationErrorFor(f => f.LivreValorDiario);
        }

        [TestMethod]
        public void Controlado_valor_diario_nao_deve_ser_nulo()
        {
            // arrange
            _planoCobranca.ControladoValorDiario = default;

            // action
            var resultado = _validador.TestValidate(_planoCobranca);

            // assert
            resultado.ShouldHaveValidationErrorFor(f => f.ControladoValorDiario);
        }
        [TestMethod]
        public void Controlado_valor_diario_deve_ser_maior_que_zero()
        {
            // arrange
            _planoCobranca.ControladoValorDiario = 0;

            // action
            var resultado = _validador.TestValidate(_planoCobranca);

            // assert
            resultado.ShouldHaveValidationErrorFor(f => f.ControladoValorDiario);
        }

        [TestMethod]
        public void Controlado_valor_por_km_nao_deve_ser_nulo()
        {
            // arrange
            _planoCobranca.ControladoValorPorKm = default;

            // action
            var resultado = _validador.TestValidate(_planoCobranca);

            // assert
            resultado.ShouldHaveValidationErrorFor(f => f.ControladoValorPorKm);
        }
        [TestMethod]
        public void Controlado_valor_por_km_deve_ser_maior_que_zero()
        {
            // arrange
            _planoCobranca.ControladoValorPorKm = 0;

            // action
            var resultado = _validador.TestValidate(_planoCobranca);

            // assert
            resultado.ShouldHaveValidationErrorFor(f => f.ControladoValorPorKm);
        }

        [TestMethod]
        public void Controlado_limite_de_km_nao_deve_ser_nulo()
        {
            // arrange
            _planoCobranca.ControladoLimiteDeKm = default;

            // action
            var resultado = _validador.TestValidate(_planoCobranca);

            // assert
            resultado.ShouldHaveValidationErrorFor(f => f.ControladoLimiteDeKm);
        }
        [TestMethod]
        public void Controlado_limite_de_km_deve_ser_maior_que_zero()
        {
            // arrange
            _planoCobranca.ControladoLimiteDeKm = 0;

            // action
            var resultado = _validador.TestValidate(_planoCobranca);

            // assert
            resultado.ShouldHaveValidationErrorFor(f => f.ControladoLimiteDeKm);
        }
    }
}
