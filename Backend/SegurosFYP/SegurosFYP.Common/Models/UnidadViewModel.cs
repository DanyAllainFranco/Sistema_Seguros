using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Common.Models
{
   public class UnidadViewModel
    {
        public int Unida_Id { get; set; }
        public string Unida_Descripcion { get; set; }
        public int Unida_UsuarioCreacion { get; set; }
        public DateTime Unida_FechaCreacion { get; set; }
        public int? Unida_UsuarioModificacion { get; set; }
        public DateTime? Unida_FechaModificacion { get; set; }
        public bool? Unida_Estado { get; set; }

    }
}
