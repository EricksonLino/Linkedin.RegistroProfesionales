using Linkedin.RegistroProfesionales.Entity;
using Linkedin.RegistroProfesionales.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Linkedin.RegistroProfesionales.Repository.Implementacion
{
    public class ProfesionalRepository : IProfesionalRepository
    {
        private readonly ApplicationDbContext context;

        public ProfesionalRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Profesional>> ListarProfesionales()
        {
            var profesionales = await context.Profesionales.ToListAsync();
            return profesionales;
        }

        public async Task<Profesional> ObtenerProfesionalPorId(int id)
        {
            var profesional = await context.Profesionales.FirstOrDefaultAsync(x => x.Id == id);
            return profesional;
        }

        public async Task<List<Experiencia>> ObtenerExperienciasPorProfesionalId(int id)
        {
            var experiencias = await context.Experiencias.Where(x => x.ProfesionalId == id).ToListAsync();
            return experiencias;
        }

        public async Task<List<Curso>> ObtenerCursoPorProfesionalId(int id)
        {
            var profesionalesCursos = await context.ProfesionalesCursos.Include(x => x.Curso).Where(x => x.ProfesionalId == id).ToListAsync();
            return profesionalesCursos.Select(x => x.Curso).ToList();
        }
    }
}
