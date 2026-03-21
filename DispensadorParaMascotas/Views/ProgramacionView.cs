using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DispensadorParaMascotas.Models;

namespace DispensadorParaMascotas.Views
{
    public class ProgramacionView : UserControl
    {
        private Label lblTitulo;
        private Button btnAnadir;
        private Panel pnlParametrosCard;
        private ComboBox cmbTipoComida;
        private Label lblCantidad;
        private FlowLayoutPanel flowHorarios;

        public List<HorarioAlimentacion> Horarios { get; private set; } = new List<HorarioAlimentacion>();
        private int _cantidadPredeterminada = 75;

        public ProgramacionView()
        {
            DoubleBuffered = true;
            BackColor = Color.FromArgb(26, 26, 27);
            Dock = DockStyle.Fill;
            Padding = new Padding(32, 24, 32, 24);

            Construir();
            CargarDatosPrueba();
            RenderizarHorarios();
        }

        private void Construir()
        {
            // --- Título ---
            lblTitulo = new Label
            {
                Text = "Programación de Alimentación",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(32, 28)
            };

            // --- Botón añadir ---
            btnAnadir = new Button
            {
                Text = "+ Añadir Horario",
                Font = new Font("Segoe UI Semibold", 9.5F),
                ForeColor = Color.FromArgb(0, 210, 200),
                BackColor = Color.FromArgb(38, 38, 44),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(155, 34),
                Location = new Point(32, 28),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            btnAnadir.FlatAppearance.BorderColor = Color.FromArgb(0, 175, 165);
            btnAnadir.FlatAppearance.BorderSize = 1;
            btnAnadir.Click += BtnAnadir_Click;

            // --- Card parámetros ---
            pnlParametrosCard = new Panel
            {
                Location = new Point(32, 78),
                Size = new Size(800, 110),
                BackColor = Color.Transparent,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            pnlParametrosCard.Paint += PintarCard;

            var lblParamHeader = new Label
            {
                Text = "Parámetros de Comida Predeterminados",
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(16, 12)
            };

            var lblTipoLabel = new Label
            {
                Text = "Tipo de Comida",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(140, 140, 150),
                AutoSize = true,
                Location = new Point(16, 40)
            };

            cmbTipoComida = new ComboBox
            {
                Location = new Point(16, 60),
                Size = new Size(210, 26),
                Font = new Font("Segoe UI", 9.5F),
                BackColor = Color.FromArgb(50, 50, 58),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbTipoComida.Items.AddRange(new[] { "Seca (Kibble)", "Húmeda (Lata)", "Mixta", "Premio" });
            cmbTipoComida.SelectedIndex = 0;

            var lblCantLabel = new Label
            {
                Text = "Cantidad Predeterminada:",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(140, 140, 150),
                AutoSize = true,
                Location = new Point(250, 40)
            };

            var btnMenos = new Button
            {
                Text = "−",
                Size = new Size(28, 28),
                Location = new Point(250, 60),
                Font = new Font("Segoe UI", 12F),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(55, 55, 62),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnMenos.FlatAppearance.BorderSize = 0;
            btnMenos.Click += (s, e) =>
            {
                _cantidadPredeterminada = Math.Max(25, _cantidadPredeterminada - 25);
                lblCantidad.Text = $"{_cantidadPredeterminada}g";
            };

            lblCantidad = new Label
            {
                Text = $"{_cantidadPredeterminada}g",
                Font = new Font("Segoe UI Semibold", 10F),
                ForeColor = Color.White,
                Size = new Size(52, 28),
                Location = new Point(282, 60),
                TextAlign = ContentAlignment.MiddleCenter
            };

            var btnMas = new Button
            {
                Text = "+",
                Size = new Size(28, 28),
                Location = new Point(338, 60),
                Font = new Font("Segoe UI", 12F),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(55, 55, 62),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnMas.FlatAppearance.BorderSize = 0;
            btnMas.Click += (s, e) =>
            {
                _cantidadPredeterminada = Math.Min(500, _cantidadPredeterminada + 25);
                lblCantidad.Text = $"{_cantidadPredeterminada}g";
            };

            pnlParametrosCard.Controls.AddRange(new Control[]
            {
                lblParamHeader, lblTipoLabel, cmbTipoComida,
                lblCantLabel, btnMenos, lblCantidad, btnMas
            });

            // --- Header lista ---
            var lblListaHeader = new Label
            {
                Text = "Horarios Programados",
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(32, 206)
            };

            // --- Flow horarios ---
            flowHorarios = new FlowLayoutPanel
            {
                Location = new Point(32, 234),
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                BackColor = Color.Transparent,
                Padding = new Padding(0, 0, 4, 0),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            Controls.AddRange(new Control[]
            {
                lblTitulo, btnAnadir, pnlParametrosCard, lblListaHeader, flowHorarios
            });
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AjustarTamanios();
        }

        private void AjustarTamanios()
        {
            if (lblTitulo == null) return;

            int margen = 32;
            int anchoDisponible = Width - margen * 2;

            // Título
            lblTitulo.Location = new Point(margen, 30);

            // Botón añadir: pegado al título, misma fila
            btnAnadir.Location = new Point(lblTitulo.Left + lblTitulo.Width + 20, 28);

            // Card parámetros — alto justo para su contenido
            pnlParametrosCard.Location = new Point(margen, 78);
            pnlParametrosCard.Size = new Size(Math.Min(680, anchoDisponible - 340), 96);

            // Lista
            int yLista = pnlParametrosCard.Bottom + 18;
            var lblLista = Controls.OfType<Label>().FirstOrDefault(l => l.Text == "Horarios Programados");
            if (lblLista != null) lblLista.Location = new Point(margen, yLista);

            flowHorarios.Location = new Point(margen, yLista + 28);
            flowHorarios.Size = new Size(anchoDisponible, Height - yLista - 60);

            RenderizarHorarios();
        }

        private void PintarCard(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var p = (Panel)sender;
            var rect = new Rectangle(0, 0, p.Width - 1, p.Height - 1);
            using (var path = RoundedRect(rect, 10))
            {
                using (var fill = new SolidBrush(Color.FromArgb(42, 42, 50)))
                    g.FillPath(fill, path);
                using (var border = new Pen(Color.FromArgb(58, 58, 68), 1f))
                    g.DrawPath(border, path);
            }
        }

        private void CargarDatosPrueba()
        {
            Horarios.Add(new HorarioAlimentacion
            {
                Hora = new TimeSpan(8, 0, 0),
                CantidadGramos = 75,
                TipoComida = "Seca (Kibble)",
                Lunes = true,
                Miercoles = true,
                Viernes = true,
                Activo = true
            });
            Horarios.Add(new HorarioAlimentacion
            {
                Hora = new TimeSpan(18, 0, 0),
                CantidadGramos = 75,
                TipoComida = "Seca (Kibble)",
                Martes = true,
                Jueves = true,
                Sabado = true,
                Domingo = true,
                Activo = true
            });
        }

        public void RenderizarHorarios()
        {
            if (flowHorarios == null) return;
            flowHorarios.Controls.Clear();
            int anchoItem = Math.Max(400, flowHorarios.ClientSize.Width - 12);

            foreach (var h in Horarios)
                flowHorarios.Controls.Add(CrearItemHorario(h, anchoItem));
        }

        private Panel CrearItemHorario(HorarioAlimentacion h, int ancho)
        {
            var pnl = new Panel
            {
                Size = new Size(ancho, 86),
                BackColor = Color.Transparent,
                Margin = new Padding(0, 0, 0, 10)
            };
            pnl.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                var rect = new Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1);
                using (var path = RoundedRect(rect, 10))
                {
                    using (var fill = new SolidBrush(Color.FromArgb(38, 38, 46)))
                        g.FillPath(fill, path);
                    using (var border = new Pen(Color.FromArgb(55, 55, 65), 1f))
                        g.DrawPath(border, path);
                }
            };

            // Hora
            AgregarLbl(pnl, "Hora", 16, 10, 100, 7.5F, Color.FromArgb(120, 120, 130));
            int hh = h.Hora.Hours > 12 ? h.Hora.Hours - 12 : (h.Hora.Hours == 0 ? 12 : h.Hora.Hours);
            string ampm = h.Hora.Hours < 12 ? "AM" : "PM";
            AgregarLbl(pnl, $"⏱ {hh:D2}:{h.Hora.Minutes:D2} {ampm}", 16, 30, 110, 9.5F, Color.White, true);

            // Cantidad
            AgregarLbl(pnl, "Cantidad", 145, 10, 90, 7.5F, Color.FromArgb(120, 120, 130));
            AgregarLbl(pnl, $"⚖ {h.CantidadGramos}g", 145, 30, 90, 9.5F, Color.White, true);

            // Tipo comida
            AgregarLbl(pnl, "Tipo de Comida", 250, 10, 190, 7.5F, Color.FromArgb(120, 120, 130));
            AgregarLbl(pnl, $"🥣 {h.TipoComida}", 250, 30, 190, 9.5F, Color.White, true);

            // Toggle activo
            AgregarLbl(pnl, "Estado", 460, 10, 60, 7.5F, Color.FromArgb(120, 120, 130));
            var toggle = new ToggleSwitch
            {
                Checked = h.Activo,
                Location = new Point(460, 31),
                Tag = h
            };
            toggle.CheckedChanged += (s, e) => h.Activo = toggle.Checked;
            pnl.Controls.Add(toggle);

            // Días pills
            AgregarLbl(pnl, "Días", 522, 10, 280, 7.5F, Color.FromArgb(120, 120, 130));
            string[] diasNom = { "Lun", "Mar", "Mie", "Jue", "Vie", "Sab", "Dom" };
            bool[] diasVals = h.ObtenerDias();
            int dx = 522;
            for (int i = 0; i < 7; i++)
            {
                bool activo = diasVals[i];
                var pill = new Panel
                {
                    Size = new Size(36, 22),
                    Location = new Point(dx, 31),
                    BackColor = Color.Transparent
                };
                Color pillColor = activo ? Color.FromArgb(0, 155, 148) : Color.FromArgb(52, 52, 60);
                pill.Paint += (s, e2) =>
                {
                    e2.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    using (var path = RoundedRect(new Rectangle(0, 0, ((Panel)s).Width - 1, ((Panel)s).Height - 1), 5))
                    using (var b = new SolidBrush(pillColor))
                        e2.Graphics.FillPath(b, path);
                };
                var lblDia = new Label
                {
                    Text = diasNom[i],
                    Font = new Font("Segoe UI", 6.5F, FontStyle.Bold),
                    ForeColor = activo ? Color.White : Color.FromArgb(110, 110, 120),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.Transparent
                };
                pill.Controls.Add(lblDia);
                pnl.Controls.Add(pill);
                dx += 40;
            }

            // Botones editar / eliminar
            int bx = ancho - 76;
            var btnEdit = CrearBtnAccion("✏", bx, 30, Color.FromArgb(160, 160, 175));
            btnEdit.Click += (s, e) => EditarHorario(h);
            var btnDel = CrearBtnAccion("🗑", bx + 36, 30, Color.FromArgb(200, 75, 75));
            btnDel.Click += (s, e) => { Horarios.Remove(h); RenderizarHorarios(); };

            pnl.Controls.AddRange(new Control[] { btnEdit, btnDel });
            return pnl;
        }

        private static void AgregarLbl(Control parent, string text, int x, int y, int w,
            float size, Color color, bool bold = false)
        {
            parent.Controls.Add(new Label
            {
                Text = text,
                Font = new Font("Segoe UI", size, bold ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = color,
                Location = new Point(x, y),
                Size = new Size(w, bold ? 22 : 16),
                BackColor = Color.Transparent
            });
        }

        private static Button CrearBtnAccion(string texto, int x, int y, Color color)
        {
            var btn = new Button
            {
                Text = texto,
                Size = new Size(30, 30),
                Location = new Point(x, y),
                Font = new Font("Segoe UI", 11F),
                ForeColor = color,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        private void BtnAnadir_Click(object sender, EventArgs e)
        {
            using (var dlg = new AñadirHorarioForm(_cantidadPredeterminada,
                cmbTipoComida.SelectedItem?.ToString() ?? "Seca (Kibble)"))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Horarios.Add(dlg.Resultado);
                    RenderizarHorarios();
                }
            }
        }

        private void EditarHorario(HorarioAlimentacion h)
        {
            using (var dlg = new AñadirHorarioForm(h))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    int i = Horarios.IndexOf(h);
                    if (i >= 0) Horarios[i] = dlg.Resultado;
                    RenderizarHorarios();
                }
            }
        }

        private static GraphicsPath RoundedRect(Rectangle rect, int r)
        {
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, r * 2, r * 2, 180, 90);
            path.AddArc(rect.Right - r * 2, rect.Y, r * 2, r * 2, 270, 90);
            path.AddArc(rect.Right - r * 2, rect.Bottom - r * 2, r * 2, r * 2, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r * 2, r * 2, r * 2, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}