using SegurosFYP.Common.Models;
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
        public Cliente1ViewModel Cliente1 { get; set; }

        public DependienteViewModel Dependiente { get; set; }
        public IdentificacionViewModel Identificacion { get; set; }
        public IEnumerable<TipoPlanViewModel> TiposdePlan { get; set; }
        public TipoPlanViewModel TipodePlan { get; set; }
        public EmpleadoViewModel Empleado { get; set; }
        public IEnumerable<DependientesViewModel> Dependientes { get; set; }
        public ConyugueViewModel Conyugue { get; set; }
    }
}
