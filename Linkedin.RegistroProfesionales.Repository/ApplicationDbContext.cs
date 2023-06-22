using Linkedin.RegistroProfesionales.Entity;
using Microsoft.EntityFrameworkCore;

namespace Linkedin.RegistroProfesionales.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Profesional> Profesionales { get; set; }
        public DbSet<Experiencia> Experiencias { get; set;}
    }
}
