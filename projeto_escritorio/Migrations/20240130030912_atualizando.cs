using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_escritorio.Migrations
{
    public partial class atualizando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Divida_Clientes_ClienteId",
                table: "Divida");

            migrationBuilder.DropForeignKey(
                name: "FK_Divida_Lojas_LojaId",
                table: "Divida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Divida",
                table: "Divida");

            migrationBuilder.RenameTable(
                name: "Divida",
                newName: "Dividas");

            migrationBuilder.RenameIndex(
                name: "IX_Divida_LojaId",
                table: "Dividas",
                newName: "IX_Dividas_LojaId");

            migrationBuilder.RenameIndex(
                name: "IX_Divida_ClienteId",
                table: "Dividas",
                newName: "IX_Dividas_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dividas",
                table: "Dividas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dividas_Clientes_ClienteId",
                table: "Dividas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dividas_Lojas_LojaId",
                table: "Dividas",
                column: "LojaId",
                principalTable: "Lojas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dividas_Clientes_ClienteId",
                table: "Dividas");

            migrationBuilder.DropForeignKey(
                name: "FK_Dividas_Lojas_LojaId",
                table: "Dividas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dividas",
                table: "Dividas");

            migrationBuilder.RenameTable(
                name: "Dividas",
                newName: "Divida");

            migrationBuilder.RenameIndex(
                name: "IX_Dividas_LojaId",
                table: "Divida",
                newName: "IX_Divida_LojaId");

            migrationBuilder.RenameIndex(
                name: "IX_Dividas_ClienteId",
                table: "Divida",
                newName: "IX_Divida_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Divida",
                table: "Divida",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Divida_Clientes_ClienteId",
                table: "Divida",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Divida_Lojas_LojaId",
                table: "Divida",
                column: "LojaId",
                principalTable: "Lojas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
