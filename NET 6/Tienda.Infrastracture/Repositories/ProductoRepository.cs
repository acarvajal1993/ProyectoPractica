using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Core.Entities;
using Tienda.Infrastracture.Data;
using Tienda.Infrastracture.Reposotories.Interfaces;

namespace Tienda.Infrastracture.Reposotories
{
    public class ProductoRepository: IProductoRepository
    {
        private readonly TiendaContext context;
        public ProductoRepository(TiendaContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Producto>> ListarProductos()
        {
            return await context.Producto.ToListAsync();
        }
    }
}
