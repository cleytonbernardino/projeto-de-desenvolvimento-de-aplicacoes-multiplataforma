using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.CustomControls
{
    [DefaultEvent("_TextChanged")]
    public partial class CustomTextBox : UserControl
    {

        // Fields
        private Color borderColor = Color.DeepSkyBlue;
        private Color borderFocusColor = Color.AliceBlue;
        private int borderSize = 2;
        private bool underlineStyle = false;
        private bool isFocused = false;

        // Constructor
        public CustomTextBox()
        {
            InitializeComponent();
        }
        // Events
        public event EventHandler _TextChanged;


        // Properties
        [Category("Additional Features")]
        public bool PasswordChar { get => textBox.UseSystemPasswordChar; set => textBox.UseSystemPasswordChar = value; }

        [Category("Additional Features")]
        public bool MultLine { get => textBox.Multiline; set => textBox.Multiline = value; }

        [Category("Additional Features")]
        public int MaxLenght { get => textBox.MaxLength; set => textBox.MaxLength = value; }

        [Category("Additional Features")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }

        [Category("Additional Features")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Additional Features")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("Additional Features")]
        public bool UnderlineStyle
        {
            get
            {
                return underlineStyle;
            }
            set
            {
                underlineStyle = value;
                this.Invalidate();
            }
        }
        [Category("Additional Features")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox.BackColor = value;
            }
        }
        [Category("Additional Features")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox.ForeColor = value;
            }
        }
        [Category("Additional Features")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox.Font = value;
                if (this.DesignMode)
                {
                    updateControlHeight();
                }
            }
        }

        [Category("Additional Features")]
        public string Texts
        {
            get
            {
                return textBox.Text;
            }
            set
            {
                textBox.Text = value;
            }
        }

        [Category("Additional Features")]
        public string PlaceHolder { 
            get => textBox.PlaceholderText;
            set
            {
                textBox.PlaceholderText = value;
                this.Invalidate();
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
                
                if (isFocused)
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                updateControlHeight();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            updateControlHeight();
        }


        // Private methods
        private void updateControlHeight()
        {
            if (textBox.Multiline == false)
            {
                int textHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox.Multiline = true;
                textBox.MinimumSize = new Size(0, textHeight);
                textBox.Multiline = false;

                this.Height = textBox.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged(sender, e);
            }
        }

        private void textBox_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }

    }
}
