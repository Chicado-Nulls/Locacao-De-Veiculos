﻿using Locadora.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.ModuloFuncionario
{
    public class Funcionario : EntidadeBase<Funcionario>
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        
        public DateTime DataEntrada { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, string login, string senha, DateTime data)
        {
            Nome=nome;
            Login=login;
            Senha=senha;
            DataEntrada=data;
        }

        public override void Atualizar(Funcionario registro)
        {
            Nome = registro.Nome;
            Login = registro.Login;
            Senha = registro.Senha;
            DataEntrada = registro.DataEntrada;
        }

        public override bool Equals(object obj)
        {
            return obj is Funcionario Funcionario &&
                   Nome == Funcionario.Nome  &&
                   Login == Funcionario.Login  &&
                   Senha == Funcionario.Senha  &&
                   DataEntrada == Funcionario.DataEntrada;
        }

        public Funcionario Clone()
        {
            return MemberwiseClone() as Funcionario;
        }
    }
}
