using Linkedin.RegistroProfesionales.Application.Dtos;
using Linkedin.RegistroProfesionales.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Linkedin.RegistroProfesionales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly ICursoApplication cursoApplication;

        public CursosController(ICursoApplication cursoApplication)
        {
            this.cursoApplication = cursoApplication;
        }

        [HttpGet]
        public async Task<ActionResult<List<CursoDto>>> ListarCursos()
        {
            var cursos = await cursoApplication.ListarCursos();
            return cursos;
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<CursoDto>> ObtenerCurso(int id)
        {
            var curso = await cursoApplication.ObtenerCurso(id);
            return curso;
        }

        [HttpPost]
        public async Task<ActionResult> Insertar([FromBody] CrearCursoDto crearCursoDto)
        {
            await cursoApplication.InsertarCurso(crearCursoDto);
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Editar(int id, [FromBody] EditarCursoDto editarCursoDto)
        {
            await cursoApplication.EditarCurso(id, editarCursoDto);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Eliminar(int id)
        {
            await cursoApplication.EliminarCurso(id);
            return Ok();
        }
    }
}
