using ITLATV.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ITLATV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Inicio()
        {
            return View();
        }
        public IActionResult Contenido()
        {
            return View();
        }
        public IActionResult Productora()
        {
            return View();
        }
        public IActionResult Generos()
        {
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
