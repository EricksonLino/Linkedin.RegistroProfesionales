namespace Linkedin.RegistroProfesionales.Application.Dtos
{
    public class ProfesionalDetalleDto
    {
        public DatosGeneralesDto DatosGenerales { get; set; }
        public List<ExperienciaDto> Experiencias { get; set;}
        public List<CursoDto> Cursos { get; set; }
    }
}
