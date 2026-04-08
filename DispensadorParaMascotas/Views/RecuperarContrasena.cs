using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DispensadorParaMascotas.Views
{
    public partial class RecuperarContrasena : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=SmartPetDispenserDB; Integrated Security=True; TrustServerCertificate=True;";
        public RecuperarContrasena()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtCorreoRecuperar.Text) || string.IsNullOrWhiteSpace(txtNuevaPass.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            if (txtNuevaPass.Text != txtConfirmarNuevaPass.Text)
            {
                MessageBox.Show("Las contraseñas nuevas no coinciden.");
                return;
            }

            // 2. Lógica de SQL para actualizar
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // Buscamos el correo y actualizamos la contraseña
                    string query = "UPDATE Suscriptores SET Contrasena = @pass WHERE Correo = @cor";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@pass", txtNuevaPass.Text);
                    cmd.Parameters.AddWithValue("@cor", txtCorreoRecuperar.Text);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("¡Contraseña actualizada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El correo ingresado no está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RecuperarContrasena_Load(object sender, EventArgs e)
        {

        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtCorreoRecuperar.Text) || string.IsNullOrWhiteSpace(txtNuevaPass.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            if (txtNuevaPass.Text != txtConfirmarNuevaPass.Text)
            {
                MessageBox.Show("Las contraseñas nuevas no coinciden.");
                return;
            }

            // 2. Lógica de SQL para actualizar
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // Buscamos el correo y actualizamos la contraseña
                    string query = "UPDATE Suscriptores SET Contrasena = @pass WHERE Correo = @cor";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@pass", txtNuevaPass.Text);
                    cmd.Parameters.AddWithValue("@cor", txtCorreoRecuperar.Text);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("¡Contraseña actualizada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El correo ingresado no está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    }


