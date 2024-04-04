using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SegurosFYP.Models;
using SegurosFYP_WEB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SegurosFYP.Services
{
    public class PolizaServices
    {
        private readonly Cliente _url;
        private readonly HttpClient _client;

        public PolizaServices(IOptions<Cliente> url, HttpClient client)
        {
            _url = url.Value;
            _client = client;
            _client.BaseAddress = new Uri(_url.Url);
        }
        public async Task<ServiceResult> Index()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _client.GetAsync("poliza/List");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var jsonObject = JsonConvert.DeserializeObject<JObject>(content); // Deserializar en un objeto JObject

                    var data = jsonObject["data"].ToString(); // Obtener la cadena JSON de la propiedad 'data'
                    var list = JsonConvert.DeserializeObject<IEnumerable<PolizaViewModel>>(data); // Deserializar la cadena JSON en una lista de DepartamentoViewModel

                    return result.Ok(list);
                }
                else
                {
                    return result.Error(response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
            
        }
    }
}
