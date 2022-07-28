using Microsoft.EntityFrameworkCore.Migrations;

namespace Locadora.Infra.Orm.Migrations
{
    public partial class Correcao_map_condutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBCondutor_TbCliente_ClienteId",
                table: "TBCondutor");

            migrationBuilder.AddForeignKey(
                name: "FK_TBCondutor_TbCliente_ClienteId",
                table: "TBCondutor",
                column: "ClienteId",
                principalTable: "TbCliente",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBCondutor_TbCliente_ClienteId",
                table: "TBCondutor");

            migrationBuilder.AddForeignKey(
                name: "FK_TBCondutor_TbCliente_ClienteId",
                table: "TBCondutor",
                column: "ClienteId",
                principalTable: "TbCliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
