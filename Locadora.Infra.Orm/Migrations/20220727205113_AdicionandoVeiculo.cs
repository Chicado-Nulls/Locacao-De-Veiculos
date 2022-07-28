using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.Infra.Orm.Migrations
{
    public partial class AdicionandoVeiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Placa = table.Column<string>(type: "varchar(100)", nullable: false),
                    Marca = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cor = table.Column<string>(type: "varchar(100)", nullable: false),
                    CapacidadeTanque = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    KmPercorrido = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TipoDeCombustivel = table.Column<int>(type: "int", nullable: false),
                    GrupoDeVeiculoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculo_TBGrupoVeiculo_GrupoDeVeiculoId",
                        column: x => x.GrupoDeVeiculoId,
                        principalTable: "TBGrupoVeiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_GrupoDeVeiculoId",
                table: "Veiculo",
                column: "GrupoDeVeiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculo");
        }
    }
}
