using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Common.Models
{
   public class EnfermadViewModel
    {

        [Display(Name = "ID")]
        public int Enfer_Id { get; set; }
        [Display(Name = "ID")]

        public string Enfer_Descripcion { get; set; }
        [Display(Name = "ID")]

        public int Enfer_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]


        public DateTime Enfer_FechaCreacion { get; set; }



        public int? Enfer_UsuarioModificacion { get; set; }
        [Display(Name = "Fecha Modificacion")]


        public DateTime? Enfer_FechaModificacion { get; set; }

        public bool? Enfer_Estado { get; set; }

        [NotMapped]
        [Display(Name = "Usuario Creacion")]

        public string UsuarioCreacion { get; set; }
        [NotMapped]
        [Display(Name = "Usuario Modificacion")]

        public string UsuarioModificacion { get; set; }

    }
}
