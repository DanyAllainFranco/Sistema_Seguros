﻿using Microsoft.Extensions.DependencyInjection;
using SegurosFYP.Services;
using SegurosFYP.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SegurosFYP
{
    public static class ServiceConfiguration
    {
        public static void SetHttpClient(this IServiceCollection service)
        {
            service.AddScoped<Cliente>();
            service.AddScoped<PolizaServices>();
            service.AddScoped<DepartamentoServices>();
            service.AddScoped<EstadoCivilServices>();

        }
    }
}