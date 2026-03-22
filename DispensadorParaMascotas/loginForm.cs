using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DispensadorParaMascotas
{
    public partial class loginForm : Form
    {
        // Variables de Estilo Petronas
        Color colorPetronas = Color.FromArgb(0, 161, 156);
        Color colorOriginal = Color.FromArgb(64, 64, 64);
        int grosorLinea = 3;

        public loginForm()
        {
            InitializeComponent();
            // Esto permite que el dibujo se actualice correctamente al mover o redimensionar
            this.ResizeRedraw = true;
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            // Opcional: Configuración inicial de los TextBox
            txtContrasena.UseSystemPasswordChar = true;
            // Esto desactiva el diseño "brillante" de Windows para la barra
            // permitiendo que el ForeColor (Petronas) se vea correctamente.
            prgCarga.Style = ProgressBarStyle.Continuous;

            // Si lo anterior no es suficiente, esta es la forma correcta:
            // (Asegúrate de haber puesto el ForeColor en Petronas en el diseñador)
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
        }

        #region Interactividad de TextBox

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.FromArgb(45, 45, 45);
            txtUsuario.ForeColor = colorPetronas;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = colorOriginal;
            txtUsuario.ForeColor = Color.White;
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            txtContrasena.BackColor = Color.FromArgb(45, 45, 45);
            txtContrasena.ForeColor = colorPetronas;
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            txtContrasena.BackColor = colorOriginal;
            txtContrasena.ForeColor = Color.White;
        }

        #endregion

        #region Botones (Mostrar Pass y Sign In)

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !txtContrasena.UseSystemPasswordChar;
            btnMostrar.Text = txtContrasena.UseSystemPasswordChar ? "👁" : "Ø";
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // 1. Validaciones de siempre
            if (txtUsuario.Text == "Admin" && txtContrasena.Text == "12345")
            {
                // 2. Preparamos la barra Petronas
                prgCarga.Visible = true;
                prgCarga.Value = 0;

                // Desactivamos el botón para que no le den clic dos veces
                btnSignIn.Enabled = false;
                btnSignIn.Text = "Cargando...";

                // 3. Iniciamos el temporizador
                tmrCarga.Start();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Haz doble clic en el Timer en el diseñador para crear este evento:
        private void tmrCarga_Tick(object sender, EventArgs e)
        {
            if (prgCarga.Value < 100)
            {
                prgCarga.Value += 5; // Aumenta de 5 en 5%
            }
            else
            {
                tmrCarga.Stop(); // Detener el reloj

                // 4. Ahora sí, abrimos el formulario principal
                this.Hide();
                Form1 principal = new Form1();
                principal.Show();
            }
        }

        #endregion

        #region Dibujo de Mascotas (Estilo Minimalista)

        // Reemplaza el método OnPaint para posicionarlos arriba de "USER LOGIN"
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen penPetronas = new Pen(colorPetronas, grosorLinea))
            {
                // Posición base arriba del título "USER LOGIN"
                // Asegúrate de tener espacio arriba en el formulario
                int inicioX = (this.Width / 2) - 150; // Centrado aproximado
                int inicioY = 50; // Distancia desde el borde superior

                // Dibujar el primer animal (Pug - Arcos paralelos)
                dibujarPugNuevo(e.Graphics, penPetronas, new Point(inicioX, inicioY));

                // Dibujar el segundo animal (Gato - Arco con orejas triangulares)
                dibujarGatitoNuevo(e.Graphics, penPetronas, new Point(inicioX + 110, inicioY));

                // Dibujar el tercer animal (Perico - Elíptico)
                dibujarPericoNuevo(e.Graphics, penPetronas, new Point(inicioX + 220, inicioY));
            }
        }

        // 1. PUG NUEVO (El diseño de los dos arcos)
        private void dibujarPugNuevo(Graphics g, Pen p, Point basePoint)
        {
            // Arco exterior principal
            g.DrawArc(p, basePoint.X, basePoint.Y, 80, 100, 180, 180);

            // Arco interior (el hocico invertido)
            g.DrawArc(p, basePoint.X + 20, basePoint.Y + 40, 40, 40, 0, 180);
        }

        // 2. GATITO NUEVO (El diseño del arco con orejas)
        private void dibujarGatitoNuevo(Graphics g, Pen p, Point basePoint)
        {
            // Arco principal del cuerpo/cabeza
            g.DrawArc(p, basePoint.X, basePoint.Y, 80, 100, 180, 180);

            // Oreja izquierda (Triángulo)
            Point[] orejaI = {
        new Point(basePoint.X + 15, basePoint.Y + 15),
        new Point(basePoint.X + 10, basePoint.Y - 10),
        new Point(basePoint.X + 35, basePoint.Y + 5)
    };
            g.DrawPolygon(p, orejaI); // O g.DrawLines si no quieres cerrar la base

            // Oreja derecha (Triángulo simétrico)
            Point[] orejaD = {
        new Point(basePoint.X + 65, basePoint.Y + 15),
        new Point(basePoint.X + 70, basePoint.Y - 10),
        new Point(basePoint.X + 45, basePoint.Y + 5)
    };
            g.DrawPolygon(p, orejaD);
        }

        // 3. PERICO NUEVO (El diseño elíptico con la marca arriba)
        private void dibujarPericoNuevo(Graphics g, Pen p, Point basePoint)
        {
            // El cuerpo elíptico inclinado
            Rectangle rectElipse = new Rectangle(basePoint.X, basePoint.Y, 60, 100);

            // Para inclinarlo un poco, usamos una transformación simple
            Matrix matrixInclinacion = new Matrix();
            matrixInclinacion.RotateAt(10, new PointF(basePoint.X + 30, basePoint.Y + 50));
            g.Transform = matrixInclinacion;

            g.DrawEllipse(p, rectElipse);

            // La marca o 'pico' simplificado arriba a la izquierda
            g.DrawLine(p, new Point(basePoint.X + 5, basePoint.Y + 5), new Point(basePoint.X - 5, basePoint.Y - 5));
            g.DrawLine(p, new Point(basePoint.X - 5, basePoint.Y - 5), new Point(basePoint.X + 10, basePoint.Y));

            // Resetear la transformación para no afectar otros dibujos
            g.ResetTransform();
        }

        #endregion
    }
}