#pragma warning disable WFO1000

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DispensadorParaMascotas.Views
{
    public class ToggleSwitch : Control
    {
        private bool _checked;

        public bool Checked
        {
            get => _checked;
            set { _checked = value; Invalidate(); }
        }

        public event EventHandler CheckedChanged;

        public ToggleSwitch()
        {
            Size = new Size(46, 24);
            Cursor = Cursors.Hand;
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
        }

        protected override void OnClick(EventArgs e)
        {
            _checked = !_checked;
            Invalidate();
            CheckedChanged?.Invoke(this, EventArgs.Empty);
            base.OnClick(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e) { }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Fondo igual al del panel padre para simular transparencia
            Color fondo = Parent?.BackColor ?? Color.FromArgb(38, 38, 46);
            using (var bgBrush = new SolidBrush(fondo))
                g.FillRectangle(bgBrush, ClientRectangle);

            Color bg = _checked ? Color.FromArgb(0, 175, 165) : Color.FromArgb(65, 65, 75);
            int r = Height / 2;

            using (var path = new GraphicsPath())
            {
                path.AddArc(0, 0, r * 2, r * 2, 90, 180);
                path.AddArc(Width - r * 2, 0, r * 2, r * 2, 270, 180);
                path.CloseFigure();
                using (var brush = new SolidBrush(bg))
                    g.FillPath(brush, path);
            }

            float margin = 3;
            float thumbSize = Height - margin * 2;
            float thumbX = _checked ? Width - thumbSize - margin : margin;
            g.FillEllipse(Brushes.White, thumbX, margin, thumbSize, thumbSize);
        }
    }
}
