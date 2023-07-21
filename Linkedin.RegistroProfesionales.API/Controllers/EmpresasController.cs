using Linkedin.RegistroProfesionales.Application.Dtos;
using Linkedin.RegistroProfesionales.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Linkedin.RegistroProfesionales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        private readonly IEmpresaApplication empresaApplication;

        public EmpresasController(IEmpresaApplication empresaApplication)
        {
            this.empresaApplication = empresaApplication;
        }

        [HttpGet]
        public async Task<ActionResult<List<EmpresaDto>>> ListarEmpresas()
        {
            var empresas = await empresaApplication.ListarEmpresas();
            return empresas;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmpresaDto>> ObtenerPorId(int id)
        {
            var empresa = await empresaApplication.ObtenerPorId(id);
            return empresa;
        }

        [HttpPost]
        public async Task<ActionResult> Instertar([FromBody] CrearEmpresaDto crearEmpresaDto)
        {
            await empresaApplication.CrearEmpresa(crearEmpresaDto);
            return Ok();
        }
    }
}
