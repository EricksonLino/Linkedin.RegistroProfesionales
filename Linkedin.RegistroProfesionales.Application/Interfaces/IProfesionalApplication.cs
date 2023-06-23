using Linkedin.RegistroProfesionales.Application.Dtos;

namespace Linkedin.RegistroProfesionales.Application.Interfaces
{
    public interface IProfesionalApplication
    {
        Task<List<ProfesionalDto>> ListarProfesionales();
    }
}
