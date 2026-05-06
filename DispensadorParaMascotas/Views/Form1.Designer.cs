namespace DispensadorParaMascotas
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlTitleBar = new Panel();
            lblTitulo = new Label();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnInicio = new DispensadorParaMascotas.Views.MenuButton();
            btnProgramacion = new DispensadorParaMascotas.Views.MenuButton();
            btnHistorial = new DispensadorParaMascotas.Views.MenuButton();
            btnConfiguracion = new DispensadorParaMascotas.Views.MenuButton();
            btnUsuario = new DispensadorParaMascotas.Views.MenuButton();
            panel1 = new Panel();
            lblKilos = new Label();
            lblCapacidad = new Label();
            lblNivelComida = new Label();
            txtNombreMascota = new Label();
            lblEstado = new Label();
            pnlContenido = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAltura = new Label();
            txtPeso = new Label();
            txtEdad = new Label();
            lblSaludo = new Label();
            pnlHeader = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pbMascota = new PictureBox();
            dispensarButton1 = new DispensadorParaMascotas.Views.dispensarButton();
            btnSuscribirse = new DispensadorParaMascotas.Views.MenuButton();
            pnlTitleBar.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlContenido.SuspendLayout();
            panel2.SuspendLayout();
            pnlHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMascota).BeginInit();
            SuspendLayout();
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(20, 20, 22);
            pnlTitleBar.Controls.Add(lblTitulo);
            pnlTitleBar.Controls.Add(btnCerrar);
            pnlTitleBar.Controls.Add(btnMinimizar);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Margin = new Padding(4, 5, 4, 5);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1829, 53);
            pnlTitleBar.TabIndex = 6;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            pnlTitleBar.MouseMove += pnlTitleBar_MouseMove;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 9F);
            lblTitulo.ForeColor = Color.Silver;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1697, 53);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SmartPet Dispenser v1.0";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.MouseDown += pnlTitleBar_MouseDown;
            lblTitulo.MouseMove += pnlTitleBar_MouseMove;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 40, 40);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9F);
            btnCerrar.ForeColor = Color.Silver;
            btnCerrar.Location = new Point(1697, 0);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(66, 53);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "✕";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.Dock = DockStyle.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 65);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 9F);
            btnMinimizar.ForeColor = Color.Silver;
            btnMinimizar.Location = new Point(1763, 0);
            btnMinimizar.Margin = new Padding(4, 5, 4, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(66, 53);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.Text = "─";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(33, 33, 33);
            flowLayoutPanel1.Controls.Add(btnInicio);
            flowLayoutPanel1.Controls.Add(btnProgramacion);
            flowLayoutPanel1.Controls.Add(btnHistorial);
            flowLayoutPanel1.Controls.Add(btnConfiguracion);
            flowLayoutPanel1.Controls.Add(btnUsuario);
            flowLayoutPanel1.Controls.Add(btnSuscribirse);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 53);
            flowLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 75, 0, 0);
            flowLayoutPanel1.Size = new Size(314, 1147);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Transparent;
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 10F);
            btnInicio.ForeColor = Color.Silver;
            btnInicio.Location = new Point(4, 78);
            btnInicio.Margin = new Padding(4, 3, 4, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(26, 0, 0, 0);
            btnInicio.Size = new Size(313, 83);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // btnProgramacion
            // 
            btnProgramacion.BackColor = Color.Transparent;
            btnProgramacion.Dock = DockStyle.Top;
            btnProgramacion.FlatAppearance.BorderSize = 0;
            btnProgramacion.FlatStyle = FlatStyle.Flat;
            btnProgramacion.Font = new Font("Segoe UI", 10F);
            btnProgramacion.ForeColor = Color.Silver;
            btnProgramacion.Location = new Point(4, 167);
            btnProgramacion.Margin = new Padding(4, 3, 4, 3);
            btnProgramacion.Name = "btnProgramacion";
            btnProgramacion.Padding = new Padding(26, 0, 0, 0);
            btnProgramacion.Size = new Size(313, 83);
            btnProgramacion.TabIndex = 1;
            btnProgramacion.Text = "Programacion";
            btnProgramacion.TextAlign = ContentAlignment.MiddleLeft;
            btnProgramacion.UseVisualStyleBackColor = false;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.Transparent;
            btnHistorial.Dock = DockStyle.Top;
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 10F);
            btnHistorial.ForeColor = Color.Silver;
            btnHistorial.Location = new Point(4, 256);
            btnHistorial.Margin = new Padding(4, 3, 4, 3);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Padding = new Padding(26, 0, 0, 0);
            btnHistorial.Size = new Size(313, 83);
            btnHistorial.TabIndex = 2;
            btnHistorial.Text = "Historial";
            btnHistorial.TextAlign = ContentAlignment.MiddleLeft;
            btnHistorial.UseVisualStyleBackColor = false;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = Color.Transparent;
            btnConfiguracion.Dock = DockStyle.Top;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Segoe UI", 10F);
            btnConfiguracion.ForeColor = Color.Silver;
            btnConfiguracion.Location = new Point(4, 345);
            btnConfiguracion.Margin = new Padding(4, 3, 4, 3);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Padding = new Padding(26, 0, 0, 0);
            btnConfiguracion.Size = new Size(313, 83);
            btnConfiguracion.TabIndex = 3;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.UseVisualStyleBackColor = false;
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.Transparent;
            btnUsuario.Dock = DockStyle.Top;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Segoe UI", 10F);
            btnUsuario.ForeColor = Color.Silver;
            btnUsuario.Location = new Point(4, 434);
            btnUsuario.Margin = new Padding(4, 3, 4, 3);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Padding = new Padding(26, 0, 0, 0);
            btnUsuario.Size = new Size(313, 83);
            btnUsuario.TabIndex = 4;
            btnUsuario.Text = "Usuario";
            btnUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(314, 1187);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1515, 13);
            panel1.TabIndex = 1;
            // 
            // lblKilos
            // 
            lblKilos.AutoSize = true;
            lblKilos.BackColor = Color.Transparent;
            lblKilos.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKilos.ForeColor = Color.White;
            lblKilos.Location = new Point(590, 263);
            lblKilos.Margin = new Padding(4, 0, 4, 0);
            lblKilos.Name = "lblKilos";
            lblKilos.Size = new Size(208, 70);
            lblKilos.TabIndex = 2;
            lblKilos.Text = "1.45 kg";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.BackColor = Color.Transparent;
            lblCapacidad.Font = new Font("Segoe UI", 9F);
            lblCapacidad.ForeColor = Color.FromArgb(180, 180, 180);
            lblCapacidad.Location = new Point(666, 337);
            lblCapacidad.Margin = new Padding(4, 0, 4, 0);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(73, 25);
            lblCapacidad.TabIndex = 3;
            lblCapacidad.Text = "/ 2.0 kg";
            // 
            // lblNivelComida
            // 
            lblNivelComida.AutoSize = true;
            lblNivelComida.BackColor = Color.Transparent;
            lblNivelComida.Font = new Font("Segoe UI", 7.5F);
            lblNivelComida.ForeColor = Color.FromArgb(120, 120, 120);
            lblNivelComida.Location = new Point(590, 370);
            lblNivelComida.Margin = new Padding(4, 0, 4, 0);
            lblNivelComida.Name = "lblNivelComida";
            lblNivelComida.Size = new Size(191, 20);
            lblNivelComida.TabIndex = 8;
            lblNivelComida.Text = "LEVEL DE COMIDA ACTUAL";
            // 
            // txtNombreMascota
            // 
            txtNombreMascota.Dock = DockStyle.Fill;
            txtNombreMascota.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            txtNombreMascota.ForeColor = Color.White;
            txtNombreMascota.Location = new Point(140, 0);
            txtNombreMascota.Margin = new Padding(4, 0, 4, 0);
            txtNombreMascota.Name = "txtNombreMascota";
            txtNombreMascota.Padding = new Padding(9, 0, 0, 0);
            txtNombreMascota.Size = new Size(270, 86);
            txtNombreMascota.TabIndex = 6;
            txtNombreMascota.Text = "Mascota: Franky";
            txtNombreMascota.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblEstado
            // 
            lblEstado.Dock = DockStyle.Fill;
            lblEstado.Font = new Font("Segoe UI", 9F);
            lblEstado.ForeColor = Color.FromArgb(0, 210, 200);
            lblEstado.Location = new Point(140, 86);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Padding = new Padding(9, 7, 0, 0);
            lblEstado.Size = new Size(270, 72);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "● Online";
            // 
            // pnlContenido
            // 
            pnlContenido.Controls.Add(panel2);
            pnlContenido.Controls.Add(lblSaludo);
            pnlContenido.Controls.Add(pnlHeader);
            pnlContenido.Controls.Add(lblKilos);
            pnlContenido.Controls.Add(lblCapacidad);
            pnlContenido.Controls.Add(lblNivelComida);
            pnlContenido.Controls.Add(dispensarButton1);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(314, 53);
            pnlContenido.Margin = new Padding(4, 3, 4, 3);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1515, 1147);
            pnlContenido.TabIndex = 5;
            pnlContenido.Paint += pnlContenido_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtAltura);
            panel2.Controls.Add(txtPeso);
            panel2.Controls.Add(txtEdad);
            panel2.Location = new Point(1059, 198);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(413, 90);
            panel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(140, 140, 150);
            label3.Location = new Point(296, 12);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 11;
            label3.Text = "Altura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(140, 140, 150);
            label2.Location = new Point(158, 12);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 28);
            label2.TabIndex = 11;
            label2.Text = "Peso";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(140, 140, 150);
            label1.Location = new Point(20, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 28);
            label1.TabIndex = 11;
            label1.Text = "Edad";
            // 
            // txtAltura
            // 
            txtAltura.AutoSize = true;
            txtAltura.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtAltura.ForeColor = Color.White;
            txtAltura.Location = new Point(296, 48);
            txtAltura.Margin = new Padding(4, 0, 4, 0);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(59, 25);
            txtAltura.TabIndex = 9;
            txtAltura.Text = "Altura";
            // 
            // txtPeso
            // 
            txtPeso.AutoSize = true;
            txtPeso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtPeso.ForeColor = Color.White;
            txtPeso.Location = new Point(158, 48);
            txtPeso.Margin = new Padding(4, 0, 4, 0);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(49, 25);
            txtPeso.TabIndex = 9;
            txtPeso.Text = "Peso";
            // 
            // txtEdad
            // 
            txtEdad.AutoSize = true;
            txtEdad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtEdad.ForeColor = Color.White;
            txtEdad.Location = new Point(20, 48);
            txtEdad.Margin = new Padding(4, 0, 4, 0);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(52, 25);
            txtEdad.TabIndex = 9;
            txtEdad.Text = "Edad";
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSaludo.ForeColor = Color.White;
            lblSaludo.Location = new Point(537, 27);
            lblSaludo.Margin = new Padding(4, 0, 4, 0);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(105, 40);
            lblSaludo.TabIndex = 9;
            lblSaludo.Text = "Saludo";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.Controls.Add(tableLayoutPanel1);
            pnlHeader.Location = new Point(1057, 27);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(414, 158);
            pnlHeader.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 136F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pbMascota, 0, 0);
            tableLayoutPanel1.Controls.Add(txtNombreMascota, 1, 0);
            tableLayoutPanel1.Controls.Add(lblEstado, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Size = new Size(414, 158);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pbMascota
            // 
            pbMascota.Image = (Image)resources.GetObject("pbMascota.Image");
            pbMascota.Location = new Point(9, 10);
            pbMascota.Margin = new Padding(9, 10, 9, 10);
            pbMascota.Name = "pbMascota";
            tableLayoutPanel1.SetRowSpan(pbMascota, 2);
            pbMascota.Size = new Size(118, 138);
            pbMascota.SizeMode = PictureBoxSizeMode.Zoom;
            pbMascota.TabIndex = 4;
            pbMascota.TabStop = false;
            // 
            // dispensarButton1
            // 
            dispensarButton1.BackColor = Color.FromArgb(45, 45, 48);
            dispensarButton1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            dispensarButton1.FlatAppearance.BorderSize = 0;
            dispensarButton1.FlatStyle = FlatStyle.Flat;
            dispensarButton1.Font = new Font("Segoe UI Semibold", 11F);
            dispensarButton1.ForeColor = Color.White;
            dispensarButton1.Location = new Point(550, 672);
            dispensarButton1.Margin = new Padding(4, 3, 4, 3);
            dispensarButton1.Name = "dispensarButton1";
            dispensarButton1.Size = new Size(300, 80);
            dispensarButton1.TabIndex = 0;
            dispensarButton1.TabStop = false;
            dispensarButton1.Text = "Dispensar";
            dispensarButton1.UseVisualStyleBackColor = false;
            dispensarButton1.Click += dispensarButton1_Click;
            // 
            // btnSuscribirse
            // 
            btnSuscribirse.BackColor = Color.Transparent;
            btnSuscribirse.Dock = DockStyle.Top;
            btnSuscribirse.FlatAppearance.BorderSize = 0;
            btnSuscribirse.FlatStyle = FlatStyle.Flat;
            btnSuscribirse.Font = new Font("Segoe UI", 10F);
            btnSuscribirse.ForeColor = Color.Silver;
            btnSuscribirse.Location = new Point(4, 523);
            btnSuscribirse.Margin = new Padding(4, 3, 4, 3);
            btnSuscribirse.Name = "btnSuscribirse";
            btnSuscribirse.Padding = new Padding(26, 0, 0, 0);
            btnSuscribirse.Size = new Size(313, 83);
            btnSuscribirse.TabIndex = 5;
            btnSuscribirse.Text = "Suscribirse";
            btnSuscribirse.TextAlign = ContentAlignment.MiddleLeft;
            btnSuscribirse.UseVisualStyleBackColor = false;
            btnSuscribirse.Click += btnSuscribirse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 27);
            ClientSize = new Size(1829, 1200);
            Controls.Add(panel1);
            Controls.Add(pnlContenido);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pnlTitleBar.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlHeader.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMascota).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitleBar;
        private Label lblTitulo;
        private Button btnCerrar;
        private Button btnMinimizar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label lblKilos;
        private Label lblCapacidad;
        private Label lblNivelComida;
        private Label txtNombreMascota;
        private Label lblEstado;
        private Views.MenuButton btnInicio;
        private Views.MenuButton btnProgramacion;
        private Views.MenuButton btnHistorial;
        private Views.MenuButton btnConfiguracion;
        private Views.MenuButton btnUsuario;
        private Panel pnlContenido;
        private Views.dispensarButton dispensarButton1;
        private PictureBox pbMascota;
        private Panel pnlHeader;
        private TableLayoutPanel tableLayoutPanel1;
        public Label lblSaludo;
        public Label txtAltura;
        public Label txtPeso;
        public Label txtEdad;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Views.MenuButton btnSuscribirse;
    }
}