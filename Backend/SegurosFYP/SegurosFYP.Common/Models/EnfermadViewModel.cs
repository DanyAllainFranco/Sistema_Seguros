using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Common.Models
{
   public class EnfermadViewModel
    {
        public int Enfer_Id { get; set; }
        public string Enfer_Descripcion { get; set; }
        public int Enfer_UsuarioCreacion { get; set; }
        public DateTime Enfer_FechaCreacion { get; set; }
        public int? Enfer_UsuarioModificacion { get; set; }
        public DateTime? Enfer_FechaModificacion { get; set; }
        public bool? Enfer_Estado { get; set; }

        [NotMapped]
        public string UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioModificacion { get; set; }

    }
}
