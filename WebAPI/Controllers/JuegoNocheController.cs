using Microsoft.AspNetCore.Mvc;
using Logica;
using Data;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class JuegoNocheController : ControllerBase
    {
        public JuegoService administrador = new JuegoService();
                
        [HttpGet("")]
        public IActionResult MostrarJuegoNoche()
        {
            List<JuegoNoche> listado = administrador.MostrarJuegosNoche();
            if (listado != null)
            {
                return Ok(listado);
            }
            return BadRequest();
        }

    }
}
