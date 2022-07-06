using Locadora.Dominio.ModuloPlanoCobranca;
using Locadora.Infra.BancoDados.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.BancoDados.ModuloPlanoCobranca
{
    public class RepositorioPlanoCobrancaBancoDados : RepositorioBase<PlanoCobranca, MapeadorPlanoCobranca>, IRepositorioPlanoCobranca
    {
        protected override string sqlInserir =>
            @"INSERT INTO [TBPLANOCOBRANCA]
              (
                GRUPO_VEICULO_ID,
                DIARIO_DIARIA,
                DIARIO_POR_KM,
                LIVRE_DIARIA,
                CONTROLADO_DIARIA,
                CONTROLADO_POR_KM,
                CONTROLADO_LIMITE_KM
              )
              VALUES
             (
                @GRUPO_VEICULO_ID,
                @DIARIO_DIARIA,
                @DIARIO_POR_KM,
                @LIVRE_DIARIA,
                @CONTROLADO_DIARIA,
                @CONTROLADO_POR_KM,
                @CONTROLADO_LIMITE_KM
             );
               SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @" UPDATE [TBPLANOCOBRANCA]
                    SET 
                        
                        [GRUPO_VEICULO_ID] = @GRUPO_VEICULO_ID, 
                        [DIARIO_DIARIA] = @DIARIO_DIARIA, 
                        [DIARIO_POR_KM] = @DIARIO_POR_KM,
                        [LIVRE_DIARIA] = @LIVRE_DIARIA,
                        [CONTROLADO_DIARIA] = @CONTROLADO_DIARIA,
                        [CONTROLADO_POR_KM] = @CONTROLADO_POR_KM,
                        [CONTROLADO_LIMITE_KM] = @CONTROLADO_LIMITE_KM

                    WHERE [ID] = @ID";



        protected override string sqlExcluir =>
            @"DELETE FROM[TBPLANOCOBRANCA]
                WHERE
                    [ID] = @ID";

        protected override string sqlSelecionarPorId =>
            @"SELECT 
                    PLANO.[ID] AS PLANOCOBRANCA_ID,
                    PLANO.[GRUPO_VEICULO_ID] AS PLANO_GRUPO_VEICULO_ID,
                    PLANO.[DIARIO_DIARIA] AS PLANOCOBRANCA_DIARIO_DIARIA,
                    PLANO.[DIARIO_POR_KM] AS PLANOCOBRANCA_DIARIOR_POR_KM,
                    PLANO.[LIVRE_DIARIA] AS PLANOCOBRANCA_LIVRE_DIARIA,
                    PLANO.[CONTROLADO_DIARIA] AS PLANOCOBRANCA_CONTROLADO_DIARIA,
                    PLANO.[CONTROLADO_POR_KM] AS PLANOCOBRANCA_CONTROLADO_POR_KM,
                    PLANO.[CONTROLADO_LIMITE_KM] AS PLANOCOBRANCA_CONTROLADO_LIMITE_KM,
                    GRUPO.[ID] AS GRUPOVEICULO_ID,
                    GRUPO.[NOME] AS GRUPOVEICULO_NOME

                FROM[TBPLANOCOBRANCA] AS PLANO

                INNER JOIN TBGRUPOVEICULO AS GRUPO
                
                ON PLANO.GRUPO_VEICULO_ID = GRUPO.ID
                
                WHERE PLANO.ID = @ID
                ";



        protected override string sqlSelecionarTodos =>
                @"SELECT 
                        PLANO.[ID] AS PLANOCOBRANCA_ID,
                        PLANO.[DIARIO_DIARIA] AS PLANOCOBRANCA_DIARIO_DIARIA,
                        PLANO.[DIARIO_POR_KM] AS PLANOCOBRANCA_DIARIOR_POR_KM,
                        PLANO.[LIVRE_DIARIA] AS PLANOCOBRANCA_LIVRE_DIARIA,
                        PLANO.[CONTROLADO_DIARIA] AS PLANOCOBRANCA_CONTROLADO_DIARIA,
                        PLANO.[CONTROLADO_POR_KM] AS PLANOCOBRANCA_CONTROLADO_POR_KM,
                        PLANO.[CONTROLADO_LIMITE_KM] AS PLANOCOBRANCA_CONTROLADO_LIMITE_KM,
                        GRUPO.[ID] AS GRUPOVEICULO_ID,
                        GRUPO.[NOME] AS GRUPOVEICULO_NOME

                FROM[TBPLANOCOBRANCA] AS PLANO

                INNER JOIN TBGRUPOVEICULO AS GRUPO
                
                ON PLANO.GRUPO_VEICULO_ID = GRUPO.ID";



        protected override string sqlValidaRegistroDuplicado => throw new NotImplementedException();

        public RepositorioPlanoCobrancaBancoDados(bool bancoTeste = false) : base(bancoTeste) { }
    }
}
