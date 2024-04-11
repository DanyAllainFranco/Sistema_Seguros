using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class InformeMedicoViewModel
    {
        public int Infor_Id { get; set; }
        public string Infor_Diagnostico { get; set; }
        public string Infor_TratamientoRealizado { get; set; }
        public string Infor_TratamientoProgramado { get; set; }
        public string Infor_OtrosTratamientos { get; set; }
        public string Infor_DocumentoAdelante { get; set; }
        public string Infor_DocumentoAtras { get; set; }
        public IFormFile Infor_DocumentoAdelanteArch { get; set; }
        public IFormFile Infor_DocumentoAtrasArch { get; set; }
        public int Infor_UsuarioCreacion { get; set; }
        public DateTime Infor_FechaCreacion { get; set; }
        public int? Infor_UsuarioModificacion { get; set; }
        public DateTime? Infor_FechaModificacion { get; set; }
        public bool? Infor_Estado { get; set; }
    }
}
