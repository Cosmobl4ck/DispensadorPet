using DispensadorParaMascotas.Views;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DispensadorParaMascotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarDatosMascota();
            this.DoubleBuffered = true;

            pnlHeader.Paint += pnlHeader_Paint;
            panel2.Paint += panel2_Paint;
            pnlContenido.Invalidate();
        }

        private enum Vista { Inicio, Programacion, Usuario }
        private Vista _vistaActual = Vista.Inicio;
        private bool _saludoOculto = false;

        // ✅ FIX null warnings
        private ProgramacionView _programacionView = null!;
        private MascotaView _mascotaView = null!;

        private double _kilosActuales = 1.45;
        private double _capacidadTotal = 2.0;
        private double _gramsDispensado = 0.1;
        private double _porcentajeComida = 0.725;
        private double _nivelDeposito = 0.85;

        private Point _dragStart;

        private void Form1_Load(object? sender, EventArgs e)
        {
            ConfigurarFotoPug();
            ReposicionarControles();

            _programacionView = new ProgramacionView { Visible = false };
            _mascotaView = new MascotaView { Visible = false };

            pnlContenido.Controls.Add(_programacionView);
            pnlContenido.Controls.Add(_mascotaView);
            pnlHeader.BringToFront();

            btnInicio.Click += (s, ev) => MostrarVista(Vista.Inicio);
            btnProgramacion.Click += (s, ev) => MostrarVista(Vista.Programacion);
            btnUsuario.Click += (s, ev) => MostrarVista(Vista.Usuario);

            dispensarButton1.TabStop = false;
            this.ActiveControl = null;

            var timerSaludo = new System.Windows.Forms.Timer { Interval = 5000 };
            timerSaludo.Tick += (s, ev) =>
            {
                _saludoOculto = true;
                lblSaludo.Visible = false;
                timerSaludo.Stop();
                timerSaludo.Dispose();
            };
            timerSaludo.Start();
        }

        private void CargarDatosMascota()
        {
            DatabaseHelper db = new DatabaseHelper();

            string query = "SELECT nombre_mascota, edad_anos, peso_kg, altura_cm FROM MASCOTAS WHERE id_usuario = @userId";

            SqlParameter[] parameters = {
                new SqlParameter("@userId", DispensadorParaMascotas.Models.Sesion.UsuarioId)
            };

            DataTable dt = db.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                txtNombreMascota.Text = dt.Rows[0]["nombre_mascota"]?.ToString() ?? "";
                txtEdad.Text = dt.Rows[0]["edad_anos"]?.ToString() ?? "";
                txtPeso.Text = dt.Rows[0]["peso_kg"]?.ToString() ?? "";
                txtAltura.Text = dt.Rows[0]["altura_cm"]?.ToString() ?? "";
                lblSaludo.Text = $"¡Hola, {DispensadorParaMascotas.Models.Sesion.NombreUsuario}!";
            }
        }

        private void MostrarVista(Vista vista)
        {
            _vistaActual = vista;

            bool esInicio = vista == Vista.Inicio;
            bool esUsuario = vista == Vista.Usuario;

            lblKilos.Visible = esInicio;
            lblCapacidad.Visible = esInicio;
            lblNivelComida.Visible = esInicio;
            dispensarButton1.Visible = esInicio;

            lblSaludo.Visible = esInicio && !_saludoOculto;
            panel2.Visible = esInicio;

            _programacionView.Visible = (vista == Vista.Programacion);
            _mascotaView.Visible = esUsuario;

            pnlHeader.Visible = !esUsuario;

            btnInicio.ForeColor = esInicio ? Color.FromArgb(0, 210, 200) : Color.Silver;
            btnProgramacion.ForeColor = (vista == Vista.Programacion) ? Color.FromArgb(0, 210, 200) : Color.Silver;
            btnHistorial.ForeColor = Color.Silver;
            btnConfiguracion.ForeColor = Color.Silver;
            btnUsuario.ForeColor = esUsuario ? Color.FromArgb(0, 210, 200) : Color.Silver;

            pnlContenido.Invalidate();
        }

        private void ReposicionarControles()
        {
            int cx = pnlContenido.Width / 2;
            int cy = pnlContenido.Height / 2 - 40;

            lblKilos.Left = cx - lblKilos.Width / 2;
            lblKilos.Top = cy - 32;

            lblCapacidad.Left = cx - lblCapacidad.Width / 2 + 12;
            lblCapacidad.Top = cy + 26;

            lblNivelComida.Left = cx - lblNivelComida.Width / 2;
            lblNivelComida.Top = cy + 48;

            dispensarButton1.Left = cx - dispensarButton1.Width / 2;
            dispensarButton1.Top = cy + 175;

            pnlHeader.Left = pnlContenido.Width - pnlHeader.Width - 20;
            pnlHeader.Top = 16;

            panel2.Left = pnlHeader.Left;
            panel2.Width = pnlHeader.Width;
            panel2.Top = pnlHeader.Bottom + 8;

            lblSaludo.Left = cx - lblSaludo.Width / 2;
            lblSaludo.Top = 18;
        }

        private void pnlContenido_Paint(object? sender, PaintEventArgs e)
        {
            if (_vistaActual != Vista.Inicio) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int cx = pnlContenido.Width / 2;
            int cy = pnlContenido.Height / 2 - 40;

            int diametroInterno = 240;
            int xInt = cx - diametroInterno / 2;
            int yInt = cy - diametroInterno / 2;
            Rectangle rectInterno = new Rectangle(xInt, yInt, diametroInterno, diametroInterno);

            int margenExtra = 28;
            Rectangle rectExterior = new Rectangle(
                xInt - margenExtra / 2,
                yInt - margenExtra / 2,
                diametroInterno + margenExtra,
                diametroInterno + margenExtra
            );

            using (SolidBrush bgBrush = new SolidBrush(Color.FromArgb(38, 38, 42)))
                g.FillEllipse(bgBrush, rectInterno);

            Color colorPlataFondo = Color.FromArgb(55, 192, 192, 192);
            Color colorPlataSolido = _nivelDeposito < 0.15
                ? Color.FromArgb(255, 80, 80)
                : Color.FromArgb(200, 200, 200);

            using (Pen penFondoExt = new Pen(colorPlataFondo, 6))
                g.DrawEllipse(penFondoExt, rectExterior);

            float sweepExterior = (float)(_nivelDeposito * 360);
            using (Pen penPlata = new Pen(colorPlataSolido, 6))
            {
                penPlata.StartCap = LineCap.Round;
                penPlata.EndCap = LineCap.Round;
                g.DrawArc(penPlata, rectExterior, -90, sweepExterior);
            }

            using (Pen penFondo = new Pen(Color.FromArgb(50, 50, 55), 18))
                g.DrawEllipse(penFondo, rectInterno);

            float sweepInterno = (float)(_porcentajeComida * 360);

            using (Pen penGlow = new Pen(Color.FromArgb(55, 0, 161, 155), 28))
                g.DrawArc(penGlow, rectInterno, -90, sweepInterno);

            using (Pen penAqua = new Pen(Color.FromArgb(0, 161, 155), 18))
            {
                penAqua.StartCap = LineCap.Round;
                penAqua.EndCap = LineCap.Round;
                g.DrawArc(penAqua, rectInterno, -90, sweepInterno);
            }
        }

        private void pnlHeader_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, pnlHeader.Width - 1, pnlHeader.Height - 1);
            int radius = 14;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
                path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
                path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();

                using (SolidBrush fill = new SolidBrush(Color.FromArgb(215, 36, 36, 40)))
                    g.FillPath(fill, path);

                using (Pen border = new Pen(Color.FromArgb(65, 65, 70), 1f))
                    g.DrawPath(border, path);
            }
        }

        private void panel2_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, panel2.Width - 1, panel2.Height - 1);
            int r = 10;

            using (var path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, r * 2, r * 2, 180, 90);
                path.AddArc(rect.Right - r * 2, rect.Y, r * 2, r * 2, 270, 90);
                path.AddArc(rect.Right - r * 2, rect.Bottom - r * 2, r * 2, r * 2, 0, 90);
                path.AddArc(rect.X, rect.Bottom - r * 2, r * 2, r * 2, 90, 90);
                path.CloseFigure();

                using (var fill = new SolidBrush(Color.FromArgb(215, 36, 36, 40)))
                    g.FillPath(fill, path);

                using (var border = new Pen(Color.FromArgb(65, 65, 70), 1f))
                    g.DrawPath(border, path);
            }
        }

        private void ConfigurarFotoPug()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pbMascota.Width, pbMascota.Height);
            pbMascota.Region = new Region(path);
            pbMascota.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void dispensarButton1_Click(object? sender, EventArgs e)
        {
            if (_kilosActuales <= 0)
            {
                lblKilos.Text = "0.00 kg";
                return;
            }

            _kilosActuales = Math.Max(0, _kilosActuales - _gramsDispensado);
            _porcentajeComida = _kilosActuales / _capacidadTotal;
            _nivelDeposito = Math.Max(0, _nivelDeposito - (_gramsDispensado / _capacidadTotal));

            lblKilos.Text = $"{_kilosActuales:F2} kg";
            ReposicionarControles();
            pnlContenido.Invalidate();
        }

        private void pnlTitleBar_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _dragStart = e.Location;
        }

        private void pnlTitleBar_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(
                    this.Left + e.X - _dragStart.X,
                    this.Top + e.Y - _dragStart.Y
                );
        }

        private void btnMinimizar_Click(object? sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
