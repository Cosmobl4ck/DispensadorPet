namespace DispensadorParaMascotas.Models
{
    public class HorarioAlimentacion
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public TimeSpan Hora { get; set; }
        public int CantidadGramos { get; set; } = 75;
        public string TipoComida { get; set; } = "Seca (Kibble)";
        public bool Lunes { get; set; }
        public bool Martes { get; set; }
        public bool Miercoles { get; set; }
        public bool Jueves { get; set; }
        public bool Viernes { get; set; }
        public bool Sabado { get; set; }
        public bool Domingo { get; set; }
        public bool Activo { get; set; } = true;

        public bool[] ObtenerDias() =>
            new[] { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo };
    }
}
