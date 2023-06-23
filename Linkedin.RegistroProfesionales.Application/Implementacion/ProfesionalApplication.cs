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
    }

}
