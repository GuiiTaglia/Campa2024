using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Data
{
    public class Archivo
    {
        private List<JuegoNoche> ListadoJuegosNoche;
        private List<JuegoTarde> ListadoJuegosTarde;
        private List<Eleccion> ListadoElecciones;

        public Archivo()
        {
            ListadoJuegosNoche = new List<JuegoNoche>();
            ListadoJuegosTarde = new List<JuegoTarde>();
            ListadoElecciones = new List<Eleccion>();

            JuegoNoche juego1 = new JuegoNoche()
            {
                NroJuego = 1,
                Nombre = "Clue",
                Descripcion = "Juego muy piola",
                Eliminado = false
            };
            ListadoJuegosNoche.Add(juego1);

            JuegoNoche juego2 = new JuegoNoche()
            {
                NroJuego = 2,
                Nombre = "Pac Man",
                Descripcion = "Juego muy cheto",
                Eliminado = false
            };
            ListadoJuegosNoche.Add(juego2);

            JuegoTarde juego3 = new JuegoTarde()
            {
                NroJuego = 1,
                Nombre = "Donkey Kong",
                Descripcion = "Juego muy bueno",
                Eliminado = false
            };
            ListadoJuegosTarde.Add(juego3);

            Eleccion eleccion = new Eleccion()
            {
                NroJuegoElegido = 10,
                NroEquipoVotante = 100
            };
            GuardarArchivoEleccion(eleccion);
        }

        /*public void GuardarArchivoEleccion(Eleccion eleccion)
        {
            ListadoElecciones.Add(eleccion);
        }

        public List<Eleccion> LeerArchivoEleccion()
        {
            return ListadoElecciones;
        }*/


        public void GuardarArchivoEleccion(Eleccion eleccion)
            {
                var listado = LeerArchivoEleccion();

                listado.Add(eleccion);

                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usersEleccion.json");
                string json = JsonConvert.SerializeObject(listado, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(rutaArchivo, json);
            }

            public List<Eleccion> LeerArchivoEleccion()
            {
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usersEleccion.json");

                if (File.Exists(rutaArchivo))
                {
                    string json = File.ReadAllText(rutaArchivo);
                    return JsonConvert.DeserializeObject<List<Eleccion>>(json);
                }
                else
                {
                    return new List<Eleccion>();
                }
            }

            public List<JuegoNoche> LeerArchivoJuegoNoche()
        {
            return ListadoJuegosNoche;
        }

        public List<JuegoTarde> LeerArchivoJuegoTarde()
        {
            return ListadoJuegosTarde;
        }
    }
}
