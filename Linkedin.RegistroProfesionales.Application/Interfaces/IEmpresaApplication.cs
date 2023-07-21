using Linkedin.RegistroProfesionales.Application.Dtos;
using Linkedin.RegistroProfesionales.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin.RegistroProfesionales.Application.Interfaces
{
    public interface IEmpresaApplication
    {
        Task<List<EmpresaDto>> ListarEmpresas();
        Task<EmpresaDto> ObtenerPorId(int id);
        Task CrearEmpresa (CrearEmpresaDto crearEmpresaDto);
        Task EditarEmpresa(int id, EditarEmpresaDto editarEmpresaDto);
        Task EliminarEmpresa(int id);

    }
}
