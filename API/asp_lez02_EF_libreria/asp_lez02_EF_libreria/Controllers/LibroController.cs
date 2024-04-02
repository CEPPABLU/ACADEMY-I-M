using asp_lez02_EF_libreria.Models;
using asp_lez02_EF_libreria.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace asp_lez02_EF_libreria.Controllers
{
    [ApiController]
    [Route("api/libri")]
    public class LibroController : Controller
    {
        [HttpGet]                                   //https://localhost:7120/api/libri

        public IActionResult ElencoLibri()
        {
            return Ok(LibroRepo.getIstanza().GetAll());
        }

        [HttpGet("{valCodice}")]
        public IActionResult DettaglioLibro(string valCodice)
        {
            Libro? lib = LibroRepo.getIstanza().GetByCodice(valCodice);
            if(lib is not null)
                return Ok(lib);

            return NotFound();
        }

        [HttpPost]
        public IActionResult InserisciLibro(Libro objLib)
        {
            if (LibroRepo.getIstanza().insert(objLib))
                return Ok();

            return BadRequest();
        }

        [HttpDelete("{varId}")]                           //Danger

        public IActionResult EliminaLibro(int varId)
        {
            if (LibroRepo.getIstanza().delete(varId))
                return Ok();
            return BadRequest();
        }

        //TODO: Elimina per codice
        [HttpDelete("codice/{valCodice}")]
        public IActionResult EliminaPerCodice(string valCodice)
        {
            Libro? lib = LibroRepo.getIstanza().GetByCodice(valCodice);
            if (lib is null)
                return BadRequest();

            return EliminaLibro(lib.LibroId);

            //if (LibroRepo.getIstanza().delete(lib.LibroId))
            //    return Ok();
            //return BadRequest();
        }

        //TODO: Modifica

        [HttpPut]

        public IActionResult ModificaLib(Libro objLib)
        {
           if(LibroRepo.getIstanza().update(objLib))
                return Ok();
           return BadRequest();

        }
    }
}
