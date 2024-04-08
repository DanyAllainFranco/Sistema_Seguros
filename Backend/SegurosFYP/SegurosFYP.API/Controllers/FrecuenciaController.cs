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
    public class FrecuenciaController : ControllerBase
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public FrecuenciaController(GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _mapper = mapper;
        }

        [HttpGet("List/Frecuencia")]
        public IActionResult ListFrecuencia()
        {
            var list = _generalServices.ListFrecuencia();
            return Ok(list);
        }

        [HttpPost("Insert/Frecuencia")]
        public IActionResult InsertFrecuencia(FrecuenciaViewModel item)
        {
            var model = _mapper.Map<tbFrecuencias>(item);
            var modelo = new tbFrecuencias()
            {
                Frecu_Id = item.Frecu_Id,
                Frecu_Descripcion = item.Frecu_Descripcion
                //Depar_UsuarioCreacion = 1,
                //Depar_FechaCreacion = item.Depar_FechaCreacion
            };
            var list = _generalServices.InsertFrecuencia(modelo);
            return Ok(list);
        }

        [HttpPut("Update/Frecuencia")]
        public IActionResult UpdateFrecuencia(FrecuenciaViewModel item)
        {
            var model = _mapper.Map<tbFrecuencias>(item);
            var modelo = new tbFrecuencias()
            {
                Frecu_Id = item.Frecu_Id,
                Frecu_Descripcion = item.Frecu_Descripcion
                //Depar_UsuarioModificacion = item.Depar_UsuarioModificacion,
                //Depar_FechaModificacion = item.Depar_FechaModificacion
            };
            var list = _generalServices.UpdateFrecuencia(modelo);
            return Ok(list);
        }

        [HttpDelete("Delete/Frecuencia")]
        public IActionResult DeleteFrecuencia(int Frecu_Id)
        {
            var list = _generalServices.DeleteFrecuencia(Frecu_Id);
            return Ok(list);
        }

        [HttpGet("Cargar/Frecuencia")]
        public IActionResult CargarFrecuencia(int Frecu_Id)
        {
            var list = _generalServices.CargarFrecuencia(Frecu_Id);

            return Ok(list);
        }

        [HttpGet("Detalles/Frecuencia")]
        public IActionResult DetallesFrecuencia(int Frecu_Id)
        {
            var list = _generalServices.DetallesFrecuencia(Frecu_Id);

            return Ok(list);
        }

    }
}