using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCarro;
using Locadora.Dominio.ModuloCliente;
using Locadora.Dominio.ModuloCondutor;
using Locadora.Dominio.ModuloGrupoDeVeiculo;
using Locadora.Dominio.ModuloPlanoCobranca;
using Locadora.Dominio.ModuloTaxa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.ModuloLocacao
{
    public class Locacao : EntidadeBase<Locacao>
    {
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public Guid CondutorId { get; set; }
        public Condutor Condutor { get; set; }
        public Guid GrupoVeiculoId { get; set; }
        public GrupoVeiculo GrupoVeiculo { get; set; }
        public Guid VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
        public Guid PlanoCobrancaId { get; set; }
        public PlanoCobranca PlanoCobranca { get; set; }
        public decimal QuilometragemInicial { get; set; }
        public decimal QuilometragemFinal{ get; set; }
        public DateTime DataInicialLocacao { get; set; }
        public DateTime DataPrevistaDevolucao { get; set; }
        public DateTime DataDevolucaorealizada { get; set; }
        List<Taxa> Taxas { get; set; }

        public override void Atualizar(Locacao registro)
        {
            throw new NotImplementedException();
        }
    }
}
