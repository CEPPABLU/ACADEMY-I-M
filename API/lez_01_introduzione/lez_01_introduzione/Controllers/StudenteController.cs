using lez_01_introduzione.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace lez_01_introduzione.Controllers
{
    [ApiController]
    [Route("api/studente")]
    public class StudenteController : Controller
    {
        [HttpGet("test")]

        public IActionResult TestGet()
        {
            return Ok("Test di GET");
        }
        [HttpPost("test")]
        public IActionResult Post()
        {
            return Ok("Test di POST");
        }
        [HttpGet("dettaglio")]
        public ActionResult<Studente?> RecuperaStudente()
        {
            Studente stu = new Studente()
            {
                Id = 1,
                Name = "Giovanni",
                Surname = "Pace",
                Matricola = "AB123"
            };

            return Ok(stu);
        }
        [HttpGet("elenco")]
        public ActionResult<List<Studente>> ElencoStudenti()
        {
            List<Studente> lista = new List<Studente>
            {

                new Studente()
                {
                    Id = 1,
                    Name = "Giovanni",
                    Surname = "Pace",
                    Matricola = "AB123"
                },
                new Studente()
                {
                    Id = 2,
                    Name = "Valeria",
                    Surname = "Berdi",
                    Matricola = "AB1234"
                }
            };
            return Ok(lista);
        }

        [HttpPost("inserisci")]
        public ActionResult Inserisci(Studente objStu)
        {
            return Ok(objStu);
        }
    }
}
