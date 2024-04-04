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
            service.AddScoped<DepartamentoRepository>();
            service.AddScoped<PolizaRepository>();
            service.AddScoped<InformacionMedicaRepository>();
            service.AddScoped<PersonaRepository>();
            service.AddScoped<IdentificacionRepository>();
            service.AddScoped<TipoPlanRepository>();


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
