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
    public class PaisController : ControllerBase
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public PaisController(GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _mapper = mapper;
        }

        [HttpGet("List/Pais")]
        public IActionResult ListPais()
        {
            var list = _generalServices.ListPais();
            return Ok(list);
        }

        [HttpPost("Insert/Pais")]
        public IActionResult InsertPais(PaisesViewModel item)
        {
            var model = _mapper.Map<tbPaises>(item);
            var modelo = new tbPaises()
            {
                Paise_Id = item.Paise_Id,
                Paise_Descripcion = item.Paise_Descripcion,
                Paise_Nacionalidad = item.Paise_Nacionalidad
                //Depar_UsuarioCreacion = 1,
                //Depar_FechaCreacion = item.Depar_FechaCreacion
            };
            var list = _generalServices.InsertPais(modelo);
            return Ok(list);
        }

        [HttpPut("Update/Pais")]
        public IActionResult UpdatePais(PaisesViewModel item)
        {
            var model = _mapper.Map<tbPaises>(item);
            var modelo = new tbPaises()
            {
                Paise_Id = item.Paise_Id,
                Paise_Descripcion = item.Paise_Descripcion,
                Paise_Nacionalidad = item.Paise_Nacionalidad
                //Depar_UsuarioModificacion = item.Depar_UsuarioModificacion,
                //Depar_FechaModificacion = item.Depar_FechaModificacion
            };
            var list = _generalServices.UpdatePais(modelo);
            return Ok(list);
        }

        [HttpDelete("Delete/Pais")]
        public IActionResult DeletePais(int Paise_Id)
        {
            var list = _generalServices.DeletePais(Paise_Id);
            return Ok(list);
        }

        [HttpGet("Cargar/Pais")]
        public IActionResult CargarPais(int Paise_Id)
        {
            var list = _generalServices.CargarPais(Paise_Id);

            return Ok(list);
        }

        [HttpGet("Detalles/Pais")]
        public IActionResult DetallesPais(int Paise_Id)
        {
            var list = _generalServices.DetallesPais(Paise_Id);

            return Ok(list);
        }

    }
}