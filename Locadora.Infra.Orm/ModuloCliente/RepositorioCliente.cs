﻿using Locadora.Dominio.ModuloCliente;
using Locadora.Infra.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.Orm.ModuloCliente
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private LocadoraVeiculoDbContext locadoraVeiculoDbContext;
        private DbSet<Cliente> cliente;

        public RepositorioCliente(LocadoraVeiculoDbContext locadoraVeiculoDbContext)
        {
            cliente = locadoraVeiculoDbContext.Set<Cliente>();
            this.locadoraVeiculoDbContext = locadoraVeiculoDbContext;
        }

        public void Editar(Cliente registro)
        {
            cliente.Update(registro);
        }

        public void Excluir(Cliente registro)
        {
            cliente.Remove(registro);
        }

        public bool ExisteRegistroIgual(Cliente registro, string consultaVerificaDuplicidade)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Cliente novoRegistro)
        {
            cliente.Add(novoRegistro);
        }

        public Cliente SelecionarPorId(Guid id)
        {
            return cliente.SingleOrDefault(x => x.Id == id);
        }

        public List<Cliente> SelecionarTodos()
        {
            return cliente.ToList();
        }
    }
}