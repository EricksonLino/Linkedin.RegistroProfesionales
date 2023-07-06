using Linkedin.RegistroProfesionales.Entity;

namespace Linkedin.RegistroProfesionales.Repository.Interfaces
{
    public interface ICursoRepository
    {
        Task<List<Curso>> ListarCursos();
        Task<Curso> ObtenerCurso(int id);
        Task InsertarCurso(Curso curso);
        Task EditarCurso(Curso curso);
        Task EliminarCurso(Curso curso);
    }
}
