using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View("Cart");
        }
    }
}
