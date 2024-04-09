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
    public class EstadoCivilController : ControllerBase
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public EstadoCivilController(GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _mapper = mapper;
        }

        [HttpGet("List/EstadoCivil")]
        public IActionResult ListEstadoCivil()
        {
            var list = _generalServices.ListEstadoC();
            return Ok(list);
        }

        [HttpPost("Insert/EstadoCivil")]
        public IActionResult InsertEstadoCivil(EstadoCivilViewModel item)
        {
            var model = _mapper.Map<tbEstadosCiviles>(item);
            var modelo = new tbEstadosCiviles()
            {
                Estad_Id = item.Estad_Id,
                Estad_Descripcion = item.Estad_Descripcion
                //Depar_UsuarioCreacion = 1,
                //Depar_FechaCreacion = item.Depar_FechaCreacion
            };
            var list = _generalServices.InsertEstadoC(modelo);
            return Ok(list);
        }

        [HttpPut("Update/EstadoCivil")]
        public IActionResult UpdateEstadoCivil(EstadoCivilViewModel item)
        {
            var model = _mapper.Map<tbEstadosCiviles>(item);
            var modelo = new tbEstadosCiviles()
            {
                Estad_Id = item.Estad_Id,
                Estad_Descripcion = item.Estad_Descripcion
                //Depar_UsuarioModificacion = item.Depar_UsuarioModificacion,
                //Depar_FechaModificacion = item.Depar_FechaModificacion
            };
            var list = _generalServices.UpdateEstadoC(modelo);
            return Ok(list);
        }

        [HttpDelete("Delete/EstadoCivil")]
        public IActionResult DeleteEstadoCivil(int Estad_Id)
        {
            var list = _generalServices.DeleteEstadoC(Estad_Id);
            return Ok(list);
        }

        [HttpGet("Cargar/EstadoCivil")]
        public IActionResult CargarEstadoCivil(int Estad_Id)
        {
            var list = _generalServices.CargarEstadoC(Estad_Id);

            return Ok(list);
        }

        [HttpGet("Detalles/EstadoCivil")]
        public IActionResult DetallesEstadoCivil(int Estad_Id)
        {
            var list = _generalServices.DetallesEstadoC(Estad_Id);

            return Ok(list);
        }

    }
}