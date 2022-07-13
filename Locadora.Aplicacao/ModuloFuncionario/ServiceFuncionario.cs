using Locadora.Aplicacao.Compartilhado;
using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloFuncionario;

namespace Locadora.Aplicacao.ModuloFuncionario
{
    public class ServiceFuncionario : ServiceBase<Funcionario, ValidadorFuncionario>
    {
        public ServiceFuncionario(IRepositorioBase<Funcionario> repositorio) : base(repositorio)
        {
        }

        protected override string ObterIdentificadorLog(Funcionario registro)
        {
            return $"ID: {registro.Id} | Nome: {registro.Nome}";
        }
    }
}
