using System;
using System.ComponentModel.DataAnnotations;

namespace SegurosFYP.Models
{
    public class DepartamentoViewModel
    {
        [Display(Name = "Codigo")]
        public string Depar_Id { get; set; }
        [Display(Name = "Departamento")]
        public string Depar_Descripcion { get; set; }
        [Display(Name = "Usuario Creacion")]
        public int Depar_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime Depar_FechaCreacion { get; set; }
        [Display(Name = "Usuario Modificacion")]
        public int? Depar_UsuarioModificacion { get; set; }
        [Display(Name = "Usuario Modificacion")]
        public DateTime? Depar_FechaModificacion { get; set; }
        public bool? Depar_Estado { get; set; }

    }
}
