using AutoMapper;
using Linkedin.RegistroProfesionales.Application.Dtos;
using Linkedin.RegistroProfesionales.Application.Interfaces;
using Linkedin.RegistroProfesionales.Entity;
using Linkedin.RegistroProfesionales.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.Query;
using System.Security.Cryptography.X509Certificates;

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

        public async Task<ProfesionalDetalleDto> ObtenerDetalleProfesional(int id)
        {
            var profesional = await profesionalRepository.ObtenerProfesionalPorId(id);
            var experiencias = await profesionalRepository.ObtenerExperienciasPorProfesionalId(id);//id del profesional

            //creación del Dto general
            var profesionalDetalleDto = new ProfesionalDetalleDto();

            //creación de DatosGeneralesDto y lo llenamos con data de la entidad profesional
            var datosGeneralesDto = new DatosGeneralesDto();
            datosGeneralesDto.Id = profesional.Id;
            datosGeneralesDto.Dni = profesional.Dni;
            datosGeneralesDto.Nombres = profesional.Nombres;
            datosGeneralesDto.Apellidos = profesional.Apellidos;

            //creación de List<ExperienciaDto> y lo llenamos con data de experiencias
            var experienciasDto = mapper.Map<List<ExperienciaDto>>(experiencias);




            //agregamos los Dtos obtenidos al Dto general
            profesionalDetalleDto.DatosGenerales = datosGeneralesDto;
            profesionalDetalleDto.Experiencias = experienciasDto;

            return profesionalDetalleDto;
        }
    }

}
