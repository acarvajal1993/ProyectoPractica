using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Infrastracture.Data;
using Tienda.Infrastracture.Reposotories;
using Tienda.Infrastracture.Reposotories.Interfaces;

namespace Tienda.Infrastracture
{
    public static class DependencyInjecttion
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TiendaContext>(options => options.UseSqlServer(configuration.GetConnectionString("TiendaEntities")));

            //Repositories
            services.AddScoped<IProductoRepository, ProductoRepository>();

            return services;
        }
    }
}
