using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.Infra.Orm.Migrations
{
    public partial class ArrumandoTbVeiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_TBGrupoVeiculo_GrupoDeVeiculoId",
                table: "Veiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veiculo",
                table: "Veiculo");

            migrationBuilder.RenameTable(
                name: "Veiculo",
                newName: "TbVeiculo");

            migrationBuilder.RenameIndex(
                name: "IX_Veiculo_GrupoDeVeiculoId",
                table: "TbVeiculo",
                newName: "IX_TbVeiculo_GrupoDeVeiculoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TbVeiculo",
                table: "TbVeiculo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbVeiculo_TBGrupoVeiculo_GrupoDeVeiculoId",
                table: "TbVeiculo",
                column: "GrupoDeVeiculoId",
                principalTable: "TBGrupoVeiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbVeiculo_TBGrupoVeiculo_GrupoDeVeiculoId",
                table: "TbVeiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TbVeiculo",
                table: "TbVeiculo");

            migrationBuilder.RenameTable(
                name: "TbVeiculo",
                newName: "Veiculo");

            migrationBuilder.RenameIndex(
                name: "IX_TbVeiculo_GrupoDeVeiculoId",
                table: "Veiculo",
                newName: "IX_Veiculo_GrupoDeVeiculoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veiculo",
                table: "Veiculo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_TBGrupoVeiculo_GrupoDeVeiculoId",
                table: "Veiculo",
                column: "GrupoDeVeiculoId",
                principalTable: "TBGrupoVeiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
