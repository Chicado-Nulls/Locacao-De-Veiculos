using Locadora.Dominio.ModuloPlanoCobranca;
using Locadora.Infra.BancoDados.Compartilhado;
using Locadora.Infra.BancoDados.ModuloGrupoVeiculo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.BancoDados.ModuloPlanoCobranca
{
    public class MapeadorPlanoCobranca : MapeadorBase<PlanoCobranca>
    {
        MapeadorGrupoVeiculo mapeador;

        public MapeadorPlanoCobranca()
        {
            mapeador = new MapeadorGrupoVeiculo();
        }
        public override void ConfigurarParametros(PlanoCobranca registro, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("ID", registro.Id);
            comando.Parameters.AddWithValue("GRUPOVEICULOID", registro.GrupoVeiculo.Id);
            comando.Parameters.AddWithValue("DIARIOVALORDIARIO", registro.DiarioValorDiario);
            comando.Parameters.AddWithValue("DIARIOVALORPORKM", registro.DiarioValorPorKm);
            comando.Parameters.AddWithValue("LIVREVALORDIARIO", registro.LivreValorDiario);
            comando.Parameters.AddWithValue("CONTROLADOVALORDIARIO", registro.ControladoValorDiario);
            comando.Parameters.AddWithValue("CONTROLADOVALORPORKM", registro.ControladoValorPorKm);
            comando.Parameters.AddWithValue("CONTROLADOLIMITEDEKM", registro.ControladoLimiteDeKm);
        }

        public override PlanoCobranca ConverterRegistro(SqlDataReader leitorRegistro)
        {
            int id = Convert.ToInt32(leitorRegistro["ID"]);
            var grupoVeiculo = mapeador.ConverterRegistro(leitorRegistro);
            decimal diarioValorDiario = Convert.ToDecimal(leitorRegistro["DIARIOVALORDIARIO"]);
            decimal diarioValorPorKm = Convert.ToDecimal(leitorRegistro["DIARIOVALORPORKM"]);
            decimal livreValorDiario = Convert.ToDecimal(leitorRegistro["LIVREVALORDIARIO"]);
            decimal controladoValorDiario = Convert.ToDecimal(leitorRegistro["CONTROLADOVALORDIARIO"]);
            decimal controladoValorPorKm = Convert.ToDecimal(leitorRegistro["CONTROLADOVALORPORKM"]);
            decimal controladoLimiteKm = Convert.ToDecimal(leitorRegistro["CONTROLADOLIMITEKM"]);

            var planoCobranca = new PlanoCobranca
            {

                Id = id,
                GrupoVeiculo = grupoVeiculo,
                DiarioValorDiario = diarioValorDiario,
                DiarioValorPorKm = diarioValorPorKm,
                LivreValorDiario= livreValorDiario,
                ControladoValorDiario = controladoValorDiario,
                ControladoValorPorKm = controladoValorPorKm,
                ControladoLimiteDeKm = controladoLimiteKm
                

            };
            return planoCobranca;


        }
    }
}
