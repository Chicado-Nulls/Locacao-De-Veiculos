using Locadora.Aplicacao.ModuloGrupoDeVeiculos;
using Locadora.Apresentacao.WinForm.Compartilhado;
using Locadora.Dominio.ModuloGrupoDeVeiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Locadora.Apresentacao.WinForm.ModuloGrupoDeVeiculos
{
    public class ControladorGrupoVeiculo : ControladorBase
    {
        IRepositorioGrupoVeiculo repositorio;
        ServiceGrupoVeiculo serviceGrupoDeVeiculos;
        TabelaGrupoVeiculoControl tabela;

        public ControladorGrupoVeiculo(IRepositorioGrupoVeiculo repositorio, ServiceGrupoVeiculo serviceGrupoDeVeiculos)
        {
            this.repositorio=repositorio;
            this.serviceGrupoDeVeiculos=serviceGrupoDeVeiculos;
        }

        public override void Editar()
        {
            GrupoVeiculo grupo = SelecionarGrupoPorNumero();

            if (grupo == null)
            {
                MessageBox.Show("Selecione um Grupo de veiculo primeiro",
                "Edição de Grupo de Veiculos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TelaCadastroGrupoDeVeiculos telaGrupo = new TelaCadastroGrupoDeVeiculos("Editar Grupo de Veículo", "Editar");

            telaGrupo.GrupoDeVeiculo = grupo;

            telaGrupo.GravarRegistro = serviceGrupoDeVeiculos.Editar;

            DialogResult dialogResult = telaGrupo.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                CarregarGrupoDeVeiculos();
            }
        }

        public override void Excluir()
        {
            GrupoVeiculo grupo = SelecionarGrupoPorNumero();

            if (grupo == null)
            {
                MessageBox.Show("Selecione um Grupo de veiculo primeiro",
                "Exclusão de Grupo de Veiculos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show($"Deseja realmente excluir o Grupo de Veiculo '{grupo.Nome}'?",
             "Exclusão de Grupo de Veiculos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            serviceGrupoDeVeiculos.Excluir(grupo);
            CarregarGrupoDeVeiculos();
        }

        public override void Inserir()
        {
            TelaCadastroGrupoDeVeiculos telaCadastro = new TelaCadastroGrupoDeVeiculos("Inserir Grupo de Veículo", "Inserir");

            telaCadastro.GrupoDeVeiculo = new GrupoVeiculo();

            telaCadastro.GravarRegistro = serviceGrupoDeVeiculos.Inserir;

            DialogResult resultado = telaCadastro.ShowDialog();

            if (resultado == DialogResult.OK)
                CarregarGrupoDeVeiculos();
        }

        private void CarregarGrupoDeVeiculos()
        {
            List<GrupoVeiculo> grupos = repositorio.SelecionarTodos();

            tabela.AtualizarRegistros(grupos);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {grupos.Count} Grupo de Veiculos(s)");

        }

        public override ConfigurarToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfigurarToolboxGrupoVeiculo();
        }

        public override UserControl ObtemListagem()
        {
            if (tabela == null)
                tabela= new TabelaGrupoVeiculoControl();

            CarregarGrupoDeVeiculos();

            return tabela;
        }

        private GrupoVeiculo SelecionarGrupoPorNumero()
        {
            var numero = tabela.ObtemNumeroRegistroSelecionado();

            GrupoVeiculo grupo = repositorio.SelecionarPorId(numero);

            return grupo;

        }
    }
}
