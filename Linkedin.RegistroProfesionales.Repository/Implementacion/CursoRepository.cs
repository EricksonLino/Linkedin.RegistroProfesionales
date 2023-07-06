using Linkedin.RegistroProfesionales.Entity;
using Linkedin.RegistroProfesionales.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Linkedin.RegistroProfesionales.Repository.Implementacion
{
    public class CursoRepository: ICursoRepository
    {
        private readonly ApplicationDbContext context;

        public CursoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Curso>> ListarCursos()
        {
            var cursos = await context.Cursos.ToListAsync();
            return cursos;
        }

        public async Task<Curso> ObtenerCurso(int id)
        {
            var curso = await context.Cursos.SingleOrDefaultAsync(x => x.Id == id);
            return curso;
        }
        public async Task InsertarCurso(Curso curso)
        {
            context.Cursos.Add(curso);
            await context.SaveChangesAsync();
        }

        public async Task EditarCurso(Curso curso)
        {
            context.Cursos.Update(curso);
            await context.SaveChangesAsync();
        }

        public async Task EliminarCurso(Curso curso)
        {
            context.Cursos.Remove(curso);
            await context.SaveChangesAsync();
        }

        
    }
}
