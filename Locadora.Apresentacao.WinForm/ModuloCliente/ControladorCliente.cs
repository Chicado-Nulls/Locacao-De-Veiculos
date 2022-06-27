using Locadora.Apresentacao.WinForm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora.Dominio.ModuloCliente;

namespace Locadora.Apresentacao.WinForm.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private readonly IRepositorioCliente repositorioCliente;
        private TabelaClientesControl tabelaClientes;

        public ControladorCliente(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public override void Editar()
        {
            var numero = tabelaClientes.ObtemIdClienteSelecionado();
            var clienteSelecionado = repositorioCliente.SelecionarPorId(numero);
         
            if (clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente primeiro",
                "Edição de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroCliente tela = new TelaCadastroCliente("EditarCliente");

            tela.Cliente = clienteSelecionado.Clone();

            tela.GravarRegistro = repositorioCliente.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarClientes();
            }

        }

        public override void Excluir()
        {
            var numero = tabelaClientes.ObtemIdClienteSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(numero);

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente primeiro",
                "Exclusão de Cliente(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show($"Deseja realmente excluir o cliente '{clienteSelecionado.Nome}'?",
               "Exclusão de Cliente(s)", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioCliente.Excluir(clienteSelecionado);
                CarregarClientes();
            }
        }

        public override void Inserir()
        {
            TelaCadastroCliente tela = new TelaCadastroCliente("Cadastrar Cliente");

            tela.Cliente = new Cliente();

            tela.GravarRegistro = repositorioCliente.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarClientes();
            }
            
        }
        private Cliente ObtemClienteSelecionado()
        {
            var id = tabelaClientes.ObtemIdClienteSelecionado();

            return repositorioCliente.SelecionarPorId(id);
        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            tabelaClientes.AtualizarRegistros(clientes);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {clientes.Count} cliente(s)");
        }

        public override ConfigurarToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfigurarToolBoxCliente();
        }

        public override UserControl ObtemListagem()
        {

            if (tabelaClientes == null)
                tabelaClientes = new TabelaClientesControl();

            CarregarClientes();

            return tabelaClientes;
        }

        
    }
}
