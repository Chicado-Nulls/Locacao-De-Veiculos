using FluentValidation.Results;
using Locadora.Dominio.ModuloGrupoDeVeiculo;
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
        GrupoVeiculo _grupoDeVeiculos;

        public TelaCadastroGrupoDeVeiculos(string titulo, string label)
        {
            InitializeComponent();
            Text = titulo;
            gravarBtn.Text = label;
        }

        public GrupoVeiculo GrupoDeVeiculo 
        {
            get { return _grupoDeVeiculos; }
            set 
            {
              _grupoDeVeiculos = value;
                ConfigurarTela();
            }

        }
        public Func<GrupoVeiculo, ValidationResult> GravarRegistro { get; set; }
        private void ConfigurarTela()
        {
            txtBoxId.Text = _grupoDeVeiculos.Id != default ? _grupoDeVeiculos.Id.ToString() : "0";
            TextNomeDoGrupo.Text = string.IsNullOrEmpty(_grupoDeVeiculos.Nome)? "" : _grupoDeVeiculos.Nome;

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
            _grupoDeVeiculos.Id = Guid.Parse(txtBoxId.Text.ToString());
            _grupoDeVeiculos.Nome = TextNomeDoGrupo.Text;
        }
    }
}
