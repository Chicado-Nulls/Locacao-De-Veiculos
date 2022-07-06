using Locadora.Dominio.ModuloGrupoDeVeiculo;
using Locadora.Infra.BancoDados.Compartilhado;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.BancoDados.ModuloGrupoVeiculo
{
    public class MapeadorGrupoVeiculo : MapeadorBase<GrupoVeiculo>
    {
        public override void ConfigurarParametros(GrupoVeiculo registro, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("ID", registro.Id);
            comando.Parameters.AddWithValue("NOME", registro.Nome);
        }

        public override GrupoVeiculo ConverterRegistro(SqlDataReader leitorRegistro)
        {
            int id = Convert.ToInt32(leitorRegistro["GRUPOVEICULO_ID"]);
            string nome = Convert.ToString(leitorRegistro["GRUPOVEICULO_NOME"]);

            var grupoDeVeiculo = new GrupoVeiculo()
            {
                Id = id,
                Nome = nome
            };

            return grupoDeVeiculo;
        }
    }
}

