using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Locadora.Infra.BancoDados.ModuloGrupoVeiculo;
using Locadora.Infra.BancoDados.Compartilhado;
using Locadora.Dominio.ModuloPlanoCobranca;
using System.ComponentModel.DataAnnotations;

namespace Locadora.Apresentacao.WinForm.ModuloPlanoCobranca
{
    public partial class TelaCadastroPlanoCobranca : Form
    {
        public TelaCadastroPlanoCobranca(string titulo, string label)
        {
            InitializeComponent();
        }

        private PlanoCobranca _planoCobranca;

        private RepositorioGrupoVeiculo repositorio;

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
            
        } 

        private void comboBoxGrupoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            repositorio = new RepositorioGrupoVeiculo();
            Db.ExecutarSql("SELECT * FROM TBGRUPOVEICULOS");
        }
    }
}
