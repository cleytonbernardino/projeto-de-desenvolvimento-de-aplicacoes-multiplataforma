namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Forms.DialogBox
{
    partial class FirstUse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstUse));
            lblUsername = new Label();
            txtUsername = new CustomControls.CustomTextBox();
            lblPassword = new Label();
            txtPassword = new CustomControls.CustomTextBox();
            btnSave = new CustomControls.CustomButton();
            lblFirstName = new Label();
            txtFirstName = new CustomControls.CustomTextBox();
            lblCpf = new Label();
            mkbCPF = new CustomControls.CustonMaskedBox();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(13, 150);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderColor = Color.SeaGreen;
            txtUsername.BorderFocusColor = Color.PaleGreen;
            txtUsername.BorderSize = 2;
            txtUsername.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(13, 169);
            txtUsername.Margin = new Padding(4);
            txtUsername.MaxLenght = 30;
            txtUsername.MultLine = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(7);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceHolder = "";
            txtUsername.ReadOnly = false;
            txtUsername.Size = new Size(261, 36);
            txtUsername.TabIndex = 3;
            txtUsername.Texts = "";
            txtUsername.UnderlineStyle = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(13, 223);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(39, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Senha";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderColor = Color.SeaGreen;
            txtPassword.BorderFocusColor = Color.PaleGreen;
            txtPassword.BorderSize = 2;
            txtPassword.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(13, 242);
            txtPassword.Margin = new Padding(4);
            txtPassword.MaxLenght = 100;
            txtPassword.MultLine = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(7);
            txtPassword.PasswordChar = false;
            txtPassword.PlaceHolder = "";
            txtPassword.ReadOnly = false;
            txtPassword.Size = new Size(261, 36);
            txtPassword.TabIndex = 4;
            txtPassword.Texts = "";
            txtPassword.UnderlineStyle = true;
            txtPassword._KeyPress += txtPassword__KeyPress;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.BackgroudColor = Color.White;
            btnSave.BorderColor = Color.SeaGreen;
            btnSave.BorderRadius = 40;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(13, 294);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(261, 40);
            btnSave.TabIndex = 5;
            btnSave.Text = "Confirmar";
            btnSave.TextColor = Color.Black;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(13, 11);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(88, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "Primeiro Nome";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.BorderColor = Color.SeaGreen;
            txtFirstName.BorderFocusColor = Color.PaleGreen;
            txtFirstName.BorderSize = 2;
            txtFirstName.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(13, 30);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.MaxLenght = 25;
            txtFirstName.MultLine = false;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Padding = new Padding(7);
            txtFirstName.PasswordChar = false;
            txtFirstName.PlaceHolder = "";
            txtFirstName.ReadOnly = false;
            txtFirstName.Size = new Size(261, 36);
            txtFirstName.TabIndex = 0;
            txtFirstName.Texts = "";
            txtFirstName.UnderlineStyle = true;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(13, 78);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 8;
            lblCpf.Text = "CPF";
            // 
            // mkbCPF
            // 
            mkbCPF.BackColor = Color.White;
            mkbCPF.BorderColor = Color.SeaGreen;
            mkbCPF.BorderFocusColor = Color.PaleGreen;
            mkbCPF.BorderSize = 2;
            mkbCPF.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mkbCPF.Location = new Point(13, 97);
            mkbCPF.Margin = new Padding(4);
            mkbCPF.Name = "mkbCPF";
            mkbCPF.Padding = new Padding(7);
            mkbCPF.ReadOnly = false;
            mkbCPF.Size = new Size(261, 36);
            mkbCPF.TabIndex = 2;
            mkbCPF.TextMask = "000.000.000-00";
            mkbCPF.Texts = "   .   .   -";
            mkbCPF.UnderlineStyle = true;
            mkbCPF._MouseClick += mkbCPF__MouseClick;
            mkbCPF.Enter += mkbCPF_Enter;
            mkbCPF.Leave += mkbCPF_Leave;
            // 
            // FirstUse
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(298, 362);
            ControlBox = false;
            Controls.Add(mkbCPF);
            Controls.Add(lblCpf);
            Controls.Add(btnSave);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FirstUse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Primeiro Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsername;
        private CustomControls.CustomTextBox txtUsername;
        private Label lblPassword;
        private CustomControls.CustomTextBox txtPassword;
        private CustomControls.CustomButton btnSave;
        private Label lblFirstName;
        private CustomControls.CustomTextBox txtFirstName;
        private Label lblCpf;
        private CustomControls.CustonMaskedBox mkbCPF;
    }
}