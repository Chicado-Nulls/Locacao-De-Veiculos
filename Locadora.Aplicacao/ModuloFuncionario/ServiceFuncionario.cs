using FluentResults;
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

        public override Result ExisteCamposDuplicados(Funcionario registro)
        {
            return Result.Ok();
        }
    }
}
