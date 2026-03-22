using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DispensadorParaMascotas.Views
{
    public class MascotaView : UserControl
    {
        private PictureBox picFoto;
        private Button btnSubirFoto;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private TextBox txtDueño;
        private TextBox txtComida;
        private Button btnGuardarDatos;
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblEdad;
        private Label lblPeso;
        private Label lblAltura;
        private Label lblDueño;
        private Label lblComida;
        private Label lblFoto;
        private Panel pnlFotoCard;
        private Panel pnlDatosCard;

        public MascotaView()
        {
            DoubleBuffered = true;
            BackColor = Color.FromArgb(26, 26, 27);
            Dock = DockStyle.Fill;
            Construir();
        }

        private void Construir()
        {
            // ── Título ─────────────────────────────────────────────────────
            lblTitulo = new Label
            {
                Text = "Mi Mascota",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(32, 28)
            };

            // ── Card foto (izquierda) ──────────────────────────────────────
            pnlFotoCard = new Panel
            {
                Location = new Point(32, 78),
                Size = new Size(280, 340),
                BackColor = Color.Transparent
            };
            pnlFotoCard.Paint += PintarCard;

            picFoto = new PictureBox
            {
                Location = new Point(30, 24),
                Size = new Size(220, 200),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(50, 50, 58),
                Cursor = Cursors.Hand
            };
            picFoto.Click += PicFoto_Click;
            AplicarBordeRedondeado(picFoto, 10);

            lblFoto = new Label
            {
                Text = "Haz clic en la foto para cambiarla",
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.FromArgb(130, 130, 140),
                AutoSize = false,
                Size = new Size(220, 18),
                Location = new Point(30, 232),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };

            btnSubirFoto = new Button
            {
                Text = "📁  Subir Foto",
                Font = new Font("Segoe UI Semibold", 9.5F),
                ForeColor = Color.FromArgb(0, 210, 200),
                BackColor = Color.FromArgb(38, 38, 44),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(150, 34),
                Location = new Point(65, 262),
                Cursor = Cursors.Hand
            };
            btnSubirFoto.FlatAppearance.BorderColor = Color.FromArgb(0, 175, 165);
            btnSubirFoto.FlatAppearance.BorderSize = 1;
            btnSubirFoto.Click += BtnSubirFoto_Click;

            pnlFotoCard.Controls.AddRange(new Control[] { picFoto, lblFoto, btnSubirFoto });

            // ── Card datos (derecha) ───────────────────────────────────────
            pnlDatosCard = new Panel
            {
                Location = new Point(340, 78),
                Size = new Size(520, 340),
                BackColor = Color.Transparent
            };
            pnlDatosCard.Paint += PintarCard;

            int lx = 20;
            int campo = 48;
            int y = 18;

            // Nombre
            lblNombre = CrearLabel("Nombre", lx, y);
            y += 18;
            txtNombre = CrearTextBox(lx, y, 460);
            y += campo;

            // Edad
            lblEdad = CrearLabel("Edad (años)", lx, y);
            y += 18;
            txtEdad = CrearTextBox(lx, y, 200);
            y += campo;

            // Peso
            lblPeso = CrearLabel("Peso (kg)", lx, y);
            y += 18;
            txtPeso = CrearTextBox(lx, y, 200);
            y += campo;

            // Altura
            lblAltura = CrearLabel("Altura (cm)", lx, y);
            y += 18;
            txtAltura = CrearTextBox(lx, y, 200);
            y += campo;

            // Dueño
            lblDueño = CrearLabel("Dueño", lx, y);
            y += 18;
            txtDueño = CrearTextBox(lx, y, 460);
            y += campo;

            // Comida
            lblComida = CrearLabel("Comida diaria (g)", lx, y);
            y += 18;
            txtComida = CrearTextBox(lx, y, 200);

            pnlDatosCard.Controls.AddRange(new Control[]
            {
                lblNombre, txtNombre,
                lblEdad,   txtEdad,
                lblPeso,   txtPeso,
                lblAltura, txtAltura,
                lblDueño,  txtDueño,
                lblComida, txtComida
            });

            // ── Botón guardar ──────────────────────────────────────────────
            btnGuardarDatos = new Button
            {
                Text = "Guardar Datos",
                Font = new Font("Segoe UI Semibold", 10.5F),
                ForeColor = Color.FromArgb(20, 20, 24),
                BackColor = Color.FromArgb(0, 175, 165),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(180, 42),
                Location = new Point(340, 432),
                Cursor = Cursors.Hand
            };
            btnGuardarDatos.FlatAppearance.BorderSize = 0;
            btnGuardarDatos.Click += BtnGuardarDatos_Click;

            Controls.AddRange(new Control[]
            {
                lblTitulo, pnlFotoCard, pnlDatosCard, btnGuardarDatos
            });
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (lblTitulo == null) return;

            int margen = 32;
            int anchoDisponible = Width - margen * 2;
            int anchoFoto = 280;
            int anchoDatos = Math.Max(300, anchoDisponible - anchoFoto - 28);

            pnlFotoCard.Location = new Point(margen, 78);
            pnlFotoCard.Size = new Size(anchoFoto, 340);

            pnlDatosCard.Location = new Point(margen + anchoFoto + 28, 78);
            pnlDatosCard.Size = new Size(anchoDatos, 340);

            // Ajustar ancho de campos al nuevo ancho del card
            int anchoField = anchoDatos - 40;
            txtNombre.Width = anchoField;
            txtDueño.Width = anchoField;

            btnGuardarDatos.Location = new Point(
                pnlDatosCard.Left + (pnlDatosCard.Width - btnGuardarDatos.Width) / 2,
                pnlDatosCard.Bottom + 18);
        }

        // ── Helpers ────────────────────────────────────────────────────────
        private static Label CrearLabel(string texto, int x, int y)
        {
            return new Label
            {
                Text = texto,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(140, 140, 150),
                AutoSize = true,
                Location = new Point(x, y),
                BackColor = Color.Transparent
            };
        }

        private static TextBox CrearTextBox(int x, int y, int w)
        {
            return new TextBox
            {
                Location = new Point(x, y),
                Size = new Size(w, 28),
                Font = new Font("Segoe UI", 10F),
                BackColor = Color.FromArgb(50, 50, 58),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
        }

        private static void PintarCard(object sender, PaintEventArgs e)
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

        private static void AplicarBordeRedondeado(Control ctrl, int radio)
        {
            var path = new GraphicsPath();
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90);
            path.AddArc(ctrl.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90);
            path.AddArc(ctrl.Width - radio * 2, ctrl.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            path.AddArc(0, ctrl.Height - radio * 2, radio * 2, radio * 2, 90, 90);
            path.CloseFigure();
            ctrl.Region = new Region(path);
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

        // ── Eventos ────────────────────────────────────────────────────────
        private void PicFoto_Click(object sender, EventArgs e)
        {
            BtnSubirFoto_Click(sender, e);
        }

        private void BtnSubirFoto_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Seleccionar foto de mascota";
                dlg.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.webp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picFoto.Image = Image.FromFile(dlg.FileName);
                    picFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    lblFoto.Text = Path.GetFileName(dlg.FileName);
                }
            }
        }

        private void BtnGuardarDatos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingresa el nombre de tu mascota.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aquí iría la lógica de persistencia (JSON/BD)
            MessageBox.Show(
                $"Datos de {txtNombre.Text} guardados correctamente.",
                "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
