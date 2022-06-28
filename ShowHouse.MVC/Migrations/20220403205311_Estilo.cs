using Microsoft.EntityFrameworkCore.Migrations;

namespace MVChallenge.Migrations
{
    public partial class Estilo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Estilo_EstiloId",
                table: "Eventos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estilo",
                table: "Estilo");

            migrationBuilder.RenameTable(
                name: "Estilo",
                newName: "Estilos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estilos",
                table: "Estilos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Estilos_EstiloId",
                table: "Eventos",
                column: "EstiloId",
                principalTable: "Estilos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Estilos_EstiloId",
                table: "Eventos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estilos",
                table: "Estilos");

            migrationBuilder.RenameTable(
                name: "Estilos",
                newName: "Estilo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estilo",
                table: "Estilo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Estilo_EstiloId",
                table: "Eventos",
                column: "EstiloId",
                principalTable: "Estilo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
