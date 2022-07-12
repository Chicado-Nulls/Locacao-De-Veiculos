﻿using System;

namespace Locadora.Dominio.Compartilhado
{
    public abstract class EntidadeBase<T>
    {
        public Guid Id { get; set; }

        public abstract void Atualizar(T registro);
    }
}
