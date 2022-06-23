using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora.Dominio.ModuloCliente;
using FluentValidation.Results;

namespace Locadora.Apresentacao.WinForm.ModuloCliente
{
    public partial class TelaCadastroCliente : Form
    {
        public TelaCadastroCliente()
        {
            InitializeComponent();
        }
        private Cliente cliente;

        public Func<Cliente, ValidationResult> GravarRegistro { get; set; }

        public Cliente Cliente
        {
            get { return cliente; }
            set
            {
                cliente = value;

                textNome.Text = cliente.Nome;
                textCPF.Text = cliente.Cpf;
                textCNPJ.Text = cliente.Cnpj;
                textEndereco.Text = cliente.Endereco;
                textCNH.Text = cliente.Cnh;
                textEmail.Text = cliente.Email;
                textTelefone.Text = cliente.Telefone;
                

            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente.Nome = textNome.Text;
            textCPF.Text = cliente.Cpf;
            textCNPJ.Text = cliente.Cnpj;
            textEndereco.Text = cliente.Endereco;
            textCNH.Text = cliente.Cnh;
            textEmail.Text = cliente.Email;
            textTelefone.Text = cliente.Telefone;
            
            var resultadoValidacao = GravarRegistro(cliente);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }

        }


        private void TelaCadastroCliente_Load(object sender, EventArgs e)
        {
                TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void labelCpf_Click(object sender, EventArgs e)
        {

        }
    }
}
