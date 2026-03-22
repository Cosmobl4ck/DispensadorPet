using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices; // Necesario para personalizar el tema de la barra

namespace DispensadorParaMascotas
{
    public partial class loginForm : Form
    {
        // Importación de librería para quitar el estilo verde de Windows
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        // Variables de Estilo Petronas
        Color colorPetronas = Color.FromArgb(0, 161, 156);
        Color colorOriginal = Color.FromArgb(64, 64, 64);
        int grosorLinea = 3;

        public loginForm()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
        }

        // Este método se ejecuta cuando se crea el control, ideal para forzar colores
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            // Esto desactiva el diseño "brillante" de Windows solo para la barra de progreso
            // permitiendo que el ForeColor (Petronas) se vea correctamente.
            SetWindowTheme(prgCarga.Handle, "", "");
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = true;

            // Configuración visual de la barra
            prgCarga.Style = ProgressBarStyle.Continuous;
            prgCarga.ForeColor = colorPetronas;
            prgCarga.BackColor = Color.FromArgb(45, 45, 45);
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
            if (txtUsuario.Text == "Admin" && txtContrasena.Text == "12345")
            {
                prgCarga.Visible = true;
                prgCarga.Value = 0;
                btnSignIn.Enabled = false;
                btnSignIn.Text = "Loading...";

                tmrCarga.Interval = 50; // Velocidad de carga
                tmrCarga.Start();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tmrCarga_Tick(object sender, EventArgs e)
        {
            if (prgCarga.Value < 100)
            {
                prgCarga.Value += 5;
                prgCarga.Refresh();
                this.Update();
            }
            else
            {
                tmrCarga.Stop();
                Form1 principal = new Form1();
                principal.Show();
                this.Hide();
            }
        }

        #endregion

        #region Dibujo de Mascotas (Estilo Minimalista)

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen penPetronas = new Pen(colorPetronas, grosorLinea))
            {
                int inicioX = (this.Width / 2) - 150;
                int inicioY = 50;

                dibujarPugNuevo(e.Graphics, penPetronas, new Point(inicioX, inicioY));
                dibujarGatitoNuevo(e.Graphics, penPetronas, new Point(inicioX + 110, inicioY));
                dibujarPericoNuevo(e.Graphics, penPetronas, new Point(inicioX + 220, inicioY));
            }
        }

        private void dibujarPugNuevo(Graphics g, Pen p, Point basePoint)
        {
            g.DrawArc(p, basePoint.X, basePoint.Y, 80, 100, 180, 180);
            g.DrawArc(p, basePoint.X + 20, basePoint.Y + 40, 40, 40, 0, 180);
        }

        private void dibujarGatitoNuevo(Graphics g, Pen p, Point basePoint)
        {
            g.DrawArc(p, basePoint.X, basePoint.Y, 80, 100, 180, 180);
            Point[] orejaI = { new Point(basePoint.X + 15, basePoint.Y + 15), new Point(basePoint.X + 10, basePoint.Y - 10), new Point(basePoint.X + 35, basePoint.Y + 5) };
            g.DrawPolygon(p, orejaI);
            Point[] orejaD = { new Point(basePoint.X + 65, basePoint.Y + 15), new Point(basePoint.X + 70, basePoint.Y - 10), new Point(basePoint.X + 45, basePoint.Y + 5) };
            g.DrawPolygon(p, orejaD);
        }

        private void dibujarPericoNuevo(Graphics g, Pen p, Point basePoint)
        {
            GraphicsState state = g.Save();
            Rectangle rectElipse = new Rectangle(basePoint.X, basePoint.Y, 60, 100);
            Matrix matrixInclinacion = new Matrix();
            matrixInclinacion.RotateAt(10, new PointF(basePoint.X + 30, basePoint.Y + 50));
            g.MultiplyTransform(matrixInclinacion);
            g.DrawEllipse(p, rectElipse);
            g.DrawLine(p, new Point(basePoint.X + 5, basePoint.Y + 5), new Point(basePoint.X - 5, basePoint.Y - 5));
            g.DrawLine(p, new Point(basePoint.X - 5, basePoint.Y - 5), new Point(basePoint.X + 10, basePoint.Y));
            g.Restore(state);
        }

        #endregion
    }
}