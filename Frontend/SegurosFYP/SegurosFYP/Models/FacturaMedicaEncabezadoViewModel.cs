using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class FacturaMedicaEncabezadoViewModel
    {
        public int Faenca_Id { get; set; }
        public string[] Faenca_Codigo { get; set; }
        public int Clien_Id { get; set; }
        public string[] Faenca_HospitalClinica { get; set; }
        public DateTime[] Faenca_FechaImpresion { get; set; }
        public int Recla_Id { get; set; }
        public string[] Factu_DocumentoAdelante { get; set; }
        public string[] Factu_DocumentoAtras { get; set; }
        public int Faenca_UsuarioCreacion { get; set; }
        public DateTime Faenca_FechaCreacion { get; set; }
        public int? Faenca_UsuarioModificacion { get; set; }
        public DateTime? Faenca_FechaModificacion { get; set; }
        public bool? Faenca_Estado { get; set; }

        public string Factu_DocumentoAdelanteArchivo { get; set; }
        public string Factu_DocumentoAtrasArchivo { get; set; }
    }
}
