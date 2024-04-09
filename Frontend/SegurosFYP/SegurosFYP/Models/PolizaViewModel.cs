using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class PolizaViewModel
    {
        public int Poliz_Id { get; set; }
        [Required]
        [Display(Name = "Contractor")]
        public int Clien_Id { get; set; }
        [Required]
        [Display(Name = "Tipos de Planes")]
        public int Tipos_Id { get; set; }
        [Required]
        [Display(Name = "Empleados")]
        public int Emple_Id { get; set; }
        [Required]
        [Display(Name = "Cantidad de Cuotas")]
        public int Poliz_Cuotas { get; set; }
        [Required]
        [Display(Name = "Estado de Cuota")]
        public bool Poliz_EstadoCuotasPoliza { get; set; }

        public int Poliz_UsuarioCreacion { get; set; }
        public DateTime Poliz_FechaCreacion { get; set; }
        public int? Poliz_UsuarioModificacion { get; set; }
        public DateTime? Poliz_FechaModificacion { get; set; }
        public bool? Poliz_Estado { get; set; }
        public int quantity { get; set; }

        //[NotMapped]
        //public string UsuarioCreacion { get; set; }
        //[NotMapped]
        //public string UsuarioModificacion { get; set; }

        //[NotMapped]
        //public string Perso_NombreCompleto { get; set; }
        //[NotMapped]
        //public string Tipo_Descripcion { get; set; }
    }
}

