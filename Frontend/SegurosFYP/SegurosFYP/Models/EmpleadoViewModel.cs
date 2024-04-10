using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class EmpleadoViewModel
    {
        [Display(Name = "ID")]

        public int Emple_Id { get; set; }
        [Display(Name = "Cargo")]

        public int Cargo_Id { get; set; }
        public int Emple_UsuarioCreacion { get; set; }
        public DateTime Emple_FechaCreacion { get; set; }
        public int? Emple_UsuarioModificacion { get; set; }
        public DateTime? Emple_FechaModificacion { get; set; }
        public bool? Emple_Estado { get; set; }

        public string UsuarioModificacion { get; set; }
        public string UsuarioCreacion { get; set; }

        [Display (Name = "Estado Civil")]
        public int? Estci_Id { get; set; }
        [Display(Name = "Numero telefonico")]

        public string Perso_Telefono { get; set; }
        [Display(Name = "Correo Electronico")]

        public string Perso_CorreoElectronico { get; set; }
        [Display(Name = "Direccion")]

        public string Perso_Direccion { get; set; }
        [Display(Name = "Municipio")]
        public string Munic_Id { get; set; }
         

        [Display(Name = "Tipo de Identificacion")]
        public int Tiden_Id { get; set; }

        [Display(Name = "Codigo de Identificacion")]
        public string Ident_NumeroIdentificacion { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        public DateTime Ident_FechaNacimiento { get; set; }

        [Display(Name = "Lugar de Nacimiento")]
        public string Ident_LugarNacimiento { get; set; }


        [Display (Name = "Primer Nombre")]
        public string Perso_PrimerNombre { get; set; }

        [Display(Name = "Segundo Nombre")]

        public string Perso_SegundoNombre { get; set; }

        [Display(Name = "Primer Apellido")]

        public string Perso_PrimerApellido { get; set; }

        [Display(Name = "Primer Apellido")]

        public string Perso_SegundoApellido { get; set; }

        [Display(Name = "Sexo")]

        public string Perso_Sexo { get; set; }
        [Display(Name = "Cargo")]

        public string Cargo_Descripcion { get; set; }


      
    }
}
