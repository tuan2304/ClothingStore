using System.Diagnostics;
using ClothingStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ClothingStoreContext context;
        public HomeController(ILogger<HomeController> logger, ClothingStoreContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            List<Product> products = context.Products.ToList();
            return View("Home",products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutUs()
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
