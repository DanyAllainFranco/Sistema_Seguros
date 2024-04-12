using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class Identificacion1ViewModel
    {
        public int Ident_Id { get; set; }
        [Display(Name = "Tipo de Identificacion")]
        public int Tiden_Id { get; set; }
        [Display(Name = "Codigo de Identificacion")]
        public string Ident_NumeroIdentificacion { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime Ident_FechaNacimiento { get; set; }
        [Display(Name = "Lugar de Nacimiento")]
        public string Ident_LugarNacimiento { get; set; }
        public int Ident_UsuarioCreacion { get; set; }
        public DateTime Ident_FechaCreacion { get; set; }
        public int? Ident_UsuarioModificacion { get; set; }
        public DateTime? Ident_FechaModificacion { get; set; }
        public bool? Ident_Estado { get; set; }


        public int quantity { get; set; }
    }
}
