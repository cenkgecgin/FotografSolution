using Microsoft.AspNetCore.Mvc;

namespace Fotograf.Controllers
{
    public class FotografCesitleriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
