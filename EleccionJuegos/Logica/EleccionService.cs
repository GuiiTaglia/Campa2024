﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Logica
{
    public class EleccionService
    {
        public Archivo archivo = new Archivo();

        public bool AgregarEleccion(Eleccion eleccion)
        {
            eleccion.FechaEleccion = DateTime.Today.Date;
            archivo.GuardarArchivoEleccion(eleccion);
            return true;
        }
    }
}
