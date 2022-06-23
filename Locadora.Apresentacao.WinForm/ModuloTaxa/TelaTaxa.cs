using FluentValidation.Results;
using Locadora.Dominio.ModuloTaxa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Apresentacao.WinForm.ModuloTaxa
{
    public partial class TelaTaxa : Form
    {
        TipoDeCalculo tipo = new TipoDeCalculo();
        public TelaTaxa()
        {
            InitializeComponent();
        }
        public Taxa taxa
        {
            get
            {
                return taxa;
            }
            set
            {
                taxa = value;

            }
        }
        public Func<Taxa, ValidationResult> GravarRegistro { get; set; }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            taxa.Descricao=textDescricao.Text;
            taxa.Valor = ValorNumeric.Value;

            InserirTipoDeCalculo();

            var resultadoValidacao = GravarRegistro(taxa);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;
                DialogResult = DialogResult.None;
            }
        }

        private void InserirTipoDeCalculo()
        {
            if (checkFixo.Checked)
            {
                taxa.TipoDeCalculo = TipoDeCalculo.CalculoFixo;                
            }
            else
            {
                taxa.TipoDeCalculo = TipoDeCalculo.CalculoDiario;
            }
            
        }
    }
}
