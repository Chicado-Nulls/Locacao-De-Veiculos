using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCarro;
using Locadora.Dominio.ModuloVeiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.ModuloVeiculo
{
    public class ServiceVeiculo : ServiceBase<Veiculo, ValidadorVeiculo>
    {
        public ServiceVeiculo(IRepositorioBase<Veiculo> repositorio) : base(repositorio)
        {
        }

        protected override string ObterIdentificadorLog(Veiculo registro)
        {
            return $"ID: {registro.Id} | Nome: {registro.Modelo}";
        }
    }
}
