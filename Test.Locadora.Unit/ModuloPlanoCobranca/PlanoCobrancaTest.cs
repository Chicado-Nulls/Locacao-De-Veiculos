using Locadora.Dominio.ModuloGrupoDeVeiculo;
using Locadora.Dominio.ModuloPlanoCobranca;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Test.Unit.ModuloPlanoCobranca
{
    [TestClass]
    public class PlanoCobrancaTest
    {
        private GrupoVeiculo grupoVeiculo { get; set; }

        private PlanoCobranca planoCobranca { get; set; }

        public PlanoCobrancaTest()
        {
            grupoVeiculo = new()
            {
                Id = 1,
                Nome = "esportivo"
            };

            planoCobranca = new()
            {
                GrupoVeiculo = grupoVeiculo,
                DiarioValorDiario = 100,
                DiarioValorPorKm = 4,
                LivreValorDiario = 5,
                ControladoValorDiario = 2,
                ControladoValorPorKm = 3,
                ControladoLimiteDeKm = 8
            };
        }

        [TestMethod]
        public void Cria_objeto_plano_cobranca_com_campos_contrutor()
        {
            // arrange - action
            var planoCobranca = new PlanoCobranca(grupoVeiculo, 100, 4, 5, 2, 3, 8 );

            // Asset
            Assert.AreEqual(grupoVeiculo, planoCobranca.GrupoVeiculo);

            // Asset
            Assert.AreEqual(100, planoCobranca.DiarioValorDiario);

            // Asset
            Assert.AreEqual(4, planoCobranca.DiarioValorPorKm);

            // Asset
            Assert.AreEqual(5, planoCobranca.LivreValorDiario);

            // Asset
            Assert.AreEqual(2, planoCobranca.ControladoValorDiario);

            // Asset
            Assert.AreEqual(3, planoCobranca.ControladoValorPorKm);

            // Asset
            Assert.AreEqual(8, planoCobranca.ControladoLimiteDeKm);
        }

        [TestMethod]
        public void Cria_objeto_plano_cobranca_com_todos_atributos_vazio()
        {
            // arrange - action
            var planoCobranca = new PlanoCobranca();

            // Asset
            Assert.AreEqual(null, planoCobranca.GrupoVeiculo);

            // Asset
            Assert.AreEqual(0, planoCobranca.DiarioValorDiario);

            // Asset
            Assert.AreEqual(0, planoCobranca.DiarioValorPorKm);

            // Asset
            Assert.AreEqual(0, planoCobranca.LivreValorDiario);

            // Asset
            Assert.AreEqual(0, planoCobranca.ControladoValorDiario);

            // Asset
            Assert.AreEqual(0, planoCobranca.ControladoValorPorKm);

            // Asset
            Assert.AreEqual(0, planoCobranca.ControladoLimiteDeKm);



        }

        [TestMethod]
        public void Deve_atualizar_campos_condutor()
        {
            // arrange
            var novoPlanoCobranca = new PlanoCobranca();

            // action
            novoPlanoCobranca.Atualizar(planoCobranca);

            // Asset
            Assert.AreEqual(planoCobranca.GrupoVeiculo, novoPlanoCobranca.GrupoVeiculo);

            // Asset
            Assert.AreEqual(planoCobranca.DiarioValorDiario, novoPlanoCobranca.DiarioValorDiario);

            // Asset
            Assert.AreEqual(planoCobranca.DiarioValorPorKm, novoPlanoCobranca.DiarioValorPorKm);

            // Asset
            Assert.AreEqual(planoCobranca.LivreValorDiario, novoPlanoCobranca.LivreValorDiario);

            // Asset
            Assert.AreEqual(planoCobranca.ControladoValorDiario, novoPlanoCobranca.ControladoValorDiario);

            // Asset
            Assert.AreEqual(planoCobranca.ControladoValorPorKm, novoPlanoCobranca.ControladoValorPorKm);

            // Asset
            Assert.AreEqual(planoCobranca.ControladoLimiteDeKm, novoPlanoCobranca.ControladoLimiteDeKm);

        }



    }
}
