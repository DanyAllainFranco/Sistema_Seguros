using Microsoft.AspNetCore.Mvc;
using SegurosFYP.Common.Models;
using SegurosFYP.Models;
using SegurosFYP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Controllers
{
    public class CoberturaController : Controller
    {
        public CoberturaServices _coberturaServices;
        public CoberturaController(CoberturaServices coberturaServices)
        {
            _coberturaServices = coberturaServices;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<CoberturaViewModel>();
                var list = await _coberturaServices.Index();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");

            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert(CoberturaViewModel item)
        {
            try
            {
                var list = await _coberturaServices.Insert(item);
                TempData["Exito"] = "Registro insertado con exito";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al insertar";
                return View(item);
            }
        }

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(CoberturaViewModel item)
        {
            try
            {
                var list = await _coberturaServices.Update(item);
                TempData["Exito"] = "Registro editado con exito";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al editar";
                return View(item);
            }
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int Cober_Id)
        {
            try
            {
                var list = await _coberturaServices.Delete(Cober_Id);
                TempData["Exito"] = "Registro eliminado con éxito";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al eliminar";
                return RedirectToAction("Index");
            }
        }



        public async Task<IActionResult> Find()
        {
            try
            {
                var model = new List<CoberturaViewModel>();
                var list = await _coberturaServices.Find();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");

            }
        }


        //GET:CoberturaController/Detalles/Cobertura
        public async Task<IActionResult> Details(int Cober_Id)
        {
            try
            {
                var result = await _coberturaServices.Details(Cober_Id);
                if (result.Success)
                {
                    return View(result.Data);
                }
                else
                {
                    TempData["Error"] = result.Message;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al obtener los detalles del estado civil";
                return RedirectToAction("Index");
            }
        }

    }
}
