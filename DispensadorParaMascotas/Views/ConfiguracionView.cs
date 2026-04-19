using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DispensadorParaMascotas.Views
{
    public class ConfiguracionView : UserControl
    {
        private Label lblTitulo;
        private Panel pnlDispensador;
        private Panel pnlAlertas;
        private Panel pnlCuenta;

        private TextBox txtNombreDispensador;
        private NumericUpDown nudCapacidad;
        private NumericUpDown nudGramosPorDefecto;
        private ToggleSwitch tglNotificaciones;
        private ToggleSwitch tglSonido;
        private ToggleSwitch tglAlertaNivel;
        private NumericUpDown nudNivelAlerta;
        private Label lblNombreUsuario;
        private Label lblIdUsuario;
        private Button btnGuardar;
        private Button btnCerrarSesion;

        public event EventHandler CerrarSesionSolicitado;

        public ConfiguracionView()
        {
            DoubleBuffered = true;
            BackColor = Color.FromArgb(26, 26, 27);
            Dock = DockStyle.Fill;
            Construir();
        }

        private void Construir()
        {
            lblTitulo = new Label
            {
                Text = "Configuración",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(32, 28)
            };

            pnlDispensador = CrearSeccion("Dispensador", 32, 88, 580, 220);
            pnlAlertas = CrearSeccion("Alertas y Notificaciones", 32, 330, 580, 190);
            pnlCuenta = CrearSeccion("Mi Cuenta", 640, 88, 380, 180);

            PoblarDispensador();
            PoblarAlertas();
            PoblarCuenta();

            btnGuardar = new Button
            {
                Text = "Guardar Configuración",
                Font = new Font("Segoe UI Semibold", 10.5F),
                ForeColor = Color.FromArgb(18, 18, 22),
                BackColor = Color.FromArgb(0, 175, 165),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(220, 44),
                Location = new Point(32, 542),
                Cursor = Cursors.Hand
            };
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 155, 148);
            btnGuardar.Click += BtnGuardar_Click;

            btnCerrarSesion = new Button
            {
                Text = "Cerrar Sesión",
                Font = new Font("Segoe UI Semibold", 10F),
                ForeColor = Color.FromArgb(220, 80, 80),
                BackColor = Color.FromArgb(42, 30, 30),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(160, 44),
                Location = new Point(640, 290),
                Cursor = Cursors.Hand
            };
            btnCerrarSesion.FlatAppearance.BorderColor = Color.FromArgb(180, 60, 60);
            btnCerrarSesion.FlatAppearance.BorderSize = 1;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 60, 60);
            btnCerrarSesion.MouseEnter += (s, e) => btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.MouseLeave += (s, e) => btnCerrarSesion.ForeColor = Color.FromArgb(220, 80, 80);
            btnCerrarSesion.Click += (s, e) => CerrarSesionSolicitado?.Invoke(this, EventArgs.Empty);

            Controls.AddRange(new Control[]
            {
                lblTitulo, pnlDispensador, pnlAlertas, pnlCuenta, btnGuardar, btnCerrarSesion
            });
        }

        private void PoblarDispensador()
        {
            int lx = 18, y = 36, gap = 54;

            Lbl(pnlDispensador, "Nombre del dispensador", lx, y);
            y += 20;
            txtNombreDispensador = new TextBox
            {
                Location = new Point(lx, y),
                Size = new Size(530, 28),
                Font = new Font("Segoe UI", 10F),
                BackColor = Color.FromArgb(50, 50, 58),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Text = "Mi Dispensador"
            };
            pnlDispensador.Controls.Add(txtNombreDispensador);
            y += gap;

            Lbl(pnlDispensador, "Capacidad total del depósito (kg)", lx, y);
            y += 20;
            nudCapacidad = new NumericUpDown
            {
                Location = new Point(lx, y),
                Size = new Size(120, 28),
                Font = new Font("Segoe UI", 10F),
                BackColor = Color.FromArgb(50, 50, 58),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Minimum = 1,
                Maximum = 20,
                DecimalPlaces = 1,
                Increment = 0.5M,
                Value = 2
            };
            nudCapacidad.Controls[0].BackColor = Color.FromArgb(50, 50, 58);
            pnlDispensador.Controls.Add(nudCapacidad);
            y += gap;

            Lbl(pnlDispensador, "Gramos por dispensación predeterminada", lx, y);
            y += 20;
            nudGramosPorDefecto = new NumericUpDown
            {
                Location = new Point(lx, y),
                Size = new Size(120, 28),
                Font = new Font("Segoe UI", 10F),
                BackColor = Color.FromArgb(50, 50, 58),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Minimum = 25,
                Maximum = 500,
                Increment = 25,
                Value = 100
            };
            nudGramosPorDefecto.Controls[0].BackColor = Color.FromArgb(50, 50, 58);
            pnlDispensador.Controls.Add(nudGramosPorDefecto);
        }

        private void PoblarAlertas()
        {
            int lx = 18, y = 36, gap = 52;

            Lbl(pnlAlertas, "Notificaciones activas", lx, y);
            tglNotificaciones = new ToggleSwitch
            {
                Checked = true,
                Location = new Point(lx + 280, y - 2)
            };
            pnlAlertas.Controls.Add(tglNotificaciones);
            y += gap;

            Lbl(pnlAlertas, "Sonido al dispensar", lx, y);
            tglSonido = new ToggleSwitch
            {
                Checked = false,
                Location = new Point(lx + 280, y - 2)
            };
            pnlAlertas.Controls.Add(tglSonido);
            y += gap;

            Lbl(pnlAlertas, "Alerta cuando el nivel baje de (%)", lx, y);
            tglAlertaNivel = new ToggleSwitch
            {
                Checked = true,
                Location = new Point(lx + 280, y - 2)
            };
            pnlAlertas.Controls.Add(tglAlertaNivel);
            nudNivelAlerta = new NumericUpDown
            {
                Location = new Point(lx + 340, y - 4),
                Size = new Size(80, 28),
                Font = new Font("Segoe UI", 10F),
                BackColor = Color.FromArgb(50, 50, 58),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Minimum = 5,
                Maximum = 50,
                Increment = 5,
                Value = 15
            };
            nudNivelAlerta.Controls[0].BackColor = Color.FromArgb(50, 50, 58);
            pnlAlertas.Controls.Add(nudNivelAlerta);
        }

        private void PoblarCuenta()
        {
            int lx = 18, y = 36;

            Lbl(pnlCuenta, "Usuario", lx, y);
            y += 22;
            lblNombreUsuario = new Label
            {
                Text = DispensadorParaMascotas.Models.Sesion.NombreUsuario,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(lx, y),
                BackColor = Color.Transparent
            };
            pnlCuenta.Controls.Add(lblNombreUsuario);
            y += 38;

            Lbl(pnlCuenta, "ID de usuario", lx, y);
            y += 22;
            lblIdUsuario = new Label
            {
                Text = $"#{DispensadorParaMascotas.Models.Sesion.UsuarioId}",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(140, 140, 150),
                AutoSize = true,
                Location = new Point(lx, y),
                BackColor = Color.Transparent
            };
            pnlCuenta.Controls.Add(lblIdUsuario);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Text = "Guardando...";
            btnGuardar.Enabled = false;

            var t = new System.Windows.Forms.Timer { Interval = 900 };
            t.Tick += (s, ev) =>
            {
                t.Stop();
                btnGuardar.Text = "✓ Guardado";
                btnGuardar.BackColor = Color.FromArgb(0, 140, 100);

                var t2 = new System.Windows.Forms.Timer { Interval = 1800 };
                t2.Tick += (s2, ev2) =>
                {
                    t2.Stop();
                    btnGuardar.Text = "Guardar Configuración";
                    btnGuardar.BackColor = Color.FromArgb(0, 175, 165);
                    btnGuardar.Enabled = true;
                };
                t2.Start();
            };
            t.Start();
        }

        private Panel CrearSeccion(string titulo, int x, int y, int w, int h)
        {
            var pnl = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(w, h),
                BackColor = Color.Transparent
            };
            pnl.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                var rect = new Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1);
                using (var path = Ruta(rect, 10))
                {
                    using (var fill = new SolidBrush(Color.FromArgb(42, 42, 50)))
                        g.FillPath(fill, path);
                    using (var border = new Pen(Color.FromArgb(56, 56, 66), 1f))
                        g.DrawPath(border, path);
                }
                using (var ft = new Font("Segoe UI Semibold", 10F, FontStyle.Bold))
                using (var br = new SolidBrush(Color.FromArgb(200, 200, 215)))
                    g.DrawString(titulo, ft, br, new PointF(18, 10));
            };
            return pnl;
        }

        private static void Lbl(Control parent, string txt, int x, int y)
        {
            parent.Controls.Add(new Label
            {
                Text = txt,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(130, 130, 142),
                AutoSize = true,
                Location = new Point(x, y),
                BackColor = Color.Transparent
            });
        }

        private static GraphicsPath Ruta(Rectangle rect, int r)
        {
            var p = new GraphicsPath();
            p.AddArc(rect.X, rect.Y, r * 2, r * 2, 180, 90);
            p.AddArc(rect.Right - r * 2, rect.Y, r * 2, r * 2, 270, 90);
            p.AddArc(rect.Right - r * 2, rect.Bottom - r * 2, r * 2, r * 2, 0, 90);
            p.AddArc(rect.X, rect.Bottom - r * 2, r * 2, r * 2, 90, 90);
            p.CloseFigure();
            return p;
        }
    }
}
