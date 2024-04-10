using Microsoft.AspNetCore.Mvc;
using SegurosFYP.BusinessLogic.Services;
using SegurosFYP.Common.Models;
using SegurosFYP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController : Controller
    {
        private readonly GeneralServices _generalServices;

        public PersonaController(GeneralServices generalServices)
        {
            _generalServices = generalServices;
        }
        [HttpPost("InsertIdentificacion")]
        public IActionResult InsertIdentificacion(IdentificacionViewModel item)
        {
            //var result = Ok();
                //var model = _mapper.Map<tbIdentificaciones>(item);
                var modelo = new tbIdentificaciones()
                {
                    Tiden_Id = item.Tiden_Id,
                    Ident_NumeroIdentificacion = item.Ident_NumeroIdentificacion,
                    Ident_FechaNacimiento = item.Ident_FechaNacimiento,
                    Ident_LugarNacimiento = item.Ident_LugarNacimiento
                };
                var list = _generalServices.InsertIdent(modelo);
                return Ok(list);
            
        }
        [HttpPost("Insert")]
        public IActionResult Insert(PersonaViewModel item)
        {
            var ident = _generalServices.NumerationIdent(1);

            var modelo = new tbPersonas()
            {
                Perso_PrimerNombre = item.Perso_PrimerNombre,
                Perso_SegundoNombre = item.Perso_SegundoNombre,
                Perso_PrimerApellido = item.Perso_PrimerApellido,
                Perso_SegundoApellido = item.Perso_SegundoApellido,
                Perso_Sexo = item.Perso_Sexo,
                Ident_Id = ident[0].Ident_Id,
                Estci_Id = item.Estci_Id,
                Perso_Telefono = item.Perso_Telefono,
                Perso_CorreoElectronico = item.Perso_CorreoElectronico,
                Perso_Direccion = item.Perso_Direccion,
                Munic_Id = item.Munic_Id,
            };

            var result = _generalServices.InsertPerso(modelo);
            return Ok(result);
        }
    }
}
