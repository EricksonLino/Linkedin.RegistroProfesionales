﻿using Linkedin.RegistroProfesionales.Application.Dtos;
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

    }
}