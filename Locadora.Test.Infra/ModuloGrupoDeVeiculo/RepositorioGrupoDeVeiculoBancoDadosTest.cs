using FluentAssertions;
using Locadora.Dominio.ModuloGrupoDeVeiculos;
using Locadora.Infra.BancoDados.Compartilhado;
using Locadora.Infra.BancoDados.ModuloGrupoDeVeiculo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Test.Infra.ModuloGrupoDeVeiculo
{
    [TestClass]
    public  class RepositorioGrupoDeVeiculoBancoDadosTest
    {
        private RepositorioGrupoDeVeiculo repositorio;

        public RepositorioGrupoDeVeiculoBancoDadosTest()
        {
            repositorio = new RepositorioGrupoDeVeiculo();
            Db.ExecutarSql("DELETE FROM TBGRUPODEVEICULOS; DBCC CHECKIDENT (TBGRUPODEVEICULOS, RESEED, 0)");
        }

        [TestMethod]

        public void Deve_inserir_novo_GrupoDeVeiculo()
        {
            var grupo = GerandoGrupoDeVeiculo();
            
            repositorio.Inserir(grupo);

            var grupoInserido = repositorio.SelecionarPorId(grupo.Id);

            grupoInserido.Should().NotBeNull();

            grupoInserido.Should().Be(grupo);
        }

        [TestMethod]

        public void Deve_Editar_GrupoDeVeiculo()
        {
            var grupo = GerandoGrupoDeVeiculo();

            repositorio.Inserir(grupo);

            grupo.Nome = "Suv";

            repositorio.Editar(grupo);

            var grupoEditado  = repositorio.SelecionarPorId(grupo.Id);

            grupoEditado.Should().NotBeNull();
            grupoEditado.Should().Be(grupo);

        }

        [TestMethod]

        public void Deve_Excluir_GrupoDeVeiculo()
        {
            var grupo = GerandoGrupoDeVeiculo();

            repositorio.Inserir(grupo);

            repositorio.Excluir(grupo);

            var grupoExcluido = repositorio.SelecionarPorId(grupo.Id);

            grupoExcluido.Should().BeNull();

        }

        [TestMethod]

        public void Deve_Selecionar_Todos_GrupoDeVeiculo()
        {
            var grupoUm = GerandoGrupoDeVeiculo();

            var grupoDois = new GrupoDeVeiculo();
            grupoDois.Nome = "StockCar";

            var grupoTres = new GrupoDeVeiculo();
            grupoTres.Nome = "gt";

            repositorio.Inserir(grupoUm);
            repositorio.Inserir(grupoDois);
            repositorio.Inserir(grupoTres);

            var grupos = repositorio.SelecionarTodos();

            grupos[0].Should().Be(grupoUm);
            grupos[1].Should().Be(grupoDois);
            grupos[2].Should().Be(grupoTres);
        }

        public GrupoDeVeiculo  GerandoGrupoDeVeiculo()
        {
            var grupo = new GrupoDeVeiculo("Monoposto");

            return grupo;
        }
    }
}
