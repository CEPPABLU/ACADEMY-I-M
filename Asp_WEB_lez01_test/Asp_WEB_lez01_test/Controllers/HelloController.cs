using Asp_WEB_lez01_test.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp_WEB_lez01_test.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Titolo = "Ciao, titolo della pagina";
            ViewBag.Sottotitolo = "Sono il sottotitolo";

            Persona persona = new Persona()
            {
                Nominativo = "Giovanni Pace",
                CodFis = "ifhif"
            };
            return View(persona);
        }
    }
}
