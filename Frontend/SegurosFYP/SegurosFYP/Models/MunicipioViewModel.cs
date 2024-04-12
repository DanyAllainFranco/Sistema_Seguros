using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class MunicipioViewModel
    {
        [Display (Name = "Codigo" )]
        public string Munic_Id { get; set; }
        [Display(Name = "Municipio")]
        public string Munic_Descripcion { get; set; }
        [NotMapped]
        [Display(Name = "Departamento")]
        public string Depar_Descripcion { get; set; }
        public string Depar_Id { get; set; }
        public int Munic_UsuarioCreacion { get; set; }
        [Display(Name = "Fecha Creacion")]
        public DateTime Munic_FechaCreacion { get; set; }
        public int? Munic_UsuarioModificacion { get; set; }
        [Display(Name = "Fecha Modificacion")]

        public DateTime? Munic_FechaModificacion { get; set; }
        public bool? Munic_Estado { get; set; }

        [NotMapped]
        [Display(Name = "Usuario Creacion")]

        public string UsuarioCreacion { get; set; }
        [NotMapped]
        [Display(Name = "Fecha Modificacion")]

        public string UsuarioModificacion { get; set; }
    }
}
