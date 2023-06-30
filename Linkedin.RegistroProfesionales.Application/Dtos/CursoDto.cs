using Linkedin.RegistroProfesionales.Entity;
using System.ComponentModel.DataAnnotations;

namespace Linkedin.RegistroProfesionales.Application.Dtos
{
    public class CursoDto
    {
        public int ProfesionalId { get; set; }
        public int CursoId { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Institucion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
    }
}
