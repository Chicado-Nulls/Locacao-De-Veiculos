using Locadora.Apresentacao.WinForm.Compartilhado;
using Locadora.Dominio.ModuloCarro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Apresentacao.WinForm.ModuloVeiculo
{
    public partial class TabelaVeiculoControl : UserControl
    {
        public TabelaVeiculoControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "Id", FillWeight=15F },
                new DataGridViewTextBoxColumn { DataPropertyName = "Modelo", HeaderText = "Modelo", FillWeight=15F },
                new DataGridViewTextBoxColumn { DataPropertyName = "Placa", HeaderText = "Placa", FillWeight=15F },
                new DataGridViewTextBoxColumn { DataPropertyName = "Km Rodados", HeaderText = "Km Rodados", FillWeight=15F },
                new DataGridViewTextBoxColumn { DataPropertyName = "Tipo De Combustivel", HeaderText = "Tipo De Combustivel", FillWeight=15F }
                
            };

            return colunas;
        }
        internal int ObtemNumeroVeiculoSelecionado()
        {
            return grid.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Veiculo > veiculos)
        {
            grid.Rows.Clear();                 

            foreach (var veiculo in veiculos)
            {
                grid.Rows.Add(veiculo.Id,veiculo.Modelo,veiculo.Placa,veiculo.KmPercorrido,veiculo.TipoDeCombustivel);
                //exemplo
                //grid.Rows.Add(materia.Numero, materia.Nome, materia.Disciplina.Nome, materia.Serie.GetDescription());
            }
        }
    }
}
