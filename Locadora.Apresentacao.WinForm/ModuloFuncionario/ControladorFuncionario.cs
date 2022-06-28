using Locadora.Aplicacao.ModuloFuncionario;
using Locadora.Apresentacao.WinForm.Compartilhado;
using Locadora.Dominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Apresentacao.WinForm.ModuloFuncionario
{
    public class ControladorFuncionario : ControladorBase
    {
        IRepositorioFuncionario repositorio;
        private ServiceFuncionario serviceFuncionario;
        TabelaFuncionarioControl tabelaFuncionario;

        
        public ControladorFuncionario(IRepositorioFuncionario repositorioFuncionario, ServiceFuncionario serviceFuncionario)
        {
            this.serviceFuncionario=serviceFuncionario;
            this.repositorio = repositorioFuncionario;
        }

        public override void Editar()
        {
            var numero = tabelaFuncionario.ObtemNumeroRegistroSelecionado();

            var funcionarioSelecionado = repositorio.SelecionarPorId(numero);

            if (funcionarioSelecionado == null)
            {
                MessageBox.Show("Selecione um funcionário primeiro",
                "Edição de funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var tela = new TelaCadastroFuncionarioForm("Editar Funcionário");

            tela.Funcionario = funcionarioSelecionado.Clone();

            tela.GravarRegistro = serviceFuncionario.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarFuncionarios();
            }
        }

        //public override bool Equals(object? obj)
        //{
        //    return obj is ControladorFuncionario funcionario&&
        //           EqualityComparer<IRepositorioFuncionario>.Default.Equals(repositorio, funcionario.repositorio)&&
        //           EqualityComparer<ServiceFuncionario>.Default.Equals(serviceFuncionario, funcionario.serviceFuncionario);
        //}

        public override void Excluir()
        {
            var numero = tabelaFuncionario.ObtemNumeroRegistroSelecionado();

            Funcionario materiaSelecionada = serviceFuncionario.SelecionarPorId(numero);

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione um funcionario primeiro",
                "Exclusão de Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show($"Deseja realmente excluir o funcionário '{materiaSelecionada.Nome}'?",
               "Exclusão de Funcionário", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;


            repositorio.Excluir(materiaSelecionada);
            CarregarFuncionarios();
        }

        public override void Inserir()
        {
            TelaCadastroFuncionarioForm telaCadastro = new TelaCadastroFuncionarioForm("Cadastrar Funcionário");

            telaCadastro.Funcionario = new Funcionario();

            telaCadastro.GravarRegistro = serviceFuncionario.Inserir;

            DialogResult resultado = telaCadastro.ShowDialog();

            if (resultado == DialogResult.OK)
                CarregarFuncionarios();
        }

        public override ConfigurarToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfigurarTollboxFuncionario();
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaFuncionario == null)
                tabelaFuncionario = new TabelaFuncionarioControl();

            CarregarFuncionarios();

            return tabelaFuncionario;
        }

        private void CarregarFuncionarios()
        {
            List<Funcionario> funcionarios = repositorio.SelecionarTodos();

            tabelaFuncionario.AtualizarRegistros(funcionarios);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {funcionarios.Count} funcionarios(s)");
        }
    }
}
