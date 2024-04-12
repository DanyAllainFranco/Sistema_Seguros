using SegurosFYP.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class EmpleadoPersonaViewModel
    {
        public EmpleadoViewModel Empleado { get; set; }
        public PersonaViewModel Persona { get; set; }
        public Identificacion1ViewModel Identidad { get; set; }
    }
}
