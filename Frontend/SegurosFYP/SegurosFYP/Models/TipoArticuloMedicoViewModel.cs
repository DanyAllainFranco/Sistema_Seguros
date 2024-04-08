using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Common.Models
{
    public class TipoArticuloMedicoViewModel
    {
        public int Tarme_Id { get; set; }
        public int Tarme_Tipo { get; set; }
        public string Tarme_Descripcion { get; set; }
        public int Tarme_UsuarioCreacion { get; set; }
        public DateTime Tarme_FechaCreacion { get; set; }
        public int? Tarme_UsuarioModificacion { get; set; }
        public DateTime? Tarme_FechaModificacion { get; set; }
        public bool? Tarme_Estado { get; set; }

    }
}
