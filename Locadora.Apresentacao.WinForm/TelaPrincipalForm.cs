using Locadora.Apresentacao.WinForm.Compartilhado;
using Locadora.Apresentacao.WinForm.ModuloTaxa;
using Locadora.Dominio.ModuloTaxa;
using Locadora.Infra.BancoDados.ModuloTaxa;
using Locadora.Apresentacao.WinForm.ModuloFuncionario;
using Locadora.Dominio.ModuloFuncionario;
using Locadora.Infra.BancoDados.ModuloFuncionario;
using System;
using System.Collections.Generic;

using System.Windows.Forms;
using Locadora.Apresentacao.WinForm.ModuloGrupoDeVeiculos;
using Locadora.Dominio.ModuloCliente;
using Locadora.Apresentacao.WinForm.ModuloCliente;
using Locadora.Infra.BancoDados.ModuloCliente;
using Locadora.Aplicacao.ModuloCliente;
using Locadora.Aplicacao.ModuloFuncionario;
using Locadora.Aplicacao.ModuloTaxa;
using Locadora.Aplicacao.ModuloGrupoDeVeiculos;
using Locadora.Dominio.ModuloGrupoDeVeiculo;
using Locadora.Infra.BancoDados.ModuloGrupoVeiculo;

namespace Locadora.Apresentacao.WinForm
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        
        public TelaPrincipalForm()
        {
            InitializeComponent();

            Instancia = this;

            labelRodape.Text = string.Empty;
            labelTipoCadastro.Text = string.Empty;
            InicializarControladores();
        }

        public static TelaPrincipalForm Instancia
        {
            get;
            private set;
        }

        public void AtualizarRodape(string mensagem)
        {
            statusStripMensagem.Items.Clear();
            statusStripMensagem.Items.Add(mensagem);
        }

        private void ConfigurarBotoes(ConfigurarToolboxBase configuracao)
        {
            btnInserir.Enabled = configuracao.InserirHabilitado;
            btnEditar.Enabled = configuracao.EditarHabilitado;
            btnExcluir.Enabled = configuracao.ExcluirHabilitado;
            btnFiltrar.Enabled = configuracao.FiltrarHabilitado;
            btnGerarPdf.Enabled = configuracao.GerarPdfHabilitado;
            btnVisualizar.Enabled = configuracao.VisualizarHabilitado;
        }

        private void ConfigurarTooltips(ConfigurarToolboxBase configuracao)
        {
            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;
            btnFiltrar.ToolTipText = configuracao.TooltipFiltrar;
            btnGerarPdf.ToolTipText = configuracao.TooltipGerarPdf;
            btnVisualizar.ToolTipText = configuracao.TooltipVisualizar;
        }

        private void ConfigurarToolbox()
        {
            ConfigurarToolboxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                toolbox.Enabled = true;

                labelTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            panelRegistros.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(listagemControl);
        }

        private void ConfigurarTelaPrincipal(ToolStripMenuItem opcaoSelecionada)
        {
            var tipo = removerAcentos(opcaoSelecionada.Text);

            controlador = controladores[tipo];

            ConfigurarToolbox();

            ConfigurarListagem();
        }

        private void InicializarControladores()
        {
            controladores = new Dictionary<string, ControladorBase>();

            IRepositorioCliente repositorioCliente = new RepositorioClienteEmBancoDeDados();
            ServiceCliente serviceCliente = new ServiceCliente(repositorioCliente);
            controladores.Add("Cliente", new ControladorCliente(repositorioCliente, serviceCliente));

            IRepositorioFuncionario repositorioFuncionario = new RepositorioFuncionarioBancoDados();
            ServiceFuncionario serviceFuncionario = new ServiceFuncionario(repositorioFuncionario);
            controladores.Add("Funcionario", new ControladorFuncionario(repositorioFuncionario, serviceFuncionario));

            IRepositorioTaxa repositorioTaxa = new RepositorioTaxa();
            ServiceTaxa serviceTaxa = new ServiceTaxa(repositorioTaxa);
            controladores.Add("Taxa", new ControladorTaxa(repositorioTaxa, serviceTaxa));

            IRepositorioGrupoVeiculo repositorioGrupoDeVeiculos = new RepositorioGrupoVeiculo();
            ServiceGrupoVeiculo serviceGrupoDeVeiculos = new ServiceGrupoVeiculo(repositorioGrupoDeVeiculos);
            controladores.Add("Grupo Veiculos", new ControladorGrupoVeiculo(repositorioGrupoDeVeiculos, serviceGrupoDeVeiculos));
            

        }

        private void taxaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void grupoVeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }
        private void planoDeCobrançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }
        public static string removerAcentos(string texto)
        {
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }
            return texto;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void condutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
