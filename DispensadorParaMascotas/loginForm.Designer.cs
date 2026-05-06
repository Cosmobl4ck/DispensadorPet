namespace DispensadorParaMascotas
{
    partial class loginForm
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
            components = new System.ComponentModel.Container();
            btnSignIn = new DispensadorParaMascotas.Views.dispensarButton();
            lblUser = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            lblPassword = new Label();
            btnMostrar = new Button();
            prgCarga = new ProgressBar();
            tmrCarga = new System.Windows.Forms.Timer(components);
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(45, 45, 48);
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI Semibold", 11F);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(162, 455);
            btnSignIn.Margin = new Padding(4);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(220, 46);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.ForeColor = Color.FromArgb(0, 161, 155);
            lblUser.Location = new Point(72, 228);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 25);
            lblUser.TabIndex = 1;
            lblUser.Text = "User";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(72, 268);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(398, 31);
            txtUsuario.TabIndex = 2;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.ForeColor = Color.White;
            txtContrasena.Location = new Point(72, 371);
            txtContrasena.Margin = new Padding(4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(398, 31);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            txtContrasena.Enter += txtContrasena_Enter;
            txtContrasena.Leave += txtContrasena_Leave;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.FromArgb(0, 161, 155);
            lblPassword.Location = new Point(72, 331);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.White;
            btnMostrar.Cursor = Cursors.Hand;
            btnMostrar.FlatAppearance.BorderSize = 0;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.ForeColor = Color.FromArgb(0, 161, 156);
            btnMostrar.Location = new Point(442, 372);
            btnMostrar.Margin = new Padding(4);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(28, 31);
            btnMostrar.TabIndex = 5;
            btnMostrar.Text = "👁";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // prgCarga
            // 
            prgCarga.ForeColor = Color.FromArgb(0, 161, 156);
            prgCarga.Location = new Point(118, 534);
            prgCarga.Margin = new Padding(4);
            prgCarga.Name = "prgCarga";
            prgCarga.Size = new Size(308, 29);
            prgCarga.Style = ProgressBarStyle.Continuous;
            prgCarga.TabIndex = 6;
            prgCarga.Visible = false;
            // 
            // tmrCarga
            // 
            tmrCarga.Tick += tmrCarga_Tick;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(175, 588);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(214, 25);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Olvidaste tu contraseña?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 27);
            ClientSize = new Size(564, 640);
            Controls.Add(linkLabel1);
            Controls.Add(prgCarga);
            Controls.Add(btnMostrar);
            Controls.Add(txtContrasena);
            Controls.Add(lblPassword);
            Controls.Add(txtUsuario);
            Controls.Add(lblUser);
            Controls.Add(btnSignIn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += loginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Views.dispensarButton btnSignIn;
        private Label lblUser;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label lblPassword;
        private Button btnMostrar;
        private ProgressBar prgCarga;
        private System.Windows.Forms.Timer tmrCarga;
        private LinkLabel linkLabel1;
    }
}