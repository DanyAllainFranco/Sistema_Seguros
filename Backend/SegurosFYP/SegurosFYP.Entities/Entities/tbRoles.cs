﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SegurosFYP.Entities.Entities
{
    public partial class tbRoles
    {
        public tbRoles()
        {
            tbPantallasPorRoles = new HashSet<tbPantallasPorRoles>();
            tbUsuarios = new HashSet<tbUsuarios>();
        }

        public int Roles_Id { get; set; }
        public string Roles_Descripcion { get; set; }
        public int Roles_UsuarioCreacion { get; set; }
        public DateTime Roles_FechaCreacion { get; set; }
        public int? Roles_UsuarioModificacion { get; set; }
        public DateTime? Roles_FechaModificacion { get; set; }
        public bool? Roles_Estado { get; set; }

        public virtual tbUsuarios Roles_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios Roles_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPantallasPorRoles> tbPantallasPorRoles { get; set; }
        public virtual ICollection<tbUsuarios> tbUsuarios { get; set; }
    }
}