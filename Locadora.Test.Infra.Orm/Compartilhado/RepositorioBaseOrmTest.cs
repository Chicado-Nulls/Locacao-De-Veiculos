﻿using Locadora.Infra.Orm.Compartilhado;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Test.Infra.Orm.Compartilhado
{
    public class RepositorioBaseOrmTest
    {
        protected string connectionString;
        protected LocadoraVeiculoDbContext contextoDadosOrm;
        public RepositorioBaseOrmTest()
        {
            var configuracao = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("ConfiguracaoAplicacao.json")
                .Build();

            
            connectionString = configuracao.GetConnectionString("SqlServer");

            contextoDadosOrm = new LocadoraVeiculoDbContext(connectionString);

            LocadoraVeiculosMigrador.AtualizarBancoDados();

            //LimparTabela("TBPLANOCOBRANCA");
            LimparTabela("TBVEICULO");
            LimparTabela("TBGRUPOVEICULO");
            LimparTabela("TBFUNCIONARIO");
            LimparTabela("TBCONDUTOR");
            LimparTabela("TBCLIENTE");
            LimparTabela("TBTAXA");
        }
        protected void LimparTabela(string tabela)
        {
            string sql = @"DELETE FROM "+tabela;

            SqlConnection conexaoComBanco = new SqlConnection(connectionString);

            SqlCommand comando = new SqlCommand(sql, conexaoComBanco);

            conexaoComBanco.Open();

            comando.ExecuteNonQuery();

            conexaoComBanco.Close();
        }
    }
}
