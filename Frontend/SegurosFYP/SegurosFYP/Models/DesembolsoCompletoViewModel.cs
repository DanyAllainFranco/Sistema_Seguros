using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class DesembolsoCompletoViewModel
    {
        public ReclamoViewModel Reclamo { get; set; }

        public InformeMedicoViewModel Informe { get; set; }

        public PrescripcionViewModel Prescripcion { get; set; }

        public FacturaMedicaEncabezadoViewModel Encabezado { get; set; }

        public FacturaMedicaDetalleViewModel Detalle { get; set; }
    }
}
