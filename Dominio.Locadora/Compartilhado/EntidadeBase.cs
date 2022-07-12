using System;

namespace Locadora.Dominio.Compartilhado
{
    public abstract class EntidadeBase<T>
    {
        protected EntidadeBase()
        {
            Id= new Guid();
        }

        public Guid Id { get; set; }

        public abstract void Atualizar(T registro);
    }
}
