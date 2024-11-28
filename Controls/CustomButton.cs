using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.CustomControls
{
    public partial class CustomButton : Button
    {
        // Fields
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.SeaGreen;

        [Category("Adicional")]
        public int BorderSize { 
            get => borderSize; 
            set
            {
                borderSize = value;
                Invalidate();
            } 
        }

        [Category("Adicional")]
        public int BorderRadius { 
            get => borderRadius;
            set
            {
                if (value <= Height)
                {
                    borderRadius = value;
                } else
                {
                    borderRadius = Height;
                }
                Invalidate();
            }
        }

        [Category("Adicional")]
        public Color BorderColor {
            get => borderColor; 
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Adicional")]
        public Color BackgroudColor { get => BackColor; set => BackColor = value;}
        [Category("Adicional")]
        public Color TextColor { get => ForeColor; set => ForeColor = value;}


        // Constructor
        public CustomButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.White;
            ForeColor = Color.Black;
            Resize += new EventHandler(Button_Resize);
        }

        // Methods
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        // Protect
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new(0, 0, Width, Height);
            RectangleF rectBorder = new(1, 1, Width - 0.8F, Height - 1);

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectSurface, borderRadius -1F))
                using (Pen penSurface = new(Parent.BackColor, 2))
                using (Pen penBorder = new(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    // Button surface
                    Region = new Region(pathSurface);
                    // Draw Surface in Hud result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    // Button border
                    if (borderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                } 
            } else // Normal Button
            {
                // Button Surface
                Region = new Region(rectSurface);
                // Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object? sender, EventArgs e)
        {
            if (DesignMode)
            {
                Invalidate();
            }
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > Height) borderRadius = Height;
        }
    }
}
