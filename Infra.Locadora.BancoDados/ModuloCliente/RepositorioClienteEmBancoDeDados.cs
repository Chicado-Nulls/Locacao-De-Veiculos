using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using Locadora.Dominio.ModuloCliente;
using Locadora.Infra.BancoDados.Compartilhado;

namespace Locadora.Infra.BancoDados.ModuloCliente
{

    public class RepositorioClienteEmBancoDeDados : RepositorioBase<Cliente, ValidadorCliente, MapeadorCliente>, IRepositorioCliente
    {
        protected override string sqlInserir =>
            @"INSERT INTO [TBCliente] 
                (
                    [ID],
                    [NOME],
                    [CPF],
                    [CNPJ],
                    [ENDERECO],
                    [CNH],
                    [EMAIL],
                    [TELEFONE],
                    [TIPOCADASTRO]
	            )
	            VALUES
                (   
                    @ID,
                    @NOME,
                    @CPF, 
                    @CNPJ,
                    @ENDERECO,
                    @CNH,
                    @EMAIL,
                    @TELEFONE,
                    @TIPOCADASTRO

                );SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
             @" UPDATE [TBCLIENTE]
                    SET 
                        [ID] = @ID,
                        [NOME] = @NOME, 
                        [CPF] = @CPF, 
                        [CNPJ] = @CNPJ,
                        [ENDERECO] = @ENERECO,
                        [CNH] = @CNH,
                        [EMAIL] = @EMAIL,
                        [TELEFONE] = @TELEFONE,    
                        [TIPOCADASTRO] = @TIPOCADASTRO

                    WHERE [ID] = @ID";

        protected override string sqlExcluir => throw new NotImplementedException();

        protected override string sqlSelecionarPorId =>
            @"SELECT 
                    [ID],
		            [NOME],
                    [CPF],
                    [CNPJ],
                    [ENDERECO],
                    [CNH],
                    [EMAIL],
                    [TELEFONE],
                    [TIPOCADASTRO]
	            FROM 
		            [TBCLIENTE]
		        WHERE
                    [ID] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT      
                [ID],
                [NOME],
                [CPF],
                [CNPJ],             
                [ENDERECO],                    
                [CNH],
                [EMAIL],
                [TELEFONE],
                [TIPOCADASTRO]
                
            FROM
                [TBCLIENTE]";

    }
}
