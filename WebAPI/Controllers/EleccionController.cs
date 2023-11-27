using Microsoft.AspNetCore.Mvc;
using Logica;
using Data;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class EleccionController : ControllerBase
    {
        public EleccionService administrador = new EleccionService();

        [HttpPost]
        public IActionResult AgregarEleccion([FromBody] Eleccion eleccion)
        {
            bool resultado = administrador.AgregarEleccion(eleccion);
            if (resultado == true)
            {
                return Ok(resultado);
            }
            return BadRequest(resultado);
        }

        

    }
}
