using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class JuegoService
    {
        public Archivo archivo = new Archivo();

        /*public bool AgregarJuego(Juego juego)
        {
            if (juego.ValidarDatos() is true)
            {
                juego.NroJuego = Archivo.LeerArchivoJuego().Count + 1;
                juego.TipoJuego = AsignarTipo(juego.Tipo);
                Archivo.GuardarArchivoJuego(juego);
                return true;
            }
            return false;
        }*/

        public List<JuegoTarde> MostrarJuegosTarde()
        {
            List<JuegoTarde> ListadoJuegos = archivo.LeerArchivoJuegoTarde();

            List<JuegoTarde> listado = ListadoJuegos.FindAll(n => n.Eliminado == false);

            return listado;
        }

        public List<JuegoNoche> MostrarJuegosNoche()
        {
            List<JuegoNoche> ListadoJuegos = archivo.LeerArchivoJuegoNoche();

            List<JuegoNoche> listado = ListadoJuegos.FindAll(n => n.Eliminado == false);

            return listado;
        }

        /*public Tipo AsignarTipo(int tipo)
        {
            if (tipo == 1)
            {
                return Tipo.Tarde;
            }
            return Tipo.Noche;
        }*/
    }
}
