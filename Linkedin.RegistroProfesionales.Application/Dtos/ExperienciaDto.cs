using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin.RegistroProfesionales.Application.Dtos
{
    public class ExperienciaDto
    {
        public int Id { get; set; }   
        public string NombreEmpresa { get; set; }   
        public string Cargo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public string Funciones { get; set; }
    }
}
