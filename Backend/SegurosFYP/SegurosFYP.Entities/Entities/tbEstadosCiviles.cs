﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SegurosFYP.Entities.Entities
{
    public partial class tbEstadosCiviles
    {
        public int Estad_Id { get; set; }
        public string Estad_Descripcion { get; set; }
        public int Estad_UsuarioCreacion { get; set; }
        public DateTime Estad_FechaCreacion { get; set; }
        public int? Estad_UsuarioModificacion { get; set; }
        public DateTime? Estad_FechaModificacion { get; set; }
        public bool? Estad_Estado { get; set; }

        public virtual tbUsuarios Estad_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios Estad_UsuarioModificacionNavigation { get; set; }
    }
}