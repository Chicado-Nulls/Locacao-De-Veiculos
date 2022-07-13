using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCliente;

namespace Locadora.Aplicacao.ModuloCliente
{
    public class ServiceCliente : ServiceBase<Cliente, ValidadorCliente>
    {
        public ServiceCliente(IRepositorioBase<Cliente> repositorio) : base(repositorio)
        {
        }

        protected override string ObterIdentificadorLog(Cliente registro)
        {
            return $"ID: {registro.Id} | Nome: {registro.Nome}";
        }
    }
}
