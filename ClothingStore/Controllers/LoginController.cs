using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
