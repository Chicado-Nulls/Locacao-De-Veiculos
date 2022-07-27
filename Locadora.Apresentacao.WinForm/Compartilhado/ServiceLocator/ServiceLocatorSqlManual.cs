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
using Locadora.Infra.BancoDados.ModuloCliente;
using Locadora.Infra.BancoDados.ModuloCondutor;
using Locadora.Infra.BancoDados.ModuloFuncionario;
using Locadora.Infra.BancoDados.ModuloGrupoVeiculo;
using Locadora.Infra.BancoDados.ModuloTaxa;
using Locadora.Infra.BancoDados.ModuloVeiculo;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Apresentacao.WinForm.Compartilhado.ServiceLocator
{
    public class ServiceLocatorSqlManual
    {
        private Dictionary<string, ControladorBase> controladores;
        public ServiceLocatorSqlManual()
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

            //IRepositorioCliente repositorioCliente = new RepositorioClienteEmBancoDeDados();
            //ServiceCliente serviceCliente = new ServiceCliente(repositorioCliente);
            //controladores.Add("ControladorCliente", new ControladorCliente(serviceCliente));

            //IRepositorioFuncionario repositorioFuncionario = new RepositorioFuncionarioBancoDados();
            //ServiceFuncionario serviceFuncionario = new ServiceFuncionario(repositorioFuncionario);
            //controladores.Add("ControladorFuncionario", new ControladorFuncionario(serviceFuncionario));

            //IRepositorioTaxa repositorioTaxa = new RepositorioTaxa();
            //ServiceTaxa serviceTaxa = new ServiceTaxa(repositorioTaxa);
            //controladores.Add("Taxa", new ControladorTaxa(serviceTaxa));

            //IRepositorioGrupoVeiculo repositorioGrupoDeVeiculos = new RepositorioGrupoVeiculo();
            //ServiceGrupoVeiculo serviceGrupoDeVeiculos = new ServiceGrupoVeiculo(repositorioGrupoDeVeiculos);
            //controladores.Add("Grupo Veiculos", new ControladorGrupoVeiculo(serviceGrupoDeVeiculos));

            //IRepositorioVeiculo repositorioVeiculo = new RepositorioVeiculo();
            //ServiceVeiculo serviceVeiculo = new ServiceVeiculo(repositorioVeiculo);
            //controladores.Add("Veiculos", new ControladorVeiculo(serviceGrupoDeVeiculos, serviceVeiculo));

            //IRepositorioCondutor repositorioCondutor = new RepositorioCondutor();
            //ServiceCondutor servicecondutor = new ServiceCondutor(repositorioCondutor);
            //controladores.Add("Condutores", new ControladorCondutor(servicecondutor, serviceCliente));
        }
    }
}
