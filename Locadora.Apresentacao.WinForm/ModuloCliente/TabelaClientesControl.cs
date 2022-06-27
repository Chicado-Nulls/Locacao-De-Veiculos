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
using Locadora.Apresentacao.WinForm.Compartilhado;

namespace Locadora.Apresentacao.WinForm.ModuloCliente
{
    public partial class TabelaClientesControl : UserControl
    {
        public TabelaClientesControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }
        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "NOME", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CPF", HeaderText = "CPF"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CNPJ", HeaderText = "CNPJ"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CNH", HeaderText = "Cnh"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ENDERECO", HeaderText = "Endereço"},

                new DataGridViewTextBoxColumn { DataPropertyName = "EMAIL", HeaderText = "Email"},

                new DataGridViewTextBoxColumn { DataPropertyName = "TELEFONE", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn { DataPropertyName = "TIPOCADASTRO", HeaderText = "Tipo cadastro"}




           };

            return colunas;
        }

        internal void AtualizarRegistros(List<Cliente> clientes)
        {
            grid.Rows.Clear();

            foreach (Cliente cliente in clientes)
            {
                string Cliente = cliente.TipoCadastro == true ? "Pessoa Física" : "Pessoa Jurídica"; 
                grid.Rows.Add(cliente.Id, cliente.Nome, cliente.Cpf, cliente.Cnpj, cliente.Cnh, cliente.Endereco, cliente.Email, cliente.Telefone, Cliente);
            }
        }
        internal int ObtemIdClienteSelecionado()
        {
            return grid.SelecionarId<int>();
        }


        private void TabelaClientesControl_Load(object sender, EventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
