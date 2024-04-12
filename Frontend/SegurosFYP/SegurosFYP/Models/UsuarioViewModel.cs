using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class UsuarioViewModel
    {
        [Display(Name = "ID")]
        public int Usuar_Id { get; set; }
        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "El campo es requerido")]

        public string Usuar_Usuario { get; set; }
        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El campo es requerido")]

        public string Usuar_Contrasena { get; set; }
        [Display(Name = "Empleado")]
        [Required(ErrorMessage = "El campo es requerido")]

        public int Emple_Id { get; set; }

        [Display(Name = "Rol")]
        [Required(ErrorMessage = "El campo es requerido")]

        public int Roles_Id { get; set; }
        [Display (Name = "Admin")]
        public bool Usuar_Admin { get; set; }
        public DateTime Usuar_UltimaSesion { get; set; }
        public int Usuar_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime Usuar_FechaCreacion { get; set; }
        public int? Usuar_UsuarioModificacion { get; set; }
        [Display(Name = "Fecha Modificacion")]
        public DateTime? Usuar_FechaModificacion { get; set; }
        public bool? Usuar_Estado { get; set; }

        [NotMapped]
        [Display(Name = "Empleado")]

        public string Perso_NombreCompleto { get; set; }
        [NotMapped]
        [Display(Name = "Rol")]

        public string Roles_Descripcion { get; set; }
        [NotMapped]
        [Display(Name = "Usuario Creacion")]

        public string UsuarioCreacion { get; set; }
        [NotMapped]
        [Display(Name = "Usuario Modificacion")]

        public string UsuarioModificacion { get; set; }

        [NotMapped]
        public string Usua_Nombre { get; set; }

        [NotMapped]
        public int Usua_Id { get; set; }

        [NotMapped]
        public string Usua_Contrasenia { get; set; }

        [NotMapped]
        public string Panta_Descripcion { get; set; }
    }
}
