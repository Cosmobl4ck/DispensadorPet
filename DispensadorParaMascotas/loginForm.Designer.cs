namespace DispensadorParaMascotas
{
    partial class loginForm
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
            components = new System.ComponentModel.Container();
            btnSignIn = new DispensadorParaMascotas.Views.dispensarButton();
            lblUser = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            lblPassword = new Label();
            btnMostrar = new Button();
            prgCarga = new ProgressBar();
            tmrCarga = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(45, 45, 48);
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI Semibold", 11F);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(130, 380);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(176, 37);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.ForeColor = Color.FromArgb(0, 161, 155);
            lblUser.Location = new Point(58, 182);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(38, 20);
            lblUser.TabIndex = 1;
            lblUser.Text = "User";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(58, 214);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(319, 27);
            txtUsuario.TabIndex = 2;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.ForeColor = Color.White;
            txtContrasena.Location = new Point(58, 297);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(319, 27);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            txtContrasena.Enter += txtContrasena_Enter;
            txtContrasena.Leave += txtContrasena_Leave;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.FromArgb(0, 161, 155);
            lblPassword.Location = new Point(58, 265);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
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
            btnMostrar.Location = new Point(355, 214);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(22, 25);
            btnMostrar.TabIndex = 5;
            btnMostrar.Text = "👁";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // prgCarga
            // 
            prgCarga.ForeColor = Color.FromArgb(0, 161, 156);
            prgCarga.Location = new Point(94, 443);
            prgCarga.Name = "prgCarga";
            prgCarga.Size = new Size(246, 23);
            prgCarga.Style = ProgressBarStyle.Continuous;
            prgCarga.TabIndex = 6;
            prgCarga.Visible = false;
            // 
            // tmrCarga
            // 
            tmrCarga.Interval = 50;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 27);
            ClientSize = new Size(451, 571);
            Controls.Add(prgCarga);
            Controls.Add(btnMostrar);
            Controls.Add(txtContrasena);
            Controls.Add(lblPassword);
            Controls.Add(txtUsuario);
            Controls.Add(lblUser);
            Controls.Add(btnSignIn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginForm";
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
    }
}