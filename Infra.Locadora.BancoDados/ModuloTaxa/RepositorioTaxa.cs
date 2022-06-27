using FluentValidation.Results;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloTaxa;
using Locadora.Infra.BancoDados.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.BancoDados.ModuloTaxa
{
    public class RepositorioTaxa : RepositorioBase<Taxa, ValidadorTaxa, MapeadorTaxa>, IRepositorioTaxa
    {
        protected override string sqlInserir => @"INSERT INTO [TbTaxa]
                                                   (
                                                    [VALOR],
                                                    [DESCRICAO],
                                                    [ENUM_TIPODECALCULO]
                                                   )
                                                   VALUES
                                                    (
                                                     @VALOR,
                                                     @DESCRICAO,
                                                     @ENUM_TIPODECALCULO
                                                    );
                                                   Select SCOPE_IDENTITY()";




        protected override string sqlEditar => @"UPDATE [TbTaxa]
                                                   SET
                                                     [VALOR]=@VALOR,
                                                     [DESCRICAO]=@DESCRICAO,
                                                     [ENUM_TIPODECALCULO]=@ENUM_TIPODECALCULO
                                                   WHERE
                                                     [ID]=@ID";
        protected override string sqlExcluir => @"DELETE FROM [TbTaxa]
                                                    WHERE
                                                       [ID]=@ID";
        protected override string sqlSelecionarPorId => @"SELECT * FROM [TbTaxa]
                                                               WHERE
                                                                [ID]=@ID";

        protected override string sqlSelecionarTodos => @"SELECT * FROM [TbTaxa]";

        protected override string sqlValidaRegistroDuplicadoInserir =>
            @"SELECT * FROM [TbTaxa]
                            WHERE
                            [DESCRICAO]=@DESCRICAO";

        protected override string sqlValidaRegistroDuplicadoEditar =>
            @"SELECT * FROM [TbTaxa]
                            WHERE
                            [DESCRICAO] = @DESCRICAO AND [ID] <> @ID";
    }
}
