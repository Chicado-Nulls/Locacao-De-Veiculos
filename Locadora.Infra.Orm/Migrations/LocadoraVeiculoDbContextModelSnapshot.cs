﻿// <auto-generated />
using System;
using Locadora.Infra.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Locadora.Infra.Orm.Migrations
{
    [DbContext(typeof(LocadoraVeiculoDbContext))]
    partial class LocadoraVeiculoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Locadora.Dominio.ModuloCarro.Veiculo", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("CapacidadeTanque")
                        .IsRequired()
                        .HasColumnType("varbinary(MAX)");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid>("GrupoDeVeiculoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("KmPercorrido")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("TipoDeCombustivel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GrupoDeVeiculoId");

                    b.ToTable("TbVeiculo");
                });

            modelBuilder.Entity("Locadora.Dominio.ModuloCliente.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cnh")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cnpj")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cpf")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("TipoCadastro")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("TbCliente");
                });

            modelBuilder.Entity("Locadora.Dominio.ModuloCondutor.Condutor", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cnh")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(18)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("TBCondutor");
                });

            modelBuilder.Entity("Locadora.Dominio.ModuloFuncionario.Funcionario", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Administrador")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("date");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TBFuncionario");
                });

            modelBuilder.Entity("Locadora.Dominio.ModuloGrupoDeVeiculo.GrupoVeiculo", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TBGrupoVeiculo");
                });

            modelBuilder.Entity("Locadora.Dominio.ModuloPlanoCobranca.PlanoCobranca", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ControladoDiaria")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ControladoLimiteKm")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ControladoPorKm")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DiarioDiaria")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DiarioPorKm")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("GrupoVeiculoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("LivreDiaria")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("GrupoVeiculoId")
                        .IsUnique();

                    b.ToTable("TbPlanoCobranca");
                });

            modelBuilder.Entity("Locadora.Dominio.ModuloTaxa.Taxa", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("TipoDeCalculo")
                        .HasColumnType("int");

                    b.Property<decimal?>("Valor")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("TBTaxa");
                });

            modelBuilder.Entity("Locadora.Dominio.ModuloCarro.Veiculo", b =>
                {
                    b.HasOne("Locadora.Dominio.ModuloGrupoDeVeiculo.GrupoVeiculo", "GrupoDeVeiculo")
                        .WithMany()
                        .HasForeignKey("GrupoDeVeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GrupoDeVeiculo");
                });

            modelBuilder.Entity("Locadora.Dominio.ModuloCondutor.Condutor", b =>
                {
                    b.HasOne("Locadora.Dominio.ModuloCliente.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Locadora.Dominio.ModuloPlanoCobranca.PlanoCobranca", b =>
                {
                    b.HasOne("Locadora.Dominio.ModuloGrupoDeVeiculo.GrupoVeiculo", "GrupoVeiculo")
                        .WithOne()
                        .HasForeignKey("Locadora.Dominio.ModuloPlanoCobranca.PlanoCobranca", "GrupoVeiculoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("GrupoVeiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
