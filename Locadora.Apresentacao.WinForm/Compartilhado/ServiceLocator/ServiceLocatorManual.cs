using Locadora.Aplicacao.ModuloCliente;
using Locadora.Aplicacao.ModuloCondutor;
using Locadora.Aplicacao.ModuloFuncionario;
using Locadora.Aplicacao.ModuloGrupoDeVeiculos;
using Locadora.Aplicacao.ModuloTaxa;
using Locadora.Aplicacao.ModuloVeiculo;
using Locadora.Apresentacao.WinForm.ModuloCliente;
using Locadora.Apresentacao.WinForm.ModuloCondutor;
using Locadora.Apresentacao.WinForm.ModuloFuncionario;
using Locadora.Apresentacao.WinForm.ModuloGrupoDeVeiculos;
using Locadora.Apresentacao.WinForm.ModuloTaxa;
using Locadora.Apresentacao.WinForm.ModuloVeiculo;
using Locadora.Dominio.ModuloCliente;
using Locadora.Dominio.ModuloCondutor;
using Locadora.Dominio.ModuloFuncionario;
using Locadora.Dominio.ModuloGrupoDeVeiculo;
using Locadora.Dominio.ModuloTaxa;
using Locadora.Dominio.ModuloVeiculo;
using Locadora.Infra.BancoDados.ModuloGrupoVeiculo;
using Locadora.Infra.BancoDados.ModuloTaxa;
using Locadora.Infra.BancoDados.ModuloVeiculo;
using Locadora.Infra.Orm.Compartilhado;
using Locadora.Infra.Orm.ModuloCliente;
using Locadora.Infra.Orm.ModuloCondutor;
using Locadora.Infra.Orm.ModuloFuncionario;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;

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

            var configuracao = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("ConfiguracaoAplicacao.json")
                 .Build();

            var connectionString = configuracao.GetConnectionString("SqlServer");

            var contextoDadosOrm = new LocadoraVeiculoDbContext(connectionString);

            IRepositorioCliente repositorioCliente = new RepositorioCliente(contextoDadosOrm);
            ServiceCliente serviceCliente = new ServiceCliente(repositorioCliente, contextoDadosOrm);
            controladores.Add("ControladorCliente", new ControladorCliente(serviceCliente));

            IRepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario(contextoDadosOrm);
            ServiceFuncionario serviceFuncionario = new ServiceFuncionario(repositorioFuncionario, contextoDadosOrm);
            controladores.Add("ControladorFuncionario", new ControladorFuncionario(serviceFuncionario));

            IRepositorioTaxa repositorioTaxa = new RepositorioTaxa();
            ServiceTaxa serviceTaxa = new ServiceTaxa(repositorioTaxa, contextoDadosOrm);
            controladores.Add("Taxa", new ControladorTaxa(serviceTaxa));

            IRepositorioGrupoVeiculo repositorioGrupoDeVeiculos = new RepositorioGrupoVeiculo();
            ServiceGrupoVeiculo serviceGrupoDeVeiculos = new ServiceGrupoVeiculo(repositorioGrupoDeVeiculos, contextoDadosOrm);
            controladores.Add("Grupo Veiculos", new ControladorGrupoVeiculo(serviceGrupoDeVeiculos));

            IRepositorioVeiculo repositorioVeiculo = new RepositorioVeiculo();
            ServiceVeiculo serviceVeiculo = new ServiceVeiculo(repositorioVeiculo, contextoDadosOrm);
            controladores.Add("Veiculos", new ControladorVeiculo(serviceGrupoDeVeiculos, serviceVeiculo));

            IRepositorioCondutor repositorioCondutor = new RepositorioCondutor(contextoDadosOrm);
            ServiceCondutor servicecondutor = new ServiceCondutor(repositorioCondutor, contextoDadosOrm);
            controladores.Add("ControladorCondutor", new ControladorCondutor(servicecondutor, serviceCliente));
        }
    }
}
