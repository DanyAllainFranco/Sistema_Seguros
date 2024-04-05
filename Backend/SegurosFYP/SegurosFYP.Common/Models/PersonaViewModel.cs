using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Common.Models
{
    public class PersonaViewModel
    {
        public int Perso_Id { get; set; }
        public string[] Perso_PrimerNombre { get; set; }
        public string[] Perso_SegundoNombre { get; set; }
        public string[] Perso_PrimerApellido { get; set; }
        public string[] Perso_SegundoApellido { get; set; }
        public string[] Perso_Sexo { get; set; }
        public int[] Ident_Id { get; set; }
        public int? Estci_Id { get; set; }
        public string Perso_Telefono { get; set; }
        public string Perso_CorreoElectronico { get; set; }
        public string Perso_Direccion { get; set; }
        public string Munic_Id { get; set; }
        public int? Paise_Id { get; set; }
        public int Poliz_Id { get; set; }
        public int[] Paren_Id { get; set; }
        public int Perso_UsuarioCreacion { get; set; }
        public DateTime Perso_FechaCreacion { get; set; }
        public int? Perso_UsuarioModificacion { get; set; }
        public DateTime? Perso_FechaModificacion { get; set; }
        public bool? Perso_Estado { get; set; }

        public string DniFrenteUrl { get; set; }
        public string DniAtrasUrl { get; set; }


        public int quantity { get; set; }
    }
}
