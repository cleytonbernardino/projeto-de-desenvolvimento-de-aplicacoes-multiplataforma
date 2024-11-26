namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.CustomControls
{
    partial class CustomTextBox
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            textBox = new TextBox();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.BorderStyle = BorderStyle.None;
            textBox.Dock = DockStyle.Fill;
            textBox.Location = new Point(7, 7);
            textBox.Name = "textBox";
            textBox.Size = new Size(200, 22);
            textBox.TabIndex = 0;
            textBox.TextChanged += textBox_TextChanged;
            textBox.Enter += textBox_Enter;
            textBox.KeyPress += textBox_KeyPress;
            textBox.Leave += textBox_Leave;
            textBox.MouseEnter += textBox_MouseEnter;
            textBox.MouseLeave += textBox_MouseLeave;
            // 
            // CustomTextBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(textBox);
            Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "CustomTextBox";
            Padding = new Padding(7);
            Size = new Size(214, 30);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
    }
}
