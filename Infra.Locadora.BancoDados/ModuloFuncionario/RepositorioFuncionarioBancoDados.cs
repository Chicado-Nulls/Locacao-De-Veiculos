using Locadora.Dominio.ModuloFuncionario;
using Locadora.Infra.BancoDados.Compartilhado;

namespace Locadora.Infra.BancoDados.ModuloFuncionario
{
    public class RepositorioFuncionarioBancoDados : RepositorioBase<Funcionario, MapeadorFuncionario>, IRepositorioFuncionario
    {
        protected override string sqlInserir =>
             @"INSERT INTO [TBFUNCIONARIO]
                        (
                            [ID],       
                            [NOME],       
                            [LOGIN], 
                            [SENHA],
                            [DATAENTRADA],
                            [ADMINISTRADOR],
                            [SALARIO]
                        )
                    VALUES
                        (
                            @ID,
                            @NOME,
                            @LOGIN,
                            @SENHA,
                            @DATAENTRADA,
                            @ADMINISTRADOR,
                            @SALARIO
                        ); SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE [TBFUNCIONARIO]	
                SET
	                [NOME] = @NOME,
                    [LOGIN] = @LOGIN,
                    [SENHA] = @SENHA,
                    [DATAENTRADA] = @DATAENTRADA,
                    [ADMINISTRADOR] = @ADMINISTRADOR,
                    [SALARIO] = @SALARIO
                WHERE
	                [ID] = @ID;";

        protected override string sqlExcluir =>
            @"DELETE FROM[TBFUNCIONARIO]
                WHERE
                    [ID] = @ID";

        protected override string sqlSelecionarPorId =>
            @"SELECT 
	                FUNCIONARIO.ID FUNCIONARIO_ID,
	                FUNCIONARIO.NOME FUNCIONARIO_NOME,
	                FUNCIONARIO.LOGIN FUNCIONARIO_LOGIN,
	                FUNCIONARIO.SENHA FUNCIONARIO_SENHA,
	                FUNCIONARIO.DATAENTRADA FUNCIONARIO_DATAENTRADA,
	                FUNCIONARIO.ADMINISTRADOR FUNCIONARIO_ADMINISTRADOR,
	                FUNCIONARIO.SALARIO FUNCIONARIO_SALARIO

                FROM TBFUNCIONARIO AS FUNCIONARIO

                WHERE FUNCIONARIO.ID = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT 
	                FUNCIONARIO.ID FUNCIONARIO_ID,
	                FUNCIONARIO.NOME FUNCIONARIO_NOME,
	                FUNCIONARIO.LOGIN FUNCIONARIO_LOGIN,
	                FUNCIONARIO.SENHA FUNCIONARIO_SENHA,
	                FUNCIONARIO.DATAENTRADA FUNCIONARIO_DATAENTRADA,
                    FUNCIONARIO.ADMINISTRADOR FUNCIONARIO_ADMINISTRADOR,
                    FUNCIONARIO.SALARIO FUNCIONARIO_SALARIO

                FROM TBFUNCIONARIO AS FUNCIONARIO";

        protected override string sqlValidaRegistroDuplicado =>
             @"SELECT 
	                FUNCIONARIO.ID FUNCIONARIO_ID,
	                FUNCIONARIO.NOME FUNCIONARIO_NOME,
	                FUNCIONARIO.LOGIN FUNCIONARIO_LOGIN,
	                FUNCIONARIO.SENHA FUNCIONARIO_SENHA,
	               FUNCIONARIO.DATAENTRADA FUNCIONARIO_DATAENTRADA,
                    FUNCIONARIO.ADMINISTRADOR FUNCIONARIO_ADMINISTRADOR,
                    FUNCIONARIO.SALARIO FUNCIONARIO_SALARIO

                FROM TBFUNCIONARIO AS FUNCIONARIO

                WHERE (NOME = @NOME or LOGIN = @LOGIN) AND ID <> @ID";
    }
}
