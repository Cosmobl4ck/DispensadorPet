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
            pnlContenido.Invalidate();
        }

        private enum Vista { Inicio, Programacion, Usuario, Suscribirse, Historial, Configuracion }
        private Vista _vistaActual = Vista.Inicio;
        private ProgramacionView _programacionView;
        private MascotaView _mascotaView;
        private Suscribirse _suscribirseView;
        private HistorialView _historialView;
        private ConfiguracionView _configuracionView;

        private double _kilosActuales = 1.45;
        private double _capacidadTotal = 2.0;
        private double _gramsDispensado = 0.1;
        private double _porcentajeComida = 0.725;
        private double _nivelDeposito = 0.85;

        private double _porcentajeAnimado = 0;
        private System.Windows.Forms.Timer _timerGauge;
        private System.Windows.Forms.Timer _timerSaludo;
        private bool _saludoOculto = false;

        private Panel _overlay;

        private Point _dragStart;

        private int _idDispensador = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarFotoPug();
            ReposicionarControles();

            _programacionView = new ProgramacionView { Visible = false };
            _mascotaView = new MascotaView { Visible = false };
            _suscribirseView = new Suscribirse { Visible = false };
            _historialView = new HistorialView { Visible = false };
            _configuracionView = new ConfiguracionView { Visible = false };

            _idDispensador = ObtenerIdDispensador();
            _historialView.IdDispensador = _idDispensador;

            _configuracionView.CerrarSesionSolicitado += (s, ev) =>
            {
                this.Hide();
                var login = new loginForm();
                login.Show();
            };

            pnlContenido.Controls.Add(_programacionView);
            pnlContenido.Controls.Add(_mascotaView);
            pnlContenido.Controls.Add(_suscribirseView);
            pnlContenido.Controls.Add(_historialView);
            pnlContenido.Controls.Add(_configuracionView);
            pnlHeader.BringToFront();

            _overlay = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(26, 26, 27),
                Visible = false
            };
            pnlContenido.Controls.Add(_overlay);
            _overlay.BringToFront();

            btnInicio.Click += (s, ev) => MostrarVista(Vista.Inicio);
            btnProgramacion.Click += (s, ev) => MostrarVista(Vista.Programacion);
            btnUsuario.Click += (s, ev) => MostrarVista(Vista.Usuario);
            btnHistorial.Click += (s, ev) => MostrarVista(Vista.Historial);
            btnConfiguracion.Click += (s, ev) => MostrarVista(Vista.Configuracion);

            dispensarButton1.TabStop = false;
            this.ActiveControl = null;

            _timerGauge = new System.Windows.Forms.Timer { Interval = 16 };
            _timerGauge.Tick += (s, ev) =>
            {
                double diff = _porcentajeComida - _porcentajeAnimado;
                if (Math.Abs(diff) < 0.002)
                {
                    _porcentajeAnimado = _porcentajeComida;
                    _timerGauge.Stop();
                }
                else
                {
                    _porcentajeAnimado += diff * 0.12;
                }
                pnlContenido.Invalidate();
            };
            _porcentajeAnimado = 0;
            _timerGauge.Start();

            _timerSaludo = new System.Windows.Forms.Timer { Interval = 5000 };
            _timerSaludo.Tick += (s, ev) =>
            {
                _saludoOculto = true;
                FadeOutLabel(lblSaludo);
                _timerSaludo.Stop();
                _timerSaludo.Dispose();
            };
            _timerSaludo.Start();
        }

        private void FadeOutLabel(Label lbl)
        {
            int alpha = 255;
            var t = new System.Windows.Forms.Timer { Interval = 30 };
            t.Tick += (s, e) =>
            {
                alpha -= 18;
                if (alpha <= 0)
                {
                    lbl.Visible = false;
                    t.Stop();
                    t.Dispose();
                    return;
                }
                lbl.ForeColor = Color.FromArgb(alpha, lbl.ForeColor.R, lbl.ForeColor.G, lbl.ForeColor.B);
            };
            t.Start();
        }

        private void AnimarTransicion(Action mostrar)
        {
            _overlay.BackColor = Color.FromArgb(0, 26, 26, 27);
            _overlay.Visible = true;
            _overlay.BringToFront();

            int alpha = 0;
            bool mostrado = false;
            var t = new System.Windows.Forms.Timer { Interval = 12 };
            t.Tick += (s, e) =>
            {
                alpha += 35;
                if (alpha >= 255) alpha = 255;
                _overlay.BackColor = Color.FromArgb(alpha, 26, 26, 27);

                if (alpha >= 200 && !mostrado)
                {
                    mostrado = true;
                    mostrar();
                }

                if (alpha >= 255)
                {
                    var t2 = new System.Windows.Forms.Timer { Interval = 12 };
                    int alpha2 = 255;
                    t2.Tick += (s2, e2) =>
                    {
                        alpha2 -= 35;
                        if (alpha2 <= 0)
                        {
                            _overlay.Visible = false;
                            t2.Stop();
                            t2.Dispose();
                        }
                        else
                        {
                            _overlay.BackColor = Color.FromArgb(alpha2, 26, 26, 27);
                        }
                    };
                    t.Stop();
                    t.Dispose();
                    t2.Start();
                }
            };
            t.Start();
        }

        private int ObtenerIdDispensador()
        {
            try
            {
                var db = new DatabaseHelper();
                var q = "SELECT TOP 1 id_dispensador FROM DISPENSADORES WHERE id_usuario = @uid";
                var dt = db.ExecuteQuery(q, new SqlParameter[] {
                    new SqlParameter("@uid", DispensadorParaMascotas.Models.Sesion.UsuarioId)
                });
                if (dt.Rows.Count > 0)
                    return Convert.ToInt32(dt.Rows[0]["id_dispensador"]);
            }
            catch { }
            return 0;
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
                txtNombreMascota.Text = dt.Rows[0]["nombre_mascota"].ToString();
                txtEdad.Text = dt.Rows[0]["edad_anos"].ToString();
                txtPeso.Text = dt.Rows[0]["peso_kg"].ToString();
                txtAltura.Text = dt.Rows[0]["altura_cm"].ToString();
                lblSaludo.Text = $"¡Hola, {DispensadorParaMascotas.Models.Sesion.NombreUsuario}!";
            }
        }

        private void MostrarVista(Vista vista)
        {
            AnimarTransicion(() =>
            {
                _vistaActual = vista;

                bool esInicio = vista == Vista.Inicio;
                bool esUsuario = vista == Vista.Usuario;
                bool esSuscribirse = vista == Vista.Suscribirse;
                bool esHistorial = vista == Vista.Historial;
                bool esConfig = vista == Vista.Configuracion;

                lblKilos.Visible = esInicio;
                lblCapacidad.Visible = esInicio;
                lblNivelComida.Visible = esInicio;
                dispensarButton1.Visible = esInicio;
                lblSaludo.Visible = esInicio && !_saludoOculto;
                panel2.Visible = esInicio;

                _programacionView.Visible = (vista == Vista.Programacion);
                _mascotaView.Visible = esUsuario;
                _suscribirseView.Visible = esSuscribirse;
                _historialView.Visible = esHistorial;
                _configuracionView.Visible = esConfig;

                if (esHistorial)
                    _historialView.CargarDesdeBD();

                if (esInicio)
                {
                    _porcentajeAnimado = 0;
                    _timerGauge.Start();
                }

                pnlHeader.Visible = !esUsuario && !esSuscribirse;

                btnInicio.ForeColor = esInicio ? Color.FromArgb(0, 210, 200) : Color.Silver;
                btnProgramacion.ForeColor = (vista == Vista.Programacion) ? Color.FromArgb(0, 210, 200) : Color.Silver;
                btnHistorial.ForeColor = esHistorial ? Color.FromArgb(0, 210, 200) : Color.Silver;
                btnConfiguracion.ForeColor = esConfig ? Color.FromArgb(0, 210, 200) : Color.Silver;
                btnUsuario.ForeColor = esUsuario ? Color.FromArgb(0, 210, 200) : Color.Silver;
                btnSuscribirse.ForeColor = esSuscribirse ? Color.FromArgb(0, 210, 200) : Color.Silver;

                pnlContenido.Invalidate();
            });
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

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
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

            float sweepInterno = (float)(_porcentajeAnimado * 360);

            using (Pen penGlow = new Pen(Color.FromArgb(55, 0, 161, 155), 28))
                g.DrawArc(penGlow, rectInterno, -90, sweepInterno);

            using (Pen penAqua = new Pen(Color.FromArgb(0, 161, 155), 18))
            {
                penAqua.StartCap = LineCap.Round;
                penAqua.EndCap = LineCap.Round;
                g.DrawArc(penAqua, rectInterno, -90, sweepInterno);
            }

            if (sweepInterno > 5)
            {
                double endRad = (-90.0 + sweepInterno) * Math.PI / 180.0;
                float tipX = cx + (diametroInterno / 2f) * (float)Math.Cos(endRad);
                float tipY = cy + (diametroInterno / 2f) * (float)Math.Sin(endRad);
                using (GraphicsPath tipPath = new GraphicsPath())
                {
                    tipPath.AddEllipse(tipX - 8, tipY - 8, 16, 16);
                    using (PathGradientBrush tipBrush = new PathGradientBrush(tipPath))
                    {
                        tipBrush.CenterColor = Color.FromArgb(220, 0, 230, 218);
                        tipBrush.SurroundColors = new[] { Color.FromArgb(0, 0, 161, 155) };
                        g.FillPath(tipBrush, tipPath);
                    }
                }
            }

            int pad = 6;
            Rectangle btnRect = new Rectangle(
                dispensarButton1.Left - pad,
                dispensarButton1.Top - pad,
                dispensarButton1.Width + pad * 2,
                dispensarButton1.Height + pad * 2
            );
            int r = 11;
            using (GraphicsPath btnPath = new GraphicsPath())
            {
                btnPath.AddArc(btnRect.X, btnRect.Y, r * 2, r * 2, 180, 90);
                btnPath.AddArc(btnRect.Right - r * 2, btnRect.Y, r * 2, r * 2, 270, 90);
                btnPath.AddArc(btnRect.Right - r * 2, btnRect.Bottom - r * 2, r * 2, r * 2, 0, 90);
                btnPath.AddArc(btnRect.X, btnRect.Bottom - r * 2, r * 2, r * 2, 90, 90);
                btnPath.CloseFigure();

                using (Pen glowOuter = new Pen(Color.FromArgb(70, 0, 210, 200), 5))
                    g.DrawPath(glowOuter, btnPath);

                using (Pen glowInner = new Pen(Color.FromArgb(0, 195, 185), 1.5f))
                    g.DrawPath(glowInner, btnPath);
            }
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
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

            Point ptPhoto = pnlHeader.PointToClient(pbMascota.PointToScreen(Point.Empty));
            int margin = 3;
            using (Pen circlePen = new Pen(Color.FromArgb(0, 175, 165), 2.5f))
                g.DrawEllipse(circlePen,
                    ptPhoto.X - margin, ptPhoto.Y - margin,
                    pbMascota.Width + margin * 2, pbMascota.Height + margin * 2);
        }

        private void ConfigurarFotoPug()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pbMascota.Width, pbMascota.Height);
            pbMascota.Region = new Region(path);
            pbMascota.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void dispensarButton1_Click(object sender, EventArgs e)
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

            try
            {
                var db = new DatabaseHelper();
                string q = @"INSERT INTO HISTORIAL_DISPENSADO
                    (id_dispensador, fecha_hora_evento, cantidad_dispensada_g, id_tipo_comida, modo_dispensado, nivel_restante_kg)
                    VALUES (@idDisp, @fecha, @gramos, @tipo, @modo, @nivel)";
                db.ExecuteNonQuery(q, new SqlParameter[] {
                    new SqlParameter("@idDisp", _idDispensador),
                    new SqlParameter("@fecha",  DateTime.Now),
                    new SqlParameter("@gramos", _gramsDispensado * 1000),
                    new SqlParameter("@tipo",   1),
                    new SqlParameter("@modo",   "Manual"),
                    new SqlParameter("@nivel",  _kilosActuales)
                });
            }
            catch { }

            _timerGauge.Stop();
            _porcentajeAnimado = _porcentajeComida + 0.05;
            _timerGauge.Start();

            ReposicionarControles();
            pnlContenido.Invalidate();
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _dragStart = e.Location;
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(
                    this.Left + e.X - _dragStart.X,
                    this.Top + e.Y - _dragStart.Y
                );
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            MostrarVista(Vista.Usuario);
        }

        private void btnSuscribirse_Click(object sender, EventArgs e)
        {
            MostrarVista(Vista.Suscribirse);
        }

        public void BtnIrAlInicio()
        {
            MostrarVista(Vista.Inicio);
        }
    }
}