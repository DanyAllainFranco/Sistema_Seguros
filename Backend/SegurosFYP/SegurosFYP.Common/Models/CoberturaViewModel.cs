using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [NotMapped]
        public string UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioModificacion { get; set; }

    }
}
