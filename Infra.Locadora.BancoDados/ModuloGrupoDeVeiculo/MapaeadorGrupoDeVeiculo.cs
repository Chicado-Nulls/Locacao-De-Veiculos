using Locadora.Dominio.ModuloGrupoDeVeiculos;
using Locadora.Infra.BancoDados.Compartilhado;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.BancoDados.ModuloGrupoDeVeiculo
{
    public class MapaeadorGrupoDeVeiculo:MapeadorBase<GrupoDeVeiculo>
    {
        public override void ConfigurarParametros(GrupoDeVeiculo registro, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("ID", registro.Id);
            comando.Parameters.AddWithValue("NOME", registro.Nome);
        }

        public override GrupoDeVeiculo ConverterRegistro(SqlDataReader leitorRegistro)
        {
            int id = Convert.ToInt32(leitorRegistro["ID"]);
            string nome = Convert.ToString(leitorRegistro["NOME"]);

            var grupoDeVeiculo = new GrupoDeVeiculo()
            {
                Id = id,
                Nome = nome
            };

            return grupoDeVeiculo;
        }
    }
}
