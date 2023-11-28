using Data;
using Logica;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JuegoTardeController : Controller
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
