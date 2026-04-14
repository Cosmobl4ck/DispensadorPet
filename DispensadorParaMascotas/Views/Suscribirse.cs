using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // La librería que instalamos

namespace DispensadorParaMascotas.Views
{
    public partial class Suscribirse : UserControl
    {
        // Dirección de tu base de datos
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=SmartPetDispenserDB; Integrated Security=True; TrustServerCertificate=True;";

        public Suscribirse()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) ||
               string.IsNullOrWhiteSpace(txtContrasena.Text) || string.IsNullOrWhiteSpace(txtConfirmarContrasena.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Inténtalo de nuevo.", "Error de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmarContrasena.Clear();
                txtConfirmarContrasena.Focus();
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Asegúrate de que el nombre del TextBox coincida con el de tu diseño
                    string query = "INSERT INTO Suscriptores (Nombre, Apellido, Celular, Correo, Contrasena, Usuario) " +
                                   "VALUES (@nom, @ape, @cel, @cor, @pass, @usu)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@ape", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@cel", txtCelular.Text);
                    cmd.Parameters.AddWithValue("@cor", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@pass", txtContrasena.Text);
                    cmd.Parameters.AddWithValue("@usu", txtUsuario.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("¡Suscripción exitosa! Bienvenido a SmartPet.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCelular.Clear(); txtCorreo.Clear();
                    txtContrasena.Clear(); txtConfirmarContrasena.Clear();
                    var form1 = this.FindForm() as Form1;
                    form1?.BtnIrAlInicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión a la base de datos: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Suscribirse_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dispensarButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                  string.IsNullOrWhiteSpace(txtContrasena.Text) || string.IsNullOrWhiteSpace(txtConfirmarContrasena.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Inténtalo de nuevo.", "Error de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmarContrasena.Clear();
                txtConfirmarContrasena.Focus();
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Asegúrate de que el nombre del TextBox coincida con el de tu diseño
                    string query = "INSERT INTO Suscriptores (Nombre, Apellido, Celular, Correo, Contrasena, Usuario) " +
                                   "VALUES (@nom, @ape, @cel, @cor, @pass, @usu)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@ape", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@cel", txtCelular.Text);
                    cmd.Parameters.AddWithValue("@cor", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@pass", txtContrasena.Text);
                    cmd.Parameters.AddWithValue("@usu", txtUsuario.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("¡Suscripción exitosa! Bienvenido a SmartPet.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombre.Clear(); txtApellido.Clear(); txtUsuario.Clear();
                    txtCelular.Clear(); txtCorreo.Clear();
                    txtContrasena.Clear(); txtConfirmarContrasena.Clear();
                    var form1 = this.FindForm() as Form1;
                    form1?.BtnIrAlInicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión a la base de datos: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 