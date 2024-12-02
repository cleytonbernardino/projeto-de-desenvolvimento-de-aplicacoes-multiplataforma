namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblSignIn = new Label();
            txtUsername = new CustomControls.CustomTextBox();
            txtPassword = new CustomControls.CustomTextBox();
            btnSeePassword = new Button();
            btnSignIn = new Button();
            lblLogo = new Label();
            SuspendLayout();
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("JetBrains Mono", 50F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignIn.ForeColor = Color.SeaGreen;
            lblSignIn.Location = new Point(460, 101);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(317, 88);
            lblSignIn.TabIndex = 0;
            lblSignIn.Text = "Sign in";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderColor = Color.SeaGreen;
            txtUsername.BorderFocusColor = Color.SpringGreen;
            txtUsername.BorderSize = 2;
            txtUsername.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(460, 258);
            txtUsername.Margin = new Padding(4);
            txtUsername.MaxLenght = 30;
            txtUsername.MultLine = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(7);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceHolder = "admin";
            txtUsername.ReadOnly = false;
            txtUsername.Size = new Size(317, 36);
            txtUsername.TabIndex = 1;
            txtUsername.Texts = "";
            txtUsername.UnderlineStyle = true;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderColor = Color.SeaGreen;
            txtPassword.BorderFocusColor = Color.SpringGreen;
            txtPassword.BorderSize = 2;
            txtPassword.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(460, 335);
            txtPassword.Margin = new Padding(4);
            txtPassword.MaxLenght = 100;
            txtPassword.MultLine = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(7);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceHolder = "admin";
            txtPassword.ReadOnly = false;
            txtPassword.Size = new Size(270, 36);
            txtPassword.TabIndex = 2;
            txtPassword.Texts = "";
            txtPassword.UnderlineStyle = true;
            txtPassword._KeyPress += txtPassword__KeyPress;
            // 
            // btnSeePassword
            // 
            btnSeePassword.BackColor = Color.White;
            btnSeePassword.BackgroundImage = (Image)resources.GetObject("btnSeePassword.BackgroundImage");
            btnSeePassword.BackgroundImageLayout = ImageLayout.Center;
            btnSeePassword.FlatAppearance.BorderSize = 0;
            btnSeePassword.FlatStyle = FlatStyle.Flat;
            btnSeePassword.Location = new Point(729, 335);
            btnSeePassword.Name = "btnSeePassword";
            btnSeePassword.Size = new Size(48, 35);
            btnSeePassword.TabIndex = 3;
            btnSeePassword.UseVisualStyleBackColor = false;
            btnSeePassword.Click += btnSeePassword_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.SeaGreen;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(569, 422);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.RightToLeft = RightToLeft.No;
            btnSignIn.Size = new Size(114, 43);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "Sign in";
            btnSignIn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.DarkGreen;
            lblLogo.Location = new Point(12, 22);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(171, 19);
            lblLogo.TabIndex = 6;
            lblLogo.Text = "Localiza Seminovos";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 642);
            Controls.Add(lblLogo);
            Controls.Add(btnSignIn);
            Controls.Add(btnSeePassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblSignIn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Localiza Seminovos | Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSignIn;
        private CustomControls.CustomTextBox txtUsername;
        private CustomControls.CustomTextBox txtPassword;
        private Button btnSeePassword;
        private Button btnSignIn;
        private Label lblLogo;
    }
}
