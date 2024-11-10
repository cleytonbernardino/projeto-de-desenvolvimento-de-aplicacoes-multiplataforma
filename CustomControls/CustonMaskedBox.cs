using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.CustomControls
{
    [DefaultEvent("_TextChanged")]
    public partial class CustonMaskedBox : UserControl
    {
        // Fields
        private Color borderColor = Color.DeepSkyBlue;
        private Color borderFocusColor = Color.AliceBlue;
        private string textMask = "";
        private int borderSize = 2;
        private bool underlineStyle = false;
        private bool isFocus = false;

        public CustonMaskedBox()
        {
            InitializeComponent();
            maskedTextBox1.Culture = CultureInfo.InvariantCulture;
        }
        // Events
        public event EventHandler _TextChanged;

        // Properties
        [Category("Additional Features")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }

        [Category("Additional Features")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Additional Features")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Additional Features")]
        public bool UnderlineStyle
        {
            get => underlineStyle;
            set
            {
                underlineStyle = value;
                this.Invalidate();
            }
        }

        [Category("Additional Features")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                this.Invalidate();
            }
        }

        [Category("Additional Features")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                this.Invalidate();
            }
        }

        [Category("Additional Features")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                this.Invalidate();
            }
        }

        [Category("Additional Features")]
        public string Texts
        {
            get => maskedTextBox1.Text;
            set
            {
                maskedTextBox1.Text = value;
            }
        }

        [Category("Additional Features")]
        public string TextMask
        {
            get => maskedTextBox1.Mask;
            set
            {
                maskedTextBox1.Mask = value;
            }
        }

        // Overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (isFocus)
                {
                    penBorder.Color = borderFocusColor;
                }

                if (underlineStyle) // Line Style
                {
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                }
                else // Normal Style
                {
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            isFocus = true;
            this.Invalidate();
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            isFocus = false;
            this.Invalidate();
        }
    }
}
