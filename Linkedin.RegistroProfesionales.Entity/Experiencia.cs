using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin.RegistroProfesionales.Entity
{
    public class Experiencia
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string NombreDeEmpresa { get; set; }
        [Required]
        [StringLength(50)]
        public string Cargo { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFinalizacion { get; set; }
        [Required]
        [StringLength(500)]
        public string Funciones { get; set; }
        public int ProfesionalId { get; set; }
        public Profesional Profesional { get; set; }
    }
}
