using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.Infra.Orm.Migrations
{
    public partial class Correcao_plano_cobranca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.CreateTable(
                name: "TbPlanoCobranca",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GrupoveiculoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_TbPlanoCobranca_TBGrupoVeiculo_GrupoveiculoId",
                        column: x => x.GrupoveiculoId,
                        principalTable: "TBGrupoVeiculo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbPlanoCobranca_GrupoveiculoId",
                table: "TbPlanoCobranca",
                column: "GrupoveiculoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbPlanoCobranca");

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapacidadeTanque = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    GrupoDeVeiculoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KmPercorrido = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDeCombustivel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_GrupoDeVeiculoId",
                table: "Veiculo",
                column: "GrupoDeVeiculoId");
        }
    }
}
