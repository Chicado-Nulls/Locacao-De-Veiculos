using Locadora.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locadora.Dominio.ModuloGrupoDeVeiculo;

namespace Locadora.Dominio.ModuloPlanoCobranca
{
    public class PlanoCobranca : EntidadeBase<PlanoCobranca>
    {
        public GrupoVeiculo GrupoVeiculo { get; set; }
        public decimal DiarioValorDiario { get; set; }
        public decimal DiarioValorPorKm { get; set; }
        public decimal LivreValorDiario { get; set; }
        public decimal ControladoValorDiario { get; set; }
        public decimal ControladoValorPorKm { get; set; }
        public decimal ControladoLimiteDeKm { get; set; }




        public PlanoCobranca() { }

        public PlanoCobranca(GrupoVeiculo grupoVeiculo, decimal diarioValorDiario, decimal diarioValorPorKm, decimal livreValorDiario, decimal controladoValorDiario, decimal controladoValorPorKm, decimal controladoLimiteDeKm)
        {
            GrupoVeiculo = grupoVeiculo;
            DiarioValorDiario  = diarioValorDiario;
            DiarioValorPorKm = diarioValorPorKm;
            LivreValorDiario = livreValorDiario;
            ControladoValorDiario = controladoValorDiario;
            ControladoValorPorKm = controladoValorPorKm;
            ControladoLimiteDeKm = controladoLimiteDeKm;

        }

        public override void Atualizar(PlanoCobranca registro)
        {
            GrupoVeiculo= registro.GrupoVeiculo;
            DiarioValorDiario = registro.DiarioValorDiario;
            DiarioValorPorKm = registro.DiarioValorPorKm;
            LivreValorDiario = registro.LivreValorDiario;
            ControladoValorDiario = registro.ControladoValorDiario;
            ControladoValorPorKm = registro.ControladoValorPorKm;
            ControladoLimiteDeKm = registro.ControladoLimiteDeKm;

        }

        public PlanoCobranca Clone()
        {
            return MemberwiseClone() as PlanoCobranca;
        }

        public override bool Equals(object obj)
        {
            return obj is PlanoCobranca cobranca &&
                   GrupoVeiculo.Equals(cobranca.GrupoVeiculo) &&
                   DiarioValorDiario == cobranca.DiarioValorDiario &&
                   DiarioValorPorKm == cobranca.DiarioValorPorKm &&
                   LivreValorDiario == cobranca.LivreValorDiario &&
                   ControladoValorDiario == cobranca.ControladoValorDiario &&
                   ControladoValorPorKm == cobranca.ControladoValorPorKm &&
                   ControladoLimiteDeKm == cobranca.ControladoLimiteDeKm;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, GrupoVeiculo, DiarioValorDiario, DiarioValorPorKm, LivreValorDiario, ControladoValorDiario, ControladoValorPorKm, ControladoLimiteDeKm);
        }
    }
}
