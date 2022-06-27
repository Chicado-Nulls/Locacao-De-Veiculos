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
        public TelaCadastroCliente(string v)
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
                ConfigurarTela();

                if(cliente.Id != 0)
                {
                    if(cliente.TipoCadastro == true)
                    {
                        radioPessoaFisica.Checked = true;
                    }
                    else if(cliente.TipoCadastro == false)
                    {
                        radioPessoaJuridica.Checked = true;
                    }
                }

            }
        }

        private void ConfigurarTela()
        {
            textNome.Text = cliente.Nome;
            textCPF.Text = cliente.Cpf;
            textCNPJ.Text = cliente.Cnpj;
            textCNH.Text = cliente.Cnh;
            textEndereco.Text = cliente.Endereco;
            textEmail.Text = cliente.Email;
            textTelefone.Text = cliente.Telefone;
        }


        private void TelaCadastroCliente_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void labelCpf_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            ConfigurarObjeto();
            var resultadoValidacao = GravarRegistro(cliente);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;

            }
        }

        private void ConfigurarObjeto()
        {
            //cliente.Id = textId.Text != "0" ? Convert.ToInt32(textId.Text) : 0;
            cliente.Nome = textNome.Text;
            cliente.Cpf = textCPF.Text;
            cliente.Cnpj = textCNPJ.Text;
            cliente.Cnh = textCNH.Text;
            cliente.Endereco = textEndereco.Text;
            cliente.Email = textEmail.Text;
            cliente.Telefone = textTelefone.Text;
            cliente.TipoCadastro = GerarTipoCadastro();
        }


        private bool GerarTipoCadastro()
        {
            if (radioPessoaFisica.Checked == true)
            {
                return true;
            }

            if (radioPessoaJuridica.Checked == true)
            {
                return false;
            }

            return true;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textCPF.Enabled = true;
            textCNH.Enabled = true;
            textCNPJ.Enabled = false;

            textCNPJ.Clear();



        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textCPF.Enabled = false;
            textCNH.Enabled = false;
            textCNPJ.Enabled = true;

            textCPF.Clear();
            textCNH.Clear();
        }

    }
}
