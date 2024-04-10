using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
   public class UnidadViewModel
    {
        [Display (Name = "ID")]
        public int Unida_Id { get; set; }
        [Display(Name = "Descripcion")]
        public string Unida_Descripcion { get; set; }
        public int Unida_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]

        public DateTime Unida_FechaCreacion { get; set; }
        public int? Unida_UsuarioModificacion { get; set; }
        [Display(Name = "Fecha Modificacion")]

        public DateTime? Unida_FechaModificacion { get; set; }
        public bool? Unida_Estado { get; set; }

        [NotMapped]
        [Display(Name = "Usuario Creacion")]
        public string UsuarioCreacion { get; set; }
        [NotMapped]
        [Display(Name = "Usuario Modificacion")]
        public string UsuarioModificacion { get; set; }

    }
}
