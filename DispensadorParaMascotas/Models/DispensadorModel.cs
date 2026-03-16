using System;
using System.Collections.Generic;
using System.Text;

namespace DispensadorParaMascotas.Model
{
    internal class DispensadorModel
    {
        public double CapacidadMaxima { get; set; } = 2.0; // En kg
        public double NivelActual { get; set; } = 2.0;     // Empieza lleno

        public double ObtenerPorcentaje()
        {
            return NivelActual / CapacidadMaxima;
        }

        public void RestarComida(double cantidad)
        {
            if (NivelActual >= cantidad)
                NivelActual -= cantidad;
            else
                NivelActual = 0;
        }
    }
}
