namespace Linkedin.RegistroProfesionales.Application.Dtos
{
    public class ProfesionalDetalleDto
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Perfil { get; set; }
        public string Resumen { get; set; }     
        public DateTime FechaNacimiento { get; set; }
        public bool Genero { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
    }
}
