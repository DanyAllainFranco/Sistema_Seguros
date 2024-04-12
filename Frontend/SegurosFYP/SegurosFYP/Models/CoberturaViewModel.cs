using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class CoberturaViewModel
    {
        [Display(Name = "ID")]
        public int Cober_Id { get; set; }
        [Display(Name = "Cobertura")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Cober_Descripcion { get; set; }
        [Display(Name = "Usuario Creacion")]
        public int Cober_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime Cober_FechaCreacion { get; set; }
        [Display(Name = "Usuario Modificacion")]
        public int? Cober_UsuarioModificacion { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime? Cober_FechaModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool? Cober_Estado { get; set; }

        [NotMapped]
        public string UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioModificacion { get; set; }
    }
}
