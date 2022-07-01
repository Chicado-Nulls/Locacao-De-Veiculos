using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloPlanoCobranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.ModuloPlanoCobranca
{
    public class ServicePlanoCobranca : ServiceBase<PlanoCobranca, ValidadorPlanoCobranca>
    {
        public ServicePlanoCobranca(IRepositorioBase<PlanoCobranca> repositorio) : base(repositorio)
        {

        }
    }
}
