using Locadora.Dominio.ModuloCliente;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.Orm.ModuloCliente
{
    public class MapeadorCliente : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("TbCliente");
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Nome).HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.Cpf).HasColumnType("varchar(50)");
            builder.Property(x => x.Cnpj).HasColumnType("varchar(50)");
            builder.Property(x => x.Endereco).HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.Cnh).HasColumnType("varchar(50)");
            builder.Property(x => x.Email).HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.Telefone).HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.TipoCadastro).HasColumnType("bit");
        }
    }
}
