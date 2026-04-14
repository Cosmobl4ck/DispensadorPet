namespace DispensadorParaMascotas.Views
{
    partial class Suscribirse : UserControl
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

        private dispensarButton GetBtnCrear()
        {
            return Crear_Suscripcion;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suscribirse));
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtCelular = new TextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            txtContrasena = new TextBox();
            label7 = new Label();
            txtConfirmarContrasena = new TextBox();
            label8 = new Label();
            txtUsuario = new TextBox();
            Crear_Suscripcion = new dispensarButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 161, 155);
            label1.Location = new Point(365, 53);
            label1.Name = "label1";
            label1.Size = new Size(175, 45);
            label1.TabIndex = 0;
            label1.Text = "Suscribirse";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(366, 162);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(398, 31);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 161, 155);
            label2.Location = new Point(365, 133);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 161, 155);
            label3.Location = new Point(366, 217);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(367, 246);
            txtApellido.Margin = new Padding(4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(398, 31);
            txtApellido.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 161, 155);
            label4.Location = new Point(364, 385);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 8;
            label4.Text = "Celular";
            // 
            // txtCelular
            // 
            txtCelular.BorderStyle = BorderStyle.FixedSingle;
            txtCelular.ForeColor = Color.Black;
            txtCelular.Location = new Point(365, 414);
            txtCelular.Margin = new Padding(4);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(398, 31);
            txtCelular.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 161, 155);
            label5.Location = new Point(364, 471);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 10;
            label5.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.ForeColor = Color.Black;
            txtCorreo.Location = new Point(365, 500);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(398, 31);
            txtCorreo.TabIndex = 9;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(825, 459);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 25);
            linkLabel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-39, 715);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._079e94;
            pictureBox2.Location = new Point(54, 254);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(230, 255);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 161, 155);
            label6.Location = new Point(364, 560);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 16;
            label6.Text = "Contraseña";
            label6.Click += label6_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.ForeColor = Color.Black;
            txtContrasena.Location = new Point(365, 589);
            txtContrasena.Margin = new Padding(4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(398, 31);
            txtContrasena.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 161, 155);
            label7.Location = new Point(365, 643);
            label7.Name = "label7";
            label7.Size = new Size(166, 21);
            label7.TabIndex = 18;
            label7.Text = "Confirmar Contraseña";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarContrasena.ForeColor = Color.Black;
            txtConfirmarContrasena.Location = new Point(366, 672);
            txtConfirmarContrasena.Margin = new Padding(4);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.PasswordChar = '*';
            txtConfirmarContrasena.Size = new Size(398, 31);
            txtConfirmarContrasena.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 161, 155);
            label8.Location = new Point(366, 302);
            label8.Name = "label8";
            label8.Size = new Size(64, 21);
            label8.TabIndex = 20;
            label8.Text = "Usuario";
            label8.Click += label8_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(367, 331);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(398, 31);
            txtUsuario.TabIndex = 19;
            // 
            // Crear_Suscripcion
            // 
            Crear_Suscripcion.BackColor = Color.FromArgb(45, 45, 48);
            Crear_Suscripcion.FlatAppearance.BorderSize = 0;
            Crear_Suscripcion.FlatStyle = FlatStyle.Flat;
            Crear_Suscripcion.Font = new Font("Segoe UI Semibold", 11F);
            Crear_Suscripcion.ForeColor = Color.White;
            Crear_Suscripcion.Location = new Point(120, 600);
            Crear_Suscripcion.Name = "Crear_Suscripcion";
            Crear_Suscripcion.Size = new Size(111, 37);
            Crear_Suscripcion.TabIndex = 21;
            Crear_Suscripcion.Text = "Crear";
            Crear_Suscripcion.UseVisualStyleBackColor = false;
            this.Crear_Suscripcion.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // Suscribirse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 27);
            Size = new Size(839, 845);
            Controls.Add(Crear_Suscripcion);
            Controls.Add(label8);
            Controls.Add(txtUsuario);
            Controls.Add(label7);
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(label6);
            Controls.Add(txtContrasena);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtCelular);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            
            Name = "Suscribirse";
            
            Text = "Suscribirse";
            Load += Suscribirse_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtCelular;
        private Label label5;
        private TextBox txtCorreo;
        private dispensarButton Crear_Suscripcion;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private TextBox txtContrasena;
        private Label label7;
        private TextBox txtConfirmarContrasena;
        private Label label8;
        private TextBox txtUsuario;
        
    }
}