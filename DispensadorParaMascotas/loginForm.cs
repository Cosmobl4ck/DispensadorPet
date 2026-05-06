using DispensadorParaMascotas.Models;
using DispensadorParaMascotas.Views;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace DispensadorParaMascotas
{
    public partial class loginForm : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=SmartPetDispenserDB; Integrated Security=True; TrustServerCertificate=True;";

        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        Color colorPetronas = Color.FromArgb(0, 161, 156);
        Color colorOriginal = Color.FromArgb(64, 64, 64);
        int grosorLinea = 3;

        public loginForm()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
            this.AcceptButton = btnSignIn; // Enter dispara el login desde cualquier campo
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetWindowTheme(prgCarga.Handle, "", "");
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = true;
            // Fix: sin esto los TextBox arrancan blancos (SystemColors.Window por defecto)
            txtUsuario.BackColor = colorOriginal;
            txtContrasena.BackColor = colorOriginal;

            linkLabel1.LinkColor = Color.White;
            linkLabel1.VisitedLinkColor = Color.White;
            linkLabel1.ActiveLinkColor = colorPetronas;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;

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
            string cuenta = txtUsuario.Text;
            string password = txtContrasena.Text;

            string query = "SELECT COUNT(*) FROM Suscriptores WHERE (Usuario = @cuenta OR Correo = @cuenta) AND Contrasena = @pass";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@cuenta", cuenta);
                    cmd.Parameters.AddWithValue("@pass", password);

                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("¡Bienvenido al sistema!");
                        Form1 principal = new Form1();
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas. Verifique su usuario y contraseña.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContrasena ventanaRecuperar = new RecuperarContrasena();
            ventanaRecuperar.ShowDialog();
        }
    }
}
