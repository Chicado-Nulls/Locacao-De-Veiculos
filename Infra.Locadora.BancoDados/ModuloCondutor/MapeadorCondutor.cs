using Locadora.Dominio.ModuloCondutor;
using Locadora.Infra.BancoDados.Compartilhado;
using Locadora.Infra.BancoDados.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.BancoDados.ModuloCondutor
{
    public class MapeadorCondutor : MapeadorBase<Condutor>
    {
        MapeadorCliente mapeadorCliente;
        public MapeadorCondutor()
        {
            mapeadorCliente = new MapeadorCliente();
        }
        public override void ConfigurarParametros(Condutor registro, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("ID", registro.Id);
            comando.Parameters.AddWithValue("NOME", registro.Nome);
            comando.Parameters.AddWithValue("CPF", registro.Cpf);
            comando.Parameters.AddWithValue("CNH", registro.Cnh);
            comando.Parameters.AddWithValue("ENDERECO", registro.Endereco);
            comando.Parameters.AddWithValue("EMAIL", registro.Email);
            comando.Parameters.AddWithValue("TELEFONE", registro.Telefone);
            
            mapeadorCliente.ConfigurarParametros(registro.Cliente, comando);
            
        }

        public override Condutor ConverterRegistro(SqlDataReader leitorRegistro)
        {
            int id = Convert.ToInt32(leitorRegistro["ID"]);
            string nome = Convert.ToString(leitorRegistro["NOME"]);
            string cpf = Convert.ToString(leitorRegistro["CPF"]);
            string cnpj = Convert.ToString(leitorRegistro["CNPJ"]);
            string cnh = Convert.ToString(leitorRegistro["CNH"]);
            string endereco = Convert.ToString(leitorRegistro["ENDERECO"]);
            string email = Convert.ToString(leitorRegistro["EMAIL"]);
            string telefone = Convert.ToString(leitorRegistro["TELEFONE"]);
            var cliente = mapeadorCliente.ConverterRegistro(leitorRegistro);

            var condutor = new Condutor
            {
                Id = id,
                Nome = nome,
                Cpf = cpf,
                Cnh = cnh,
                Endereco = endereco,
                Email = email,
                Telefone = telefone,
                Cliente = cliente

            };

            return condutor;
        }
    }
}
