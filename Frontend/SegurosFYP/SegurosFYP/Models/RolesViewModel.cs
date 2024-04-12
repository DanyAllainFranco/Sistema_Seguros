using SegurosFYP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class RolesViewModel
    {
        [Display(Name = "ID")]
        public int Roles_Id { get; set; }
        [Display(Name = "Roles")]

        public string Roles_Descripcion { get; set; }
        public int Roles_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime Roles_FechaCreacion { get; set; }
        public int? Roles_UsuarioModificacion { get; set; }
        [Display(Name = "Fecha Modificacion")]

        public DateTime? Roles_FechaModificacion { get; set; }
        public bool? Roles_Estado { get; set; }

        [NotMapped]
        public List<PantallaViewModel> pantallas { get; set; }

        [NotMapped]
        public List<int> PantallasID { get; set; }

        [NotMapped]
        [Display(Name = "Usuario Creacion")]
        public string UsuarioCreacion { get; set; }
        [NotMapped]
        [Display(Name = "Usuario Modificacion")]
        public string UsuarioModificacion { get; set; }

    }
}
