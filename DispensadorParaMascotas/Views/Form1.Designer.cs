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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnInicio = new DispensadorParaMascotas.Views.MenuButton();
            btnProgramacion = new DispensadorParaMascotas.Views.MenuButton();
            btnHistorial = new DispensadorParaMascotas.Views.MenuButton();
            btnConfiguracion = new DispensadorParaMascotas.Views.MenuButton();
            btnUsuario = new DispensadorParaMascotas.Views.MenuButton();
            panel1 = new Panel();
            lblKilos = new Label();
            lblCapacidad = new Label();
            pnlContenido = new Panel();
            picMascota = new PictureBox();
            dispensarButton1 = new DispensadorParaMascotas.Views.dispensarButton();
            flowLayoutPanel1.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMascota).BeginInit();
            SuspendLayout();
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
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 60, 0, 0);
            flowLayoutPanel1.Size = new Size(238, 600);
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
            btnInicio.Location = new Point(3, 63);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(20, 0, 0, 0);
            btnInicio.Size = new Size(250, 62);
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
            btnProgramacion.Location = new Point(3, 131);
            btnProgramacion.Name = "btnProgramacion";
            btnProgramacion.Padding = new Padding(20, 0, 0, 0);
            btnProgramacion.Size = new Size(250, 62);
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
            btnHistorial.Location = new Point(3, 199);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Padding = new Padding(20, 0, 0, 0);
            btnHistorial.Size = new Size(250, 62);
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
            btnConfiguracion.Location = new Point(3, 267);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Padding = new Padding(20, 0, 0, 0);
            btnConfiguracion.Size = new Size(250, 62);
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
            btnUsuario.Location = new Point(3, 335);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Padding = new Padding(20, 0, 0, 0);
            btnUsuario.Size = new Size(250, 62);
            btnUsuario.TabIndex = 4;
            btnUsuario.Text = "Usuario";
            btnUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuario.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(238, 590);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 10);
            panel1.TabIndex = 1;
            // 
            // lblKilos
            // 
            lblKilos.AutoSize = true;
            lblKilos.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKilos.ForeColor = SystemColors.ButtonFace;
            lblKilos.Location = new Point(464, 274);
            lblKilos.Name = "lblKilos";
            lblKilos.Size = new Size(175, 60);
            lblKilos.TabIndex = 2;
            lblKilos.Text = "1.45 kg";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.ForeColor = SystemColors.ButtonFace;
            lblCapacidad.Location = new Point(525, 334);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(58, 20);
            lblCapacidad.TabIndex = 3;
            lblCapacidad.Text = "/ 2.0 kg";
            // 
            // pnlContenido
            // 
            pnlContenido.Controls.Add(picMascota);
            pnlContenido.Controls.Add(lblKilos);
            pnlContenido.Controls.Add(lblCapacidad);
            pnlContenido.Controls.Add(dispensarButton1);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1100, 600);
            pnlContenido.TabIndex = 5;
            pnlContenido.Paint += pnlContenido_Paint;
            // 
            // picMascota
            // 
            picMascota.Location = new Point(909, 39);
            picMascota.Name = "picMascota";
            picMascota.Size = new Size(116, 132);
            picMascota.TabIndex = 4;
            picMascota.TabStop = false;
            // 
            // dispensarButton1
            // 
            dispensarButton1.BackColor = Color.FromArgb(45, 45, 48);
            dispensarButton1.FlatAppearance.BorderSize = 0;
            dispensarButton1.FlatStyle = FlatStyle.Flat;
            dispensarButton1.Font = new Font("Segoe UI Semibold", 11F);
            dispensarButton1.ForeColor = Color.White;
            dispensarButton1.Location = new Point(440, 477);
            dispensarButton1.Name = "dispensarButton1";
            dispensarButton1.Size = new Size(225, 62);
            dispensarButton1.TabIndex = 0;
            dispensarButton1.Text = "Dispensar";
            dispensarButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 27);
            ClientSize = new Size(1100, 600);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlContenido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMascota).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label lblKilos;
        private Label lblCapacidad;
        private Views.MenuButton btnInicio;
        private Views.MenuButton btnProgramacion;
        private Views.MenuButton btnHistorial;
        private Views.MenuButton btnConfiguracion;
        private Views.MenuButton btnUsuario;
        private Panel pnlContenido;
        private Views.dispensarButton dispensarButton1;
        private PictureBox picMascota;
    }
}
