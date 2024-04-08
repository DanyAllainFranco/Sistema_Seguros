using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Common.Models
{
    public class TiposIdentificacionesViewModel
    {
        public int Tiden_Id { get; set; }
        public string Tiden_Descripcion { get; set; }
        public int Tiden_UsuarioCreacion { get; set; }
        public DateTime Tiden_FechaCreacion { get; set; }
        public int? Tiden_UsuarioModificacion { get; set; }
        public DateTime? Tiden_FechaModificacion { get; set; }
        public bool? Tiden_Estado { get; set; }

    }
}
