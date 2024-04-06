using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tienda.Infrastracture.Reposotories.Interfaces;
using Tienda.Web.Models;

namespace Tienda.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductoRepository productoRepository;

        public HomeController(ILogger<HomeController> logger, IProductoRepository productoRepository)
        {
            _logger = logger;
            this.productoRepository = productoRepository;
        }

        public async Task<IActionResult> Index()
        {
            var productos = await productoRepository.ListarProductos();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
