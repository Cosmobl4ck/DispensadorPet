using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DispensadorParaMascotas.Views
{
    internal class dispensarButton : Button
    {
        private bool isHovering = false;
        private Color colorAqua = Color.FromArgb(0, 161, 155);
        private Color colorGrisOscuro = Color.FromArgb(45, 45, 48);

        // Animación suave
        private float _hoverProgress = 0f;
        private System.Windows.Forms.Timer _animTimer;

        public dispensarButton()
        {
            this.Size = new Size(180, 50);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = colorGrisOscuro;
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI Semibold", 11F);
            this.Text = "DISPENSAR";
            this.Cursor = Cursors.Hand;

            // Timer a ~60fps para la transición suave
            _animTimer = new System.Windows.Forms.Timer { Interval = 16 };
            _animTimer.Tick += (s, e) =>
            {
                float target = isHovering ? 1f : 0f;
                float diff = target - _hoverProgress;
                if (Math.Abs(diff) < 0.02f) { _hoverProgress = target; _animTimer.Stop(); }
                else _hoverProgress += diff * 0.18f;
                Invalidate();
            };

            this.MouseEnter += (s, e) => { isHovering = true; _animTimer.Start(); };
            this.MouseLeave += (s, e) => { isHovering = false; _animTimer.Start(); };
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 1. Crear el camino con bordes redondeados
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            int radius = 15;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // 2. Fondo con leve iluminación al hover
            int glow = (int)(20 * _hoverProgress);
            using (LinearGradientBrush brush = new LinearGradientBrush(rect,
                Color.FromArgb(60 + glow, 60 + glow, 60 + glow), Color.FromArgb(30, 30, 30), 90F))
            {
                g.FillPath(brush, path);
            }

            // 3. Borde Aqua animado (alpha de 80 a 255)
            int borderAlpha = (int)(80 + 175 * _hoverProgress);
            using (Pen penAqua = new Pen(Color.FromArgb(borderAlpha, colorAqua), 2))
            {
                g.DrawPath(penAqua, path);
            }

            // 4. Texto centrado
            TextRenderer.DrawText(g, this.Text, this.Font, rect, this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}