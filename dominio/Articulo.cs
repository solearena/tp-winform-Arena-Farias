﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        [DisplayName("Código")]
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        [DisplayName("Imagen Url")]
        public string ImagenUrl { get; set; }
        [DisplayName("Marca")]
        public Marca DescripcionMarca { get; set; }
        [DisplayName("Categoría")]
        public Categoria DescripcionCategoria { get; set; }
    }
}
