using System.ComponentModel.DataAnnotations;

namespace Linkedin.RegistroProfesionales.Entity
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(11)]
        public string Ruc { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(70)]
        public string Direccion { get; set; }
    }
}
