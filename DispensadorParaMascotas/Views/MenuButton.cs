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

        // Animación suave
        private float _hoverProgress = 0f;
        private System.Windows.Forms.Timer _animTimer;

        public MenuButton()
        {
            this.Size = new Size(200, 50);
            this.Dock = DockStyle.Top;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.Silver;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.Padding = new Padding(20, 0, 0, 0);
            this.Cursor = Cursors.Hand;

            // Timer a ~60fps
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
            base.OnPaint(pevent);

            if (_hoverProgress > 0.01f)
            {
                // Barra lateral que crece de 0 a 5px
                int barWidth = (int)(5 * _hoverProgress);
                int alpha = (int)(255 * _hoverProgress);
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(alpha, petronasAqua)))
                {
                    pevent.Graphics.FillRectangle(brush, 0, 10, barWidth, Height - 20);
                }
                // Texto de Silver a White gradualmente
                int brightness = (int)(192 + 63 * _hoverProgress);
                this.ForeColor = Color.FromArgb(brightness, brightness, brightness);
            }
            else
            {
                this.ForeColor = Color.Silver;
            }
        }
    }
}