using Linkedin.RegistroProfesionales.Application.Dtos;

namespace Linkedin.RegistroProfesionales.Application.Interfaces
{
    public interface ICursoApplication
    {
        Task<List<CursoDto>> ListarCursos();
        Task<CursoDto> ObtenerCurso(int id);
        Task InsertarCurso(CrearCursoDto crearCursoDto);
        Task EditarCurso(int id, EditarCursoDto editarCursoDto);
        Task EliminarCurso(int id);


    }
}
