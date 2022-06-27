using FluentValidation.Results;
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
    public partial class TelaCadastroGrupoDeVeiculos : Form
    {
        GrupoDeVeiculo _grupoDeVeiculos;

        public TelaCadastroGrupoDeVeiculos()
        {
            InitializeComponent();
        }

        public GrupoDeVeiculo GrupoDeVeiculo 
        {
            get { return _grupoDeVeiculos; }
            set 
            {
              _grupoDeVeiculos = value;
                ConfigurarTela();
            }

        }
        public Func<GrupoDeVeiculo, ValidationResult> GravarRegistro { get; set; }
        private void ConfigurarTela()
        {
            txtBoxId.Text = _grupoDeVeiculos.Id != null ? _grupoDeVeiculos.Id.ToString() : "0";
            TextNomeDoGrupo.Text = _grupoDeVeiculos.Nome != null ? _grupoDeVeiculos.Nome : "";

        }

        private void gravarBtn_Click(object sender, EventArgs e)
        {
            ConfigurarObjeto();
            var resultadoValidacao = GravarRegistro(GrupoDeVeiculo);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void ConfigurarObjeto()
        {
            _grupoDeVeiculos.Id = Convert.ToInt32(txtBoxId.Text);
            _grupoDeVeiculos.Nome = TextNomeDoGrupo.Text;
        }
    }
}
