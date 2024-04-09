using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SegurosFYP.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SegurosFYP.API.Clases;
using SegurosFYP.Entities.Entities;
using SegurosFYP.Common.Models;

namespace SegurosFYP.API.Controllers
{
    [ApiController]
    [Route("/API/[controller]")]
    public class RolesController : Controller
    {

        private readonly AccessServices _accesServices;
        private readonly IMapper _mapper;

        public RolesController(AccessServices accesServices, IMapper mapper)
        {
            _accesServices = accesServices;
            _mapper = mapper;
        }

        [HttpGet("ListadoRoles")]
        public IActionResult Index()
        {
            var list = _accesServices.ListRol();
            return Ok(list);
        }

        [HttpGet("CreatePantalla")]
        public IActionResult Create()
        {
            var list = _accesServices.ListPantalla();
            return Ok(list);
        }

        [HttpPost("CreatePantalla")]
        public IActionResult Create([FromBody] FormData formData)
        {
            string txtRol = formData.txtRol;
            List<int> pantallasSeleccionadas = formData.pantallasSeleccionadas;

            try
            {

                var modelo = new tbRoles()
                {
                    Roles_Descripcion = txtRol,
                    Roles_UsuarioCreacion = 1, // Aquí va la sesión del ID del usuario
                    Roles_FechaCreacion = DateTime.Now
                };

                var list = _accesServices.InsertarRol(modelo);

                var id = _accesServices.ObtenerId(txtRol, modelo.Roles_UsuarioCreacion, modelo.Roles_FechaCreacion);

                var rol = id.Data;

                int rolid = 0;

                foreach (var item in rol)
                {
                    rolid = item.Rol_Id;
                }

                foreach (var pantalla in pantallasSeleccionadas)
                {
                    var modelo2 = new tbPantallasPorRoles()
                    {
                        Panta_Id = pantalla,
                        Roles_Id = rolid,
                        Papro_UsuarioCreacion = 1,
                        Papro_FechaCreacion = DateTime.Now
                    };

                    var msj = _accesServices.InsertarPantallasPorRol(modelo2);
                }
                return Ok(list);
            }
            catch
            {

                return Ok();

            }
        }

        [HttpGet("UpdateRol")]
        public IActionResult Update(int Rol_id)
        {
            var PantallasPorRol = _accesServices.ObtenerPantallasPorRol(Rol_id);
            var Pantallas = _accesServices.ListPantalla();
            var ObtenerRol = _accesServices.ObtenerRol(Rol_id);

            int rolid = 0;
            string NombreRol = "";

            var Rol = ObtenerRol.Data;

            foreach (var item in Rol)
            {
                rolid = item.Roles_Id;
                NombreRol = item.Roles_Descripcion;
            }

            var pantallasSeleccionadas = PantallasPorRol.Select(p => (int)p.Panta_Id).ToList();

            var panta = Pantallas.Data as IEnumerable<tbPantallas>;

            var pantallasViewModel = _mapper.Map<List<PantallaViewModel>>(panta);

            var rolViewModel = new RolesViewModel
            {
                Roles_Id = rolid,
                Roles_Descripcion = NombreRol,
                PantallasID = pantallasSeleccionadas,
                pantallas = (List<PantallaViewModel>)pantallasViewModel,
            };
            return Ok(rolViewModel);
        }

        [HttpPost("UpdateRol")]
        public JsonResult Edit([FromBody] FormData formData)
        {
            if (string.IsNullOrEmpty(formData.txtRol))
            {
                ModelState.AddModelError("txtRol", "El nombre del rol es requerido.");
            }

            var rol = new tbRoles()
            {
                Roles_Descripcion = formData.txtRol,
                Roles_UsuarioModificacion = 1, //debe ir el usuario que lo modifico con una sesion
                Roles_FechaModificacion = DateTime.Now,

            };

            var id = _accesServices.ObtenerId(formData.txtRol, (int)rol.Roles_UsuarioModificacion, (DateTime)rol.Roles_FechaModificacion);
            var role = id.Data;
            int RolId = 0;
            foreach (var item in role)
            {
                RolId = item.Roles_Id;
            }
            _accesServices.ActualizarRol(rol);


            foreach (var pantalla in formData.pantallasSeleccionadas)
            {
                var modelo2 = new tbPantallasPorRoles()
                {
                    Panta_Id = pantalla,
                    Roles_Id = RolId,
                    Papro_UsuarioCreacion = 1,
                    Papro_FechaCreacion = DateTime.Now
                };

                var msj = _accesServices.InsertarPantallasPorRol(modelo2);
            }

            return Json(1);

        }

        [HttpDelete("DeleteRol")]
        public IActionResult Delete(int Rol_id)
        {
            var list = _accesServices.EliminarRol(Rol_id);
            return Ok(list);
        }

    }
}
