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

        public override bool Equals(object obj)
        {
            return obj is PlanoCobranca PlanoCobranca &&
                   GrupoVeiculo == PlanoCobranca.GrupoVeiculo &&
                   DiarioValorDiario == PlanoCobranca.DiarioValorDiario &&
                   DiarioValorPorKm == PlanoCobranca.DiarioValorPorKm &&
                   LivreValorDiario == PlanoCobranca.LivreValorDiario &&
                   ControladoValorDiario == PlanoCobranca.ControladoValorDiario &&
                   ControladoValorPorKm == PlanoCobranca.ControladoValorPorKm &&
                   ControladoLimiteDeKm == PlanoCobranca.ControladoLimiteDeKm;
        }

        public PlanoCobranca Clone()
        {
            return MemberwiseClone() as PlanoCobranca;
        }
    }
}
