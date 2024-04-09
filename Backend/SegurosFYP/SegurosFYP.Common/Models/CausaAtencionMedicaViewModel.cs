using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Common.Models
{
   public class CausaAtencionMedicaViewModel
    {
        public int Catme_Id { get; set; }
        public string Catme_Descripcion { get; set; }
        public int Infor_Id { get; set; }
        public int Catme_UsuarioCreacion { get; set; }
        public DateTime Catme_FechaCreacion { get; set; }
        public int? Catme_UsuarioModificacion { get; set; }
        public DateTime? Catme_FechaModificacion { get; set; }
        public bool? Catme_Estado { get; set; }

    }
}
