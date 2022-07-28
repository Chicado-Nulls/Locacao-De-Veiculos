using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.Infra.Orm.Migrations
{
    public partial class deleteBehavior : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbVeiculo_TBGrupoVeiculo_GrupoDeVeiculoId",
                table: "TbVeiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_TbVeiculo_TBGrupoVeiculo_GrupoDeVeiculoId",
                table: "TbVeiculo",
                column: "GrupoDeVeiculoId",
                principalTable: "TBGrupoVeiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbVeiculo_TBGrupoVeiculo_GrupoDeVeiculoId",
                table: "TbVeiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_TbVeiculo_TBGrupoVeiculo_GrupoDeVeiculoId",
                table: "TbVeiculo",
                column: "GrupoDeVeiculoId",
                principalTable: "TBGrupoVeiculo",
                principalColumn: "Id");
        }
    }
}
