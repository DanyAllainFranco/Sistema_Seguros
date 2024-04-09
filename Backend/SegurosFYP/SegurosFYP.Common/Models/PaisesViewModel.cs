using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Common.Models
{
   public class PaisesViewModel
    {
        public int Paise_Id { get; set; }
        public string Paise_Descripcion { get; set; }
        public string Paise_Nacionalidad { get; set; }
        public int Paise_UsuarioCreacion { get; set; }
        public DateTime Paise_FechaCreacion { get; set; }
        public int? Paise_UsuarioModificacion { get; set; }
        public DateTime? Paise_FechaModificacion { get; set; }
        public bool? Paise_Estado { get; set; }

        [NotMapped]
        public string UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioModificacion { get; set; }

    }
}
