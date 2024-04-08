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
            CreateMap<PersonaViewModel, tbPersonas>().ReverseMap();
            CreateMap<InformacionMedicaViewModel, tbInformacionMedica>().ReverseMap();
            CreateMap<TipoPlanViewModel, tbTiposPlanes>().ReverseMap();
            CreateMap<IdentificacionViewModel, tbIdentificaciones>().ReverseMap();
            CreateMap<PolizaViewModel, tbPolizas>().ReverseMap();
            CreateMap<EstadoCivilViewModel, tbEstadosCiviles>().ReverseMap();
            CreateMap<EnfermadViewModel,tbEnfermedades>().ReverseMap();
            CreateMap<MunicipioViewModel, tbMunicipios>().ReverseMap();
            CreateMap<PaisesViewModel, tbPaises>().ReverseMap();
            CreateMap<ParentescoViewModel, tbParentescos>().ReverseMap();
            CreateMap<TipoArticuloMedicoViewModel, tbTipoArticuloMedico>().ReverseMap();
            CreateMap<CargosViewModel, tbCargos>().ReverseMap();
            CreateMap<CausaAtencionMedicaViewModel, tbCausaAtencionMedica>().ReverseMap();
            CreateMap<CoberturaViewModel, tbCoberturas>().ReverseMap();
            CreateMap<EmpleadoViewModel, tbEmpleados>().ReverseMap();
            CreateMap<UnidadViewModel, tbUnidades>().ReverseMap();

        }
    }
}
