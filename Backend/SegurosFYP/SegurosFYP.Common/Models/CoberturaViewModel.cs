using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Common.Models
{
    public class CoberturaViewModel
    {
        public int Cober_Id { get; set; }
        public string Cober_Descripcion { get; set; }
        public int Cober_UsuarioCreacion { get; set; }
        public DateTime Cober_FechaCreacion { get; set; }
        public int? Cober_UsuarioModificacion { get; set; }
        public DateTime? Cober_FechaModificacion { get; set; }
        public bool? Cober_Estado { get; set; }

    }
}
