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
    }
}
