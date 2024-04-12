using Microsoft.Extensions.Options;
using SegurosFYP.Models;
using SegurosFYP.WebAPI;
using SegurosFYP_WEB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SegurosFYP.Services
{
    public class IdentificacionServices
    {
        private readonly API _aPI;
        private readonly HttpClient _client;
        private readonly Cliente _url;
        public IdentificacionServices(API aPI, HttpClient httpClient, IOptions<Cliente> url)
        {
            _aPI = aPI;
            _client = httpClient;
            _url = url.Value;
            _client.BaseAddress = new Uri(_url.Url);
        }
        public async Task<ServiceResult> Insert(Identificacion1ViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _client.PostAsJsonAsync("persona/InsertIdentificacion", item);

                if (!response.IsSuccessStatusCode)
                {
                    return result.Error();

                }
                else
                {
                    return result.Ok();

                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }

        }
    }
}
