using FluentValidation;
using Locadora.Dominio.Compartilhado;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Locadora.Infra.BancoDados.Compartilhado
{
    public abstract class 
        RepositorioBase<T, TMapeador>
        where T : EntidadeBase<T>
        where TMapeador : MapeadorBase<T>, new ()
    {
        public RepositorioBase(bool bancoTeste = false)
        {
            enderecoBanco = bancoTeste == true ? enderecoBancoTest : enderecoBanco;
        }
        protected string enderecoBanco =
            @"Data Source=(LOCALDB)\MSSQLLOCALDB;
              Initial Catalog=LocadoraVeiculosDB;
              Integrated Security=True";

        protected string enderecoBancoTest =
            @"Data Source=(LOCALDB)\MSSQLLOCALDB;
              Initial Catalog=LocadoraVeiculosDBTest;
              Integrated Security=True";

        protected abstract string sqlInserir { get; }

        protected abstract string sqlEditar { get; }

        protected abstract string sqlExcluir { get; }

        protected abstract string sqlSelecionarPorId { get; }

        protected abstract string sqlSelecionarTodos { get; }

        protected abstract string sqlValidaRegistroDuplicado{ get; }

        public virtual void Inserir(T registro)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            var mapeador = new TMapeador();

            mapeador.ConfigurarParametros(registro, comandoInsercao);

            conexaoComBanco.Open();
            var id = comandoInsercao.ExecuteNonQuery();
            conexaoComBanco.Close();

        }

        public virtual void Editar(T registro)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoEdicao = new SqlCommand(sqlEditar, conexaoComBanco);

            var mapeador = new TMapeador();

            mapeador.ConfigurarParametros(registro, comandoEdicao);

            conexaoComBanco.Open();
            comandoEdicao.ExecuteNonQuery();
            conexaoComBanco.Close();

        }

        public virtual void Excluir(T registro)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoComBanco);

            comandoExclusao.Parameters.AddWithValue("ID", registro.Id);

            conexaoComBanco.Open();
            comandoExclusao.ExecuteNonQuery();
            conexaoComBanco.Close();
        }

        public virtual T SelecionarPorId(Guid id)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorId, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("ID", id);

            conexaoComBanco.Open();
            SqlDataReader leitorRegistro = comandoSelecao.ExecuteReader();

            var mapeador = new TMapeador();

            T registro = null;

            if (leitorRegistro.Read())
                registro = mapeador.ConverterRegistro(leitorRegistro);

            conexaoComBanco.Close();

            return registro;
        }

        public virtual List<T> SelecionarTodos()
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarTodos, conexaoComBanco);
            conexaoComBanco.Open();

            SqlDataReader leitorPaciente = comandoSelecao.ExecuteReader();

            var mapeador = new TMapeador();

            List<T> registros = new List<T>();

            while (leitorPaciente.Read())
                registros.Add(mapeador.ConverterRegistro(leitorPaciente));

            conexaoComBanco.Close();

            return registros;
        }

        public bool ExisteRegistroIgual(T registro, string tipo)
        {
           SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlValidaRegistroDuplicado, conexaoComBanco);

            var mapeador = new TMapeador();

            mapeador.ConfigurarParametros(registro, comandoSelecao);

            conexaoComBanco.Open();

            SqlDataReader leitorRegistro = comandoSelecao.ExecuteReader();

            T registroBusca = null;

            if (leitorRegistro.Read())
                registroBusca = mapeador.ConverterRegistro(leitorRegistro);

            conexaoComBanco.Close();

            return registroBusca == null ? false : true;
        }
    }
}
