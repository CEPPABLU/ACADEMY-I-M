using Microsoft.AspNetCore.Mvc;

namespace lez_01_introduzione.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
