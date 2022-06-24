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
        TabelaFuncionarioControl tabelaFuncionario;

        public ControladorFuncionario(IRepositorioFuncionario repositorioFuncionario)
        {
            repositorio=repositorioFuncionario;
        }
        public override void Editar()
        {
            var numero = tabelaFuncionario.ObtemNumeroRegistroSelecionado();

            var funcionarioSelecionado = repositorio.SelecionarPorId(numero);

            if (funcionarioSelecionado == null)
            {
                MessageBox.Show("Selecione um funcionário primeiro",
                "Edição de funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var tela = new TelaCadastroFuncionarioForm("Editar Funcionário");

            tela.Funcionario = funcionarioSelecionado.Clone();

            tela.GravarRegistro = repositorio.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarFuncionarios();
            }
        }

        public override void Excluir()
        {
            var numero = tabelaFuncionario.ObtemNumeroRegistroSelecionado();

            Funcionario materiaSelecionada = repositorio.SelecionarPorId(numero);

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione um funcionario primeiro",
                "Exclusão de Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show($"Deseja realmente excluir o funcionário '{materiaSelecionada.Nome}'?",
               "Exclusão de Funcionário", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorio.Excluir(materiaSelecionada);
                CarregarFuncionarios();
            }
        }

        public override void Inserir()
        {
            TelaCadastroFuncionarioForm telaCadastro = new TelaCadastroFuncionarioForm("Cadastrar Funcionário");

            telaCadastro.Funcionario = new Funcionario();

            telaCadastro.GravarRegistro = repositorio.Inserir;

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
