using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class IdentificacionViewModel
    {
        public int Ident_Id { get; set; }
        public int[] Tiden_Id { get; set; }
        public string[] Ident_NumeroIdentificacion { get; set; }
        public DateTime[] Ident_FechaNacimiento { get; set; }
        public string[] Ident_LugarNacimiento { get; set; }
        public int Ident_UsuarioCreacion { get; set; }
        public DateTime Ident_FechaCreacion { get; set; }
        public int? Ident_UsuarioModificacion { get; set; }
        public DateTime? Ident_FechaModificacion { get; set; }
        public bool? Ident_Estado { get; set; }


        public int quantity { get; set; }
    }
}
