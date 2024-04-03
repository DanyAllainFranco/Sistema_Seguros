using AutoMapper;
using SegurosFYP.Common;
using SegurosFYP.Common.Models;
using SegurosFYP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.API.Extensions
{
    public class MappingProfileExtensions : Profile
    {
        public MappingProfileExtensions()
        {
            CreateMap<UsuarioViewModel, tbUsuarios>().ReverseMap();
            CreateMap<DepartamentoViewModel, tbDepartamentos>().ReverseMap();
            CreateMap<DepartamentoViewModel, tbPersonas>().ReverseMap();
            CreateMap<DepartamentoViewModel, tbInformacionMedica>().ReverseMap();
            CreateMap<DepartamentoViewModel, tbTiposPlanes>().ReverseMap();
            CreateMap<DepartamentoViewModel, tbIdentificaciones>().ReverseMap();

        }
    }
}
