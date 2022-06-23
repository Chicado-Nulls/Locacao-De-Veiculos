using Locadora.Dominio.ModuloFuncionario;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Locadora.Test.Unit.ModuloFuncionario
{
    [TestClass]
    public class FuncionarioTest
    {
        private readonly Funcionario funcionario;

        public FuncionarioTest()
        {
            funcionario = new()
            {
                Id = 1,
                Nome = "usuario master",
                Login = "admin1",
                Senha = "admin1",
                DataEntrada = new DateTime(2022, 01, 01)
            };
        }
        [TestMethod]
        public void Cria_objeto_funcionario_com_campos_contrutor()
        {
            // arrange - action
            var FuncionarioCriar = new Funcionario("Usuario teste", "login", "login", new DateTime(2022,01,01));

            // Asset
            Assert.AreEqual("Usuario teste", FuncionarioCriar.Nome);

            // Asset
            Assert.AreEqual("login", FuncionarioCriar.Login);

            // Asset
            Assert.AreEqual("login", FuncionarioCriar.Senha);
        }

        [TestMethod]
        public void Cria_objeto_funcionario_com_todos_atributos_vazio()
        {
            // arrange - action
            var FuncionarioCriar = new Funcionario();

            // Asset
            Assert.AreEqual(null, FuncionarioCriar.Nome);

            // Asset
            Assert.AreEqual(null, FuncionarioCriar.Login);

            // Asset
            Assert.AreEqual(null, FuncionarioCriar.Senha);

        }
        [TestMethod]
        public void Deve_atualizar_campos_funcionario()
        {
            // arrange
            var FuncionarioCriar = new Funcionario();

            // action

            FuncionarioCriar.Atualizar(funcionario);

            // Asset
            Assert.AreEqual(funcionario.Nome, FuncionarioCriar.Nome);

            // Asset
            Assert.AreEqual(funcionario.Login, FuncionarioCriar.Login);

            // Asset
            Assert.AreEqual(funcionario.Senha, FuncionarioCriar.Senha);

        }
    }
}
