using Microsoft.AspNetCore.Mvc;
using ClothingStore.Models;

namespace ClothingStore.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private ClothingStoreContext context;
        public ProductController(ClothingStoreContext context)
        {
            this.context = context;
        }
        public IActionResult ProductManager()
        {
            List<Product> products = context.Products.ToList();
            return View(products);
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
