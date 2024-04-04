using AutoMapper;
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
    public class PolizaController : Controller
    {
        private readonly SalesServices _salesServices;
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public PolizaController(SalesServices salesServices, GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _salesServices = salesServices;
            _mapper = mapper;
        }

        [HttpGet("List")]
        public IActionResult Index()
        {
            var list = _salesServices.ListPoliz();
            return Ok(list);
        }
        [HttpPost("InsertIdentificacion")]
        public IActionResult InsertIdentificacion(IdentificacionViewModel item)
        {
            var model = _mapper.Map<tbIdentificaciones>(item);
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
        [HttpPost("InsertCliente")]
        public IActionResult InsertCliente(PersonaViewModel item)
        {
            var numeracion = _salesServices.NumerationPoliz();

            var model = _mapper.Map<tbPersonas>(item);
            var modelo = new tbPersonas()
            {
                Perso_PrimerNombre = item.Perso_PrimerNombre,
                Perso_SegundoNombre = item.Perso_SegundoNombre,
                Perso_PrimerApellido = item.Perso_PrimerApellido,
                Perso_SegundoApellido = item.Perso_SegundoApellido,
                Perso_Sexo = item.Perso_Sexo,
                Ident_Id = item.Ident_Id,

                Estci_Id = item.Estci_Id,
                Perso_Telefono = item.Perso_Telefono,
                Perso_CorreoElectronico = item.Perso_CorreoElectronico,
                Perso_Direccion = item.Perso_Direccion,
                Munic_Id = item.Munic_Id,
                Paise_Id = item.Paise_Id,

                Poliz_Id = numeracion.Data + 1,
                Paren_Id = 1,
            };
            var list = _generalServices.InsertPerso(modelo);
            return Ok(list);
        }
        [HttpPost("InsertPariente")]
        public IActionResult InsertPariente(PersonaViewModel item)
        {
            var numeracion = _salesServices.NumerationPoliz();

            var model = _mapper.Map<tbPersonas>(item);
            var modelo = new tbPersonas()
            {
                Perso_PrimerNombre = item.Perso_PrimerNombre,
                Perso_SegundoNombre = item.Perso_SegundoNombre,
                Perso_PrimerApellido = item.Perso_PrimerApellido,
                Perso_SegundoApellido = item.Perso_SegundoApellido,
                Perso_Sexo = item.Perso_Sexo,
                Ident_Id = item.Ident_Id,

                Estci_Id = item.Estci_Id,
                Perso_Telefono = item.Perso_Telefono,
                Perso_CorreoElectronico = item.Perso_CorreoElectronico,
                Perso_Direccion = item.Perso_Direccion,
                Munic_Id = item.Munic_Id,
                Paise_Id = item.Paise_Id,

                Poliz_Id = numeracion.Data + 1,
                Paren_Id = item.Paren_Id,
            };
            var list = _generalServices.InsertPerso(modelo);
            return Ok(list);
        }
        [HttpPost("InsertInformacionMedica")]
        public IActionResult InsertInformacionMedica(InformacionMedicaViewModel item)
        {
            var model = _mapper.Map<tbInformacionMedica>(item);
            var modelo = new tbInformacionMedica()
            {
                Perso_Id = item.Perso_Id,
                Inmed_PesoKgs = item.Inmed_PesoKgs,
                Inmed_EstaturaMtrs = item.Inmed_EstaturaMtrs,
                Inmed_TipoSangre = item.Inmed_TipoSangre,
                Inmed_ReaccionesAlergicas = item.Inmed_ReaccionesAlergicas,
                Inmed_AumentoDisminucion = item.Inmed_AumentoDisminucion,
                Inmed_AumentoDisminucionPeso = item.Inmed_AumentoDisminucionPeso,
                Inmed_IngiereBebidasAlcoholicas = item.Inmed_IngiereBebidasAlcoholicas,
                Inmed_TipoAlcohol = item.Inmed_TipoAlcohol,
                Inmed_IngiereCantidad = item.Inmed_IngiereCantidad,
                Inmed_IngiereFrecuencia = item.Inmed_IngiereFrecuencia,
                Inmed_DrogasEstimulantes = item.Inmed_DrogasEstimulantes,
                Inmed_TipoDrogasEstimulantes = item.Inmed_TipoDrogasEstimulantes,
                Inmed_DrogasEstimulantesCantidad = item.Inmed_DrogasEstimulantesCantidad,
                Inmed_DrogasEstimulantesFrecuencia = item.Inmed_DrogasEstimulantesFrecuencia,
                Inmed_Fumar = item.Inmed_Fumar,
                Inmed_FumarCantidad = item.Inmed_FumarCantidad,
                Inmed_FumarFrecuencia = item.Inmed_FumarFrecuencia,
                Inmed_Enfermedad1 = item.Inmed_Enfermedad1,
                Inmed_Enfermedad2 = item.Inmed_Enfermedad2,
                Inmed_Enfermedad3 = item.Inmed_Enfermedad3,
                Inmed_Enfermedad4 = item.Inmed_Enfermedad4,
                Inmed_Enfermedad5 = item.Inmed_Enfermedad5,
                Inmed_Enfermedad6 = item.Inmed_Enfermedad6,
                Inmed_Enfermedad7 = item.Inmed_Enfermedad7,
                Inmed_Enfermedad8 = item.Inmed_Enfermedad8,
                Inmed_Enfermedad9 = item.Inmed_Enfermedad9,
            };
            var list = _generalServices.InsertInmed(modelo);
            return Ok(list);
        }
        [HttpPost("InsertPoliza")]
        public IActionResult InsertPoliza(PolizaViewModel item)
        {
            var model = _mapper.Map<tbPolizas>(item);
            var modelo = new tbPolizas()
            {
                Clien_Id = item.Clien_Id,
                Tipos_Id = item.Tipos_Id,
                Emple_Id = item.Emple_Id,
                Poliz_Cuotas = item.Poliz_Cuotas,
                Poliz_TipoPago = item.Poliz_TipoPago,
                Poliz_EstadoCuotasPoliza = item.Poliz_EstadoCuotasPoliza,
            };
            var list = _salesServices.InsertPoliz(modelo);
            return Ok(list);
        }
    }
}
