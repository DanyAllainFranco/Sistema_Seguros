using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SegurosFYP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Text.Json;
using SegurosFYP.Services;

namespace SegurosFYP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UsuarioService _usuarioService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(ILogger<HomeController> logger, UsuarioService usuarioService, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _usuarioService = usuarioService;
            _httpContextAccessor = httpContextAccessor;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Login(string Usuario, string Contrasenia)
        {
            string usuario = "";
            int? idrol = 0;

            if (Usuario != null && Contrasenia != null)
            {
                int x = 0;

                int? rol;

                List<string> pantallasPorRol = new List<string>();
                var Claim = new List<Claim>();
                var list = await _usuarioService.Login(Usuario, Contrasenia);
                var saber = list.Data as IEnumerable<UsuarioViewModel>;
      
                if (saber.ToList().Count  > 0)
                {
                    var loginlist = saber.ToList().FirstOrDefault();

                    foreach (var item in saber.ToList())
                    {
                        HttpContext.Session.SetString("Usua_Id", item.Usuar_Id.ToString());
                        HttpContext.Session.SetString("rolesssss", item.Roles_Id.ToString());
                        //HttpContext.Session.SetString("Usuario", item.Usuar_Usuario.ToString());
                        pantallasPorRol.Add(item.Panta_Descripcion);
                        if (item.Panta_Descripcion != null)
                        {
                            Claim.Add(new Claim(ClaimTypes.Role, item.Panta_Descripcion));
                        }
                        else
                        {
                            Claim.Add(new Claim(ClaimTypes.Role, "Ninguna Pantalla"));
                        }
                        rol = item.Roles_Id;
                    }

                    if (loginlist.Usuar_Admin == true)
                    {
                        pantallasPorRol.Add("Admin");
                        Claim.Add(new Claim(ClaimTypes.Role, "Admin"));
                    }

                    var ClaimsIdentity = new ClaimsIdentity(Claim, CookieAuthenticationDefaults.AuthenticationScheme);


                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(ClaimsIdentity));

                    var pantallasJson = JsonSerializer.Serialize(pantallasPorRol);
                    HttpContext.Session.SetString("Pantallas", pantallasJson);

                    return RedirectToAction("Index");
                }
            }

            return View();
        }
   
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Salir()
        {
            return RedirectToAction("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
