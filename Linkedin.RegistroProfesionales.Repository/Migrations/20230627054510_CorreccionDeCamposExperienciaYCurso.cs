using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linkedin.RegistroProfesionales.Repository.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionDeCamposExperienciaYCurso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreEmpresa",
                table: "Experiencias",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Cursos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NombreCurso",
                table: "Cursos",
                newName: "Nombre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Experiencias",
                newName: "NombreEmpresa");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cursos",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Cursos",
                newName: "NombreCurso");
        }
    }
}
