using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Common.Models
{
     public class FrecuenciaViewModel
    {
        [Display (Name = "ID")]
        public int Frecu_Id { get; set; }

        [Display(Name = "Frecuencia")]

        public string Frecu_Descripcion { get; set; }
        public int Frecu_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]

        public DateTime Frecu_FechaCreacion { get; set; }
        public int? Frecu_UsuarioModificacion { get; set; }
        [Display(Name = "Fecha Modificacion")]

        public DateTime? Frecu_FechaModificacion { get; set; }
        public bool? Frecu_Estado { get; set; }

        [NotMapped]
        [Display(Name = "Usuario Creacion")]

        public string UsuarioCreacion { get; set; }
        [NotMapped]
        [Display(Name = "Usuario Modificacion")]

        public string UsuarioModificacion { get; set; }
    }
}
