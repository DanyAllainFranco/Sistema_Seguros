using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
   public class ParentescoViewModel
    {
        public int Paren_Id { get; set; }
        public string Paren_Descripcion { get; set; }
        public int Paren_UsuarioCreacion { get; set; }
        public DateTime Paren_FechaCreacion { get; set; }
        public int? Paren_UsuarioModificacion { get; set; }
        public DateTime? Paren_FechaModificacion { get; set; }
        public bool? Paren_Estado { get; set; }

        [NotMapped]
        public string UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioModificacion { get; set; }

    }
}
