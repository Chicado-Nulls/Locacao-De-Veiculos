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

namespace Locadora.Apresentacao.WinForm.ModuloPlanoCobranca
{
    public partial class TelaCadastroPlanoCobranca : Form
    {
        public TelaCadastroPlanoCobranca()
        {
            InitializeComponent();
        }

        private RepositorioGrupoVeiculo repositorio;

        private void comboBoxGrupoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            repositorio = new RepositorioGrupoVeiculo();
            Db.ExecutarSql("SELECT * FROM TBGRUPOVEICULOS");
        }
    }
}
