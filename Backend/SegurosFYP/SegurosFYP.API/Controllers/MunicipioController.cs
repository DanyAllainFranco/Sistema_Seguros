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
    public class MunicipioController : ControllerBase
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public MunicipioController(GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _mapper = mapper;
        }

        [HttpGet("List/Municipio")]
        public IActionResult ListMunicipio()
        {
            var list = _generalServices.ListMunicipio();
            return Ok(list);
        }

        [HttpPost("Insert/Municipio")]
        public IActionResult InsertMunicipio(MunicipioViewModel item)
        {
            var model = _mapper.Map<tbMunicipios>(item);
            var modelo = new tbMunicipios()
            {
                Munic_Id = item.Munic_Id,
                Munic_Descripcion = item.Munic_Descripcion,
                Depar_Id = item.Depar_Id
                //Depar_UsuarioCreacion = 1,
                //Depar_FechaCreacion = item.Depar_FechaCreacion
            };
            var list = _generalServices.InsertMunicipio(modelo);
            return Ok(list);
        }

        [HttpPut("Update/Municipio")]
        public IActionResult UpdateMunicipio(MunicipioViewModel item)
        {
            var model = _mapper.Map<tbMunicipios>(item);
            var modelo = new tbMunicipios()
            {
                Munic_Id = item.Munic_Id,
                Munic_Descripcion = item.Munic_Descripcion,
                Depar_Id = item.Depar_Id

                //Depar_UsuarioModificacion = item.Depar_UsuarioModificacion,
                //Depar_FechaModificacion = item.Depar_FechaModificacion
            };
            var list = _generalServices.UpdateMunicipio(modelo);
            return Ok(list);
        }

        [HttpDelete("Delete/Municipio")]
        public IActionResult DeleteMunicipio(string Munic_Id)
        {
            var list = _generalServices.DeleteMunicipio(Munic_Id);
            return Ok(list);
        }

        [HttpGet("Cargar/Municipio")]
        public IActionResult CargarMunicipio(string Munic_Id)
        {
            var list = _generalServices.CargarMunicipio(Munic_Id);

            return Ok(list);
        }
        [HttpGet("DropDownList/Municipio")]
        public IActionResult DropDownList(string Depar_Id)
        {
            var list = _generalServices.DropDownListMunic(Depar_Id);

            return Ok(list);
        }

        [HttpGet("Detalles/Municipio")]
        public IActionResult DetallesMunicipio(string Munic_Id)
        {
            var list = _generalServices.DetallesMunicipio(Munic_Id);

            return Ok(list);
        }

    }
}