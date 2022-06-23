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
            Cliente clienteSelecionado = ObtemClienteSelecionado();

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente primeiro",
                "Edição de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroCliente tela = new TelaCadastroCliente();

            tela.Cliente = clienteSelecionado;

            tela.GravarRegistro = repositorioCliente.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarClientes();
            }

        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            TelaCadastroCliente tela = new TelaCadastroCliente();
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
        }

        public override ConfigurarToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfigurarToolBoxCliente();
        }

        public override UserControl ObtemListagem()
        {

            tabelaClientes = new TabelaClientesControl();

            CarregarClientes();

            return tabelaClientes;
        }

        
    }
}
