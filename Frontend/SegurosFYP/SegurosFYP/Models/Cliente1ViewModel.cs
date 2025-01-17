﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class ClienteViewModel
    {
        public int Perso_Id { get; set; }
        [Required]
        [Display(Name = "Primer Nombre")]
        public string[] Perso_PrimerNombre { get; set; }
        [Display(Name = "Segundo Nombre")]
        public string[] Perso_SegundoNombre { get; set; }
        [Required]
        [Display(Name = "Primer Apellido")]
        public string[] Perso_PrimerApellido { get; set; }
        [Display(Name = "Segundo Apellido")]
        public string[] Perso_SegundoApellido { get; set; }
        [Required]
        [Display(Name = "Sexo")]
        public string[] Perso_Sexo { get; set; }
        public int[] Ident_Id { get; set; }
        [Required]
        [Display(Name = "Estado Civil")]
        public int? Estci_Id { get; set; }
        [Required]
        [Display(Name = "Telefono")]
        public string Perso_Telefono { get; set; }
        [Required]
        [Display(Name = "Correo Electronico")]
        public string Perso_CorreoElectronico { get; set; }
        [Required]
        [Display(Name = "Direccion")]
        public string Perso_Direccion { get; set; }
        [Required]
        [Display(Name = "Municipio")]
        public string Munic_Id { get; set; }
        [Required]
        [Display(Name = "Nacionalidad")]
        public int? Paise_Id { get; set; }
        [Required]

        public int Poliz_Id { get; set; }
        [Required]
        [Display(Name = "Parentesco")]

        public int[] Paren_Id { get; set; }



        public int Tiden_Id { get; set; }
        [Display(Name = "Codigo de Identificacion")]
        public string Ident_NumeroIdentificacion { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime Ident_FechaNacimiento { get; set; }
        [Display(Name = "Lugar de Nacimiento")]
        public string Ident_LugarNacimiento { get; set; }

        [Display(Name = "Pais")]
        public string Paise_Descripcion { get; set; }
        [Display(Name = "Nacionalidad")]
        public string Paise_Nacionalidad { get; set; }
        [Display(Name = "Departamento")]
        public string Depar_Descripcion { get; set; }
        [Display(Name = "Municipio")]
        public string Munic_Descripcion { get; set; }


        public int Perso_UsuarioCreacion { get; set; }
        public DateTime Perso_FechaCreacion { get; set; }
        public int? Perso_UsuarioModificacion { get; set; }
        public DateTime? Perso_FechaModificacion { get; set; }
        public bool? Perso_Estado { get; set; }

        public int quantity { get; set; }

        public string DniFrenteUrl { get; set; }
        public string DniAtrasUrl { get; set; }

        [Required]
        public IFormFile DniFrente { get; set; }
        [Required]

        public IFormFile DniAtras { get; set; }
    }
}
