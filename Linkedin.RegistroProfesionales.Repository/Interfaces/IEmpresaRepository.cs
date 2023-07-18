using Linkedin.RegistroProfesionales.Entity;

namespace Linkedin.RegistroProfesionales.Repository.Interfaces
{
    public interface IEmpresaRepository
    {
        Task<List<Empresa>> ListarEmpresas();
        Task<Empresa> ObtenerPorId(int id);
        Task InsertarEmpresa(Empresa empresa);
        Task ActualizarEmpresa(Empresa empresa);
        Task EliminarEmpresa(Empresa empresa);
    }
}
