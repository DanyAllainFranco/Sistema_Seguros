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
    public class ParentescoController : ControllerBase
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public ParentescoController(GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _mapper = mapper;
        }

        [HttpGet("List/Parentesco")]
        public IActionResult ListParentesco()
        {
            var list = _generalServices.ListParentesco();
            return Ok(list);
        }

        [HttpPost("Insert/Parentesco")]
        public IActionResult InsertParentesco(ParentescoViewModel item)
        {
            var model = _mapper.Map<tbParentescos>(item);
            var modelo = new tbParentescos()
            {
                Paren_Id = item.Paren_Id,
                Paren_Descripcion = item.Paren_Descripcion
                //Depar_UsuarioCreacion = 1,
                //Depar_FechaCreacion = item.Depar_FechaCreacion
            };
            var list = _generalServices.InsertParentesco(modelo);
            return Ok(list);
        }

        [HttpPut("Update/Parentesco")]
        public IActionResult UpdateParentesco(ParentescoViewModel item)
        {
            var model = _mapper.Map<tbParentescos>(item);
            var modelo = new tbParentescos()
            {
                Paren_Id = item.Paren_Id,
                Paren_Descripcion = item.Paren_Descripcion
                //Depar_UsuarioModificacion = item.Depar_UsuarioModificacion,
                //Depar_FechaModificacion = item.Depar_FechaModificacion
            };
            var list = _generalServices.UpdateParentesco(modelo);
            return Ok(list);
        }

        [HttpDelete("Delete/Parentesco")]
        public IActionResult DeleteParentesco(int Paren_Id)
        {
            var list = _generalServices.DeleteParentesco(Paren_Id);
            return Ok(list);
        }

        [HttpGet("Cargar/Parentesco")]
        public IActionResult CargarParentesco(int Paren_Id)
        {
            var list = _generalServices.CargarParentesco(Paren_Id);

            return Ok(list);
        }

        [HttpGet("Detalles/Parentesco")]
        public IActionResult DetallesParentesco(int Paren_Id)
        {
            var list = _generalServices.DetallesParentesco(Paren_Id);

            return Ok(list);
        }

    }
}