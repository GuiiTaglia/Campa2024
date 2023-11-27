using Microsoft.AspNetCore.Mvc;
using Logica;
using Data;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class JuegoController : ControllerBase
    {
        public JuegoService administrador = new JuegoService();


        /*[HttpPost]
        public IActionResult AgregarJuego(Juego juego)
        {
            bool resultado = administrador.AgregarJuego(juego);
            if (resultado == true)
            {
                return Ok();
            }
            return BadRequest();
        }*/

        [HttpGet("")]
        public IActionResult MostrarJuegosTarde()
        {
            List<JuegoTarde> listado = administrador.MostrarJuegosTarde();
            if (listado != null)
            {
                return Ok(listado);
            }
            return BadRequest();
        }

        
    }
}
