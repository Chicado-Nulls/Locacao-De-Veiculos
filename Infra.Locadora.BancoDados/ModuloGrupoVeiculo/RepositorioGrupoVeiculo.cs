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
        public RepositorioGrupoVeiculo(bool bancoTeste = false) : base(bancoTeste) { }
        protected override string sqlInserir => @"INSERT INTO [TBGRUPOVEICULO]
                                                    (
                                                     ID,
                                                     NOME
                                                    )
                                                  VALUES
                                                     (
                                                      @ID,
                                                      @NOME
                                                     )
                                                 ";
        protected override string sqlEditar => @"UPDATE [TBGRUPOVEICULO]
                                                  SET
                                                   NOME=@NOME
                                                 WHERE
                                                  [ID]=@ID";
        protected override string sqlExcluir => @"DELETE [TBGRUPOVEICULO]
                                                    WHERE
                                                     [ID]=@ID";
        protected override string sqlSelecionarPorId => @"SELECT 

                                                            ID AS GRUPOVEICULO_ID,
                                                            NOME AS GRUPOVEICULO_NOME

                                                           FROM [TBGRUPOVEICULO]

                                                            WHERE
                                                             [ID]=@ID";
        protected override string sqlSelecionarTodos => @"SELECT 
                                                            ID AS GRUPOVEICULO_ID,
                                                            NOME AS GRUPOVEICULO_NOME
                                                           FROM [TBGRUPOVEICULO]

";

        protected override string sqlValidaRegistroDuplicado =>
            @"SELECT * FROM [TBGRUPOVEICULO]
                   WHERE
                       [NOME]=@NOME AND [ID] <> @ID";

    }
}
