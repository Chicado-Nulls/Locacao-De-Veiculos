using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCondutor;

namespace Locadora.Aplicacao.ModuloCondutor
{
    public class ServiceCondutor : ServiceBase<Condutor, ValidadorCondutor>
    {
        public ServiceCondutor(IRepositorioBase<Condutor> repositorio) : base(repositorio)
        {
        }

        protected override string ObterIdentificadorLog(Condutor registro)
        {
            return $"ID: {registro.Id} | Nome: {registro.Nome}";
        }
    }
}
