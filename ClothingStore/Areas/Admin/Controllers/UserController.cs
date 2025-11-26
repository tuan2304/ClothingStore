using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserManagement()
        {
            return View();
        }
    }
}
