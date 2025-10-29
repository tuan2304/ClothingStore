using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
