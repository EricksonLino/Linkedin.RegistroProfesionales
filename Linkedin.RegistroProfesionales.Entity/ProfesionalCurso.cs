using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin.RegistroProfesionales.Entity
{
    public class ProfesionalCurso
    {
        public int ProfesionalId { get; set; }
        public int CursoId { get; set; }
        public Profesional Profesional { get; set; }
        public Curso Curso { get; set; }
    }
}
