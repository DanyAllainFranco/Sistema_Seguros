using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SegurosFYP.Models
{
    public class DepartamentoViewModel
    {
        [Display(Name = "Codigo")]
        [Required(ErrorMessage = "El campo es requerido")]
        public string Depar_Id { get; set; }
        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "El campo es requerido")]
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


        [NotMapped]
        public string UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioModificacion { get; set; }

        [NotMapped]
        public string Munic_Id { get; set; }
        [NotMapped]
        public string Munic_Descripcion { get; set; }
    }
}
