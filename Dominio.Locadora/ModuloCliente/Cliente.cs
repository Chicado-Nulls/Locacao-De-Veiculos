﻿using Locadora.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
        
        public string Nome { get; set; }    
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Cnh { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool TipoCadastro { get; set; }    

        
        

        public Cliente()
        {
        }

        public Cliente( string nome, string cpf, string cnpj, string cnh, string endereco, string email, string telefone, bool tipoCadastro)
        {
            //Id = id;
            Nome = nome;
            Cpf = cpf;
            Cnpj = cnpj;
            Cnh = cnh;
            Endereco = endereco;
            Email = email;
            Telefone = telefone;
            TipoCadastro = tipoCadastro;
            

        }

        public override void Atualizar(Cliente registro)
        {
            Id = registro.Id;
            Nome = registro.Nome;
            Cpf = registro.Cpf;
            Cnpj = registro.Cnpj;
            Cnh = registro.Cnh;
            Endereco = registro.Endereco;
            Email = registro.Email;
            Telefone = registro.Telefone;
            TipoCadastro = registro.TipoCadastro;
        }

        public override bool Equals(object obj)
        {
            return obj is Cliente Cliente &&
                   Id == Cliente.Id &&
                   Nome == Cliente.Nome &&
                   Cpf == Cliente.Cpf &&
                   Cnh == Cliente.Cnh &&
                   Endereco == Cliente.Endereco &&
                   Email == Cliente.Email &&
                   Telefone == Cliente.Telefone &&
                   TipoCadastro == Cliente.TipoCadastro;
        }

        public Cliente Clone()
        {
            return MemberwiseClone() as Cliente;
        }
    }
}