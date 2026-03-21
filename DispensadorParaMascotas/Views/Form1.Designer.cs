namespace DispensadorParaMascotas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
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
            lblNombreMascota = new Label();
            lblEstado = new Label();
            pnlContenido = new Panel();
            pnlHeader = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pbMascota = new PictureBox();
            dispensarButton1 = new DispensadorParaMascotas.Views.dispensarButton();
            pnlTitleBar.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlContenido.SuspendLayout();
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
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1280, 32);
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
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1188, 32);
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
            btnCerrar.Location = new Point(1188, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(46, 32);
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
            btnMinimizar.Location = new Point(1234, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(46, 32);
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
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 32);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 45, 0, 0);
            flowLayoutPanel1.Size = new Size(220, 688);
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
            btnInicio.Location = new Point(3, 47);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(18, 0, 0, 0);
            btnInicio.Size = new Size(219, 50);
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
            btnProgramacion.Location = new Point(3, 101);
            btnProgramacion.Margin = new Padding(3, 2, 3, 2);
            btnProgramacion.Name = "btnProgramacion";
            btnProgramacion.Padding = new Padding(18, 0, 0, 0);
            btnProgramacion.Size = new Size(219, 50);
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
            btnHistorial.Location = new Point(3, 155);
            btnHistorial.Margin = new Padding(3, 2, 3, 2);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Padding = new Padding(18, 0, 0, 0);
            btnHistorial.Size = new Size(219, 50);
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
            btnConfiguracion.Location = new Point(3, 209);
            btnConfiguracion.Margin = new Padding(3, 2, 3, 2);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Padding = new Padding(18, 0, 0, 0);
            btnConfiguracion.Size = new Size(219, 50);
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
            btnUsuario.Location = new Point(3, 263);
            btnUsuario.Margin = new Padding(3, 2, 3, 2);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Padding = new Padding(18, 0, 0, 0);
            btnUsuario.Size = new Size(219, 50);
            btnUsuario.TabIndex = 4;
            btnUsuario.Text = "Usuario";
            btnUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuario.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(220, 712);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 8);
            panel1.TabIndex = 1;
            // 
            // lblKilos
            // 
            lblKilos.AutoSize = true;
            lblKilos.BackColor = Color.Transparent;
            lblKilos.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKilos.ForeColor = Color.White;
            lblKilos.Location = new Point(413, 158);
            lblKilos.Name = "lblKilos";
            lblKilos.Size = new Size(141, 47);
            lblKilos.TabIndex = 2;
            lblKilos.Text = "1.45 kg";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.BackColor = Color.Transparent;
            lblCapacidad.Font = new Font("Segoe UI", 9F);
            lblCapacidad.ForeColor = Color.FromArgb(180, 180, 180);
            lblCapacidad.Location = new Point(466, 202);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(46, 15);
            lblCapacidad.TabIndex = 3;
            lblCapacidad.Text = "/ 2.0 kg";
            // 
            // lblNivelComida
            // 
            lblNivelComida.AutoSize = true;
            lblNivelComida.BackColor = Color.Transparent;
            lblNivelComida.Font = new Font("Segoe UI", 7.5F);
            lblNivelComida.ForeColor = Color.FromArgb(120, 120, 120);
            lblNivelComida.Location = new Point(413, 222);
            lblNivelComida.Name = "lblNivelComida";
            lblNivelComida.Size = new Size(126, 12);
            lblNivelComida.TabIndex = 8;
            lblNivelComida.Text = "LEVEL DE COMIDA ACTUAL";
            // 
            // lblNombreMascota
            // 
            lblNombreMascota.Dock = DockStyle.Fill;
            lblNombreMascota.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNombreMascota.ForeColor = Color.White;
            lblNombreMascota.Location = new Point(98, 0);
            lblNombreMascota.Name = "lblNombreMascota";
            lblNombreMascota.Padding = new Padding(6, 0, 0, 0);
            lblNombreMascota.Size = new Size(189, 52);
            lblNombreMascota.TabIndex = 6;
            lblNombreMascota.Text = "Mascota: Franky";
            lblNombreMascota.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblEstado
            // 
            lblEstado.Dock = DockStyle.Fill;
            lblEstado.Font = new Font("Segoe UI", 9F);
            lblEstado.ForeColor = Color.FromArgb(0, 210, 200);
            lblEstado.Location = new Point(98, 52);
            lblEstado.Name = "lblEstado";
            lblEstado.Padding = new Padding(6, 4, 0, 0);
            lblEstado.Size = new Size(189, 43);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "● Online";
            // 
            // pnlContenido
            // 
            pnlContenido.Controls.Add(pnlHeader);
            pnlContenido.Controls.Add(lblKilos);
            pnlContenido.Controls.Add(lblCapacidad);
            pnlContenido.Controls.Add(lblNivelComida);
            pnlContenido.Controls.Add(dispensarButton1);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(220, 32);
            pnlContenido.Margin = new Padding(3, 2, 3, 2);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1060, 688);
            pnlContenido.TabIndex = 5;
            pnlContenido.Paint += pnlContenido_Paint;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Transparent;
            pnlHeader.Controls.Add(tableLayoutPanel1);
            pnlHeader.Location = new Point(740, 16);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(290, 95);
            pnlHeader.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pbMascota, 0, 0);
            tableLayoutPanel1.Controls.Add(lblNombreMascota, 1, 0);
            tableLayoutPanel1.Controls.Add(lblEstado, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Size = new Size(290, 95);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pbMascota
            // 
            pbMascota.Image = (Image)resources.GetObject("pbMascota.Image");
            pbMascota.Location = new Point(6, 6);
            pbMascota.Margin = new Padding(6);
            pbMascota.Name = "pbMascota";
            tableLayoutPanel1.SetRowSpan(pbMascota, 2);
            pbMascota.Size = new Size(83, 83);
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
            dispensarButton1.Location = new Point(385, 400);
            dispensarButton1.Margin = new Padding(3, 2, 3, 2);
            dispensarButton1.Name = "dispensarButton1";
            dispensarButton1.Size = new Size(210, 48);
            dispensarButton1.TabIndex = 0;
            dispensarButton1.TabStop = false;
            dispensarButton1.Text = "Dispensar";
            dispensarButton1.UseVisualStyleBackColor = false;
            dispensarButton1.Click += dispensarButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 27);
            ClientSize = new Size(1280, 720);
            Controls.Add(panel1);
            Controls.Add(pnlContenido);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pnlTitleBar.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
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
        private Label lblNombreMascota;
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
    }
}
