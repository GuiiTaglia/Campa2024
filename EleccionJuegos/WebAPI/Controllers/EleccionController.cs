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
        public VotacionService adm = new VotacionService(); 

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

        //Juegos Votos

        [HttpGet("")]
        public IActionResult MostrarVotosJuegos()
        {
            List<JuegoVotos> listado = adm.JuegosVotacion();
            if (listado != null)
            {
                return Ok(listado);
            }
            return BadRequest();
        }



    }
}
