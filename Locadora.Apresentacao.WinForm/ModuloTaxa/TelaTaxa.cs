using FluentValidation.Results;
using Locadora.Dominio.ModuloTaxa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Apresentacao.WinForm.ModuloTaxa
{
    public partial class TelaTaxa : Form
    {
        private Taxa _taxa;
        
        public TelaTaxa(string titulo, string label)
        {
            InitializeComponent();
            Text = titulo;
            btnGravar.Text = label;
        }
        public Taxa Taxa
        {
            get
            {
                return _taxa;
            }
            set
            {
                _taxa = value;
                ConfigurarTela();
            }
        }
        public Func<Taxa, ValidationResult> GravarRegistro { get; set; }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ExisteCampoVazio())
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Preencha todos os campos");

                DialogResult = DialogResult.None;

                return;
            }
            ConfigurarObjeto();

            var resultadoValidacao = GravarRegistro(Taxa);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;


                TelaPrincipalForm.Instancia.AtualizarRodape(erro);


                DialogResult = DialogResult.None;
            }
        }

        private bool ExisteCampoVazio()
        {
            if(string.IsNullOrEmpty(txtBoxDescricao.Text) || string.IsNullOrEmpty(txtBoxValor.Text))
                return true;
            
            return false;
        }

        private void ConfigurarObjeto()
        {
            Taxa.Descricao=txtBoxDescricao.Text;
            Taxa.Valor = Convert.ToDecimal(txtBoxValor.Text);

            ConfigurarTipoCalculoObjeto();
        }
        private void ConfigurarTipoCalculoObjeto()
        {
            if (checkFixo.Checked)
            {
                Taxa.TipoDeCalculo = TipoDeCalculo.CalculoFixo;
                return;
            }

            Taxa.TipoDeCalculo=TipoDeCalculo.CalculoDiario;                             
        }        

        private void ConfigurarTela()
        {
            txtBoxId.Text = Taxa.Id == default ? "0" : Taxa.Id.ToString(); 
            txtBoxDescricao.Text = Taxa.Descricao == null ? "" : Taxa.Descricao; 
            txtBoxValor.Text = Taxa.Valor == default ? "" : string.Format("{0:#,##0.00}", Double.Parse(Taxa.Valor.ToString()));
            ConfigurarTipoCalculoTela();
        }
        private void ConfigurarTipoCalculoTela()
        {
            if (Taxa.TipoDeCalculo == TipoDeCalculo.CalculoFixo)
            {
                checkFixo.Checked= true;
                return;
            }

            checkDiario.Checked = true;
        }

        private void txtBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox box = (TextBox)sender;

                string texto = Regex.Replace(box.Text, "[^0-9]", string.Empty);

                if (texto == string.Empty) texto = "00";

                if (e.KeyChar.Equals((char)Keys.Back))
                    texto = texto.Substring(0, texto.Length -1);
                else
                    texto += e.KeyChar;

                box.Text = string.Format("{0:#,##0.00}", Double.Parse(texto)/100);

                box.Select(box.Text.Length, 0);
            }
            e.Handled = true;
        }
    }
}
