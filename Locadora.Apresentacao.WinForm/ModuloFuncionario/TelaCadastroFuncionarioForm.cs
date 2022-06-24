using FluentValidation.Results;
using Locadora.Dominio.ModuloFuncionario;
using System;
using System.Windows.Forms;

namespace Locadora.Apresentacao.WinForm.ModuloFuncionario
{
    public partial class TelaCadastroFuncionarioForm : Form
    {
        Funcionario _funcionario;
        public TelaCadastroFuncionarioForm(string titulo)
        {
            InitializeComponent();
            Text = titulo;
        }

        public Funcionario Funcionario
        {
            get { return _funcionario; }
            set
            {
                _funcionario = value;
                ConfigurarTela();
            }
        }

        public Func<Funcionario, ValidationResult> GravarRegistro { get; set; }

        private void ConfigurarTela()
        {
            txtBoxID.Text = _funcionario.Id != default ? Convert.ToString(_funcionario.Id) : "0";
            
            txtBoxNome.Text = _funcionario.Nome != null ? _funcionario.Nome : "";
            
            txtBoxLogin.Text = _funcionario.Login != null ? _funcionario.Login : "";
            
            txtBoxSenha.Text = _funcionario.Senha != null ? _funcionario.Senha : "";
            
            txtBoxDataCadastro.Text = _funcionario.DataEntrada != default ? Convert.ToString(_funcionario.DataEntrada) : "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ConfigurarObjeto();

            var resultadoValidacao = GravarRegistro(Funcionario);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void ConfigurarObjeto()
        {
            Funcionario.Id = txtBoxID.Text != "0" ? Convert.ToInt32(txtBoxID.Text) : 0;
            Funcionario.Nome = txtBoxNome.Text;
            Funcionario.Login = txtBoxLogin.Text;
            Funcionario.Senha = txtBoxSenha.Text;
            Funcionario.DataEntrada = Convert.ToDateTime(txtBoxDataCadastro.Text);
        }
    }
}
