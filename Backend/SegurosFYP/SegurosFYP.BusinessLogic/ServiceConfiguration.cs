using Microsoft.Extensions.DependencyInjection;
using SegurosFYP.DataAccess;
using SegurosFYP.BusinessLogic.Services;
using System;
using SegurosFYP.DataAccess.Repository;

namespace SegurosFYP.BusinessLogic
{
    public static class ServiceConfiguration
    {
        public static void DataAccess(this IServiceCollection service, string conn)
        {
            service.AddScoped<UsuarioRepository>();
            service.AddScoped<EstadoCivilRepository>();
            service.AddScoped<DepartamentoRepository>();
            service.AddScoped<PolizaRepository>();
            service.AddScoped<InformacionMedicaRepository>();
            service.AddScoped<EmpleadoRepository>();
            service.AddScoped<PersonaRepository>();
            service.AddScoped<IdentificacionRepository>();
            service.AddScoped<TipoPlanRepository>();
            service.AddScoped<EnfermedadRepository>();
            service.AddScoped<FrecuenciaRepository>();
            service.AddScoped<MunicipioRepository>();
            service.AddScoped<PaisRepository>();
            service.AddScoped<ParentescoRepository>();
            service.AddScoped<TipoArticuloMedicoRepository>();
            service.AddScoped<TiposIdentificacionesRepository>();
            service.AddScoped<CargoRepository>();
            service.AddScoped<CausaAtencionMedicaRepository>();
            service.AddScoped<CoberturaRepository>();
            service.AddScoped<UnidadRepository>();

            SegurosFYPContext.BuildConnectionString(conn);
        }
        public static void BusinessLogic(this IServiceCollection service)
        {
            service.AddScoped<AccessServices>();
            service.AddScoped<GeneralServices>();
            service.AddScoped<SalesServices>();
            service.AddScoped<InsuranceServices>();
        }
    }
}
