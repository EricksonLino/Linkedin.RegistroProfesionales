using Linkedin.RegistroProfesionales.Entity;

namespace Linkedin.RegistroProfesionales.Repository.Interfaces
{
    public interface IProfesionalRepository
    {
        Task<List<Profesional>> ListarProfesionales();
        Task<Profesional> ObtenerProfesionalPorId(int id);
        Task<List<Experiencia>> ObtenerExperienciasPorProfesionalId(int id);
        //Task<List<Curso>> ObtenerCursoPorProfesionalId(int id);
    }
}
