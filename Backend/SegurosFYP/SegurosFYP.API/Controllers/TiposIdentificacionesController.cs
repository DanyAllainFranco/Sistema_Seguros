using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SegurosFYP.BusinessLogic.Services;
using SegurosFYP.Common.Models;
using SegurosFYP.Entities.Entities;
using System.Collections.Generic;

namespace SegurosFYP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TiposIdentificacionesController : ControllerBase
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public TiposIdentificacionesController(GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _mapper = mapper;
        }

        [HttpGet("List/TiposIdentificaciones")]
        public IActionResult ListTiposIdentificaciones()
        {
            var list = _generalServices.ListTiposIdentificaciones();
            return Ok(list);
        }

        [HttpPost("Insert/TiposIdentificaciones")]
        public IActionResult InsertTiposIdentificaciones(TiposIdentificacionesViewModel item)
        {
            var model = _mapper.Map<tbTiposIdentificaciones>(item);
            var modelo = new tbTiposIdentificaciones()
            {
                Tiden_Id = item.Tiden_Id,
                Tiden_Descripcion = item.Tiden_Descripcion
                //Depar_UsuarioCreacion = 1,
                //Depar_FechaCreacion = item.Depar_FechaCreacion
            };
            var list = _generalServices.InsertTiposIdentificaciones(modelo);
            return Ok(list);
        }

        [HttpPut("Update/TiposIdentificaciones")]
        public IActionResult UpdateTiposIdentificaciones(TiposIdentificacionesViewModel item)
        {
            var model = _mapper.Map<tbTiposIdentificaciones>(item);
            var modelo = new tbTiposIdentificaciones()
            {
                Tiden_Id = item.Tiden_Id,
                Tiden_Descripcion = item.Tiden_Descripcion
                //Depar_UsuarioModificacion = item.Depar_UsuarioModificacion,
                //Depar_FechaModificacion = item.Depar_FechaModificacion
            };
            var list = _generalServices.UpdateTiposIdentificaciones(modelo);
            return Ok(list);
        }

        [HttpDelete("Delete/TiposIdentificaciones")]
        public IActionResult DeleteTiposIdentificaciones(int Tiden_Id)
        {
            var list = _generalServices.DeleteTiposIdentificaciones(Tiden_Id);
            return Ok(list);
        }

        [HttpGet("Cargar/TiposIdentificaciones")]
        public IActionResult CargarTiposIdentificaciones(int Tiden_Id)
        {
            var list = _generalServices.CargarTiposIdentificaciones(Tiden_Id);

            return Ok(list);
        }

        [HttpGet("Detalles/TiposIdentificaciones")]
        public IActionResult DetallesTiposIdentificaciones(int Tiden_Id)
        {
            var list = _generalServices.DetallesTiposIdentificaciones(Tiden_Id);

            return Ok(list);
        }

    }
}