using Microsoft.EntityFrameworkCore.Migrations;

namespace SafetyComeback.App.Persistencia.Migrations
{
    public partial class Oct_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clases_Clases_ClaseId",
                table: "Clases");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Programas_ProgramaId1",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_ProgramaId1",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Clases_ClaseId",
                table: "Clases");

            migrationBuilder.DropColumn(
                name: "ProgramaId1",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "ClaseId",
                table: "Clases");

            migrationBuilder.AlterColumn<string>(
                name: "Dependencia",
                table: "Personas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Dependencia",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProgramaId1",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClaseId",
                table: "Clases",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_ProgramaId1",
                table: "Personas",
                column: "ProgramaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Clases_ClaseId",
                table: "Clases",
                column: "ClaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clases_Clases_ClaseId",
                table: "Clases",
                column: "ClaseId",
                principalTable: "Clases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Programas_ProgramaId1",
                table: "Personas",
                column: "ProgramaId1",
                principalTable: "Programas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
