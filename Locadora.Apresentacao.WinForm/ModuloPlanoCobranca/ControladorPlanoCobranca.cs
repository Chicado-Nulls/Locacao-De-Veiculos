using Locadora.Aplicacao.ModuloGrupoDeVeiculos;
using Locadora.Aplicacao.ModuloPlanoCobranca;
using Locadora.Apresentacao.WinForm.Compartilhado;
using Locadora.Dominio.ModuloPlanoCobranca;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Locadora.Apresentacao.WinForm.ModuloPlanoCobranca
{
    public class ControladorPlanoCobranca : ControladorBase
    {
        private readonly IRepositorioPlanoCobranca repositorio;
        private ServicePlanoCobranca servicePlanoCobranca;
        private ServiceGrupoVeiculo serviceGrupoVeiculo;
        private TabelaPlanoCobrancaControl tabelaPlanoCobranca;

        public ControladorPlanoCobranca(IRepositorioPlanoCobranca repositorioPlanoCobranca, ServicePlanoCobranca servicePlanoCobranca, ServiceGrupoVeiculo serviceGrupoVeiculo)
        {
            this.servicePlanoCobranca = servicePlanoCobranca;
            this.repositorio = repositorioPlanoCobranca;
            this.serviceGrupoVeiculo = serviceGrupoVeiculo;
        }

        public override void Inserir()
        {
            TelaCadastroPlanoCobranca telaCadastro = new TelaCadastroPlanoCobranca("Inserir Plano de Cobrança", "Inserir");

            telaCadastro.GrupoVeiculos = serviceGrupoVeiculo.SelecionarTodos();

            telaCadastro.PlanoCobranca = new PlanoCobranca();

            telaCadastro.GravarRegistro = servicePlanoCobranca.Inserir;

            DialogResult resultado = telaCadastro.ShowDialog();

            if (resultado == DialogResult.OK)
                CarregarPlanoCobranca();
        }

        public override void Editar()
        {
            var numero = tabelaPlanoCobranca.ObtemIdPlanoCobrancaSelecionado();

            var planoCobrancaSelecionado = repositorio.SelecionarPorId(numero);

            if (planoCobrancaSelecionado == null)
            {
                MessageBox.Show("Selecione um Plano de Cobranca primeiro",
                "Edição de Planos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroPlanoCobranca tela = new TelaCadastroPlanoCobranca("Editar Plano", "Editar");

            tela.GrupoVeiculos = serviceGrupoVeiculo.SelecionarTodos();

            tela.PlanoCobranca = planoCobrancaSelecionado.Clone();

            tela.GravarRegistro = servicePlanoCobranca.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarPlanoCobranca();
            }

        }

        public override void Excluir()
        {
            var numero = tabelaPlanoCobranca.ObtemIdPlanoCobrancaSelecionado();

            PlanoCobranca planoCobrancaSelecionado = servicePlanoCobranca.SelecionarPorId(numero);

            if (planoCobrancaSelecionado == null)
            {
                MessageBox.Show("Selecione um Plano primeiro",
                "Exclusão de Plano(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show($"Deseja realmente excluir o plano '{planoCobrancaSelecionado.GrupoVeiculo}'?",
               "Exclusão de Plano(s)", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorio.Excluir(planoCobrancaSelecionado);
                CarregarPlanoCobranca();
            }
        }

        private void CarregarPlanoCobranca()
        {
            List<PlanoCobranca> planoCobranca = repositorio.SelecionarTodos();

            tabelaPlanoCobranca.AtualizarRegistros(planoCobranca);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {planoCobranca.Count} Planos De Cobrança(s)");
        }

        public override ConfigurarToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfigurarToolBoxPlanoCobranca();
        }

        public override UserControl ObtemListagem()
        {

            if (tabelaPlanoCobranca == null)
                tabelaPlanoCobranca = new TabelaPlanoCobrancaControl();

            CarregarPlanoCobranca();

            return tabelaPlanoCobranca;
        }
    }
}
