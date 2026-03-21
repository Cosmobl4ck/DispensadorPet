using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DispensadorParaMascotas.Models;

namespace DispensadorParaMascotas.Views
{
    public class AñadirHorarioForm : Form
    {
        public HorarioAlimentacion Resultado { get; private set; }

        private NumericUpDown nudHora;
        private NumericUpDown nudMinutos;
        private ComboBox cmbTipoComida;
        private NumericUpDown nudCantidad;
        private CheckBox[] chkDias;
        private Point _dragStart;

        public AñadirHorarioForm(int cantidadDefault = 75, string tipoDefault = "Seca (Kibble)")
        {
            Construir(null, cantidadDefault, tipoDefault);
        }

        public AñadirHorarioForm(HorarioAlimentacion existente)
        {
            Construir(existente, existente.CantidadGramos, existente.TipoComida);
        }

        private void Construir(HorarioAlimentacion h, int cantDefault, string tipoDefault)
        {
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.FromArgb(30, 30, 34);
            Size = new Size(430, 400);
            StartPosition = FormStartPosition.CenterParent;
            DoubleBuffered = true;

            this.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var pen = new Pen(Color.FromArgb(60, 60, 68), 1f))
                    e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            };

            // --- Title bar ---
            var pnlTitle = new Panel
            {
                BackColor = Color.FromArgb(20, 20, 24),
                Dock = DockStyle.Top,
                Height = 36
            };
            pnlTitle.MouseDown += (s, e) => { if (e.Button == MouseButtons.Left) _dragStart = e.Location; };
            pnlTitle.MouseMove += (s, e) => { if (e.Button == MouseButtons.Left) Location = new Point(Left + e.X - _dragStart.X, Top + e.Y - _dragStart.Y); };

            var lblTitleText = new Label
            {
                Text = h == null ? "Añadir Horario" : "Editar Horario",
                Font = new Font("Segoe UI Semibold", 10F),
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            lblTitleText.MouseDown += (s, e) => { if (e.Button == MouseButtons.Left) _dragStart = e.Location; };
            lblTitleText.MouseMove += (s, e) => { if (e.Button == MouseButtons.Left) Location = new Point(Left + e.X - _dragStart.X, Top + e.Y - _dragStart.Y); };

            var btnX = new Button
            {
                Text = "✕",
                Dock = DockStyle.Right,
                Width = 40,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Silver,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 9F)
            };
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 40, 40);
            btnX.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
            pnlTitle.Controls.Add(lblTitleText);
            pnlTitle.Controls.Add(btnX);

            // --- Content ---
            int lx = 24;
            int y = 54;

            Label Lbl(string txt, int x, int top, int w = 200) => new Label
            {
                Text = txt,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(140, 140, 150),
                Location = new Point(x, top),
                Size = new Size(w, 18)
            };

            NumericUpDown NUD(int x, int top, int w, int min, int max, int val)
            {
                var n = new NumericUpDown
                {
                    Location = new Point(x, top),
                    Size = new Size(w, 28),
                    Minimum = min,
                    Maximum = max,
                    Value = val,
                    Font = new Font("Segoe UI", 10F),
                    BackColor = Color.FromArgb(45, 45, 52),
                    ForeColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle
                };
                n.Controls[0].BackColor = Color.FromArgb(45, 45, 52);
                return n;
            }

            // Hora
            var lblHora = Lbl("Hora de Alimentación", lx, y);
            y += 22;
            nudHora = NUD(lx, y, 62, 0, 23, h?.Hora.Hours ?? 8);
            var lblSep = new Label
            {
                Text = ":",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(lx + 65, y + 3),
                BackColor = Color.Transparent
            };
            nudMinutos = NUD(lx + 82, y, 62, 0, 59, h?.Hora.Minutes ?? 0);
            y += 48;

            // Tipo comida
            var lblTipo = Lbl("Tipo de Comida", lx, y);
            y += 22;
            cmbTipoComida = new ComboBox
            {
                Location = new Point(lx, y),
                Size = new Size(220, 28),
                Font = new Font("Segoe UI", 9.5F),
                BackColor = Color.FromArgb(45, 45, 52),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbTipoComida.Items.AddRange(new[] { "Seca (Kibble)", "Húmeda (Lata)", "Mixta", "Premio" });
            int idx = cmbTipoComida.Items.IndexOf(tipoDefault);
            cmbTipoComida.SelectedIndex = idx >= 0 ? idx : 0;
            y += 48;

            // Cantidad
            var lblCant = Lbl("Cantidad (gramos)", lx, y);
            y += 22;
            nudCantidad = NUD(lx, y, 100, 25, 500, cantDefault);
            nudCantidad.Increment = 25;
            y += 48;

            // Días
            var lblDias = Lbl("Días de la Semana", lx, y);
            y += 22;
            string[] diasNom = { "L", "M", "X", "J", "V", "S", "D" };
            bool[] diasVals = h?.ObtenerDias() ?? new bool[7];
            chkDias = new CheckBox[7];
            for (int i = 0; i < 7; i++)
            {
                chkDias[i] = new CheckBox
                {
                    Text = diasNom[i],
                    Size = new Size(42, 32),
                    Location = new Point(lx + i * 48, y),
                    Checked = diasVals[i],
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI Semibold", 9F),
                    Appearance = Appearance.Button,
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Cursor = Cursors.Hand
                };
                chkDias[i].FlatAppearance.BorderColor = Color.FromArgb(60, 60, 70);
                chkDias[i].FlatAppearance.CheckedBackColor = Color.FromArgb(0, 161, 155);
                chkDias[i].FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 60);
            }
            y += 52;

            // Botones
            var btnCancelar = new Button
            {
                Text = "Cancelar",
                Size = new Size(115, 36),
                Location = new Point(lx, y),
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Silver,
                BackColor = Color.FromArgb(55, 55, 62),
                FlatStyle = FlatStyle.Flat,
                DialogResult = DialogResult.Cancel,
                Cursor = Cursors.Hand
            };
            btnCancelar.FlatAppearance.BorderSize = 0;

            var btnGuardar = new Button
            {
                Text = "Guardar",
                Size = new Size(115, 36),
                Location = new Point(lx + 125, y),
                Font = new Font("Segoe UI Semibold", 10F),
                ForeColor = Color.Black,
                BackColor = Color.FromArgb(0, 175, 165),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Click += (s, e) =>
            {
                Resultado = new HorarioAlimentacion
                {
                    Id = h?.Id ?? Guid.NewGuid(),
                    Hora = new TimeSpan((int)nudHora.Value, (int)nudMinutos.Value, 0),
                    CantidadGramos = (int)nudCantidad.Value,
                    TipoComida = cmbTipoComida.SelectedItem?.ToString() ?? "Seca (Kibble)",
                    Lunes = chkDias[0].Checked,
                    Martes = chkDias[1].Checked,
                    Miercoles = chkDias[2].Checked,
                    Jueves = chkDias[3].Checked,
                    Viernes = chkDias[4].Checked,
                    Sabado = chkDias[5].Checked,
                    Domingo = chkDias[6].Checked,
                    Activo = h?.Activo ?? true
                };
                DialogResult = DialogResult.OK;
                Close();
            };

            Controls.Add(pnlTitle);
            Controls.AddRange(new Control[] { lblHora, nudHora, lblSep, nudMinutos });
            Controls.AddRange(new Control[] { lblTipo, cmbTipoComida });
            Controls.AddRange(new Control[] { lblCant, nudCantidad });
            Controls.Add(lblDias);
            Controls.AddRange(chkDias);
            Controls.AddRange(new Control[] { btnCancelar, btnGuardar });
        }
    }
}