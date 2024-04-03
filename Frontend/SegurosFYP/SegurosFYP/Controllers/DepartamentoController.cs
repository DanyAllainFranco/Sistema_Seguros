using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SegurosFYP.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SegurosFYP.Controllers
{
    public class DepartamentoController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DepartamentoController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("https://localhost:44327/");

            var response = await httpClient.GetAsync("api/departamento/List/Departamentos");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var jsonObject = JsonConvert.DeserializeObject<JObject>(content); // Deserializar en un objeto JObject
                var data = jsonObject["data"].ToString(); // Obtener la cadena JSON de la propiedad 'data'
                var departamentos = JsonConvert.DeserializeObject<IEnumerable<DepartamentoViewModel>>(data); // Deserializar la cadena JSON en una lista de DepartamentoViewModel
                return View(departamentos);
            }
            else
            {
                return View("Error");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Insert(DepartamentoViewModel departamento)
        {
            var httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("https://localhost:44327/"); // Cambia la URL base según tu configuración

            var json = JsonConvert.SerializeObject(departamento);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("api/departamento/Insert/Departamentos", content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Error");
            }
        }
    }
}
