using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Common.Models
{
    public class EmpleadoViewModel
    {
        public int Emple_Id { get; set; }
        public int Cargo_Id { get; set; }

        [NotMapped]
        public string Perso_PrimerNombre { get; set; }
        [NotMapped]

        public string Perso_SegundoNombre { get; set; }
        [NotMapped]

        public string Perso_PrimerApellido { get; set; }
        [NotMapped]

        public string Perso_SegundoApellido { get; set; }
        [NotMapped]

        public string Perso_Sexo { get; set; }
        [NotMapped]

        public string Cargo_Descripcion { get; set; }
        [NotMapped]
        public string Perso_NombreCompleto { get; set; }
        
        public int Emple_UsuarioCreacion { get; set; }
        public DateTime Emple_FechaCreacion { get; set; }
        public int? Emple_UsuarioModificacion { get; set; }
        public DateTime? Emple_FechaModificacion { get; set; }
        public bool? Emple_Estado { get; set; }

    }
}
