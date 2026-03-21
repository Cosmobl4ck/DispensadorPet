using System;

namespace DispensadorParaMascotas.Views
{
    internal interface IMascotaView
    {
        // Evento del botón guardar
        event EventHandler GuardarSolicitado;

        // Datos del formulario
        string Nombre { get; }
        int Edad { get; }
        double Peso { get; }
        double Altura { get; }
        string Dueno { get; }
        string Comida { get; }
        string Foto { get; }

        // Mostrar mensajes
        void MostrarMensaje(string mensaje);
    }
}
