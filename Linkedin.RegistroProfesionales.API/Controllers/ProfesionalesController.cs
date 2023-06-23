using Linkedin.RegistroProfesionales.Application.Dtos;
using Linkedin.RegistroProfesionales.Application.Interfaces;
using Microsoft.AspNetCore.Http;
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
    }
}
