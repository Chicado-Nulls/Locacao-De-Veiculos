using Locadora.Dominio.ModuloCarro;
using Locadora.Dominio.ModuloGrupoDeVeiculo;
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
using FluentValidation.Results;
using Locadora.Dominio.ModuloVeiculo;

namespace Locadora.Apresentacao.WinForm.ModuloVeiculo
{
    public partial class TelaVeiculo : Form
    {
        Veiculo _veiculo;
        List<GrupoVeiculo> GruposVeiculos;
        List<EnumTipoDeCombustivel> tipoDeCombustivel;



        public TelaVeiculo(List<GrupoVeiculo> grupoVeiculos)
        {
            InitializeComponent();

            this.GruposVeiculos = grupoVeiculos;
            this.tipoDeCombustivel=new List<EnumTipoDeCombustivel>();

            EncherComboBoxGrupoVeiculo(GruposVeiculos);
        }

        public Veiculo Veiculo
        {
            get
            {
                return _veiculo;
            }
            set
            {
                _veiculo = value;
                ConfigurarTela();
            }
        }
        public Func<Veiculo, ValidationResult> GravarRegistro { get; set; }

        private void ConfigurarTela()
        {

            textBoxPlaca.Text = Veiculo.Placa == null ? "" : Veiculo.Placa;
            textBoxModelo.Text = Veiculo.Modelo == null ? "" : Veiculo.Modelo;
            textBoxMarca.Text = Veiculo.Marca == null ? "" : Veiculo.Marca;
            textBoxCor.Text = Veiculo.Cor == null ? "" : Veiculo.Cor;


            textBoxKmPercorrido.Text = Veiculo.KmPercorrido == null ? "" : string.Format("{0:#,##0.00}", Double.Parse(Veiculo.KmPercorrido.ToString()));
            TextBoxCapacidadeTanque.Text = Veiculo.CapacidadeTanque == null ? "" : string.Format("{0:#,##0.00}", Double.Parse(Veiculo.KmPercorrido.ToString()));

            
           

        }
        private void ConfigurarObjeto()
        {
            _veiculo.Cor=textBoxCor.Text;
            _veiculo.Placa=textBoxPlaca.Text;
            _veiculo.Modelo=textBoxModelo.Text;
            _veiculo.Marca=textBoxMarca.Text;   
            _veiculo.GrupoDeVeiculo = (GrupoVeiculo)comboBoxGrupoVeiculo.SelectedItem;
            _veiculo.TipoDeCombustivel=  (EnumTipoDeCombustivel)Enum.Parse(typeof(EnumTipoDeCombustivel), SelecionarEnum());
            _veiculo.CapacidadeTanque=Convert.ToDecimal(TextBoxCapacidadeTanque.Text);
            _veiculo.KmPercorrido = Convert.ToDecimal(textBoxKmPercorrido.Text);

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
          

            ConfigurarObjeto();

            ValidationResult resultadoValidacao = GravarRegistro(Veiculo);

            if (resultadoValidacao.IsValid==false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;


                TelaPrincipalForm.Instancia.AtualizarRodape(erro);


                DialogResult = DialogResult.None;
            }
        }
        
        private void EncherComboBoxGrupoVeiculo(List<GrupoVeiculo> GruposVeiculos)
        {
            comboBoxGrupoVeiculo.Items.Clear();

            foreach (var Grupo in GruposVeiculos)
            {
                comboBoxGrupoVeiculo.Items.Add(Grupo);
            }
        }
       
        private string SelecionarEnum()
        {
            var enumSelecionado = comboBoxTipoCombustivel.SelectedItem.ToString();

            if (enumSelecionado == "Gasolina Comum")
                return "GasolinaComum";
            if (enumSelecionado == "Gasolina Adtivada")
                return "GasolinaAdtivada";

            return null;

               
                
        }

    }
}
