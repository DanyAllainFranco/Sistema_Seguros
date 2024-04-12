using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class ReclamoViewModel
    {
        public int Recla_Id { get; set; }
        public int Clien_Id { get; set; }
        public int Infor_Id { get; set; }
        public decimal Recla_TotalFactura { get; set; }
        public int Recla_UsuarioCreacion { get; set; }
        public DateTime Recla_FechaCreacion { get; set; }
        public int? Recla_UsuarioModificacion { get; set; }
        public DateTime? Recla_FechaModificacion { get; set; }
        public bool? Recla_Estado { get; set; }
    }
}
