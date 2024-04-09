using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class PolizaCompletaViewModel
    {
        public PolizaViewModel Poliza { get; set; }
        public ClienteViewModel Cliente { get; set; }
        public DependienteViewModel Dependiente { get; set; }
        public IdentificacionViewModel Identificacion { get; set; }
    }
}
