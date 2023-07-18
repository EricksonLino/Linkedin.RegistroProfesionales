using Linkedin.RegistroProfesionales.Entity;
using Linkedin.RegistroProfesionales.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Linkedin.RegistroProfesionales.Repository.Implementacion
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public EmpresaRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<List<Empresa>> ListarEmpresas()
        {
            var empresas = await applicationDbContext.Empresas.ToListAsync();
            return empresas;
        }

        public async Task<Empresa> ObtenerPorId(int id)
        {
            var empresa = await applicationDbContext.Empresas.FirstOrDefaultAsync(x => x.Id == id);
            return empresa;
        }
        public async Task InsertarEmpresa(Empresa empresa)
        {
            applicationDbContext.Empresas.Add(empresa);
            await applicationDbContext.SaveChangesAsync();
        }
        public async Task ActualizarEmpresa(Empresa empresa)
        {
            applicationDbContext.Empresas.Update(empresa);
            await applicationDbContext.SaveChangesAsync();
        }
        public async Task EliminarEmpresa(Empresa empresa)
        {
           applicationDbContext.Empresas.Remove(empresa);
            await applicationDbContext.SaveChangesAsync();
        }      
    }
}
