using Locadora.Aplicacao.ModuloCondutor;
using Locadora.Apresentacao.WinForm.Compartilhado;
using Locadora.Dominio.ModuloCliente;
using Locadora.Dominio.ModuloCondutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Apresentacao.WinForm.ModuloCondutor
{
    public class ControladorCondutor : ControladorBase
    {
        private readonly IRepositorioCondutor repositorioCondutor;
        private ServiceCondutor serviceCondutor;

        private readonly IRepositorioCliente _repositorioCliente;

        private TabelaCondutorControl tabelaCondutor;

        public ControladorCondutor(IRepositorioCondutor repositorioCondutor, ServiceCondutor serviceCondutor, IRepositorioCliente repositorioCliente)
        {
            this.repositorioCondutor=repositorioCondutor;
            this.serviceCondutor=serviceCondutor;
            this._repositorioCliente = repositorioCliente;
        }

        public override void Editar()
        {
            var numero = tabelaCondutor.ObtemIdCondutorSelecionado();

            var clienteSelecionado = repositorioCondutor.SelecionarPorId(numero);

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um condutor primeiro",
                "Edição de Condutor(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroCondutorForm tela = new TelaCadastroCondutorForm("Editar Condutor", "Editar");

            tela.Clientes = _repositorioCliente.SelecionarTodos();
            
            tela.Condutor = clienteSelecionado.Clone();

            tela.GravarRegistro = serviceCondutor.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarCondutores();
            }
        }

        public override void Excluir()
        {
            var numero = tabelaCondutor.ObtemIdCondutorSelecionado();

            Condutor condutorSelecionado = serviceCondutor.SelecionarPorId(numero);

            if (condutorSelecionado == null)
            {
                MessageBox.Show("Selecione um condutor primeiro",
                "Exclusão de Condutor(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Deseja realmente excluir o condutor '{condutorSelecionado.Nome}'?",
               "Exclusão de Condutor(s)", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.OK)
                return;

            var resultado = serviceCondutor.Excluir(condutorSelecionado);

            if (!resultado.IsValid)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(resultado.Errors[0].ErrorMessage);
                return;
            }

            CarregarCondutores();
            
        }

        public override void Inserir()
        {
            TelaCadastroCondutorForm tela = new TelaCadastroCondutorForm("Inserir Condutor", "Inserir");

            tela.Clientes = _repositorioCliente.SelecionarTodos();

            if (tela.Clientes == null)
            {
                MessageBox.Show("Nenhum cliente cadastrado. O cadastro de condutor necessita de um cliente cadastrado!",
                "Inserir Condutor(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tela.Condutor = new Condutor();

            tela.GravarRegistro = serviceCondutor.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
                CarregarCondutores();

        }

        public override ConfigurarToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfigurarToolboxCondutor();
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaCondutor == null)
                tabelaCondutor = new TabelaCondutorControl();

            CarregarCondutores();

            return tabelaCondutor;
        }

        private void CarregarCondutores()
        {
            List<Condutor> condutores = repositorioCondutor.SelecionarTodos();

            tabelaCondutor.AtualizarRegistros(condutores);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {condutores.Count} condutor(s)");
        }
        private Condutor ObtemCondutoreSelecionado()
        {
            var id = tabelaCondutor.ObtemIdCondutorSelecionado();

            return repositorioCondutor.SelecionarPorId(id);
        }
    }
}
