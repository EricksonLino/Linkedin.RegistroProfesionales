using Linkedin.RegistroProfesionales.Application.Dtos;
using Linkedin.RegistroProfesionales.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Linkedin.RegistroProfesionales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesionalesController : ControllerBase
    {
        private readonly IProfesionalApplication profesionalApplication;

        public ProfesionalesController(IProfesionalApplication profesionalApplication)
        {
            this.profesionalApplication = profesionalApplication;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProfesionalDto>>> ListarProfesionales()
        {
            var profesionales = await profesionalApplication.ListarProfesionales();
            return profesionales;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProfesionalDetalleDto>> ObtenerDetalleProfesional(int id)
        {
            var profesional = await profesionalApplication.ObtenerDetalleProfesional(id);
            if (profesional == null)
            {
                return NotFound($"No se encontro el ID {id}");
            }
            return profesional;
        }
    }
}
