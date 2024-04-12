using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SegurosFYP.Models;
using SegurosFYP.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Controllers
{
    public class PolizaController : Controller
    {
        private readonly PolizaServices _polizaServices;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public PolizaController(PolizaServices polizaServices, IWebHostEnvironment webHostEnvironment)
        {
            _polizaServices = polizaServices;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            //var list = _polizaServices.Index();

            //return View(list);
            try
            {
                var model = new List<PolizaViewModel>();
                var list = await _polizaServices.Index();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpGet]
        public async Task<IActionResult> /*IActionResult*/ Create()
        {
            try
            {
                var list = await _polizaServices.ListCre();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> /*IActionResult*/ Create(PolizaCompletaViewModel item)
        {
            try
            {
                item.Identificacion.quantity = item.Identificacion.Ident_NumeroIdentificacion.Length;
                var identificacion = await _polizaServices.InsertIdentificacion(item.Identificacion);

                if (item.Cliente.DniFrente != null)
                {
                    string folder = "images/documents/dniFrente/";
                    folder += Guid.NewGuid().ToString()+"_"+item.Cliente.DniFrente.FileName;

                    item.Cliente.DniFrenteUrl = "/" + folder;

                    string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);

                    await item.Cliente.DniFrente.CopyToAsync(new FileStream(serverFolder,FileMode.Create));
                }

                if (item.Cliente.DniAtras != null)
                {
                    string folder = "images/documents/dniAtras/";
                    folder += Guid.NewGuid().ToString() + "_" + item.Cliente.DniAtras.FileName;

                    item.Cliente.DniAtrasUrl = "/" + folder;

                    string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);

                    await item.Cliente.DniAtras.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
                }

                item.Cliente.quantity = item.Identificacion.quantity;

                await _polizaServices.InsertCliente(item.Cliente);
                if(item.Dependiente != null)
                {
                    item.Dependiente.quantity = item.Identificacion.quantity;
                }

                await _polizaServices.InsertDependiente(item.Dependiente);

                item.Poliza.quantity = item.Identificacion.quantity; 

                await _polizaServices.InsertPoliza(item.Poliza);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }
    }
}
