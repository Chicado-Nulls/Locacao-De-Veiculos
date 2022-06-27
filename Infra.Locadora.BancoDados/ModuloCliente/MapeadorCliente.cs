using Locadora.Dominio.ModuloCliente;
using Locadora.Infra.BancoDados.Compartilhado;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.BancoDados.ModuloCliente
{
    public class MapeadorCliente : MapeadorBase<Cliente>
    {
        public override void ConfigurarParametros(Cliente registro, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("ID", registro.Id);
            comando.Parameters.AddWithValue("NOME", registro.Nome);
            comando.Parameters.AddWithValue("CPF", registro.Cpf);
            comando.Parameters.AddWithValue("CNPJ", registro.Cnpj);
            comando.Parameters.AddWithValue("CNH", registro.Cnh);
            comando.Parameters.AddWithValue("ENDERECO", registro.Endereco);
            comando.Parameters.AddWithValue("EMAIL", registro.Email);
            comando.Parameters.AddWithValue("TELEFONE", registro.Telefone);
            comando.Parameters.AddWithValue("TIPOCADASTRO", registro.TipoCadastro);
        }

        public override Cliente ConverterRegistro(SqlDataReader leitorRegistro)
        {
            int id = Convert.ToInt32(leitorRegistro["ID"]);
            string nome = Convert.ToString(leitorRegistro["NOME"]);
            string cpf = Convert.ToString(leitorRegistro["CPF"]);
            string cnpj = Convert.ToString(leitorRegistro["CNPJ"]);
            string cnh = Convert.ToString(leitorRegistro["CNH"]);
            string endereco = Convert.ToString(leitorRegistro["ENDERECO"]);
            string email = Convert.ToString(leitorRegistro["EMAIL"]);
            string telefone = Convert.ToString(leitorRegistro["TELEFONE"]);
            bool tipocadastro = leitorRegistro.GetBoolean(leitorRegistro.GetOrdinal("TIPOCADASTRO"));

            var cliente = new Cliente
            {
                Id = id,
                Nome = nome,
                Cpf = cpf,
                Cnpj = cnpj,
                Cnh = cnh,
                Endereco = endereco,
                Email = email,
                Telefone = telefone,
                TipoCadastro = tipocadastro

            };
            return cliente;


        }
    }
}
