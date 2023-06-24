using Linkedin.RegistroProfesionales.Entity;

namespace Linkedin.RegistroProfesionales.Repository.Interfaces
{
    public interface IProfesionalRepository
    {
        Task<List<Profesional>> ListarProfesionales();

    }
}
