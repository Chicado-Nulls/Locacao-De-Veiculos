using Locadora.Dominio.ModuloCliente;
using Locadora.Dominio.ModuloCondutor;
using Locadora.Dominio.ModuloFuncionario;
using Locadora.Dominio.ModuloGrupoDeVeiculo;
using Locadora.Dominio.ModuloPlanoCobranca;
using Locadora.Dominio.ModuloTaxa;
using Locadora.Dominio.ModuloVeiculo;
using Locadora.Infra.BancoDados.ModuloCliente;
using Locadora.Infra.BancoDados.ModuloCondutor;
using Locadora.Infra.BancoDados.ModuloFuncionario;
using Locadora.Infra.BancoDados.ModuloGrupoVeiculo;
using Locadora.Infra.BancoDados.ModuloPlanoCobranca;
using Locadora.Infra.BancoDados.ModuloTaxa;
using Locadora.Infra.BancoDados.ModuloVeiculo;
using Locadora.Aplicacao.ModuloCliente;
using Locadora.Aplicacao.ModuloCondutor;
using Locadora.Aplicacao.ModuloFuncionario;
using Locadora.Aplicacao.ModuloGrupoDeVeiculos;
using Locadora.Aplicacao.ModuloPlanoCobranca;
using Locadora.Aplicacao.ModuloTaxa;
using Locadora.Aplicacao.ModuloVeiculo;
using Locadora.Apresentacao.WinForm.ModuloCliente;
using Locadora.Apresentacao.WinForm.ModuloCondutor;
using Locadora.Apresentacao.WinForm.ModuloFuncionario;
using Locadora.Apresentacao.WinForm.ModuloGrupoDeVeiculos;
using Locadora.Apresentacao.WinForm.ModuloPlanoCobranca;
using Locadora.Apresentacao.WinForm.ModuloTaxa;
using Locadora.Apresentacao.WinForm.ModuloVeiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Apresentacao.WinForm.Compartilhado.ServiceLocator
{
    internal class ServiceLocatorManual : IServiceLocator
    {
        private Dictionary<string, ControladorBase> controladores;
        public ServiceLocatorManual()
        {
            InicializarControladores();
        }
        public T Get<T>() where T : ControladorBase
        {
            var tipo = typeof(T);

            var nomeControlador = tipo.Name;

            return (T)controladores[nomeControlador];
        }

        private void InicializarControladores()
        {
            controladores = new Dictionary<string, ControladorBase>();

            IRepositorioCliente repositorioCliente = new RepositorioClienteEmBancoDeDados();
            ServiceCliente serviceCliente = new ServiceCliente(repositorioCliente);
            controladores.Add("Cliente", new ControladorCliente(serviceCliente));

            IRepositorioFuncionario repositorioFuncionario = new RepositorioFuncionarioBancoDados();
            ServiceFuncionario serviceFuncionario = new ServiceFuncionario(repositorioFuncionario);
            controladores.Add("Funcionario", new ControladorFuncionario(serviceFuncionario));

            IRepositorioTaxa repositorioTaxa = new RepositorioTaxa();
            ServiceTaxa serviceTaxa = new ServiceTaxa(repositorioTaxa);
            controladores.Add("Taxa", new ControladorTaxa(serviceTaxa));

            IRepositorioGrupoVeiculo repositorioGrupoDeVeiculos = new RepositorioGrupoVeiculo();
            ServiceGrupoVeiculo serviceGrupoDeVeiculos = new ServiceGrupoVeiculo(repositorioGrupoDeVeiculos);
            controladores.Add("Grupo Veiculos", new ControladorGrupoVeiculo(serviceGrupoDeVeiculos));

            IRepositorioVeiculo repositorioVeiculo = new RepositorioVeiculo();
            ServiceVeiculo serviceVeiculo = new ServiceVeiculo(repositorioVeiculo);
            controladores.Add("Veiculos", new ControladorVeiculo(serviceGrupoDeVeiculos, serviceVeiculo));

            IRepositorioCondutor repositorioCondutor = new RepositorioCondutor();
            ServiceCondutor servicecondutor = new ServiceCondutor(repositorioCondutor);
            controladores.Add("Condutores", new ControladorCondutor(servicecondutor, serviceCliente));
        }
    }
}
