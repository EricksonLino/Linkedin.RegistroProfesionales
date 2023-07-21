using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin.RegistroProfesionales.Application.Dtos
{
    public class EmpresaDto
    {
        public int Id { get; set; }
        public string Ruc { get; set; }
        public string Nombre { get; set; }
    }
}
