using Linkedin.RegistroProfesionales.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin.RegistroProfesionales.Application.Dtos
{
    public class ProfesionalDto
    {
        
        public int Id { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Perfil { get; set; }
        
        public List<Experiencia> Experiencias { get; set; }
    }
}
