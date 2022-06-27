using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloGrupoDeVeiculos;
using Locadora.Infra.BancoDados.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.BancoDados.ModuloGrupoDeVeiculo
{
    public class RepositorioGrupoDeVeiculo : RepositorioBase<GrupoDeVeiculo, ValidadorGrupoDeVeiculos, MapaeadorGrupoDeVeiculo>, IRepositorioGrupoDeVeiculos
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
        protected override string sqlSelecionarPorId => @"SELECT * FROM [TBGRUPODEVEICULOS]
                                                            WHERE
                                                             [ID]=@ID";
        protected override string sqlSelecionarTodos => @"SELECT * FROM [TBGRUPODEVEICULOS]";
    }
}
