﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SegurosFYP.Entities.kkkk
{
    public partial class tbPrescripciones
    {
        public int Presc_Id { get; set; }
        public int Recla_Id { get; set; }
        public string Presc_DocumentoAdelante { get; set; }
        public string Presc_DocumentoAtras { get; set; }
        public int Presc_UsuarioCreacion { get; set; }
        public DateTime Presc_FechaCreacion { get; set; }
        public int? Presc_UsuarioModificacion { get; set; }
        public DateTime? Presc_FechaModificacion { get; set; }
        public bool? Presc_Estado { get; set; }

        public virtual tbReclamos Recla { get; set; }
    }
}