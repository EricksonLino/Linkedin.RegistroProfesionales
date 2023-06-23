﻿using AutoMapper;
using Linkedin.RegistroProfesionales.Application.Dtos;
using Linkedin.RegistroProfesionales.Entity;

namespace Linkedin.RegistroProfesionales.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Profesional, ProfesionalDto>();
            
        }
    }
}