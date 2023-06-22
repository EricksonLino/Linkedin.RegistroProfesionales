using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin.RegistroProfesionales.Entity
{
    public class Profesional
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(80)]
        public string Apellido { get; set; }
        [Required]
        [StringLength(8)]
        public string DNI { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public bool Genero { get; set; }
        [Required]
        [StringLength(50)]
        public string EstadoCivil { get; set; }
        [Required]
        [StringLength(15)]
        public string Telefono { get; set; }
        [Required]
        [StringLength(100)]
        public string Correo { get; set; }
        [Required]
        [StringLength(100)]
        public string Direccion { get; set; }
        public List<Experiencia> Experiencias { get; set;}
        
    }
}
