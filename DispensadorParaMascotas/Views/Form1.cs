using DispensadorParaMascotas.Controllers;
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
        private double _nivelDeposito = 0.85;     // 85% de capacidad total del tanque

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // --- DIMENSIONES ---
            int diametroInterno = 250;
            int xInt = (pnlContenido.Width - diametroInterno) / 2;
            int yInt = (pnlContenido.Height - diametroInterno) / 2 - 20;
            Rectangle rectInterno = new Rectangle(xInt, yInt, diametroInterno, diametroInterno);

            // Usamos margenExtra para que el código sea dinámico
            int margenExtra = 40;
            Rectangle rectExterior = new Rectangle(
                xInt - (margenExtra / 2),
                yInt - (margenExtra / 2),
                diametroInterno + margenExtra,
                diametroInterno + margenExtra
            );

            // --- 1. LÓGICA DEL CÍRCULO EXTERIOR (PLATEADO) ---
            // Definimos los colores para el efecto "Plata"
            Color colorPlataFondo = Color.FromArgb(60, 192, 192, 192); // Plata translúcido
            Color colorPlataSolido = Color.FromArgb(200, 200, 200);   // Plata sólido

            // CAMBIO DE COLOR DINÁMICO: Si el depósito está bajo (< 15%)
            if (_nivelDeposito < 0.15)
            {
                colorPlataSolido = Color.FromArgb(255, 80, 80); // Cambia a un rojo suave de alerta
            }

            // Dibujar fondo del anillo exterior
            using (Pen penFondoExt = new Pen(colorPlataFondo, 6))
            {
                g.DrawEllipse(penFondoExt, rectExterior);
            }

            // Dibujar progreso del anillo exterior
            float sweepExterior = (float)(_nivelDeposito * 360);
            using (Pen penPlata = new Pen(colorPlataSolido, 6))
            {
                penPlata.StartCap = LineCap.Round;
                penPlata.EndCap = LineCap.Round;
                g.DrawArc(penPlata, rectExterior, -90, sweepExterior);
            }

            // --- 2. CÍRCULO INTERNO (TU PETRONAS ORIGINAL) ---
            // Fondo gris del panel
            using (Pen penFondo = new Pen(Color.FromArgb(45, 45, 48), 15))
            {
                g.DrawEllipse(penFondo, rectInterno);
            }

            float sweepInterno = (float)(_porcentajeComida * 360);

            // Glow Petronas
            using (Pen penGlow = new Pen(Color.FromArgb(40, 0, 161, 155), 22))
            {
                g.DrawArc(penGlow, rectInterno, -90, sweepInterno);
            }

            // Arco Petronas Sólido
            using (Pen penAqua = new Pen(Color.FromArgb(0, 161, 155), 15))
            {
                penAqua.StartCap = LineCap.Round;
                penAqua.EndCap = LineCap.Round;
                g.DrawArc(penAqua, rectInterno, -90, sweepInterno);
            }
        }

        private void ConfigurarFotoPug()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picMascota.Width, picMascota.Height);
            picMascota.Region = new Region(path);
            picMascota.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            pnlContenido.Controls.Clear();

            var form = new MascotaForm();
            var controller = new MascotaController(form);

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // 🔥 ESCUCHAR CUANDO QUIERA VOLVER
            form.VolverInicioSolicitado += (s, ev) =>
            {
                pnlContenido.Controls.Clear();
                pnlContenido.Invalidate();
            };

            pnlContenido.Controls.Add(form);
            form.Show();
        }
    }
}
