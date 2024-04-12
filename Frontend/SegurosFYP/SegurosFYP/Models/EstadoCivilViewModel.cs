using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SegurosFYP.Models
{
    public class EstadoCivilViewModel
    {
        [Display(Name = "ID")]
        public int Estad_Id { get; set; }
        [Display(Name="Estado Civil")]
        [Required]
        public string Estad_Descripcion { get; set; }
        [Display(Name = "Usuario Creacion")]
        public int Estad_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]

        public DateTime Estad_FechaCreacion { get; set; }
        [Display(Name = "Usuario Modificacion")]

        public int? Estad_UsuarioModificacion { get; set; }
        [Display(Name = "Fecha Modificacion")]

        public DateTime? Estad_FechaModificacion { get; set; }
        public bool? Estad_Estado { get; set; }

        [Display(Name = "Usuario Creacion")]
        [NotMapped]
        public string usua_creac { get; set; }

        [Display(Name = "Usuario Modificacion")]
        [NotMapped]
        public string usua_modi { get; set; }

    }
}
