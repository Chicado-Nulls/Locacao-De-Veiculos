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
            LimparTabela(null);
        }
        protected void LimparTabela(string tabela)
        {
            string sql;

            if (tabela == null)
                sql = "DELETE FROM "+NomeTabela+"; DBCC CHECKIDENT ("+NomeTabela+", RESEED, 0)";
            else
                sql = "DELETE FROM "+tabela+"; DBCC CHECKIDENT ("+tabela+", RESEED, 0)";

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comando = new SqlCommand(sql, conexaoComBanco);

            conexaoComBanco.Open();

            comando.ExecuteNonQuery();

            conexaoComBanco.Close();
        }
    }
}
