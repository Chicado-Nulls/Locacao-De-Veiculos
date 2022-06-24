using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Locadora.Infra.BancoDados.ModuloFuncionario;
using Locadora.Dominio.ModuloFuncionario;
using System;

namespace Locadora.Test.Infra.ModuloFuncionario
{
    [TestClass]
    public class RepositorioFuncionarioBancoDadosTest
    {
        private RepositorioFuncionarioBancoDados repositorio;

        public RepositorioFuncionarioBancoDadosTest()
        {
            repositorio = new RepositorioFuncionarioBancoDados();
            Db.ExecutarSql("DELETE FROM TBFUNCIONARIO; DBCC CHECKIDENT (TBFUNCIONARIO, RESEED, 0)");
        }

        [TestMethod]
        public void Deve_inserir_novo_funcionario()
        {
            //arrange
            var fornecedor = NovoFuncionario();

            //action
            repositorio.Inserir(fornecedor);

            //assert
            var fornecedorEncontrado = repositorio.SelecionarPorId(fornecedor.Id);

            fornecedorEncontrado.Should().NotBeNull();
            fornecedorEncontrado.Should().Be(fornecedor);
        }

        [TestMethod]
        public void Deve_editar_informacoes_funcionario()
        {
            //arrange
            var fornecedor = NovoFuncionario();
            repositorio.Inserir(fornecedor);

            fornecedor.Nome = "Joao editado";
            fornecedor.Login = "joaologin";
            fornecedor.Senha = "joaosenha";
            fornecedor.DataEntrada = new DateTime(2022,03,03);

            //action
            repositorio.Editar(fornecedor);

            //assert
            var fornecedorEncontrado = repositorio.SelecionarPorId(fornecedor.Id);

            fornecedorEncontrado.Should().NotBeNull();
            fornecedorEncontrado.Should().Be(fornecedor);
        }

        [TestMethod]
        public void Deve_excluir_funcionario()
        {
            //arrange           
            var funcionario = NovoFuncionario();
            repositorio.Inserir(funcionario);

            //action           
            repositorio.Excluir(funcionario);

            //assert
            repositorio.SelecionarPorId(funcionario.Id)
                .Should().BeNull();
        }

        [TestMethod]
        public void Deve_selecionar_apenas_um_funcionario()
        {
            //arrange          
            var funcionario = NovoFuncionario();
            repositorio.Inserir(funcionario);

            //action
            var fornecedorEncontrado = repositorio.SelecionarPorId(funcionario.Id);

            //assert
            Assert.IsNotNull(fornecedorEncontrado);
            Assert.AreEqual(funcionario, fornecedorEncontrado);
        }

        [TestMethod]
        public void Deve_selecionar_todos_os_fornecedores()
        {
            //arrange
            var f0 = new Funcionario("Usuário master", "Admin1", "Admin1", new DateTime(2022, 01, 01)); ;
            var f1 = new Funcionario("Ze da pastelaria", "zezeze", "zezeze", new DateTime(2022, 02, 02)); ;
            var f2 = new Funcionario("Joao da borracharia", "joaobr", "joaobr", new DateTime(2022, 03, 03)); ;

            repositorio.Inserir(f0);
            repositorio.Inserir(f1);
            repositorio.Inserir(f2);

            //action
            var fornecedores = repositorio.SelecionarTodos();

            //assert

            Assert.AreEqual(3, fornecedores.Count);

            Assert.AreEqual(f0.Nome, fornecedores[0].Nome);
            Assert.AreEqual(f1.Nome, fornecedores[1].Nome);
            Assert.AreEqual(f2.Nome, fornecedores[2].Nome);
        }


        private Funcionario NovoFuncionario()
        {
            return new Funcionario("Usuário master", "Admin1", "Admin1", new DateTime(2022,01,01));
        }
    }
}
