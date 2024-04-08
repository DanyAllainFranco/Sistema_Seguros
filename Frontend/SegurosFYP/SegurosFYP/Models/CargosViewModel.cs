using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class CargosViewModel
    {
        public int Cargo_Id { get; set; }
        public string Cargo_Descripcion { get; set; }
        public int Cargo_UsuarioCreacion { get; set; }
        public DateTime Cargo_FechaCreacion { get; set; }
        public int? Cargo_UsuarioModificacion { get; set; }
        public DateTime? Cargo_FechaModificacion { get; set; }
        public bool? Cargo_Estado { get; set; }

    }
}
