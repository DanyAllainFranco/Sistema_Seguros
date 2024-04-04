using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SegurosFYP.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Options;
using SegurosFYP.Services;

namespace SegurosFYP.Controllers
{
    public class DepartamentoController : Controller
    {
        private readonly Cliente _url;
        private readonly HttpClient _client;
        private readonly DepartamentoServices _departamentoServices;

        public DepartamentoController(IOptions<Cliente> url, HttpClient client, DepartamentoServices departamentoServices)
        {
            _url = url.Value;
            _client = client;
            _client.BaseAddress = new Uri(_url.Url);
            _departamentoServices = departamentoServices;
        }

        public IActionResult Index()
        {
            var list = _departamentoServices.Index();

            return View(list);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(DepartamentoViewModel departamento)
        {
            var json = JsonConvert.SerializeObject(departamento);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("api/departamento/Insert/Departamentos", content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Error");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(DepartamentoViewModel departamento)
        {
            var json = JsonConvert.SerializeObject(departamento);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PutAsync("api/Departamento/Update/Departamentos", content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Error");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DepartamentoViewModel departamento)
        {
            var json = JsonConvert.SerializeObject(departamento);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.DeleteAsync("api/Departamento/Delete/Departamentos");

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> Find(DepartamentoViewModel departamento)
        {
            var response = await _client.GetAsync($"api/Departamento/Cargar/Departamentos?Depar_Id={departamento.Depar_Id}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var jsonObject = JsonConvert.DeserializeObject<JObject>(content); 
                var data = jsonObject["data"].ToString(); 
                var departamentos = JsonConvert.DeserializeObject<IEnumerable<DepartamentoViewModel>>(data);
                return View(departamentos);
            }
            else
            {
                return View("Error");
            }
        }

    }
}
