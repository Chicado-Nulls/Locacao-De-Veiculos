using FluentAssertions;
using Locadora.Dominio.ModuloTaxa;
using Locadora.Infra.BancoDados.Compartilhado;
using Locadora.Infra.BancoDados.ModuloTaxa;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Test.Infra.ModuloTaxa
{
    [TestClass]
    public class RepositorioTaxaBancoDadosTest
    {
        private RepositorioTaxa repositorio;
        public RepositorioTaxaBancoDadosTest()
        {
            this.repositorio = new RepositorioTaxa();
            Db.ExecutarSql("DELETE FROM [TbTaxa]; DBCC CHECKIDENT ([TbTaxa], RESEED, 0)");
        }

        [TestMethod]
        public void Deve_Inserir_Taxa()
        {
            var NovaTaxa = gerarTaxa();

            repositorio.Inserir(NovaTaxa);

            var taxaInserida = repositorio.SelecionarPorId(NovaTaxa.Id);

            taxaInserida.Should().NotBeNull();           
            taxaInserida.Should().Be(NovaTaxa);
        }
        [TestMethod]
        public void Deve_Editar_Taxa()
        {
            var novaTaxa = gerarTaxa();

            repositorio.Inserir(novaTaxa);

            novaTaxa.Descricao = "Sense of time are running low";
            novaTaxa.TipoDeCalculo = 0;
            novaTaxa.Valor = 2000;

            repositorio.Editar(novaTaxa);

            var taxaEditada = repositorio.SelecionarPorId(novaTaxa.Id);

            taxaEditada.Should().NotBeNull();
            taxaEditada.Should().Be(novaTaxa);
           
        }
        [TestMethod]
        public void Deve_Excluir_Taxa()
        {
            var novaTaxa =gerarTaxa();

            repositorio.Inserir(novaTaxa);
            repositorio.Inserir(novaTaxa);                      
            repositorio.Excluir(novaTaxa);

            
            repositorio.SelecionarPorId(novaTaxa.Id)
                .Should().BeNull();
        }

        [TestMethod]
        public void Deve_Selecionar_Por_Id()
        {
            var novaTaxa = gerarTaxa();

            repositorio.Inserir(novaTaxa);
            repositorio.SelecionarPorId(novaTaxa.Id)
                .Should().NotBeNull();
        }
        [TestMethod]
        public void Deve_Selecionar_Todas_Taxas()
        {
            var novaTaxaUm = gerarTaxa();

            var novaTaxaDois = new Taxa();

            novaTaxaDois.Id = 2;
            novaTaxaDois.Descricao = "aaaaaa";
            novaTaxaDois.Valor = 1000;
            novaTaxaDois.TipoDeCalculo = TipoDeCalculo.CalculoDiario;

            var novaTaxaTres =  new Taxa();
            novaTaxaTres.Id = 3;
            novaTaxaTres.Descricao = "ggggg";
            novaTaxaTres.Valor = 2000;
            novaTaxaTres.TipoDeCalculo = TipoDeCalculo.CalculoFixo;

            repositorio.Inserir(novaTaxaUm);
            repositorio.Inserir(novaTaxaDois);
            repositorio.Inserir(novaTaxaTres);

            var listTaxa = repositorio.SelecionarTodos();

            listTaxa[0].Descricao.Should().Be(novaTaxaUm.Descricao);
            listTaxa[1].Descricao.Should().Be(novaTaxaDois.Descricao);
            listTaxa[2].Descricao.Should().Be(novaTaxaTres.Descricao);
        }
        
        private Taxa gerarTaxa()
        {
           Taxa taxa = new Taxa();

           taxa.Descricao = "Ar condicionado Incluso";
           taxa.TipoDeCalculo = TipoDeCalculo.CalculoFixo;
           taxa.Valor = 100;

            return taxa;
        }
    }
}
