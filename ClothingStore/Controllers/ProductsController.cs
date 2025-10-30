using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult AllProduct()
        {
            return View();
        }
        public IActionResult Shirts()
        {
            return View();
        }

        public IActionResult Pants()
        {
            return View();
        }

        public IActionResult Accessories()
        {
            return View();
        }
    }
}
