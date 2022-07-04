using FluentAssertions;
using Locadora.Dominio.ModuloCarro;
using Locadora.Dominio.ModuloGrupoDeVeiculo;
using Locadora.Dominio.ModuloVeiculo;
using Locadora.Infra.BancoDados.ModuloGrupoVeiculo;
using Locadora.Infra.BancoDados.ModuloVeiculo;
using Locadora.Test.Infra.Compartilhado;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Test.Infra.ModuloVeiculo
{
    [TestClass]
    public class RepositorioGrupoVeiculoBancoDadosTest : RepositorioBaseTest
    {
        protected override string NomeTabela =>"TbVeiculo";

        private RepositorioVeiculo repositorio;
        private RepositorioGrupoVeiculo repositorioGrupo;

        public RepositorioGrupoVeiculoBancoDadosTest()
        {
            this.repositorio = new RepositorioVeiculo(true);            
            this.repositorioGrupo=new RepositorioGrupoVeiculo(true);
            
        }
        [TestMethod]
        
        public void Deve_Inserir()
        {
            var veiculo = GerandoVeiculo();

            repositorio.Inserir(veiculo);

            var veiculoInserido = repositorio.SelecionarPorId(veiculo.Id);

            veiculoInserido.Should().Be(veiculo);
        }
        [TestMethod]
        public void Deve_Editar()
        {
            var veiculo = GerandoVeiculo();

            repositorio.Inserir(veiculo);

            veiculo.Modelo = "BMW M3 GT2";
            veiculo.Placa = "242420-TB";
            veiculo.Cor = "Laranja";
            veiculo.TipoDeCombustivel = EnumTipoDeCombustivel.Etanol;

            repositorio.Editar(veiculo);

            var veiculoEditado = repositorio.SelecionarPorId(veiculo.Id);

            veiculoEditado.Should().Be(veiculo);    

        }
        [TestMethod]
        public void Deve_Excluir()
        {
            var veiculo = GerandoVeiculo();

            repositorio.Inserir(veiculo);

            var veiculoExcluir = repositorio.SelecionarPorId(veiculo.Id);

            repositorio.Excluir(veiculoExcluir);

            var veiculoExcluido=repositorio.SelecionarPorId(veiculoExcluir.Id);

            veiculoExcluido.Should().BeNull();
            
        }
        [TestMethod]

        public void Deve_Selecionar_Todos()
        {
            LimparTabela(NomeTabela);
            Veiculo veiculoUm = new Veiculo("BMW Z4", "40440-DV", "BMW", "Azul", 30m, 100m, EnumTipoDeCombustivel.Gasolina);

            Veiculo veiculoDois = new Veiculo("BMW M2", "204242-DD", "BMWM", "LARANJA", 50m, 200M, EnumTipoDeCombustivel.Gasolina);

            Veiculo veiculoTres = new Veiculo("Stock car", "224242-bb", "Toyota", "Vermelho", 20m, 300m, EnumTipoDeCombustivel.Etanol);

            var grupoVeiculo = GerarGrupo();

            veiculoUm.GrupoDeVeiculo=grupoVeiculo;
            veiculoDois.GrupoDeVeiculo = grupoVeiculo;
            veiculoTres.GrupoDeVeiculo = grupoVeiculo;

            repositorio.Inserir(veiculoUm);
            repositorio.Inserir(veiculoDois);
            repositorio.Inserir(veiculoTres);

            var listaVeiculos = repositorio.SelecionarTodos();

            listaVeiculos[0].Should().Be(veiculoUm);
            listaVeiculos[1].Should().Be(veiculoDois);
            listaVeiculos[2].Should().Be(veiculoTres);
        }



        public Veiculo GerandoVeiculo()
        {
            var grupoDeVeiculo = new GrupoVeiculo("Turismo");

            repositorioGrupo.Inserir(grupoDeVeiculo);

            var veiculo = new Veiculo("BMW Z4","40440-DV","BMW","Azul",30m,100m, EnumTipoDeCombustivel.Gasolina);

            veiculo.GrupoDeVeiculo=grupoDeVeiculo;

            return veiculo;
        }
        public GrupoVeiculo GerarGrupo()
        {
            var grupoDeVeiculo = new GrupoVeiculo("Turismo");

            repositorioGrupo.Inserir(grupoDeVeiculo);

            return grupoDeVeiculo;
        }

    }
}
