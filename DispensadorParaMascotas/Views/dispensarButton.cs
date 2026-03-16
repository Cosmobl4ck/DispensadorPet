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

            // Eventos para el efecto visual
            this.MouseEnter += (s, e) => { isHovering = true; Invalidate(); };
            this.MouseLeave += (s, e) => { isHovering = false; Invalidate(); };
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

            // 2. Dibujar fondo con degradado metálico
            using (LinearGradientBrush brush = new LinearGradientBrush(rect,
                Color.FromArgb(60, 60, 60), Color.FromArgb(30, 30, 30), 90F))
            {
                g.FillPath(brush, path);
            }

            // 3. Dibujar borde con brillo Aqua Petronas
            using (Pen penAqua = new Pen(isHovering ? colorAqua : Color.FromArgb(100, colorAqua), 2))
            {
                g.DrawPath(penAqua, path);
            }

            // 4. Dibujar el texto centrado
            TextRenderer.DrawText(g, this.Text, this.Font, rect, this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
