using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DispensadorParaMascotas.Views
{
     public class MenuButton : Button
    {
        private bool isHovering = false;
        private Color petronasAqua = Color.FromArgb(0, 161, 155);

        public MenuButton()
        {
            this.Size = new Size(200, 50);
            this.Dock = DockStyle.Top;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.Transparent; // Para que se vea el fondo del panel
            this.ForeColor = Color.Silver;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.Padding = new Padding(20, 0, 0, 0);
            this.Cursor = Cursors.Hand;

            // Eventos para detectar el mouse
            this.MouseEnter += (s, e) => { isHovering = true; Invalidate(); };
            this.MouseLeave += (s, e) => { isHovering = false; Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (isHovering)
            {
                // Dibujamos la barrita vertical Aqua Petronas a la izquierda
                using (SolidBrush brush = new SolidBrush(petronasAqua))
                {
                    pevent.Graphics.FillRectangle(brush, 0, 10, 5, Height - 20);
                }
                this.ForeColor = Color.White; // Texto más brillante al pasar el mouse
            }
            else
            {
                this.ForeColor = Color.Silver;
            }
        }
    }
}
