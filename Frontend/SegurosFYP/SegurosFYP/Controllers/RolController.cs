using Microsoft.AspNetCore.Mvc;
using SegurosFYP.Models;
using SegurosFYP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace SegurosFYP.Controllers
{
    public class RolController : Controller
    {
        public RolServices _rolService;
        private object httpClient;

        public RolController(RolServices rolService)
        {
            _rolService = rolService;
        }


        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<RolesViewModel>();
                var list = await _rolService.ObtenerRolList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet("CreatePantalla")]

        public async Task<IActionResult> Create()
        {
            try
            {
                var model = new List<PantallaViewModel>();
                var list = await _rolService.ObtenerPantallaList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost("CreatePantalla")]

        public async Task<IActionResult> Create(RolesViewModel item)
        {
            try
            {
                var list = await _rolService.CrearRoles(item);
                TempData["Exito"] = "Registro insertado con exito";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }

        [HttpGet("UpdateRol")]

        public async Task<IActionResult> Edit(int Rol_Id)
        {
            try
            {
                var apiUrl = "https://localhost:44327/API/Roles/UpdateRol?Rol_id=" + Rol_Id; // URL de tu API
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var rolData = JsonConvert.DeserializeObject<RolesViewModel>(content); 
                        return View(rolData);
                    }
                    else
                    {

                        return RedirectToAction("Error", "Home");
                    }
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromForm] int Rol_Id)
        {
            try
            {
                var list = await _rolService.EliminarRol(Rol_Id);
                var hola = list.Message;
                if (hola == "Error al realizar la operacion.")
                {
                    string[] notificaciones = new string[4];
                    notificaciones[0] = "tim-icons icon-alert-circle-exc";
                    notificaciones[1] = "Error";
                    notificaciones[2] = "Ocurrio un error al eliminar el rol";
                    notificaciones[3] = "danger";
                    TempData["Notificaciones"] = notificaciones;
                }
                else
                {
                    string[] notificaciones = new string[4];
                    notificaciones[0] = "tim-icons icon-alert-circle-exc";
                    notificaciones[1] = "Exito";
                    notificaciones[2] = "Se elimino el rol con exito";
                    notificaciones[3] = "info";
                    TempData["Notificaciones"] = notificaciones;
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

    }
}
