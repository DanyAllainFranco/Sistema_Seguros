﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SegurosFYP.Entities.Entities
{
    public partial class tbPantallas
    {
        public tbPantallas()
        {
            tbPantallasPorRoles = new HashSet<tbPantallasPorRoles>();
        }

        public int Panta_Id { get; set; }
        public string Panta_Descripcion { get; set; }
        public int Panta_UsuarioCreacion { get; set; }
        public DateTime Panta_FechaCreacion { get; set; }
        public int? Panta_UsuarioModificacion { get; set; }
        public DateTime? Panta_FechaModificacion { get; set; }
        public bool? Panta_Estado { get; set; }

        public virtual tbUsuarios Panta_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios Panta_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPantallasPorRoles> tbPantallasPorRoles { get; set; }
    }
}