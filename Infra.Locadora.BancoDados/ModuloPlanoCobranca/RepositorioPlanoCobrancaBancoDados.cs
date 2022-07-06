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
                DIARIO_VALOR_DIARIO,
                DIARIO_VALOR_POR_KM,
                LIVRE_VALOR_DIARIO,
                CONTROLADO_VALOR_DIARIO,
                CONTROLADO_VALOR_POR_KM,
                CONTROLADO_LIMITE_DE_KM
              )
              VALUES
             (
                @GRUPO_VEICULO_ID,
                @DIARIO_VALOR_DIARIO,
                @DIARIO_VALOR_POR_KM,
                @LIVRE_VALOR_DIARIO,
                @CONTROLADO_VALOR_DIARIO,
                @CONTROLADO_VALOR_POR_KM,
                @CONTROLADO_LIMITE_DE_KM
             );
               SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @" UPDATE [TBPLANOCOBRANCA]
                    SET 
                        
                        [GRUPO_VEICULO_ID] = @GRUPO_VEICULO_ID, 
                        [DIARIO_VALOR_DIARIO] = @DIARIO_VALOR_DIARIO, 
                        [DIARIO_VALOR_POR_KM] = @DIARIO_VALOR_POR_KM,
                        [LIVRE_VALOR_DIARIO] = @LIVRE_VALOR_DIARIO,
                        [CONTROLADO_VALOR_DIARIO] = @CONTROLADO_VALOR_DIARIO,
                        [CONTROLADO_VALOR_POR_KM] = @CONTROLADO_VALOR_POR_KM,
                        [CONTROLADO_LIMITE_DE_KM] = @CONTROLADO_LIMITE_DE_KM

                    WHERE [ID] = @ID";



        protected override string sqlExcluir =>
            @"DELETE FROM[TBPLANOCOBRANCA]
                WHERE
                    [ID] = @ID";

        protected override string sqlSelecionarPorId =>
            @"SELECT PLANO.[ID] AS PLANO_ID,
                      PLANO.[GRUPO_VEICULO_ID] AS PLANO_GRUPO_VEICULO_ID,
                      PLANO.[DIARIO_VALOR_DIARIO] AS PLANO_DIARIO_VALOR_DIARIO,
                      PLANO.[DIARIO_VALOR_POR_KM] AS PLANO_DIARIO_VALOR_POR_KM,
                      PLANO.[LIVRE_VALOR_DIARIO] AS PLANO_LIVRE_VALOR_DIARIO,
                      PLANO.[CONTROLADO_VALOR_DIARIO] AS PLANO_CONTROLADO_VALOR_DIARIO,
                      PLANO.[CONTROLADO_VALOR_POR_KM] AS PLANO_CONTROLADO_VALOR_POR_KM,
                      PLANO.[CONTROLADO_LIMITE_DE_KM] AS PLANO_CONTROLADO_LIMITE_DE_KM,
	                  GRUPO.[ID] AS GRUPODEVEICULO_ID,
	                  GRUPO.[NOME] AS GRUPODEVEICULO_NOME

                FROM[TBPLANOCOBRANCA] AS PLANO



                   INNER JOIN TBGRUPODEVEICULOS AS GRUPO
                   ON
                   PLANO.GRUPO_VEICULO_ID = GRUPO.ID
                   WHERE PLANO.ID = @ID
";



        protected override string sqlSelecionarTodos =>
                            @"SELECT PLANO.[ID] AS PLANO_ID,
                      PLANO.[GRUPO_VEICULO_ID] AS PLANO_GRUPO_VEICULO_ID,
                      PLANO.[DIARIO_VALOR_DIARIO] AS PLANO_DIARIO_VALOR_DIARIO,
                      PLANO.[DIARIO_VALOR_POR_KM] AS PLANO_DIARIO_VALOR_POR_KM,
                      PLANO.[LIVRE_VALOR_DIARIO] AS PLANO_LIVRE_VALOR_DIARIO,
                      PLANO.[CONTROLADO_VALOR_DIARIO] AS PLANO_CONTROLADO_VALOR_DIARIO,
                      PLANO.[CONTROLADO_VALOR_POR_KM] AS PLANO_CONTROLADO_VALOR_POR_KM,
                      PLANO.[CONTROLADO_LIMITE_DE_KM] AS PLANO_CONTROLADO_LIMITE_DE_KM,
	                  GRUPO.[ID] AS GRUPODEVEICULO_ID,
	                  GRUPO.[NOME] AS GRUPODEVEICULO_NOME

                FROM[TBPLANOCOBRANCA] AS PLANO



                   INNER JOIN TBGRUPODEVEICULOS AS GRUPO
                   ON
                   PLANO.GRUPO_VEICULO_ID = GRUPO.ID";



        protected override string sqlValidaRegistroDuplicado => throw new NotImplementedException();

        public RepositorioPlanoCobrancaBancoDados(bool bancoTeste = false) : base(bancoTeste) { }
    }
}
