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

    public class RepositorioClienteEmBancoDeDados : RepositorioBase<Cliente, MapeadorCliente>, IRepositorioCliente
    {
        protected override string sqlInserir =>
            @"INSERT INTO [TBCLIENTE] 
                (
                    [ID],
                    [NOME],
                    [CPF],
                    [CNPJ],
                    [CNH],
                    [ENDERECO],
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
                    @CNH,
                    @ENDERECO,
                    @EMAIL,
                    @TELEFONE,
                    @TIPOCADASTRO
                    

                );";

        protected override string sqlEditar =>
             @" UPDATE [TBCLIENTE]
                    SET 
                        
                        [NOME] = @NOME, 
                        [CPF] = @CPF, 
                        [CNPJ] = @CNPJ,
                        [ENDERECO] = @ENDERECO,
                        [CNH] = @CNH,
                        [EMAIL] = @EMAIL,
                        [TELEFONE] = @TELEFONE,
                        [TIPOCADASTRO] = @TIPOCADASTRO

                    WHERE [ID] = @ID";

        protected override string sqlExcluir =>
             @"DELETE FROM[TBCLIENTE]
                WHERE
                    [ID] = @ID";

        protected override string sqlSelecionarPorId =>
            @"SELECT 
                    [ID] as CLIENTE_ID,
		            [NOME] as CLIENTE_NOME,
                    [CPF] as CLIENTE_CPF,
                    [CNPJ] as CLIENTE_CNPJ,
                    [ENDERECO] as CLIENTE_ENDERECO,
                    [CNH] as CLIENTE_CNH,
                    [EMAIL] as CLIENTE_EMAIL,
                    [TELEFONE] as CLIENTE_TELEFONE,
                    [TIPOCADASTRO] as CLIENTE_TIPOCADASTRO
	            FROM 
		            [TBCLIENTE]
		        WHERE
                    [ID] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT 
                    [ID] as CLIENTE_ID,
		            [NOME] as CLIENTE_NOME,
                    [CPF] as CLIENTE_CPF,
                    [CNPJ] as CLIENTE_CNPJ,
                    [ENDERECO] as CLIENTE_ENDERECO,
                    [CNH] as CLIENTE_CNH,
                    [EMAIL] as CLIENTE_EMAIL,
                    [TELEFONE] as CLIENTE_TELEFONE,
                    [TIPOCADASTRO] as CLIENTE_TIPOCADASTRO
	            FROM 
		            [TBCLIENTE]";

        protected override string sqlValidaRegistroDuplicado =>
            @"SELECT 
                    [ID] as CLIENTE_ID,
		            [NOME] as CLIENTE_NOME,
                    [CPF] as CLIENTE_CPF,
                    [CNPJ] as CLIENTE_CNPJ,
                    [ENDERECO] as CLIENTE_ENDERECO,
                    [CNH] as CLIENTE_CNH,
                    [EMAIL] as CLIENTE_EMAIL,
                    [TELEFONE] as CLIENTE_TELEFONE,
                    [TIPOCADASTRO] as CLIENTE_TIPOCADASTRO
	            FROM 
		            [TBCLIENTE]
		        WHERE
                    [CPF] = @CPF AND [CNPJ] = @CNPJ AND ID <> @ID";

        public RepositorioClienteEmBancoDeDados(bool bancoTeste = false) : base(bancoTeste)
        {

        }
    }
}
