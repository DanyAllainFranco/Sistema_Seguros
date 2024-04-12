using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Common.Models
{
    public class PersonaViewModel
    {
        public int Perso_Id { get; set; }
        [Display(Name ="Primer Nombre")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Perso_PrimerNombre { get; set; }
        [Display(Name = "Segundo Nombre")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Perso_SegundoNombre { get; set; }
        [Display(Name = "Primer Apellido")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Perso_PrimerApellido { get; set; }
        [Display(Name = "Segundo Apellido")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Perso_SegundoApellido { get; set; }
        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Perso_Sexo { get; set; }
        public int Ident_Id { get; set; }
        [Display(Name = "Estado Civil")]
        [Required(ErrorMessage = "El campo es requerido")]
        public int? Estci_Id { get; set; }
        [Display(Name = "Telefono")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Perso_Telefono { get; set; }
        [Display(Name = "Correo Electronico")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Perso_CorreoElectronico { get; set; }
        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Perso_Direccion { get; set; }
        [Display(Name = "Municipio")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Munic_Id { get; set; }
        [Display(Name = "Nacionalidad")]
        [Required(ErrorMessage = "El campo es requerido")]
        public int? Paise_Id { get; set; }
        public int Poliz_Id { get; set; }
        [Display(Name = "Parentesco")]
        [Required(ErrorMessage = "El campo es requerido")]
        public int Paren_Id { get; set; }
        public int Perso_UsuarioCreacion { get; set; }
        public DateTime Perso_FechaCreacion { get; set; }
        public int? Perso_UsuarioModificacion { get; set; }
        public DateTime? Perso_FechaModificacion { get; set; }
        public bool? Perso_Estado { get; set; }
    }
}
