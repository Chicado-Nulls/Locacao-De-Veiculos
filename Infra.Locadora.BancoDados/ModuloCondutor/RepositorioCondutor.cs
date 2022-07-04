﻿using Locadora.Dominio.ModuloCondutor;
using Locadora.Infra.BancoDados.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.BancoDados.ModuloCondutor
{
    public class RepositorioCondutor : RepositorioBase<Condutor, MapeadorCondutor>, IRepositorioCondutor
    {
        protected override string sqlInserir =>
			@"INSERT INTO [TBCONDUTOR] 
                (
                    [NOME],
                    [CPF],
                    [CNH],
                    [ENDERECO],
                    [EMAIL],
                    [TELEFONE],
                    [CLIENTE_ID]
                )
	            VALUES
                (   
                    @NOME,
                    @CPF, 
                    @CNH,
                    @ENDERECO,
                    @EMAIL,
                    @TELEFONE,
                    @CLIENTE_ID
                    
				);SELECT SCOPE_IDENTITY()";

		protected override string sqlEditar =>
			@" UPDATE [TBCONDUTOR]
                    SET 
                        
                        [NOME] = @NOME, 
                        [CPF] = @CPF, 
                        [ENDERECO] = @ENDERECO,
                        [CNH] = @CNH,
                        [EMAIL] = @EMAIL,
                        [TELEFONE] = @TELEFONE,
                        [CLIENTE_ID] = @CLIENTE_ID

                    WHERE [ID] = @ID";

		protected override string sqlExcluir =>
			@"DELETE FROM[TBCONDUTOR]
                WHERE
                    [ID] = @ID";

		protected override string sqlSelecionarPorId =>
			@"SELECT
					CONDUTOR.ID AS CONDUTOR_ID,
					CONDUTOR.NOME AS CONDUTOR_NOME,
					CONDUTOR.CPF AS CONDUTOR_CPF,
					CONDUTOR.CNH AS CONDUTOR_CNH,
					CONDUTOR.EMAIL AS CONDUTOR_EMAIL,
					CONDUTOR.TELEFONE AS CONDUTOR_TELEFONE,
					CONDUTOR.ENDERECO AS CONDUTOR_ENDERECO,

					CLIENTE.ID AS CLIENTE_ID,
					CLIENTE.NOME AS CLIENTE_NOME,
					CLIENTE.CPF AS CLIENTE_CPF,
					CLIENTE.CNPJ AS CLIENTE_CNPJ,
					CLIENTE.ENDERECO AS CLIENTE_ENDERECO,
					CLIENTE.CNH AS CLIENTE_CNH,
					CLIENTE.EMAIL AS CLIENTE_EMAIL,
					CLIENTE.TELEFONE AS CLIENTE_TELEFONE,
					CLIENTE.TIPOCADASTRO AS CLIENTE_TIPOCADASTRO

				FROM TBCONDUTOR AS CONDUTOR

				INNER JOIN TBCLIENTE AS CLIENTE

				ON CONDUTOR.CLIENTE_ID = CLIENTE.ID

				WHERE @ID = @ID";


        protected override string sqlSelecionarTodos =>
			@"SELECT
					CONDUTOR.ID AS CONDUTOR_ID,
					CONDUTOR.NOME AS CONDUTOR_NOME,
					CONDUTOR.CPF AS CONDUTOR_CPF,
					CONDUTOR.CNH AS CONDUTOR_CNH,
					CONDUTOR.EMAIL AS CONDUTOR_EMAIL,
					CONDUTOR.TELEFONE AS CONDUTOR_TELEFONE,
					CONDUTOR.ENDERECO AS CONDUTOR_ENDERECO,

					CLIENTE.ID AS CLIENTE_ID,
					CLIENTE.NOME AS CLIENTE_NOME,
					CLIENTE.CPF AS CLIENTE_CPF,
					CLIENTE.CNPJ AS CLIENTE_CNPJ,
					CLIENTE.ENDERECO AS CLIENTE_ENDERECO,
					CLIENTE.CNH AS CLIENTE_CNH,
					CLIENTE.EMAIL AS CLIENTE_EMAIL,
					CLIENTE.TELEFONE AS CLIENTE_TELEFONE,
					CLIENTE.TIPOCADASTRO AS CLIENTE_TIPOCADASTRO

				FROM TBCONDUTOR AS CONDUTOR

				INNER JOIN TBCLIENTE AS CLIENTE

				ON CONDUTOR.CLIENTE_ID = CLIENTE.ID";

        protected override string sqlValidaRegistroDuplicado => throw new NotImplementedException();

		public RepositorioCondutor(bool BancoTeste = false) : base(BancoTeste)
        {

        }
    }
}