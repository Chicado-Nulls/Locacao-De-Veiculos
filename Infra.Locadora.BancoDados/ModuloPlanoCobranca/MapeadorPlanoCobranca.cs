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
            comando.Parameters.AddWithValue("GRUPO_VEICULO_ID", registro.GrupoVeiculo.Id);
            comando.Parameters.AddWithValue("DIARIO_VALOR_DIARIO", registro.DiarioValorDiario);
            comando.Parameters.AddWithValue("DIARIO_VALOR_POR_KM", registro.DiarioValorPorKm);
            comando.Parameters.AddWithValue("LIVRE_VALOR_DIARIO", registro.LivreValorDiario);
            comando.Parameters.AddWithValue("CONTROLADO_VALOR_DIARIO", registro.ControladoValorDiario);
            comando.Parameters.AddWithValue("CONTROLADO_VALOR_POR_KM", registro.ControladoValorPorKm);
            comando.Parameters.AddWithValue("CONTROLADO_LIMITE_DE_KM", registro.ControladoLimiteDeKm);
        }

        public override PlanoCobranca ConverterRegistro(SqlDataReader leitorRegistro)
        {
            int id = Convert.ToInt32(leitorRegistro["PLANO_ID"]);
            var grupoVeiculo = mapeador.ConverterRegistro(leitorRegistro);
            decimal diarioValorDiario = Convert.ToDecimal(leitorRegistro["PLANO_DIARIO_VALOR_DIARIO"]);
            decimal diarioValorPorKm = Convert.ToDecimal(leitorRegistro["PLANO_DIARIO_VALOR_POR_KM"]);
            decimal livreValorDiario = Convert.ToDecimal(leitorRegistro["PLANO_LIVRE_VALOR_DIARIO"]);
            decimal controladoValorDiario = Convert.ToDecimal(leitorRegistro["PLANO_CONTROLADO_VALOR_DIARIO"]);
            decimal controladoValorPorKm = Convert.ToDecimal(leitorRegistro["PLANO_CONTROLADO_VALOR_POR_KM"]);
            decimal controladoLimiteKm = Convert.ToDecimal(leitorRegistro["PLANO_CONTROLADO_LIMITE_DE_KM"]);

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
