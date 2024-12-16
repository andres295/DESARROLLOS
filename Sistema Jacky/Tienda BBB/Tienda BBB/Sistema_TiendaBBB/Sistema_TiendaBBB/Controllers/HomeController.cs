using Microsoft.AspNetCore.Mvc;
using Sistema_TiendaBBB.Models;
using System.Diagnostics;

namespace Sistema_TiendaBBB.Controllers
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


    }
}
