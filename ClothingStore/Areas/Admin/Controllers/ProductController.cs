using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductManager()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateProduct(){
            return View();
        }


        [HttpGet]
        public IActionResult EditProduct()
        {
            return View();
        }
    }
}
