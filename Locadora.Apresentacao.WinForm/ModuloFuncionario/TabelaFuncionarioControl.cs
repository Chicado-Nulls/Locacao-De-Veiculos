using Locadora.Apresentacao.WinForm.Compartilhado;
using Locadora.Dominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Locadora.Apresentacao.WinForm.ModuloFuncionario
{
    public partial class TabelaFuncionarioControl : UserControl
    {
        public TabelaFuncionarioControl()
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
            };
            
            return colunas;
        }

        internal int ObtemNumeroMateriaSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Funcionario> funcionarios)
        {
            grid.Rows.Clear();

            foreach (var materia in funcionarios)
            {
                //exemplo
                //grid.Rows.Add(materia.Numero, materia.Nome, materia.Disciplina.Nome, materia.Serie.GetDescription());
            }
        }
    }
}
