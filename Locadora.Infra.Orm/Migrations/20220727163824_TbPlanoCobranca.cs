using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.Infra.Orm.Migrations
{
    public partial class TbPlanoCobranca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GrupoVeiculo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoVeiculo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbPlanoCobranca",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GrupoVeiculoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiarioDiaria = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiarioPorKm = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LivreDiaria = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ControladoDiaria = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ControladoPorKm = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ControladoLimiteKm = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbPlanoCobranca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbPlanoCobranca_GrupoVeiculo_GrupoVeiculoId",
                        column: x => x.GrupoVeiculoId,
                        principalTable: "GrupoVeiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapacidadeTanque = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    KmPercorrido = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TipoDeCombustivel = table.Column<int>(type: "int", nullable: false),
                    GrupoDeVeiculoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculo_GrupoVeiculo_GrupoDeVeiculoId",
                        column: x => x.GrupoDeVeiculoId,
                        principalTable: "GrupoVeiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbPlanoCobranca_GrupoVeiculoId",
                table: "TbPlanoCobranca",
                column: "GrupoVeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_GrupoDeVeiculoId",
                table: "Veiculo",
                column: "GrupoDeVeiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbPlanoCobranca");

            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "GrupoVeiculo");
        }
    }
}
