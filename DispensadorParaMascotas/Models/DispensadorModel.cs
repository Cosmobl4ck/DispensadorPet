<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;

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
                if (value <= 0)
                    throw new ArgumentException("La capacidad máxima debe ser mayor que 0");

                _capacidadMaxima = value;

                // Ajusta el nivel actual si excede la nueva capacidad
                if (_nivelActual > _capacidadMaxima)
                    _nivelActual = _capacidadMaxima;
            }
        }

        private double _nivelActual = 2.0;
        public double NivelActual
        {
            get { return _nivelActual; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El nivel no puede ser negativo");

                if (value > CapacidadMaxima)
                    throw new ArgumentException("El nivel no puede superar la capacidad máxima");

                _nivelActual = value;
            }
        }

        public double ObtenerPorcentaje()
        {
            if (CapacidadMaxima == 0)
                return 0;

            return NivelActual / CapacidadMaxima;
        }

        public void RestarComida(double cantidad)
        {
            if (cantidad < 0)
                throw new ArgumentException("La cantidad no puede ser negativa");

            NivelActual = Math.Max(0, NivelActual - cantidad);
        }

        public void AgregarComida(double cantidad)
        {
            if (cantidad < 0)
                throw new ArgumentException("La cantidad no puede ser negativa");

            NivelActual = Math.Min(CapacidadMaxima, NivelActual + cantidad);
        }
    }
}
>>>>>>> 80b11f0f7615b252f98e232ea1a201069262f365
