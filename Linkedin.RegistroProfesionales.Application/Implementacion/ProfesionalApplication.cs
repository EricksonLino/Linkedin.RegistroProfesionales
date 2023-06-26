using AutoMapper;
using Linkedin.RegistroProfesionales.Application.Dtos;
using Linkedin.RegistroProfesionales.Application.Interfaces;
using Linkedin.RegistroProfesionales.Repository.Interfaces;

namespace Linkedin.RegistroProfesionales.Application.Implementacion
{
    public class ProfesionalApplication : IProfesionalApplication
    {
        private readonly IProfesionalRepository profesionalRepository;
        private readonly IMapper mapper;

        public ProfesionalApplication(IProfesionalRepository profesionalRepository, IMapper mapper)
        {
            this.profesionalRepository = profesionalRepository;
            this.mapper = mapper;
        }
        public async Task<List<ProfesionalDto>> ListarProfesionales()
        {
            var profesionales = await profesionalRepository.ListarProfesionales();
            var profecionalDto = mapper.Map<List<ProfesionalDto>>(profesionales);
            return profecionalDto;
        }

        public async Task<ProfesionalDetalleDto> ObtenerProfesionalPorId(int id)
        {
            var profesional = await profesionalRepository.ObtenerProfesionalPorId(id);
            var profesionalDetalleDto = mapper.Map<ProfesionalDetalleDto>(profesional);
            return profesionalDetalleDto;
        }

        public async Task<List<ExperienciaDto>> ObtenerExperienciasPorProfesionalId(int id)
        {
            var experiencias = await profesionalRepository.ObtenerExperienciasPorProfesionalId(id);
            var experienciaDto = mapper.Map<List<ExperienciaDto>>(experiencias);
            return experienciaDto;
        }
    }

}
