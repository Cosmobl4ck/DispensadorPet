using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DispensadorParaMascotas.Views
{
    public class HistorialView : UserControl
    {
        private FlowLayoutPanel flpHistorial;
        private Label lblTitulo;
        private Label lblVacio;
        private Button btnRecargar;
        private Label lblTotal;

        public int IdDispensador { get; set; } = 0;

        public HistorialView()
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
                Text = "Historial de Alimentación",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(32, 28)
            };

            btnRecargar = new Button
            {
                Text = "↻  Actualizar",
                Font = new Font("Segoe UI Semibold", 9.5F),
                ForeColor = Color.FromArgb(0, 210, 200),
                BackColor = Color.FromArgb(38, 38, 44),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(145, 38),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            btnRecargar.FlatAppearance.BorderColor = Color.FromArgb(0, 175, 165);
            btnRecargar.FlatAppearance.BorderSize = 1;
            btnRecargar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 155, 148);
            btnRecargar.MouseEnter += (s, e) => btnRecargar.ForeColor = Color.White;
            btnRecargar.MouseLeave += (s, e) => btnRecargar.ForeColor = Color.FromArgb(0, 210, 200);
            btnRecargar.Click += (s, e) => CargarDesdeBD();

            lblTotal = new Label
            {
                Text = "",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(120, 120, 130),
                AutoSize = true,
                Location = new Point(32, 86),
                BackColor = Color.Transparent
            };

            lblVacio = new Label
            {
                Text = "No hay registros de dispensación todavía.",
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.FromArgb(90, 90, 100),
                AutoSize = true,
                Location = new Point(32, 160),
                Visible = false
            };

            flpHistorial = new FlowLayoutPanel
            {
                Location = new Point(32, 118),
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                BackColor = Color.Transparent,
                Padding = new Padding(0, 0, 8, 0),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            Controls.AddRange(new Control[] { lblTitulo, btnRecargar, lblTotal, lblVacio, flpHistorial });
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (flpHistorial == null) return;
            int m = 32;
            btnRecargar.Location = new Point(Width - m - btnRecargar.Width, 28);
            flpHistorial.Location = new Point(m, 118);
            flpHistorial.Size = new Size(Width - m * 2, Height - 126);
            foreach (Control c in flpHistorial.Controls)
                if (c is Panel p) p.Width = flpHistorial.ClientSize.Width - 14;
        }

        public void CargarDesdeBD()
        {
            flpHistorial.Controls.Clear();
            lblVacio.Visible = false;
            lblTotal.Text = "Cargando...";

            try
            {
                var db = new DatabaseHelper();
                string q = @"SELECT TOP 50 id_historial, fecha_hora_evento,
                    cantidad_dispensada_g, modo_dispensado, nivel_restante_kg, id_tipo_comida
                    FROM HISTORIAL_DISPENSADO
                    WHERE id_dispensador = @idDisp
                    ORDER BY fecha_hora_evento DESC";

                DataTable dt = db.ExecuteQuery(q, new SqlParameter[] {
                    new SqlParameter("@idDisp", IdDispensador)
                });

                if (dt.Rows.Count == 0)
                {
                    lblVacio.Visible = true;
                    lblTotal.Text = "Sin registros";
                    return;
                }

                lblTotal.Text = $"{dt.Rows.Count} dispensaciones registradas";
                int ancho = flpHistorial.ClientSize.Width - 14;

                foreach (DataRow row in dt.Rows)
                {
                    DateTime fecha = row["fecha_hora_evento"] == DBNull.Value
                        ? DateTime.MinValue : Convert.ToDateTime(row["fecha_hora_evento"]);
                    double gramos = Convert.ToDouble(row["cantidad_dispensada_g"]);
                    double nivel = row["nivel_restante_kg"] == DBNull.Value
                        ? 0 : Convert.ToDouble(row["nivel_restante_kg"]);
                    string modo = row["modo_dispensado"]?.ToString() ?? "Manual";
                    int tipo = row["id_tipo_comida"] == DBNull.Value
                        ? 1 : Convert.ToInt32(row["id_tipo_comida"]);

                    flpHistorial.Controls.Add(CrearCard(fecha, gramos, nivel, modo, tipo, ancho));
                }
            }
            catch (Exception ex)
            {
                lblVacio.Text = $"Error: {ex.Message}";
                lblVacio.Visible = true;
                lblTotal.Text = "";
            }
        }

        private Panel CrearCard(DateTime fecha, double gramos, double nivel, string modo, int tipo, int ancho)
        {
            bool esReciente = fecha != DateTime.MinValue && (DateTime.Now - fecha).TotalHours < 2;

            var card = new Panel
            {
                Width = ancho,
                Height = 82,
                Margin = new Padding(0, 0, 0, 10),
                BackColor = Color.Transparent
            };

            card.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                var rect = new Rectangle(0, 0, card.Width - 1, card.Height - 1);
                using (var path = Ruta(rect, 10))
                {
                    using (var fill = new SolidBrush(esReciente
                        ? Color.FromArgb(46, 48, 56) : Color.FromArgb(42, 42, 50)))
                        g.FillPath(fill, path);
                    using (var border = new Pen(esReciente
                        ? Color.FromArgb(0, 120, 115) : Color.FromArgb(55, 55, 65), esReciente ? 1.5f : 1f))
                        g.DrawPath(border, path);
                }

                if (esReciente)
                    using (var b = new SolidBrush(Color.FromArgb(0, 175, 165)))
                        g.FillEllipse(b, 10, card.Height / 2 - 4, 8, 8);
            };

            string fechaTxt = fecha == DateTime.MinValue ? "—"
                : fecha.Date == DateTime.Today ? "Hoy"
                : fecha.Date == DateTime.Today.AddDays(-1) ? "Ayer"
                : fecha.ToString("dd MMM");

            string horaTxt = fecha == DateTime.MinValue ? "--:--" : fecha.ToString("hh:mm tt");

            string[] tipos = { "Seca (Kibble)", "Húmeda (Lata)", "Mixta", "Premio", "Otro" };
            string[] iconos = { "🥣", "🥫", "🍽️", "🎁", "🐾" };
            int ti = tipo >= 1 && tipo <= 4 ? tipo - 1 : 4;

            L(card, fechaTxt, 24, 10, 110, 8F, Color.FromArgb(130, 130, 140));
            L(card, horaTxt, 24, 30, 130, 13F, Color.White, true);
            L(card, iconos[ti] + " " + tipos[ti], 180, 32, 210, 9.5F, Color.FromArgb(175, 175, 190));
            L(card, "Restante", 415, 10, 140, 8F, Color.FromArgb(120, 120, 130));
            L(card, $"{nivel:F2} kg", 415, 30, 140, 10F, Color.FromArgb(185, 185, 200), true);
            L(card, modo, 560, 32, 130, 8.5F, Color.FromArgb(140, 140, 155));

            var lGramos = new Label
            {
                Text = $"{gramos:F0}g",
                Font = new Font("Segoe UI", 17F, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 175, 165),
                AutoSize = true,
                BackColor = Color.Transparent
            };
            lGramos.Location = new Point(card.Width - lGramos.PreferredWidth - 18,
                (card.Height - lGramos.PreferredHeight) / 2);
            card.Controls.Add(lGramos);

            return card;
        }

        private static void L(Control parent, string txt, int x, int y, int w,
            float sz, Color c, bool bold = false)
        {
            parent.Controls.Add(new Label
            {
                Text = txt,
                Font = new Font("Segoe UI", sz, bold ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = c,
                Location = new Point(x, y),
                Size = new Size(w, bold ? 26 : 18),
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