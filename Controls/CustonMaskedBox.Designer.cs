namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.CustomControls
{
    partial class CustonMaskedBox
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
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.White;
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox1.Dock = DockStyle.Fill;
            maskedTextBox1.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox1.Location = new Point(7, 7);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(200, 20);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.TextChanged += maskedTextBox1_TextChanged;
            maskedTextBox1.Enter += maskedTextBox1_Enter;
            maskedTextBox1.KeyDown += maskedTextBox1_KeyDown;
            maskedTextBox1.KeyPress += maskedTextBox1_KeyPress;
            maskedTextBox1.Leave += maskedTextBox1_Leave;
            // 
            // CustonMaskedBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(maskedTextBox1);
            Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "CustonMaskedBox";
            Padding = new Padding(7);
            Size = new Size(214, 30);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
    }
}
