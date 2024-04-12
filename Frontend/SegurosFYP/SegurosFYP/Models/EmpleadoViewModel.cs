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
        [Display(Name = "Cod. de Empleado")]
        [Required(ErrorMessage = "El campo es requerido")]

        public int Emple_Id { get; set; }
        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "El campo es requerido")]


        public int Cargo_Id { get; set; }
        public int Emple_UsuarioCreacion { get; set; }
        public DateTime Emple_FechaCreacion { get; set; }
        public int? Emple_UsuarioModificacion { get; set; }
        public DateTime? Emple_FechaModificacion { get; set; }
        public bool? Emple_Estado { get; set; }
        [Display(Name = "Usuario Modificacion")]
        public string UsuarioModificacion { get; set; }
        [Display(Name = "Usuario Creacion")]
        public string UsuarioCreacion { get; set; }

        [Display (Name = "Estado Civil")]
        [Required(ErrorMessage = "El campo es requerido")]

        public int? Estci_Id { get; set; }
        [Display(Name = "Numero telefonico")]

        public string Perso_Telefono { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]

        [Display(Name = "Correo Electronico")]

        public string Perso_CorreoElectronico { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]

        [Display(Name = "Direccion")]

        public string Perso_Direccion { get; set; }
        [Display(Name = "Municipio")]
        [Required(ErrorMessage = "El campo es requerido")]

        public string Munic_Id { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]



        [Display(Name = "Tipo de Identificacion")]
        public int Tiden_Id { get; set; }

        [Display(Name = "Codigo de Identificacion")]
        [Required(ErrorMessage = "El campo es requerido")]

        public string Ident_NumeroIdentificacion { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]

        [Display(Name = "Fecha de Nacimiento")]
        public DateTime Ident_FechaNacimiento { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]


        [Display(Name = "Lugar de Nacimiento")]
        public string Ident_LugarNacimiento { get; set; }


        [Display (Name = "Primer Nombre")]
        [Required(ErrorMessage = "El campo es requerido")]

        public string Perso_PrimerNombre { get; set; }

        [Display(Name = "Segundo Nombre")]

        public string Perso_SegundoNombre { get; set; }

        [Display(Name = "Primer Apellido")]
        [Required(ErrorMessage = "El campo es requerido")]

        public string Perso_PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]

        public string Perso_SegundoApellido { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]

        [Display(Name = "Sexo")]
        public string Perso_Sexo { get; set; }

        [Display(Name = "Nombre")]

        public string Perso_NombreCompleto { get; set; }


        [Display(Name = "Cargo")]
        public string Cargo_Descripcion { get; set; }
    }
}
