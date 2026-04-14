namespace DispensadorParaMascotas.Views
{
    partial class RecuperarContrasena
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 1. Instanciación (Dar vida a los objetos)
            label4 = new Label();
            txtConfirmarNuevaPass = new TextBox();
            label3 = new Label();
            txtNuevaPass = new TextBox();
            label2 = new Label();
            txtCorreoRecuperar = new TextBox();
            label1 = new Label();
            BtnContinuar = new dispensarButton();
            btnCancelar = new dispensarButton();

            SuspendLayout();

            // 2. Configuración de Propiedades

            // label4
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            label4.ForeColor = Color.FromArgb(0, 161, 155);
            label4.Location = new Point(61, 412);
            label4.Name = "label4";
            label4.Size = new Size(166, 21);
            label4.Text = "Confirmar Contrasena";

            // txtConfirmarNuevaPass (Color blanco para que se vea en fondo oscuro)
            txtConfirmarNuevaPass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarNuevaPass.ForeColor = Color.White;
            txtConfirmarNuevaPass.BackColor = Color.FromArgb(45, 45, 45);
            txtConfirmarNuevaPass.Location = new Point(63, 442);
            txtConfirmarNuevaPass.Name = "txtConfirmarNuevaPass";
            txtConfirmarNuevaPass.Size = new Size(398, 31);
            txtConfirmarNuevaPass.UseSystemPasswordChar = true;

            // label3
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(0, 161, 155);
            label3.Location = new Point(63, 327);
            label3.Text = "Nueva Contrasena";

            // txtNuevaPass
            txtNuevaPass.BorderStyle = BorderStyle.FixedSingle;
            txtNuevaPass.ForeColor = Color.White;
            txtNuevaPass.BackColor = Color.FromArgb(45, 45, 45);
            txtNuevaPass.Location = new Point(64, 357);
            txtNuevaPass.Name = "txtNuevaPass";
            txtNuevaPass.Size = new Size(398, 31);
            txtNuevaPass.UseSystemPasswordChar = true;

            // label2
            label2.ForeColor = Color.FromArgb(0, 161, 155);
            label2.Location = new Point(61, 243);
            label2.Text = "Correo";

            // txtCorreoRecuperar
            txtCorreoRecuperar.BorderStyle = BorderStyle.FixedSingle;
            txtCorreoRecuperar.ForeColor = Color.White;
            txtCorreoRecuperar.BackColor = Color.FromArgb(45, 45, 45);
            txtCorreoRecuperar.Location = new Point(63, 272);
            txtCorreoRecuperar.Name = "txtCorreoRecuperar";
            txtCorreoRecuperar.Size = new Size(398, 31);

            // label1 (Título)
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 161, 155);
            label1.Location = new Point(64, 117);
            label1.Text = "Recuperar Contrasena";

            // BtnContinuar
            BtnContinuar.BackColor = Color.FromArgb(45, 45, 48);
            BtnContinuar.FlatStyle = FlatStyle.Flat;
            BtnContinuar.ForeColor = Color.White;
            BtnContinuar.Location = new Point(183, 521);
            BtnContinuar.Name = "BtnContinuar";
            BtnContinuar.Size = new Size(156, 39);
            BtnContinuar.Text = "Continuar";
            BtnContinuar.Click += BtnContinuar_Click;

            // btnCancelar
            btnCancelar.BackColor = Color.FromArgb(60, 60, 60);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(183, 575);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(156, 39);
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;

            // 3. Configuración del Formulario Final
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(26, 26, 27);
            this.ClientSize = new Size(530, 733);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;

            // Agregar controles a la colección
            this.Controls.Add(btnCancelar);
            this.Controls.Add(BtnContinuar);
            this.Controls.Add(label1);
            this.Controls.Add(label4);
            this.Controls.Add(txtConfirmarNuevaPass);
            this.Controls.Add(label3);
            this.Controls.Add(txtNuevaPass);
            this.Controls.Add(label2);
            this.Controls.Add(txtCorreoRecuperar);

            this.Name = "RecuperarContrasena";
            this.Text = "Recuperar Contraseña";
            this.Load += RecuperarContrasena_Load;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtConfirmarNuevaPass;
        private Label label3;
        private TextBox txtNuevaPass;
        private Label label2;
        private TextBox txtCorreoRecuperar;
        private Label label1;
        private dispensarButton btnActualizar;
        private dispensarButton BtnContinuar;
        private dispensarButton btnCancelar; // Agregado
    }
}