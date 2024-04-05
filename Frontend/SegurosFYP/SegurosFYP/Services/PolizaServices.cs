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
                //var response = await _aPI.GetAsync("poliza/List").ConfigureAwait(false);

                //if (response.IsSuccessStatusCode)
                //{

                //    var content = await response.Content.ReadAsStringAsync();
                //    var jsonObject = JsonConvert.DeserializeObject<JObject>(content); // Deserializar en un objeto JObject

                //    var data = jsonObject["data"].ToString(); // Obtener la cadena JSON de la propiedad 'data'
                //    var list = JsonConvert.DeserializeObject<IEnumerable<PolizaViewModel>>(data); // Deserializar la cadena JSON en una lista de DepartamentoViewModel

                //    return result.Ok(list);
                //}
                //else
                //{
                //    return result.Error(response.StatusCode);
                //}
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
            
        }
    }
}
