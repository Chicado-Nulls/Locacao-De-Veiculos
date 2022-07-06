using Locadora.Apresentacao.WinForm.Compartilhado;
using Locadora.Dominio.ModuloPlanoCobranca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Apresentacao.WinForm.ModuloPlanoCobranca
{
    public partial class TabelaPlanoCobrancaControl : UserControl
    {
        public TabelaPlanoCobrancaControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "GRUPO_VEICULO_ID", HeaderText = "Id Grupo De Veiculo"},
                new DataGridViewTextBoxColumn { DataPropertyName = "DIARIO_VALOR_DIARIO", HeaderText = "Valor Diario (Diário)"},
                new DataGridViewTextBoxColumn { DataPropertyName = "DIARIO_VALOR_POR_KM", HeaderText = "Valor Por Km (Diário)"},
                new DataGridViewTextBoxColumn { DataPropertyName = "LIVRE_VALOR_DIARIO", HeaderText = "Valor Diário (Livre)"},
                new DataGridViewTextBoxColumn { DataPropertyName = "CONTROLADO_VALOR_DIARIO", HeaderText = "Valor Diário (Controlado)"},
                new DataGridViewTextBoxColumn { DataPropertyName = "CONTROLADO_VALOR_POR_KM", HeaderText = "Valor Por Km (Controlado)"},
                new DataGridViewTextBoxColumn { DataPropertyName = "CONTROLADO_LIMITE_DE_KM", HeaderText = "Limite De Km (Controlado)"},


           };

            return colunas;
        }

        internal void AtualizarRegistros(List<PlanoCobranca> planoCobrancas)
        {
            grid.Rows.Clear();

            foreach (PlanoCobranca planoCobranca in planoCobrancas)
            {
                grid.Rows.Add(planoCobranca.Id, planoCobranca.GrupoVeiculo, planoCobranca.DiarioValorDiario, planoCobranca.DiarioValorPorKm, planoCobranca.LivreValorDiario, planoCobranca.ControladoValorDiario, planoCobranca.ControladoValorPorKm, planoCobranca.ControladoLimiteDeKm);
            }
        }
        internal int ObtemIdPlanoCobrancaSelecionado()
        {
            return grid.SelecionarId<int>();
        }
    }
}
