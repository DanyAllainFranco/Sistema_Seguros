﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SegurosFYP.Entities.Entities
{
    public partial class tbCausaAtencionMedica
    {
        public int Catme_Id { get; set; }
        public string Catme_Descripcion { get; set; }
        public int Infor_Id { get; set; }
        public int Catme_UsuarioCreacion { get; set; }
        public DateTime Catme_FechaCreacion { get; set; }
        public int? Catme_UsuarioModificacion { get; set; }
        public DateTime? Catme_FechaModificacion { get; set; }
        public bool? Catme_Estado { get; set; }

        public virtual tbUsuarios Catme_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios Catme_UsuarioModificacionNavigation { get; set; }
        public virtual tbInformeMedico Infor { get; set; }
    }
}