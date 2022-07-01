using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Test.Infra.Compartilhado
{
    public abstract class RepositorioBaseTest
    {
        private string enderecoBanco =
            @"Data Source=(LOCALDB)\MSSQLLOCALDB;
              Initial Catalog=LocadoraVeiculosDBTest;
              Integrated Security=True";
        protected abstract string NomeTabela { get; }
        public RepositorioBaseTest()
        {
            LimparTabela();
        }
        protected void LimparTabela()
        {
            string sql = "DELETE FROM "+NomeTabela+"; DBCC CHECKIDENT ("+NomeTabela+", RESEED, 0)";

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comando = new SqlCommand(sql, conexaoComBanco);

            conexaoComBanco.Open();

            comando.ExecuteNonQuery();

            conexaoComBanco.Close();
        }
    }
}
