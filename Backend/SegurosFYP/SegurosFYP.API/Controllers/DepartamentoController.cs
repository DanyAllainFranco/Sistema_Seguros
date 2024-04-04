using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SegurosFYP.BusinessLogic.Services;
using SegurosFYP.Common.Models;
using SegurosFYP.Entities.Entities;
using System.Collections.Generic;

namespace SegurosFYP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartamentoController : ControllerBase
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public DepartamentoController(GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _mapper = mapper;
        }

        [HttpGet("List/Departamentos")]
        public IActionResult ListDepartamentos()
        {
            var list = _generalServices.ListDepar();
            return Ok(list);
        }

        [HttpPost("Insert/Departamentos")]
        public IActionResult InsertDepartamento(DepartamentoViewModel item)
        {
            var model = _mapper.Map<tbDepartamentos>(item);
            var modelo = new tbDepartamentos()
            {
                Depar_Id = item.Depar_Id,
                Depar_Descripcion = item.Depar_Descripcion
                //Depar_UsuarioCreacion = 1,
                //Depar_FechaCreacion = item.Depar_FechaCreacion
            };
            var list = _generalServices.InsertDepar(modelo);
            return Ok(list);
        }

        [HttpPut("Update/Departamentos")]
        public IActionResult UpdateDepartamento(DepartamentoViewModel item)
        {
            var model = _mapper.Map<tbDepartamentos>(item);
            var modelo = new tbDepartamentos()
            {
                Depar_Id = item.Depar_Id,
                Depar_Descripcion = item.Depar_Descripcion
                //Depar_UsuarioModificacion = item.Depar_UsuarioModificacion,
                //Depar_FechaModificacion = item.Depar_FechaModificacion
            };
            //var list = _generalServices.UpdateDepar(modelo);
            return Ok(model);
        }

        [HttpDelete("Delete/Departamentos")]
        public IActionResult DeleteDepartamento(DepartamentoViewModel item)
        {
            var model = _mapper.Map<tbDepartamentos>(item);
            var modelo = new tbDepartamentos()
            {
                Depar_Id = item.Depar_Id
            };
            //var list = _generalServices.DeleteDepar(modelo);
            return Ok(modelo);
        }

        [HttpGet("Cargar/Departamentos")]
        public IActionResult CargarDepartamentos(string Depar_Id)
        {
            //var list = _generalServices.CargarDepar(Depar_Id);
            return Ok();
        }

    }
}