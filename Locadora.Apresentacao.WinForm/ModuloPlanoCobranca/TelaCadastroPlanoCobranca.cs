using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Locadora.Dominio.ModuloPlanoCobranca;
using Locadora.Dominio.ModuloGrupoDeVeiculo;
using FluentValidation.Results;

namespace Locadora.Apresentacao.WinForm.ModuloPlanoCobranca
{
    public partial class TelaCadastroPlanoCobranca : Form
    {
        public TelaCadastroPlanoCobranca(string titulo, string label)
        {
            InitializeComponent();
            Text = titulo;
            btnInserir.Text = label;
        }

        private PlanoCobranca _planoCobranca;
        public List<GrupoVeiculo> _grupoVeiculos; 
        public List<GrupoVeiculo> GrupoVeiculos 
        { 
            get { return _grupoVeiculos; }
            set
            {
                _grupoVeiculos = value;
                PreencherCBoxGrupoVeiculo();
            } 
        }

        private void PreencherCBoxGrupoVeiculo()
        {
            comboBoxGrupoVeiculo.Items.Clear();

            comboBoxGrupoVeiculo.Items.Add("Selecionar Grupo Veículo");

            foreach (var item in _grupoVeiculos)
                comboBoxGrupoVeiculo.Items.Add(item);

            comboBoxGrupoVeiculo.SelectedIndex = 0;
        }

        public Func<PlanoCobranca, ValidationResult> GravarRegistro { get; set; }

        public PlanoCobranca PlanoCobranca
        {
            get { return _planoCobranca; }
            set
            {
                _planoCobranca = value;
                ConfigurarTela();
            }
        }
        private void ConfigurarTela()
        {
            txtBoxControladoDiaria.Text = _planoCobranca.ControladoDiaria == default ? "" : _planoCobranca.ControladoDiaria.ToString();
            txtBoxControladoPorKm.Text = _planoCobranca.ControladoPorKm == default ? "" : _planoCobranca.ControladoPorKm.ToString();
            txtBoxControladoLimteKm.Text = _planoCobranca.ControladoLimiteKm == default ? "" : _planoCobranca.ControladoLimiteKm.ToString();
            txtBoxDiarioDiaria.Text = _planoCobranca.DiarioDiaria == default ? "" : _planoCobranca.DiarioDiaria.ToString();
            txtBoxDiarioPorKm.Text = _planoCobranca.DiarioPorKm == default ? "" : _planoCobranca.DiarioPorKm.ToString();
            txtBoxLivreDiaria.Text = _planoCobranca.LivreDiaria == default ? "" : _planoCobranca.LivreDiaria.ToString();
            comboBoxGrupoVeiculo.SelectedItem = _planoCobranca.GrupoVeiculo == null ? comboBoxGrupoVeiculo.SelectedItem : _planoCobranca.GrupoVeiculo;
        }

        private void txtBoxControladoDiaria_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBoxControladoPorKm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBoxControladoLimteKm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBoxDiarioDiaria_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBoxDiarioPorKm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBoxLivreDiaria_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
