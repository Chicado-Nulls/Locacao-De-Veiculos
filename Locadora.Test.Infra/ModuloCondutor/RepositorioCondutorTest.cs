using Locadora.Dominio.ModuloCondutor;
using Locadora.Test.Infra.Compartilhado;
using Locadora.Infra.BancoDados.ModuloCondutor;
using Locadora.Dominio.ModuloCliente;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Locadora.Infra.BancoDados.ModuloCliente;

namespace Locadora.Test.Infra.ModuloCondutor
{
    [TestClass]
    public class RepositorioCondutorTest : RepositorioBaseTest
    {
        protected override string NomeTabela => "TBCONDUTOR";
        private Cliente _cliente;
        private Condutor _condutor;
        private RepositorioClienteEmBancoDeDados _repositorioCliente;
        private RepositorioCondutor _repositorioCondutor;

        public RepositorioCondutorTest() : base()
        {
            _cliente = new()
            {
                Nome = "romulo",
                Cpf = "12345",
                Cnpj = "123456",
                Cnh = "88888",
                Endereco = "lages",
                Email = "Romulo@gmail.com",
                Telefone = "49999999",
                TipoCadastro = true
            };

            _condutor = new()
            {
                Nome = "Marcos",
                Cpf = "123.456.789.10",
                Cnh = "12345678910",
                Endereco = "Rua teste - lages",
                Email = "condutor@dirigir.com",
                Telefone = "49999993510",
                Cliente = _cliente
            };

            _repositorioCliente = new RepositorioClienteEmBancoDeDados(true);
            _repositorioCondutor = new RepositorioCondutor(true);

            LimparTabela("TBCLIENTE");
        }
        [TestMethod]
        public void Deve_inserir_condutor()
        {
            //action
            _repositorioCliente.Inserir(_cliente);
            _repositorioCondutor.Inserir(_condutor);

            //assert
            var condutorEncontrado = _repositorioCondutor.SelecionarPorId(_condutor.Id);

            Assert.IsNotNull(condutorEncontrado);
            Assert.AreEqual(true, _condutor.Equals(condutorEncontrado));
        }
    }
}
