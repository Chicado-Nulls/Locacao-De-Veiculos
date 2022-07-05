using Locadora.Aplicacao.ModuloGrupoDeVeiculos;
using Locadora.Aplicacao.ModuloVeiculo;
using Locadora.Apresentacao.WinForm.Compartilhado;
using Locadora.Dominio.ModuloCarro;
using Locadora.Dominio.ModuloGrupoDeVeiculo;
using Locadora.Dominio.ModuloVeiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Apresentacao.WinForm.ModuloVeiculo
{
    public class ControladorVeiculo : ControladorBase
    {
        IrepositorioVeiculo RepositorioVeiculo;
        ServiceGrupoVeiculo serviceGrupoVeiculo;
        ServiceVeiculo serviceVeiculo;
        TabelaVeiculoControl tabelaVeiculo;
        List<GrupoVeiculo> grupoVeiculos; 

        public ControladorVeiculo(IrepositorioVeiculo repositorioVeiculo, ServiceGrupoVeiculo serviceGrupoVeiculo, ServiceVeiculo serviceVeiculo)
        {
            this.RepositorioVeiculo = repositorioVeiculo;
            this.serviceGrupoVeiculo = serviceGrupoVeiculo;
            this.serviceVeiculo = serviceVeiculo;
        }

        public override void Editar()
        {
            Veiculo veiculo = SelecionarVeiculoPorNumero();

            if (veiculo == null)
            {
                MessageBox.Show("Selecione um veiculo primeiro",
                "Edição de veiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TelaVeiculo telaVeiculo = new TelaVeiculo(serviceGrupoVeiculo.SelecionarTodos(), "Editar Veículo", "Editar");

            telaVeiculo.Veiculo = veiculo;
            telaVeiculo.GravarRegistro = serviceVeiculo.Editar;

            DialogResult dialogResult = telaVeiculo.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                CarregarVeiculos();
            }
        }

        public override void Excluir()
        {
            Veiculo veiculo =SelecionarVeiculoPorNumero();

            if (veiculo == null)
            {
                MessageBox.Show("Selecione um veiculo primeiro",
                "Exclusão de veiculo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show($"Deseja realmente excluir o veiculo selecionado '{veiculo.Modelo}'?", "Exclusão de veiculo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;

            serviceVeiculo.Excluir(veiculo);

            CarregarVeiculos();

        }

        public override void Inserir()
        {
            if (serviceGrupoVeiculo.SelecionarTodos().Count == 0)
            {
                MessageBox.Show("Crie um grupo de Veiculo primeiro",
              "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            TelaVeiculo telaVeiculo= new TelaVeiculo(serviceGrupoVeiculo.SelecionarTodos(), "Inserir Veículo", "Inserir");

            telaVeiculo.Veiculo = new Veiculo();

            telaVeiculo.GravarRegistro = serviceVeiculo.Inserir;

            DialogResult resultado = telaVeiculo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarVeiculos();
            }


        }

        private void CarregarVeiculos()
        {
            List<Veiculo> veiculos = serviceVeiculo.SelecionarTodos();

            tabelaVeiculo.AtualizarRegistros(veiculos);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {veiculos.Count} Veiculos");
        }

        public override ConfigurarToolboxBase ObtemConfiguracaoToolbox()
        {
           return new ConfigurarToolBoxVeiculo();
        }

        public override UserControl ObtemListagem()
        {

            if (tabelaVeiculo == null)
                tabelaVeiculo = new TabelaVeiculoControl();

            CarregarVeiculos();

            return tabelaVeiculo;
        }
       

        private Veiculo SelecionarVeiculoPorNumero()
        {
            var numero = tabelaVeiculo.ObtemNumeroVeiculoSelecionado();

            var veiculo = serviceVeiculo.SelecionarPorId(numero);

            return veiculo;

        }
       
    }
}
