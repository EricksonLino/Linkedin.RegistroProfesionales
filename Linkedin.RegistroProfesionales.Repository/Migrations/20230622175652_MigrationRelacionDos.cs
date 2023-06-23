using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linkedin.RegistroProfesionales.Repository.Migrations
{
    /// <inheritdoc />
    public partial class MigrationRelacionDos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Perfil",
                table: "Profesionales",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Experiencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDeEmpresa = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Funciones = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ProfesionalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiencias_Profesionales_ProfesionalId",
                        column: x => x.ProfesionalId,
                        principalTable: "Profesionales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Experiencias_ProfesionalId",
                table: "Experiencias",
                column: "ProfesionalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiencias");

            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "Profesionales");
        }
    }
}
