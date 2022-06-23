using Locadora.Dominio.Compartilhado;
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
        public string Endereco { get; set; }
        public string Cnh { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        
        

        public Cliente()
        {
        }

        public Cliente(string nome, string cpf, string cnpj, string endereco, string cnh, string email, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Cnpj = cnpj;
            Endereco = endereco;
            Cnh = cnh;
            Email = email;
            Telefone = telefone;
            

        }

        public override void Atualizar(Cliente registro)
        {
            throw new NotImplementedException();
        }
    }
}
