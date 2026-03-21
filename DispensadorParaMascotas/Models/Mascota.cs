using System.ComponentModel.DataAnnotations;

namespace DispensadorParaMascotas.Models
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Dueno { get; set; }
        public string Comida { get; set; }
        public string Foto { get; set; }
    }
}