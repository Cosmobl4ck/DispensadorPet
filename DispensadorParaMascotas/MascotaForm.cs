using DispensadorParaMascotas.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DispensadorParaMascotas
{
    public partial class MascotaForm : Form, IMascotaView
    {
        //evento para el controller
        public event EventHandler GuardarSolicitado;

        public event EventHandler VolverInicioSolicitado;

        public MascotaForm()
        {
            InitializeComponent();

            // Ocultar textbox de foto (opcional)
            btnSubirFoto.Visible = false;
        }

        // PROPIEDADES (datos que el controller lee)
        public string Nombre => txtNombre.Text;
        public int Edad => int.TryParse(txtEdad.Text, out int e) ? e : 0;
        public double Peso => double.TryParse(txtPeso.Text, out double p) ? p : 0;
        public double Altura => double.TryParse(txtAltura.Text, out double a) ? a : 0;
        public string Dueno => txtDueño.Text;
        public string Comida => txtComida.Text;
        public string Foto => btnSubirFoto.Text;

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void MascotaForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

        }

        private void PicFoto_Click(object sender, EventArgs e)
        {
            btnSubirFoto_Click(sender, e);
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Imagenes|*.jpg;*.png;*.jpeg";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                btnSubirFoto.Image = Image.FromFile(openFile.FileName);
                btnSubirFoto.Text = openFile.FileName;
            }
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            GuardarSolicitado.Invoke(this, EventArgs.Empty);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDueño_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComida_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            VolverInicioSolicitado?.Invoke(this, EventArgs.Empty);
        }
    }
}
