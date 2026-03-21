using System;
using DispensadorParaMascotas.Models;
using DispensadorParaMascotas.Views;

namespace DispensadorParaMascotas.Controllers
{
    internal class MascotaController
    {
        private readonly IMascotaView _view;

        public MascotaController(IMascotaView view)
        {
            _view = view;

            // Escucha cuando el usuario da click en Guardar
            _view.GuardarSolicitado += OnGuardar;
        }

        private void OnGuardar(object sender, EventArgs e)
        {
            try
            {
                Mascota mascota = new Mascota
                {
                    Nombre = _view.Nombre,
                    Edad = _view.Edad,
                    Peso = _view.Peso,
                    Altura = _view.Altura,
                    Dueno = _view.Dueno,
                    Comida = _view.Comida,
                    Foto = _view.Foto
                };

                // Aquí puedes guardar en BD después

                _view.MostrarMensaje("Mascota guardada correctamente 🐾");
            }
            catch (Exception ex)
            {
                _view.MostrarMensaje("Error: " + ex.Message);
            }
        }
    }
}