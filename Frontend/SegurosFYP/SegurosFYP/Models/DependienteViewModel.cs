using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class DependienteViewModel
    {
        [Required]

        public string[] Perso_PrimerNombre { get; set; }
        public string[] Perso_SegundoNombre { get; set; }
        [Required]

        public string[] Perso_PrimerApellido { get; set; }
        public string[] Perso_SegundoApellido { get; set; }
        [Required]

        public string[] Perso_Sexo { get; set; }
        [Required]

        public int[] Ident_Id { get; set; }
        [Required]

        public int Poliz_Id { get; set; }
        [Required]

        public int[] Paren_Id { get; set; }

        public int Perso_UsuarioCreacion { get; set; }
        public DateTime Perso_FechaCreacion { get; set; }
        public int? Perso_UsuarioModificacion { get; set; }
        public DateTime? Perso_FechaModificacion { get; set; }
        public bool? Perso_Estado { get; set; }

        public int quantity {get; set;}

    }
}
