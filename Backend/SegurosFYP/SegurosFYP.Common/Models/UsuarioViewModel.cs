using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SegurosFYP.Common
{
    public class UsuarioViewModel
    {
        public int Usuar_Id { get; set; }
        public string Usuar_Usuario { get; set; }
        public string Usuar_Contrasena { get; set; }
        public int Emple_Id { get; set; }
        public int Roles_Id { get; set; }
        public bool Usuar_Admin { get; set; }
        public DateTime Usuar_UltimaSesion { get; set; }
        public int Usuar_UsuarioCreacion { get; set; }
        public DateTime Usuar_FechaCreacion { get; set; }
        public int? Usuar_UsuarioModificacion { get; set; }
        public DateTime? Usuar_FechaModificacion { get; set; }
        public bool? Usuar_Estado { get; set; }
        
        [NotMapped]
        public string Perso_NombreCompleto { get; set; }
        [NotMapped]
        public string Roles_Descripcion { get; set; }
        [NotMapped]
        public string UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioModificacion { get; set; }
    }
}
