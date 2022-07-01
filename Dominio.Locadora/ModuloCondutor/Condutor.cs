﻿using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.ModuloCondutor
{
    public class Condutor : EntidadeBase<Condutor>
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Cliente Cliente { get; set; } 
        public override void Atualizar(Condutor registro)
        {
                Nome = registro.Nome;
                Cpf = registro.Cpf;
                Cnh = registro.Cnh;
                Endereco = registro.Endereco;
                Email = registro.Email;
                Telefone = registro.Telefone;
                Cliente.Atualizar(registro.Cliente);
        }
        public override bool Equals(object obj)
        {
            return obj is Condutor condutor &&
                   Id == condutor.Id &&
                   Nome == condutor.Nome &&
                   Cpf == condutor.Cpf &&
                   Cnh == condutor.Cnh &&
                   Endereco == condutor.Endereco &&
                   Email == condutor.Email &&
                   Telefone == condutor.Telefone &&
                   Cliente.Equals(condutor.Cliente);
        }
        public Condutor Clone()
        {
            return MemberwiseClone() as Condutor;
        }
    }
}