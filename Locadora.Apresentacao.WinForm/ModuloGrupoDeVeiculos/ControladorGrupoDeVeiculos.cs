using Locadora.Apresentacao.WinForm.Compartilhado;
using Locadora.Dominio.ModuloGrupoDeVeiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Apresentacao.WinForm.ModuloGrupoDeVeiculos
{
    public class ControladorGrupoDeVeiculos : ControladorBase
    {
        IrepositorioGrupoDeVeiculos repositorio;
        TabelaGrupoDeVeiculosControl tabela; 

        public ControladorGrupoDeVeiculos(IrepositorioGrupoDeVeiculos repositorio)
        {
            this.repositorio = repositorio;
        }


        public override void Editar()
        {
            GrupoDeVeiculo grupo = SelecionarGrupoPorNumero();

            if (grupo == null)
            {
                MessageBox.Show("Selecione um Grupo de veiculo primeiro",
                "Edição de Grupo de Veiculos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroGrupoDeVeiculos telaGrupo = new TelaCadastroGrupoDeVeiculos();

            telaGrupo.GrupoDeVeiculo = grupo;

            telaGrupo.GravarRegistro = repositorio.Editar;

            DialogResult dialogResult = telaGrupo.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                CarregarGrupoDeVeiculos();
            }
        }

        public override void Excluir()
        {
            GrupoDeVeiculo grupo = SelecionarGrupoPorNumero();

            if (grupo == null)
            {
                MessageBox.Show("Selecione um Grupo de veiculo primeiro",
                "Exclusão de Grupo de Veiculos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show($"Deseja realmente excluir o Grupo de Veiculo '{grupo.Nome}'?",
             "Exclusão de Grupo de Veiculos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorio.Excluir(grupo);
                CarregarGrupoDeVeiculos();
            }
        }

        public override void Inserir()
        {
            TelaCadastroGrupoDeVeiculos telaCadastro = new TelaCadastroGrupoDeVeiculos();

            telaCadastro.GrupoDeVeiculo = new GrupoDeVeiculo();

            telaCadastro.GravarRegistro = repositorio.Inserir;

            DialogResult resultado = telaCadastro.ShowDialog();

            if (resultado == DialogResult.OK)
                CarregarGrupoDeVeiculos();
        }

        private void CarregarGrupoDeVeiculos()
        {
            List<GrupoDeVeiculo> grupos = repositorio.SelecionarTodos();

            tabela.AtualizarRegistros(grupos);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {grupos.Count} funcionarios(s)");

        }

        public override ConfigurarToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfigurarToolboxGrupoDeVeiculos();
        }

        public override UserControl ObtemListagem()
        {
            if (tabela == null)
                tabela= new TabelaGrupoDeVeiculosControl();

            CarregarGrupoDeVeiculos();

            return tabela;
        }

        private GrupoDeVeiculo SelecionarGrupoPorNumero()
        {
            var numero = tabela.ObtemNumeroRegistroSelecionado();

            GrupoDeVeiculo grupo = repositorio.SelecionarPorId(numero);

            return grupo;

        }
    }
}
