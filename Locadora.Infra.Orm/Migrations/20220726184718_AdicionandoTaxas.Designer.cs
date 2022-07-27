﻿// <auto-generated />
using System;
using Locadora.Infra.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Locadora.Infra.Orm.Migrations
{
    [DbContext(typeof(LocadoraVeiculoDbContext))]
    [Migration("20220726184718_AdicionandoTaxas")]
    partial class AdicionandoTaxas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
#pragma warning restore 612, 618
        }
    }
}