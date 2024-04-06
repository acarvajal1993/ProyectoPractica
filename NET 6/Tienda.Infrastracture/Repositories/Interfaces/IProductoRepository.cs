using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Core.Entities;

namespace Tienda.Infrastracture.Reposotories.Interfaces
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> ListarProductos();
    }
}
