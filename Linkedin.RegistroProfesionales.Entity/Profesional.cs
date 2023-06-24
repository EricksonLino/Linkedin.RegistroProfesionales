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
        [StringLength(8)]
        public string Dni { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }
        [Required]
        [StringLength(80)]
        public string Apellidos { get; set; }
        [Required]
        [StringLength(70)]
        public string Perfil { get; set; }
        [Required]
        [StringLength(5000)]
        public string Resumen { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public bool Genero { get; set; }
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
