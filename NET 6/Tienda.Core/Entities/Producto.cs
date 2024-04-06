using System;
using System.Collections.Generic;

namespace Tienda.Core.Entities
{
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Precio { get; set; }
        public decimal? PrecionPromocional { get; set; }
        public int Stock { get; set; }
        public string? Color { get; set; }
        public string? Marca { get; set; }
    }
}
