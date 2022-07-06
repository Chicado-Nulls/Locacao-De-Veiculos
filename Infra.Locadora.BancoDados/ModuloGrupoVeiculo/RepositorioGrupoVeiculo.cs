using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloGrupoDeVeiculo;
using Locadora.Infra.BancoDados.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.BancoDados.ModuloGrupoVeiculo
{
    public class RepositorioGrupoVeiculo : RepositorioBase<GrupoVeiculo, MapeadorGrupoVeiculo>, IRepositorioGrupoVeiculo
    {
        protected override string sqlInserir => @"INSERT INTO [TBGRUPODEVEICULOS]
                                                    (
                                                     NOME
                                                    )
                                                  VALUES
                                                     (
                                                      @NOME
                                                     );
                                                  SELECT SCOPE_IDENTITY();";
        protected override string sqlEditar => @"UPDATE [TBGRUPODEVEICULOS]
                                                  SET
                                                   NOME=@NOME
                                                 WHERE
                                                  [ID]=@ID";
        protected override string sqlExcluir => @"DELETE [TBGRUPODEVEICULOS]
                                                    WHERE
                                                     [ID]=@ID";
        protected override string sqlSelecionarPorId => @"SELECT 

                                                            ID AS GRUPODEVEICULO_ID,
                                                            NOME AS GRUPODEVEICULO_NOME

                                                           FROM [TBGRUPODEVEICULOS]

                                                            WHERE
                                                             [ID]=@ID";
        protected override string sqlSelecionarTodos => @"SELECT 
                                                            ID AS GRUPODEVEICULO_ID,
                                                            NOME AS GRUPODEVEICULO_NOME
                                                           FROM [TBGRUPODEVEICULOS]

";

        protected override string sqlValidaRegistroDuplicado =>
            @"SELECT * FROM [TBGRUPODEVEICULOS]
                   WHERE
                       [NOME]=@NOME AND [ID] <> @ID";

        public RepositorioGrupoVeiculo(bool bancoTeste = false) : base(bancoTeste) { }
    }
}
