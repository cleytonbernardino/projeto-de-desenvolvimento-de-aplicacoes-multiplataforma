namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Forms.MessageBox
{
    partial class BalanceToBeAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtValue = new CustomControls.CustomTextBox();
            btnSave = new CustomControls.CustomButton();
            btnCancel = new CustomControls.CustomButton();
            lblText = new Label();
            SuspendLayout();
            // 
            // txtValue
            // 
            txtValue.BackColor = Color.White;
            txtValue.BorderColor = Color.SeaGreen;
            txtValue.BorderFocusColor = Color.SpringGreen;
            txtValue.BorderSize = 2;
            txtValue.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValue.Location = new Point(13, 78);
            txtValue.Margin = new Padding(4);
            txtValue.MaxLenght = 32767;
            txtValue.MultLine = false;
            txtValue.Name = "txtValue";
            txtValue.Padding = new Padding(7);
            txtValue.PasswordChar = false;
            txtValue.PlaceHolder = "Insira um valor";
            txtValue.Size = new Size(355, 36);
            txtValue.TabIndex = 0;
            txtValue.Texts = "";
            txtValue.UnderlineStyle = true;
            txtValue._KeyPress += txtValue__KeyPress;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.BackgroudColor = Color.SeaGreen;
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 40;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(24, 121);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "Confirmar";
            btnSave.TextColor = Color.Black;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.BackgroudColor = Color.Red;
            btnCancel.BorderColor = Color.PaleVioletRed;
            btnCancel.BorderRadius = 40;
            btnCancel.BorderSize = 0;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(203, 121);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 40);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancelar";
            btnCancel.TextColor = Color.Black;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblText
            // 
            lblText.Location = new Point(13, 18);
            lblText.Name = "lblText";
            lblText.Size = new Size(355, 56);
            lblText.TabIndex = 3;
            lblText.Text = "Digite um valor a ser adicionado a conta desse usuario. APENAS VALORES POSITIVOS SERÃO ACEITOS.";
            // 
            // BalanceToBeAdd
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(388, 175);
            Controls.Add(lblText);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtValue);
            Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BalanceToBeAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Valor a ser adicionado";
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomTextBox txtValue;
        private CustomControls.CustomButton btnSave;
        private CustomControls.CustomButton btnCancel;
        private Label lblText;
    }
}