using Microsoft.AspNetCore.Mvc;

namespace SecretGardenMVC.Controllers
{
    public class SecretGardenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
