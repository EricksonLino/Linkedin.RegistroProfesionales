using AutoMapper;
using Linkedin.RegistroProfesionales.Application.Dtos;
using Linkedin.RegistroProfesionales.Application.Interfaces;
using Linkedin.RegistroProfesionales.Entity;
using Linkedin.RegistroProfesionales.Repository.Interfaces;

namespace Linkedin.RegistroProfesionales.Application.Implementacion
{
    public class CursoApplication : ICursoApplication
    {
        private readonly ICursoRepository cursoRepository;
        

        public CursoApplication(ICursoRepository cursoRepository)
        {
            this.cursoRepository = cursoRepository;
            
        }

        public async Task<List<CursoDto>> ListarCursos()
        {
            var cursos = await cursoRepository.ListarCursos();
            
            var cursosDto = new List<CursoDto>();
            foreach (var item in cursos)
            {
                var cursoDto = new CursoDto();
                cursoDto.Id = item.Id;
                cursoDto.Nombre = item.Nombre;
                cursoDto.Descripcion = item.Descripcion;

                cursosDto.Add(cursoDto);
            }
            return cursosDto;
        }

        public async Task<CursoDto> ObtenerCurso(int id)
        {
            var curso = await cursoRepository.ObtenerCurso(id);
            var cursoDto = new CursoDto();
            cursoDto.Id = curso.Id;
            cursoDto.Nombre = curso.Nombre;
            cursoDto.Descripcion = curso.Descripcion;

            return cursoDto;
        }

        public async Task InsertarCurso(CrearCursoDto crearCursoDto)
        {
            var cursoEntidad = new Curso();
            //cursoEntidad.Id = crearCursoDto.Id;
            cursoEntidad.Nombre = crearCursoDto.Nombre;
            cursoEntidad.Descripcion = crearCursoDto.Descripcion;

            await cursoRepository.InsertarCurso(cursoEntidad);
        }

        public async Task EditarCurso(int id, EditarCursoDto editarCursoDto)
        {
            var cursoEntidad = await cursoRepository.ObtenerCurso(id); //utilizamos el metodo de obtenerporid
            
            cursoEntidad.Nombre = editarCursoDto.Nombre;
            cursoEntidad.Descripcion = editarCursoDto.Descripcion;

            await cursoRepository.EditarCurso(cursoEntidad);
            //var cursoEntidad = await cursoRepository.ObtenerCurso(id);
            //mapper.Map(crearCursoDto, cursoEntidad);
            //await cursoRepository.EditarCurso(cursoEntidad);
        }

        public async Task EliminarCurso(int id)
        {
            var cursoEntidad = await cursoRepository.ObtenerCurso(id);
            await cursoRepository.EliminarCurso(cursoEntidad);
        }
    }
}
