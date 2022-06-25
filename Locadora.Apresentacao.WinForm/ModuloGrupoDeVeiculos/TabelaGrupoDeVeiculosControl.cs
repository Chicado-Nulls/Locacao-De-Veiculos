﻿using Locadora.Apresentacao.WinForm.Compartilhado;
using Locadora.Dominio.ModuloGrupoDeVeiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Apresentacao.WinForm.ModuloGrupoDeVeiculos
{
    public partial class TabelaGrupoDeVeiculosControl : UserControl
    {        
        public TabelaGrupoDeVeiculosControl()
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
                new DataGridViewTextBoxColumn { DataPropertyName = "NOME", HeaderText = "Nome", FillWeight=15F }
                
            };

            return colunas;
        }

        internal int ObtemNumeroRegistroSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<GrupoDeVeiculo> grupoDeVeiculos)
        {
            grid.Rows.Clear();

            foreach (var grupoDeVeiculo in grupoDeVeiculos)
            {
                
                grid.Rows.Add(grupoDeVeiculo.Id, grupoDeVeiculo.Nome);
            }
        }
    }
}
