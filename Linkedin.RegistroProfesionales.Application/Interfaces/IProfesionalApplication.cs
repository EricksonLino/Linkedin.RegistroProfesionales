using Linkedin.RegistroProfesionales.Application.Dtos;

namespace Linkedin.RegistroProfesionales.Application.Interfaces
{
    public interface IProfesionalApplication
    {
        Task<List<ProfesionalDto>> ListarProfesionales();
        Task<ProfesionalDetalleDto> ObtenerProfesionalPorId(int id);
        Task<List<ExperienciaDto>> ObtenerExperienciasPorProfesionalId(int id);
    }
}
