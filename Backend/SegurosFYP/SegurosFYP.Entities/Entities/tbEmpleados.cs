﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SegurosFYP.Entities.Entities
{
    public partial class tbEmpleados
    {
        public tbEmpleados()
        {
            tbPolizas = new HashSet<tbPolizas>();
            tbUsuarios = new HashSet<tbUsuarios>();
        }

        public int Emple_Id { get; set; }
        public int Cargo_Id { get; set; }
        public int Emple_UsuarioCreacion { get; set; }
        public DateTime Emple_FechaCreacion { get; set; }
        public int? Emple_UsuarioModificacion { get; set; }
        public DateTime? Emple_FechaModificacion { get; set; }
        public bool? Emple_Estado { get; set; }

        public virtual tbCargos Cargo { get; set; }
        public virtual tbPersonas Emple { get; set; }
        public virtual tbUsuarios Emple_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios Emple_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPolizas> tbPolizas { get; set; }
        public virtual ICollection<tbUsuarios> tbUsuarios { get; set; }

        [NotMapped]
        public string Perso_PrimerNombre { get; set; }
        [NotMapped]
        public string Perso_SegundoNombre { get; set; }
        [NotMapped]
        public string Perso_PrimerApellido { get; set; }
        [NotMapped]
        public string Perso_SegundoApellido { get; set; }
        [NotMapped]
        public string Perso_Sexo { get; set; }
        [NotMapped]
        public string Cargo_Descripcion { get; set; }

    }
}