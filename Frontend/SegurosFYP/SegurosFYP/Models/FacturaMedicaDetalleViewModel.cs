﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Models
{
    public class FacturaMedicaDetalleViewModel
    {
        public int Fadet_Id { get; set; }
        public int[] Faenca_Id { get; set; }
        public bool[] Fadet_ProductoServicio { get; set; }
        public string[] Fadet_Descripcion { get; set; }
        public int[] Fadet_Cantidad { get; set; }
        public int[] Unida_Id { get; set; }
        public decimal[] Fadet_Precio { get; set; }
        public int[] Categ_Id { get; set; }
        public int Fadet_UsuarioCreacion { get; set; }
        public DateTime Fadet_FechaCreacion { get; set; }
        public int? Fadet_UsuarioModificacion { get; set; }
        public DateTime? Fadet_FechaModificacion { get; set; }
        public bool? Fadet_Estado { get; set; }
    }
}
