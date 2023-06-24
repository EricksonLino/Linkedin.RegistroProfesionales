using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin.RegistroProfesionales.Entity
{
    public class Curso
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(150)]
        public string NombreCurso { get; set; }
        [Required]
        [StringLength(200)]
        public string Institucion { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFinalizacion { get; set; }
        public List<ProfesionalCurso> ProfesionalCurso { get; set; }
    }
}
