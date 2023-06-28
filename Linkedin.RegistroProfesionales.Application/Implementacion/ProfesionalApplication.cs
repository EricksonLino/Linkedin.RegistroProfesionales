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
            //this.mapper = mapper;
        }
        public async Task<List<ProfesionalDto>> ListarProfesionales()
        {
            var profesionales = await profesionalRepository.ListarProfesionales();
            //var profesionalDto = mapper.Map<List<ProfesionalDto>>(profesionales);
            var profesionalesDto = new List<ProfesionalDto>();
            foreach (var item in profesionales)
            {
                var profesionalDto = new ProfesionalDto();
                profesionalDto.Id = item.Id;
                profesionalDto.Dni = item.Dni;
                profesionalDto.Nombres = item.Nombres;
                profesionalDto.Apellidos = item.Apellidos;
                profesionalDto.Perfil = item.Perfil;

                profesionalesDto.Add(profesionalDto);
            }
            return profesionalesDto;
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
            datosGeneralesDto.Perfil = profesional.Perfil;
            datosGeneralesDto.Resumen = profesional.Resumen;
            datosGeneralesDto.FechaNacimiento = profesional.FechaNacimiento;
            datosGeneralesDto.Genero = profesional.Genero;
            datosGeneralesDto.Telefono = profesional.Telefono;
            datosGeneralesDto.Correo = profesional.Correo;
            datosGeneralesDto.Direccion = profesional.Direccion;


            //creación de List<ExperienciaDto> y lo llenamos con data de experiencias
            //var experienciasDto = mapper.Map<List<ExperienciaDto>>(experiencias);
            var experienciasDto = new List<ExperienciaDto>();
            foreach (var item in experiencias)
            {
                var experienciaDto = new ExperienciaDto();
                experienciaDto.Id = item.Id;
                experienciaDto.Nombre = item.Nombre;
                experienciaDto.Cargo = item.Cargo;
                experienciaDto.FechaInicio = item.FechaInicio;
                experienciaDto.FechaFinalizacion = item.FechaFinalizacion;
                experienciaDto.Funciones = item.Funciones;

                experienciasDto.Add(experienciaDto);
            }

            //agregamos los Dtos obtenidos al Dto general
            profesionalDetalleDto.DatosGenerales = datosGeneralesDto;
            profesionalDetalleDto.Experiencias = experienciasDto;

            return profesionalDetalleDto;
        }
    }

}
