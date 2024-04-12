using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
   public class ParentescoViewModel
    {
        [Display (Name = "ID")]
        public int Paren_Id { get; set; }
        [Display(Name = "Parentesco")]
        [Required(ErrorMessage = "El campo es requerido")]

        public string Paren_Descripcion { get; set; }
        public int Paren_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]

        public DateTime Paren_FechaCreacion { get; set; }
        public int? Paren_UsuarioModificacion { get; set; }
        [Display(Name = "Fecha Modificacion")]

        public DateTime? Paren_FechaModificacion { get; set; }
        public bool? Paren_Estado { get; set; }

        [NotMapped]
        [Display(Name = "Usuario Creacion")]

        public string UsuarioCreacion { get; set; }
        [NotMapped]
        [Display(Name = "Usuario Modificacion")]

        public string UsuarioModificacion { get; set; }

    }
}
