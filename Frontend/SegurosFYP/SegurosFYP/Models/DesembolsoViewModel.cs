using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class DesembolsoViewModel
    {
        public int Desem_Id { get; set; }
        public int Recla_Id { get; set; }
        public decimal? Desem_TotalAcreditar { get; set; }
        public int Desem_UsuarioCreacion { get; set; }
        public DateTime Desem_FechaCreacion { get; set; }
        public int? Desem_UsuarioModificacion { get; set; }
        public DateTime? Desem_FechaModificacion { get; set; }
        public bool? Desem_Estado { get; set; }
    }
}
