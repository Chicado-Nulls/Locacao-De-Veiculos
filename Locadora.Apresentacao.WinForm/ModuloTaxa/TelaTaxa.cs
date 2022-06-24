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
        private Taxa _taxa;
        TipoDeCalculo tipo = new TipoDeCalculo();
        public TelaTaxa()
        {
            InitializeComponent();
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

            }
        }
        public Func<Taxa, ValidationResult> GravarRegistro { get; set; }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Taxa.Descricao=textDescricao.Text;
            Taxa.Valor = ValorNumerico.Value;

            InserirTipoDeCalculo();

            var resultadoValidacao = GravarRegistro(Taxa);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;
                

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);


                DialogResult = DialogResult.None;
            }
        }

        

        private void InserirTipoDeCalculo()
        {
            if (checkFixo.Checked)
            {
                Taxa.TipoDeCalculo = TipoDeCalculo.CalculoFixo;                
            }
            else if (checkDiario.Checked)
            {
                Taxa.TipoDeCalculo=TipoDeCalculo.CalculoDiario;
            }

            Taxa.TipoDeCalculo = null;
            
            
        }

        
    }
}
