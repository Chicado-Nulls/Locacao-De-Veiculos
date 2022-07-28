using Locadora.Dominio.ModuloGrupoDeVeiculo;
using Locadora.Dominio.ModuloPlanoCobranca;
using Locadora.Infra.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.Orm.ModuloPlanoCobranca
{
    public class RepositorioPlanoCobranca : IRepositorioPlanoCobranca
    {
        private LocadoraVeiculoDbContext locadoraVeiculoDbContext;
        private DbSet<PlanoCobranca> planoCobranca;

        public RepositorioPlanoCobranca(LocadoraVeiculoDbContext locadoraVeiculoDbContext)
        {
            planoCobranca = locadoraVeiculoDbContext.Set<PlanoCobranca>();
            this.locadoraVeiculoDbContext = locadoraVeiculoDbContext;
        }


        public void Editar(PlanoCobranca registro)
        {
            planoCobranca.Update(registro);
        }

        public void Excluir(PlanoCobranca registro)
        {
            planoCobranca.Remove(registro);
        }

        public bool ExisteRegistroIgual(PlanoCobranca registro, string consultaVerificaDuplicidade)
        {
            throw new NotImplementedException();
        }

        public void Inserir(PlanoCobranca novoRegistro)
        {
            planoCobranca.Add(novoRegistro);
        }

        public PlanoCobranca SelecionarPlanoCobrancaPorGrupoVeiculo(GrupoVeiculo grupoVeiculo)
        {
            return planoCobranca.SingleOrDefault(x => x.GrupoVeiculo.Id == grupoVeiculo.Id);
        }

        public PlanoCobranca SelecionarPorId(Guid id)
        {
            return planoCobranca.SingleOrDefault(x => x.Id == id);
        }

        public List<PlanoCobranca> SelecionarTodos()
        {
            return planoCobranca.ToList();
        }
    }
}