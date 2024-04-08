using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Common.Models
{
     public class FrecuenciaViewModel
    {
        public int Frecu_Id { get; set; }
        public string Frecu_Descripcion { get; set; }
        public int Frecu_UsuarioCreacion { get; set; }
        public DateTime Frecu_FechaCreacion { get; set; }
        public int? Frecu_UsuarioModificacion { get; set; }
        public DateTime? Frecu_FechaModificacion { get; set; }
        public bool? Frecu_Estado { get; set; }

        [NotMapped]
        public string UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioModificacion { get; set; }
    }
}
