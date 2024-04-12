using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class CargosViewModel
    {
        [Display(Name = "ID")]
        public int Cargo_Id { get; set; }
        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Cargo_Descripcion { get; set; }
        [Display(Name = "Usuario Creacion")]
        public int Cargo_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime Cargo_FechaCreacion { get; set; }
        [Display(Name = "Usuario Modificacion")]
        public int? Cargo_UsuarioModificacion { get; set; }
        [Display(Name = "Fecha Modificacion")]
        public DateTime? Cargo_FechaModificacion { get; set; }

        [Display(Name = "Estado")]
        public bool? Cargo_Estado { get; set; }

        [NotMapped]
        public string UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioModificacion { get; set; }

    }
}
