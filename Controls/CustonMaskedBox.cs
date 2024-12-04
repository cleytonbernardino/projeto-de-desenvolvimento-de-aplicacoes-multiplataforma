using System.ComponentModel;
using System.Globalization;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.CustomControls
{
    [DefaultEvent("_TextChanged")]
    public partial class CustonMaskedBox : UserControl
    {
        // Fields
        private Color borderColor = Color.SeaGreen;
        private Color borderFocusColor = Color.PaleGreen;
        private int borderSize = 2;
        private bool underlineStyle = false;
        private bool isFocus = false;

        //public 

        public CustonMaskedBox()
        {
            InitializeComponent();
            maskedTextBox1.Culture = CultureInfo.InvariantCulture;
        }

        // Events
        public event EventHandler _TextChanged;
        public event KeyPressEventHandler _KeyPress;
        public event KeyEventHandler _KeyDown;
        public event EventHandler _MouseClick;
        public event EventHandler _FocusEnter;
        public event EventHandler _FocusLeave;


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
        public bool ReadOnly
        {
            get => maskedTextBox1.ReadOnly;
            set
            {
                maskedTextBox1.ReadOnly = value;
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

        public void Select(int start, int lengt)
        {
            maskedTextBox1.Select(start, lengt);
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

        private void maskedTextBox1_TextChanged(object sender, EventArgs e) => _TextChanged?.Invoke(sender, e);
        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e) => _KeyPress?.Invoke(sender, e);
        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e) => _KeyDown?.Invoke(sender, e);
        private void maskedTextBox1_Click(object sender, EventArgs e) => _MouseClick?.Invoke(sender, e);

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            isFocus = true;
            _FocusEnter?.Invoke(sender, e);
            this.Invalidate();
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            isFocus = false;
            _FocusLeave?.Invoke(sender, e);
            this.Invalidate();
        }
    }
}
