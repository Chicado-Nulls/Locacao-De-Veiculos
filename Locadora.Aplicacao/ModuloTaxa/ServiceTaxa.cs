using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloTaxa;

namespace Locadora.Aplicacao.ModuloTaxa
{
    public class ServiceTaxa : ServiceBase<Taxa, ValidadorTaxa>
    {
        public ServiceTaxa(IRepositorioBase<Taxa> repositorio) : base(repositorio)
        {
        }

        protected override string ObterIdentificadorLog(Taxa registro)
        {
            return $"ID: {registro.Id} | Nome: {registro.Descricao}";
        }
    }
}
