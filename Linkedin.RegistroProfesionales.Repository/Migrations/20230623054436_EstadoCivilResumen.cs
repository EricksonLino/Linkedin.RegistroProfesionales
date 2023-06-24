using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linkedin.RegistroProfesionales.Repository.Migrations
{
    /// <inheritdoc />
    public partial class EstadoCivilResumen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "Profesionales");

            migrationBuilder.RenameColumn(
                name: "DNI",
                table: "Profesionales",
                newName: "Dni");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Profesionales",
                newName: "Nombres");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Profesionales",
                newName: "Apellidos");

            migrationBuilder.RenameColumn(
                name: "NombreDeEmpresa",
                table: "Experiencias",
                newName: "NombreEmpresa");

            migrationBuilder.AddColumn<string>(
                name: "Resumen",
                table: "Profesionales",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Funciones",
                table: "Experiencias",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resumen",
                table: "Profesionales");

            migrationBuilder.RenameColumn(
                name: "Dni",
                table: "Profesionales",
                newName: "DNI");

            migrationBuilder.RenameColumn(
                name: "Nombres",
                table: "Profesionales",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Apellidos",
                table: "Profesionales",
                newName: "Apellido");

            migrationBuilder.RenameColumn(
                name: "NombreEmpresa",
                table: "Experiencias",
                newName: "NombreDeEmpresa");

            migrationBuilder.AddColumn<string>(
                name: "EstadoCivil",
                table: "Profesionales",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Funciones",
                table: "Experiencias",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 5000);
        }
    }
}
