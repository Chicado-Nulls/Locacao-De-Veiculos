﻿using System.Data.SqlClient;

namespace Locadora.Infra.BancoDados.ModuloCliente
{
    public static class Db
    {
        private static string enderecoBanco =
            @"Data Source=(LOCALDB)\MSSQLLOCALDB;
              Initial Catalog=LocadoraVeiculosDB;
              Integrated Security=True";

        public static void ExecutarSql(string sql)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comando = new SqlCommand(sql, conexaoComBanco);

            conexaoComBanco.Open();
            comando.ExecuteNonQuery();
            conexaoComBanco.Close();
        }
    }
}

