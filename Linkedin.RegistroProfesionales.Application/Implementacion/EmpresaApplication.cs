using Linkedin.RegistroProfesionales.Application.Dtos;
using Linkedin.RegistroProfesionales.Application.Interfaces;
using Linkedin.RegistroProfesionales.Repository.Interfaces;

namespace Linkedin.RegistroProfesionales.Application.Implementacion
{
    public class EmpresaApplication : IEmpresaApplication
    {
        private readonly IEmpresaRepository empresaRepository;

        public EmpresaApplication(IEmpresaRepository empresaRepository)
        {
            this.empresaRepository = empresaRepository;
        }
        public async Task<List<EmpresaDto>> ListarEmpresas()
        {
            var empresas = await empresaRepository.ListarEmpresas();
            
            var empresasDto = new List<EmpresaDto>();
            foreach (var item in empresas)
            {
                var empresaDto = new EmpresaDto();
                empresaDto.Id = item.Id;
                empresaDto.Nombre = item.Nombre;
                empresaDto.Ruc = item.Ruc;
                
                empresasDto.Add(empresaDto);                
            }
             return empresasDto;
        }

        public async Task<EmpresaDto> ObtenerPorId(int id)
        {
            var empresa = await empresaRepository.ObtenerPorId(id);

            var empresaDto = new EmpresaDto();
            empresaDto.Id = empresa.Id;
            empresaDto.Nombre = empresa.Nombre;
            empresaDto.Ruc = empresa.Ruc;
            
            return empresaDto;
        }
    }
}
