

using Locadora.Dominio.ModuloGrupoDeVeiculo;
using Locadora.Dominio.ModuloPlanoCobranca;
using Locadora.Infra.BancoDados.ModuloGrupoVeiculo;
using Locadora.Infra.BancoDados.ModuloPlanoCobranca;
using Locadora.Test.Infra.Compartilhado;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Locadora.Test.Infra.ModuloPlanoCobranca
{
    [TestClass]
    public class RepositorioPlanoCobrancaBancoDadosTest : RepositorioBaseTest
    {
        protected override string NomeTabela => "TBPLANOCOBRANCA";

        private GrupoVeiculo grupoVeiculo;
        private RepositorioGrupoVeiculo repositorioGrupoVeiculo;

        private PlanoCobranca planoCobranca;
        private RepositorioPlanoCobrancaBancoDados repositorioPlanoCobranca;

        public RepositorioPlanoCobrancaBancoDadosTest() : base()
        {

            grupoVeiculo = new()
            {
                Id = 1,
                Nome = "Esportivo"
            };


            planoCobranca = new()
            {

                Id = 1,
                GrupoVeiculo = grupoVeiculo,
                DiarioValorDiario = 2,
                DiarioValorPorKm = 3,
                LivreValorDiario = 4,
                ControladoValorDiario = 5,
                ControladoValorPorKm = 6,
                ControladoLimiteDeKm = 7

            };





            this.repositorioGrupoVeiculo = new RepositorioGrupoVeiculo(true);
            this.repositorioPlanoCobranca = new RepositorioPlanoCobrancaBancoDados(true);

            LimparTabela("TBGRUPODEVEICULOS");

        }


        [TestMethod]
        public void Deve_Inserir_Plano_Cobranca()
        {
            //action
            repositorioGrupoVeiculo.Inserir(grupoVeiculo);
            repositorioPlanoCobranca.Inserir(planoCobranca);

            //assert
            var planoCobrancaEncontrado = repositorioPlanoCobranca.SelecionarPorId(planoCobranca.Id);

            Assert.IsNotNull(planoCobrancaEncontrado);
            Assert.AreEqual(planoCobranca, planoCobrancaEncontrado);
        }

        [TestMethod]
        public void Deve_Editar_Plano_Cobranca()
        {
            repositorioGrupoVeiculo.Inserir(grupoVeiculo);

            grupoVeiculo.Nome = "Camionete";

            repositorioGrupoVeiculo.Editar(grupoVeiculo);


            
            repositorioPlanoCobranca.Inserir(planoCobranca);
            
            planoCobranca.GrupoVeiculo = grupoVeiculo;
            planoCobranca.DiarioValorDiario = 8;
            planoCobranca.DiarioValorPorKm = 7;
            planoCobranca.LivreValorDiario = 6;
            planoCobranca.ControladoValorDiario = 8;
            planoCobranca.ControladoValorPorKm = 4;
            planoCobranca.ControladoLimiteDeKm = 4;

            repositorioPlanoCobranca.Editar(planoCobranca);



            var planoCobrancaEncontrado = repositorioPlanoCobranca.SelecionarPorId(planoCobranca.Id);

            Assert.IsNotNull(planoCobrancaEncontrado);
            Assert.AreEqual(planoCobranca, planoCobrancaEncontrado);



        }

















    }
}
