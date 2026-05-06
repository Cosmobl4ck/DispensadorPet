using System;
using System.Collections.Generic;
using System.Text;

namespace DispensadorParaMascotas.Model
{
    internal class DispensadorModel
    {
        private double _capacidadMaxima = 2.0;
        public double CapacidadMaxima
        {
            get { return _capacidadMaxima; }
            set
            {
                if (value > 0)
                    _capacidadMaxima = value;
            }
        }

        private double _nivelActual = 2.0;
        public double NivelActual
        {
            get { return _nivelActual; }
            set
            {
                if (value >= 0 && value <= CapacidadMaxima)
                    _nivelActual = value;
            }
        }
        

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
