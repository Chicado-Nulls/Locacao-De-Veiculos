using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace Locadora.Dominio.Compartilhado
{
    public interface IRepositorioBase<T> where T: EntidadeBase<T>
    {
        void Inserir(T novoRegistro);

        void Editar(T registro);

        void Excluir(T registro);

        List<T> SelecionarTodos();

        T SelecionarPorId(Guid numero);

        public bool ExisteRegistroIgual(T registro, string consultaVerificaDuplicidade);
    }
}
