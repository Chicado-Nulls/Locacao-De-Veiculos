using Locadora.Dominio.ModuloFuncionario;
using Locadora.Infra.BancoDados.Compartilhado;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Locadora.Infra.BancoDados.ModuloFuncionario
{
    public class MapeadorFuncionario : MapeadorBase<Funcionario>
    {
        public override void ConfigurarParametros(Funcionario registro, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("ID", registro.Id);
            comando.Parameters.AddWithValue("NOME", registro.Nome);
            comando.Parameters.AddWithValue("LOGIN", registro.Login);
            comando.Parameters.AddWithValue("SENHA", registro.Senha);
            comando.Parameters.AddWithValue("DATAENTRADA", registro.DataEntrada);
        }

        public override Funcionario ConverterRegistro(SqlDataReader leitorRegistro)
        {
            int id = Convert.ToInt32(leitorRegistro["FUNCIONARIO_ID"]);
            string nome = Convert.ToString(leitorRegistro["FUNCIONARIO_NOME"]);
            string login = Convert.ToString(leitorRegistro["FUNCIONARIO_LOGIN"]);
            string senha = Convert.ToString(leitorRegistro["FUNCIONARIO_SENHA"]);
            DateTime dataEntrada = Convert.ToDateTime(leitorRegistro["FUNCIONARIO_DATAENTRADA"]);
            
            var funcionario = new Funcionario
            {
                Id = id,
                Nome = nome,
                Login = login,
                Senha = senha,
                DataEntrada = dataEntrada
            };

            return funcionario;
        }
    }
}
