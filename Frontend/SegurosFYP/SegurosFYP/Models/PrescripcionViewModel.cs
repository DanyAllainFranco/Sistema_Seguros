using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class PrescripcionesViewModel
    {
        public int Presc_Id { get; set; }
        public int Recla_Id { get; set; }
        public string Presc_DocumentoAdelante { get; set; }
        public string Presc_DocumentoAtras { get; set; }
        public int Presc_UsuarioCreacion { get; set; }
        public DateTime Presc_FechaCreacion { get; set; }
        public int? Presc_UsuarioModificacion { get; set; }
        public DateTime? Presc_FechaModificacion { get; set; }
        public bool? Presc_Estado { get; set; }
    }
}
