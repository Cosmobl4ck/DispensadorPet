using System.Drawing.Drawing2D;

namespace DispensadorParaMascotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            // Forzamos a que el panel se dibuje al iniciar
            pnlContenido.Invalidate();
        }

        private double _porcentajeComida = 0.725; // 1.45kg de 2.0kg = 72.5%

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Para que no se vea "pixelado"

            // Definimos el área del círculo (centrado en el panel)
            int diametro = 250;
            int x = (pnlContenido.Width - diametro) / 2;
            int y = (pnlContenido.Height - diametro) / 2 - 20; // Un poco arriba del centro
            Rectangle rect = new Rectangle(x, y, diametro, diametro);

            // 1. Dibujar el fondo del círculo (Gris más claro)
            using (Pen penFondo = new Pen(Color.FromArgb(45, 45, 48), 15))
            {
                g.DrawEllipse(penFondo, rect);
            }

            // 2. Dibujar el Brillo Neón (Glow) Aqua
            // Calculamos el ángulo: 360 grados * porcentaje
            float sweepAngle = (float)(_porcentajeComida * 360);

            using (Pen penGlow = new Pen(Color.FromArgb(50, 0, 161, 155), 22))
            {
                g.DrawArc(penGlow, rect, -90, sweepAngle);
            }

            // 3. Dibujar el arco principal (Aqua Petronas sólido)
            using (Pen penAqua = new Pen(Color.FromArgb(0, 161, 155), 15))
            {
                penAqua.StartCap = LineCap.Round;
                penAqua.EndCap = LineCap.Round;
                g.DrawArc(penAqua, rect, -90, sweepAngle);
            }
        }

        private void ConfigurarFotoPug()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picMascota.Width, picMascota.Height);
            picMascota.Region = new Region(path);
            picMascota.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
