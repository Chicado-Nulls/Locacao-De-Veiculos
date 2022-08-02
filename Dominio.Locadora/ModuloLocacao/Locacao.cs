using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCarro;
using Locadora.Dominio.ModuloCliente;
using Locadora.Dominio.ModuloCondutor;
using Locadora.Dominio.ModuloFuncionario;
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
        public Guid FuncionarioId { get; set; }
        public Funcionario Funcionario { get; private set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; private set; }
        public Guid CondutorId { get; set; }
        public Condutor Condutor { get; private set; }
        public Guid GrupoVeiculoId { get; set; }
        public GrupoVeiculo GrupoVeiculo { get; private set; }
        public Guid VeiculoId { get; set; }
        public Veiculo Veiculo { get; private set; }
        public Guid PlanoCobrancaId { get; set; }
        public PlanoCobranca PlanoCobranca { get; private set; }
        public decimal QuilometragemInicial { get; set; }
        public decimal QuilometragemFinal{ get; set; }
        public DateTime DataInicialLocacao { get; set; }
        public DateTime DataPrevistaDevolucao { get; set; }
        public DateTime DataDevolucaoRealizada { get; set; }
        public EnumLocacaoStatus Status { get; set; }
        public List<Taxa> Taxas { get; private set; }

        public Locacao()
        {
            Taxas = new List<Taxa>();
        }
        public override void Atualizar(Locacao registro)
        {
            throw new NotImplementedException();
        }
        public void AddCliente(Cliente cliente)
        {
            Cliente = cliente;
            ClienteId = cliente.Id;
        }
        public void AddFuncionario(Funcionario funcionario)
        {
            Funcionario = funcionario;
            FuncionarioId = funcionario.Id;
        }
        public void AddCondutor(Condutor condutor)
        {
            Condutor = condutor;
            CondutorId = condutor.Id;
        }
        public void AddGrupoVeiculo(GrupoVeiculo grupoVeiculo)
        {
            GrupoVeiculo = grupoVeiculo;
            GrupoVeiculoId = grupoVeiculo.Id;
        }
        public void AddVeiculo(Veiculo veiculo)
        {
            Veiculo = veiculo;
            VeiculoId = veiculo.Id;
        }
        public void AddPlanoCobranca(PlanoCobranca planoCobranca)
        {
            PlanoCobranca = planoCobranca;
            PlanoCobrancaId = planoCobranca.Id;
        }
        public void AddTaxas(Taxa taxa)
        {
            Taxas.Add(taxa);
        }
    }
}
