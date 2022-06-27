using Locadora.Apresentacao.WinForm.Compartilhado;
using Locadora.Dominio.ModuloTaxa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Apresentacao.WinForm.ModuloTaxa
{
    public class ControladorTaxa : ControladorBase
    {

        IRepositorioTaxa RepositorioTaxa;
        TabelaTaxaControl tabelaTaxa;

        public ControladorTaxa(IRepositorioTaxa repositorioTaxa)
        {
            this.RepositorioTaxa = repositorioTaxa;
        }

        public override void Editar()
        {
            Taxa taxa = SelecionarTaxaPorNumero();

            if (taxa == null)
            {
                MessageBox.Show("Selecione uma taxa primeiro",
                "Edição de taxa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TelaTaxa telaTaxa = new TelaTaxa();

            telaTaxa.Taxa = taxa;
            telaTaxa.GravarRegistro = RepositorioTaxa.Editar;

            DialogResult dialogResult = telaTaxa.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                CarregarTaxas();
            }
        }

        public override void Excluir()
        {
            var taxa =  SelecionarTaxaPorNumero();

            if (taxa == null)
            {
                MessageBox.Show("Selecione uma taxa primeiro",
                "Exclusão de taxa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show($"Deseja realmente excluir a taxa '{taxa.Descricao}'?", "Exclusão de taxa", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;
            
            RepositorioTaxa.Excluir(taxa);

            CarregarTaxas();
        }

        public override void Inserir()
        {
            TelaTaxa telaTaxa=  new TelaTaxa();

            telaTaxa.Taxa= new Taxa();

            telaTaxa.GravarRegistro = RepositorioTaxa.Inserir;

            DialogResult resultado = telaTaxa.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTaxas();
            }
        }

        public override ConfigurarToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfigurarToolBoxTaxa();
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaTaxa == null)
                tabelaTaxa = new TabelaTaxaControl();

            CarregarTaxas();

            return tabelaTaxa;
        }

        private void CarregarTaxas()
        {
            List<Taxa> grupos = RepositorioTaxa.SelecionarTodos();

            tabelaTaxa.AtualizarRegistros(grupos);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {grupos.Count} Taxa(s)");
        }

        private Taxa SelecionarTaxaPorNumero()
        {
            var numero = tabelaTaxa.ObtemNumeroMateriaSelecionado();

            Taxa taxa = RepositorioTaxa.SelecionarPorId(numero);
            
            return taxa;

        }
    }
}
