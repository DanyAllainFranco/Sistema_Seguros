using AutoMapper;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SegurosFYP.BusinessLogic.Services;
using SegurosFYP.Common.Models;
using SegurosFYP.DataAccess.Repository;
using SegurosFYP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly AccessServices _accessServices;
        private readonly IMapper _mapper;

        public UsuarioController(AccessServices accessServices, IMapper mapper)
        {
            _accessServices = accessServices;
            _mapper = mapper;
        }
        [HttpGet("List")]
        public IActionResult Index()
        {
            var list = _accessServices.ListUsu();
            return Ok(list);
        }
        [HttpPost("Insert")]
        public IActionResult Insert(UsuarioViewModel item)
        {
            var model = _mapper.Map<tbUsuarios>(item);
            var modelo = new tbUsuarios()
            {
                Usuar_Usuario = item.Usuar_Usuario,
                Usuar_Contrasena = item.Usuar_Contrasena,
                Emple_Id = item.Emple_Id,
                Roles_Id = item.Roles_Id,
                Usuar_Admin = item.Usuar_Admin
            };
            var list = _accessServices.InsertUsu(modelo);
            return Ok(list);
        }

        [HttpPut("Update/Usuario")]
        public IActionResult UpdateUsuario(UsuarioViewModel item)
        {
            var model = _mapper.Map<tbUsuarios>(item);
            var modelo = new tbUsuarios()
            {
                Usuar_Id = item.Usuar_Id,
                Usuar_Usuario = item.Usuar_Usuario,
                Usuar_Contrasena = item.Usuar_Contrasena,
                Emple_Id = item.Emple_Id,
                Roles_Id = item.Roles_Id,
                Usuar_Admin = item.Usuar_Admin
            };
            var list = _accessServices.UpdateUsuario(modelo);
            return Ok(list);
        }

        [HttpDelete("Delete/Usuario")]
        public IActionResult DeleteUnidades(int Usuar_Id)
        {
            var list = _accessServices.DeleteUsuario(Usuar_Id);
            return Ok(list);
        }

        [HttpGet("Cargar/Usuario")]
        public IActionResult CargarUnidades(int Usuar_Id)
        {
            var list = _accessServices.CargarUsuario(Usuar_Id);

            return Ok(list);
        }

        [HttpGet("Detalles/Usuario")]
        public IActionResult DetallesUnidades(int Usuar_Id)
        {
            var list = _accessServices.CargarUsuario(Usuar_Id);

            return Ok(list);
        }


    }
}

