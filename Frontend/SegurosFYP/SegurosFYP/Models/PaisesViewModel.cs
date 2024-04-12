using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
   public class PaisesViewModel
    {
        [Display (Name  = "ID")]
        public int Paise_Id { get; set; }
        [Display(Name = "Pais")]
        public string Paise_Descripcion { get; set; }

        [Display(Name = "Nacionalidad")]
        public string Paise_Nacionalidad { get; set; }
        public int Paise_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime Paise_FechaCreacion { get; set; }
        public int? Paise_UsuarioModificacion { get; set; }
        [Display(Name = "Fecha Modificacion")]
        public DateTime? Paise_FechaModificacion { get; set; }
        public bool? Paise_Estado { get; set; }

        [NotMapped]
        [Display(Name = "Usuario Creacion")]
        public string UsuarioCreacion { get; set; }
        [NotMapped]
        [Display(Name = "Usuario Modificacion")]
        public string UsuarioModificacion { get; set; }

    }
}
