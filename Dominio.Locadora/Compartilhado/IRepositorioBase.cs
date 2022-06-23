using FluentValidation.Results;
using System.Collections.Generic;

namespace Locadora.Dominio.Compartilhado
{
    public interface IRepositorioBase<T> where T: EntidadeBase<T>
    {
        ValidationResult Inserir(T novoRegistro);

        ValidationResult Editar(T registro);

        void Excluir(T registro);

        List<T> SelecionarTodos();

        T SelecionarPorId(int Id);
    }
}
