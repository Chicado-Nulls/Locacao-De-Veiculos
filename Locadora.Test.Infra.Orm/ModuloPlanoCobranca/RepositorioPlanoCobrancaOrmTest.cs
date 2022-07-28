using FluentAssertions;
using Locadora.Dominio.ModuloGrupoDeVeiculo;
using Locadora.Dominio.ModuloPlanoCobranca;
using Locadora.Infra.Orm.ModuloGrupoVeiculo;
using Locadora.Infra.Orm.ModuloPlanoCobranca;
using Locadora.Test.Infra.Orm.Compartilhado;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Test.Infra.Orm.ModuloPlanoCobranca
{
    [TestClass]
    public class RepositorioPlanoCobrancaOrmTest : RepositorioBaseOrmTest
    {
        private RepositorioPlanoCobranca repositorioPlanoCobranca;
        private RepositorioGrupoVeiculo repositorioGrupoVeiculo;
        private GrupoVeiculo grupoVeiculo;
        private PlanoCobranca novoPlanoCobranca;

        public RepositorioPlanoCobrancaOrmTest()
        {
            repositorioGrupoVeiculo = new RepositorioGrupoVeiculo(contextoDadosOrm);
            repositorioPlanoCobranca = new RepositorioPlanoCobranca(contextoDadosOrm);

            grupoVeiculo = new GrupoVeiculo();
            grupoVeiculo.Nome = "Esportivo";
            repositorioGrupoVeiculo.Inserir(grupoVeiculo);
            contextoDadosOrm.GravarDados();

            novoPlanoCobranca = new PlanoCobranca();
            novoPlanoCobranca.GrupoVeiculo = grupoVeiculo;
            novoPlanoCobranca.DiarioDiaria = 2;
            novoPlanoCobranca.DiarioPorKm = 3;
            novoPlanoCobranca.LivreDiaria = 4;
            novoPlanoCobranca.ControladoDiaria = 5;
            novoPlanoCobranca.ControladoPorKm = 6;
            novoPlanoCobranca.ControladoLimiteKm = 7;

            LimparTabela("TbGrupoVeiculo");
            LimparTabela("TbPlanoCobranca");
        }

        [TestMethod]
        public void Deve_Inserir_Novo_PlanoCobranca()
        {
            repositorioPlanoCobranca.Inserir(novoPlanoCobranca);

            contextoDadosOrm.GravarDados();

            var planoInserido = repositorioPlanoCobranca.SelecionarPorId(novoPlanoCobranca.Id);
            planoInserido.Should().NotBeNull();

        }






    }
}
