using System;
using System.Collections.Generic;
using System.Text;

namespace DispensadorParaMascotas.Views
{
    internal interface IDispensadorView
    {
        // Evento que se dispara cuando el usuario hace clic en dispensar
        event EventHandler DispensarSolicitado;

        // Método para que el controlador actualice la UI
        void ActualizarDatos(double kg, double porcentaje);
    }
}
