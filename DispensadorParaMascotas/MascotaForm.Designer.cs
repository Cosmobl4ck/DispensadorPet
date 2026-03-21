namespace DispensadorParaMascotas
{
    partial class MascotaForm
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
            panel1 = new Panel();
            btnUsuario = new Button();
            btnConfiguracion = new Button();
            btnHistorial = new Button();
            btnProgramacion = new Button();
            btnInicio = new Button();
            panel2 = new Panel();
            PicFoto = new PictureBox();
            btnSubirFoto = new Button();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            txtDueño = new TextBox();
            txtComida = new TextBox();
            btnGuardarDatos = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblFoto = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicFoto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(btnUsuario);
            panel1.Controls.Add(btnConfiguracion);
            panel1.Controls.Add(btnHistorial);
            panel1.Controls.Add(btnProgramacion);
            panel1.Controls.Add(btnInicio);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnUsuario
            // 
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuario.ForeColor = Color.Silver;
            btnUsuario.Location = new Point(3, 247);
            btnUsuario.Margin = new Padding(3, 2, 3, 2);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Padding = new Padding(18, 0, 0, 0);
            btnUsuario.Size = new Size(190, 46);
            btnUsuario.TabIndex = 4;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfiguracion.ForeColor = Color.Silver;
            btnConfiguracion.Location = new Point(3, 197);
            btnConfiguracion.Margin = new Padding(3, 2, 3, 2);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Padding = new Padding(18, 0, 0, 0);
            btnConfiguracion.Size = new Size(190, 46);
            btnConfiguracion.TabIndex = 3;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistorial.ForeColor = Color.Silver;
            btnHistorial.Location = new Point(3, 147);
            btnHistorial.Margin = new Padding(3, 2, 3, 2);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Padding = new Padding(18, 0, 0, 0);
            btnHistorial.Size = new Size(190, 46);
            btnHistorial.TabIndex = 2;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnProgramacion
            // 
            btnProgramacion.FlatStyle = FlatStyle.Flat;
            btnProgramacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProgramacion.ForeColor = Color.Silver;
            btnProgramacion.Location = new Point(3, 97);
            btnProgramacion.Margin = new Padding(3, 2, 3, 2);
            btnProgramacion.Name = "btnProgramacion";
            btnProgramacion.Padding = new Padding(18, 0, 0, 0);
            btnProgramacion.Size = new Size(190, 46);
            btnProgramacion.TabIndex = 1;
            btnProgramacion.Text = "Programacion";
            btnProgramacion.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Transparent;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.Silver;
            btnInicio.Location = new Point(3, 47);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(18, 0, 0, 0);
            btnInicio.Size = new Size(190, 46);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(208, 442);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(754, 8);
            panel2.TabIndex = 2;
            // 
            // PicFoto
            // 
            PicFoto.BorderStyle = BorderStyle.FixedSingle;
            PicFoto.Cursor = Cursors.AppStarting;
            PicFoto.ErrorImage = null;
            PicFoto.Image = Properties.Resources.Gemini_Generated_Image_ltp2zqltp2zqltp2;
            PicFoto.InitialImage = null;
            PicFoto.Location = new Point(282, 70);
            PicFoto.Name = "PicFoto";
            PicFoto.Size = new Size(215, 200);
            PicFoto.SizeMode = PictureBoxSizeMode.Zoom;
            PicFoto.TabIndex = 3;
            PicFoto.TabStop = false;
            PicFoto.Click += PicFoto_Click;
            // 
            // btnSubirFoto
            // 
            btnSubirFoto.FlatStyle = FlatStyle.Flat;
            btnSubirFoto.ForeColor = Color.Silver;
            btnSubirFoto.Location = new Point(346, 309);
            btnSubirFoto.Name = "btnSubirFoto";
            btnSubirFoto.Size = new Size(75, 23);
            btnSubirFoto.TabIndex = 4;
            btnSubirFoto.Text = "Subir Foto";
            btnSubirFoto.UseVisualStyleBackColor = true;
            btnSubirFoto.Click += btnSubirFoto_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(700, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(199, 23);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(700, 111);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(199, 23);
            txtEdad.TabIndex = 6;
            txtEdad.TextChanged += txtEdad_TextChanged;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(700, 154);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(199, 23);
            txtPeso.TabIndex = 7;
            txtPeso.TextChanged += txtPeso_TextChanged;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(700, 200);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(199, 23);
            txtAltura.TabIndex = 8;
            txtAltura.TextChanged += txtAltura_TextChanged;
            // 
            // txtDueño
            // 
            txtDueño.Location = new Point(700, 245);
            txtDueño.Name = "txtDueño";
            txtDueño.Size = new Size(199, 23);
            txtDueño.TabIndex = 9;
            txtDueño.TextChanged += txtDueño_TextChanged;
            // 
            // txtComida
            // 
            txtComida.BackColor = Color.White;
            txtComida.Location = new Point(700, 291);
            txtComida.Name = "txtComida";
            txtComida.Size = new Size(199, 23);
            txtComida.TabIndex = 10;
            txtComida.TextChanged += txtComida_TextChanged;
            // 
            // btnGuardarDatos
            // 
            btnGuardarDatos.FlatStyle = FlatStyle.Flat;
            btnGuardarDatos.ForeColor = Color.Silver;
            btnGuardarDatos.Location = new Point(472, 362);
            btnGuardarDatos.Name = "btnGuardarDatos";
            btnGuardarDatos.Size = new Size(190, 46);
            btnGuardarDatos.TabIndex = 11;
            btnGuardarDatos.Text = "Guardar  Datos";
            btnGuardarDatos.UseVisualStyleBackColor = true;
            btnGuardarDatos.Click += btnGuardarDatos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(282, 31);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 12;
            label1.Text = "Nueva Mascota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(632, 70);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 13;
            label2.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(613, 114);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 14;
            label3.Text = "Edad (años):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(628, 157);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 15;
            label4.Text = "Peso (kg):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(616, 203);
            label5.Name = "label5";
            label5.Size = new Size(82, 17);
            label5.TabIndex = 16;
            label5.Text = "Altura (cm):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(645, 249);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 17;
            label6.Text = "Dueño:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(617, 294);
            label7.Name = "label7";
            label7.Size = new Size(81, 17);
            label7.TabIndex = 18;
            label7.Text = "Comida (g):";
            label7.Click += label7_Click;
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.FlatStyle = FlatStyle.Flat;
            lblFoto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoto.ForeColor = Color.Silver;
            lblFoto.Location = new Point(326, 276);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(111, 17);
            lblFoto.TabIndex = 19;
            lblFoto.Text = "Agregue Su Foto";
            // 
            // MascotaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 27);
            ClientSize = new Size(962, 450);
            Controls.Add(lblFoto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardarDatos);
            Controls.Add(txtComida);
            Controls.Add(txtDueño);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(btnSubirFoto);
            Controls.Add(PicFoto);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MascotaForm";
            Text = "MascotaForm";
            Load += MascotaForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnInicio;
        private Button btnProgramacion;
        private Button btnUsuario;
        private Button btnConfiguracion;
        private Button btnHistorial;
        private PictureBox PicFoto;
        private Button btnSubirFoto;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private TextBox txtDueño;
        private TextBox txtComida;
        private Button btnGuardarDatos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblFoto;
    }
}