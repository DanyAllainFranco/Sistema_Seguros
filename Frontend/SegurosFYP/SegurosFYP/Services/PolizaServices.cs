using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SegurosFYP.Models;
using SegurosFYP_WEB.Services;
using SegurosFYP.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SegurosFYP.Services
{
    public class PolizaServices
    {
        private readonly API _aPI;

        public PolizaServices(API aPI)
        {
            _aPI = aPI;
        }
        public async Task<ServiceResult> Index()
        {
            var result = new ServiceResult();
            try
            {

                var response = await _aPI.Get<IEnumerable<PolizaViewModel>, IEnumerable<PolizaViewModel>>(req =>
                {
                    req.Path = $"poliza/List";
                });
                if (!response.Success)
                {
                    return result.FromApi(response);
                }
                else
                {
                    return result.Ok(response.Data);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
            
        }
    }
}
