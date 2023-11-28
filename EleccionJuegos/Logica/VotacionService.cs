using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VotacionService
    {
        Archivo archivo = new Archivo();

        public List<JuegoVotos> JuegosVotacion()
        {
            List<JuegoVotos> resultado = new List<JuegoVotos>();
            List<Eleccion> elecciones = archivo.LeerArchivoEleccion();
            foreach (Eleccion eleccion in elecciones)
            {
                if (resultado == null)
                {
                    JuegoVotos juego = new JuegoVotos()
                    {
                        Juegos = eleccion.NroJuegoElegido,
                        CantVotos = 1
                    };
                    resultado.Add(juego);
                }
                else
                {
                    bool res = false;
                    foreach (JuegoVotos juego in resultado)
                    {
                        if (eleccion.NroJuegoElegido == juego.Juegos)
                        {
                            juego.CantVotos += 1;
                            res = true;
                        }
                    }
                    if (res is false)
                    {
                        JuegoVotos juego = new JuegoVotos()
                        {
                            Juegos = eleccion.NroJuegoElegido,
                            CantVotos = 1
                        };
                        resultado.Add(juego);
                    }
                }
            }
            return resultado;
        }
    }
}
