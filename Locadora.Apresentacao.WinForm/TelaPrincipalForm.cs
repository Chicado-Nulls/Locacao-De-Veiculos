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
using Locadora.Dominio.ModuloGrupoDeVeiculos;
using Locadora.Infra.BancoDados.ModuloGrupoDeVeiculo;
using Locadora.Apresentacao.WinForm.ModuloGrupoDeVeiculos;

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

            labelRodape.Text = "Teste";
            
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
            AtualizarRodape("-");

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
            //EXEMPLO ABAIXO

            //IRepositorioDisciplina repositorioDisciplina = new RepositorioDisciplinaEmBancoDados();

            //controladores = new Dictionary<string, ControladorBase>();

            //controladores.Add("Disciplinas", new ControladorDisciplina(repositorioDisciplina));


            IRepositorioFuncionario repositorioFuncionario = new RepositorioFuncionarioBancoDados();
            
            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("Funcionario", new ControladorFuncionario(repositorioFuncionario));


            IRepositorioTaxa repositorioTaxa = new RepositorioTaxa();

            controladores.Add("Taxa", new ControladorTaxa(repositorioTaxa));

            IrepositorioGrupoDeVeiculos repositorioGrupoDeVeiculos = new RepositorioGrupoDeVeiculo();

            controladores.Add("Grupo Veiculos", new ControladorGrupoDeVeiculos(repositorioGrupoDeVeiculos));
            

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
    }
}
