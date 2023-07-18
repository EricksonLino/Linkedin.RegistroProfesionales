using Linkedin.RegistroProfesionales.Entity;
using Microsoft.EntityFrameworkCore;

namespace Linkedin.RegistroProfesionales.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //apifluente de entityframework core / generando las llaves compuestas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProfesionalCurso>() // la entidad ProfesionalCurso va aterner una nueva llave 
                .HasKey(x => new {x.ProfesionalId, x.CursoId}); //una llave primaria compuesta por profesional id y curso id
        }

        public DbSet<Profesional> Profesionales { get; set; }
        public DbSet<Experiencia> Experiencias { get; set;}
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<ProfesionalCurso> ProfesionalesCursos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
    }
}

