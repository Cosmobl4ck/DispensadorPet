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
            label4 = new Label();
            txtConfirmarNuevaPass = new TextBox();
            label3 = new Label();
            txtNuevaPass = new TextBox();
            label2 = new Label();
            txtCorreoRecuperar = new TextBox();
            label1 = new Label();
            BtnContinuar = new dispensarButton();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 161, 155);
            label4.Location = new Point(61, 412);
            label4.Name = "label4";
            label4.Size = new Size(166, 21);
            label4.TabIndex = 14;
            label4.Text = "Confirmar Contrasena";
            // 
            // txtConfirmarNuevaPass
            // 
            txtConfirmarNuevaPass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarNuevaPass.ForeColor = Color.Black;
            txtConfirmarNuevaPass.Location = new Point(63, 442);
            txtConfirmarNuevaPass.Margin = new Padding(4, 3, 4, 3);
            txtConfirmarNuevaPass.Name = "txtConfirmarNuevaPass";
            txtConfirmarNuevaPass.Size = new Size(398, 31);
            txtConfirmarNuevaPass.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 161, 155);
            label3.Location = new Point(63, 327);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 12;
            label3.Text = "Nueva Contrasena";
            // 
            // txtNuevaPass
            // 
            txtNuevaPass.BorderStyle = BorderStyle.FixedSingle;
            txtNuevaPass.ForeColor = Color.Black;
            txtNuevaPass.Location = new Point(64, 357);
            txtNuevaPass.Margin = new Padding(4, 3, 4, 3);
            txtNuevaPass.Name = "txtNuevaPass";
            txtNuevaPass.Size = new Size(398, 31);
            txtNuevaPass.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 161, 155);
            label2.Location = new Point(61, 243);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 10;
            label2.Text = "Correo";
            // 
            // txtCorreoRecuperar
            // 
            txtCorreoRecuperar.BorderStyle = BorderStyle.FixedSingle;
            txtCorreoRecuperar.ForeColor = Color.Black;
            txtCorreoRecuperar.Location = new Point(63, 272);
            txtCorreoRecuperar.Margin = new Padding(4, 3, 4, 3);
            txtCorreoRecuperar.Name = "txtCorreoRecuperar";
            txtCorreoRecuperar.Size = new Size(398, 31);
            txtCorreoRecuperar.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 161, 155);
            label1.Location = new Point(64, 117);
            label1.Name = "label1";
            label1.Size = new Size(342, 45);
            label1.TabIndex = 15;
            label1.Text = "Recuperar Contrasena";
            // 
            // BtnContinuar
            // 
            BtnContinuar.BackColor = Color.FromArgb(45, 45, 48);
            BtnContinuar.FlatAppearance.BorderSize = 0;
            BtnContinuar.FlatStyle = FlatStyle.Flat;
            BtnContinuar.Font = new Font("Segoe UI Semibold", 11F);
            BtnContinuar.ForeColor = Color.White;
            BtnContinuar.Location = new Point(183, 521);
            BtnContinuar.Name = "BtnContinuar";
            BtnContinuar.Size = new Size(156, 39);
            BtnContinuar.TabIndex = 16;
            BtnContinuar.Text = "Continuar";
            BtnContinuar.UseVisualStyleBackColor = false;
            BtnContinuar.Click += BtnContinuar_Click;
            // 
            // RecuperarContrasena
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 27);
            ClientSize = new Size(530, 733);
            Controls.Add(BtnContinuar);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(txtConfirmarNuevaPass);
            Controls.Add(label3);
            Controls.Add(txtNuevaPass);
            Controls.Add(label2);
            Controls.Add(txtCorreoRecuperar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecuperarContrasena";
            Text = "RecuperarContrasena";
            Load += RecuperarContrasena_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}