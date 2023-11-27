using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Eleccion
    {
        public Eleccion()
        {
            Eleccion eleccion = new Eleccion()
            {
                NroJuegoElegido = 1,
                NroEquipoVotante = 10000
            };
            Archivo archivo = new Archivo();
            archivo.GuardarArchivoEleccion(eleccion);
        }
        public int NroJuegoElegido { get; set; }
        public int NroEquipoVotante { get; set; }
        public DateTime? FechaEleccion { get; set; }

        public bool ValidarDatos()
        {
            if (NroJuegoElegido == null || NroJuegoElegido == 0 || NroJuegoElegido > 5)
            {
                return false;
            }

            if (NroEquipoVotante == null || NroEquipoVotante == 0)
            {
                return false;
            }
            return true;
        }
    }
}
