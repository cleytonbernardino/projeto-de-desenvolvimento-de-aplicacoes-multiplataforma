namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    partial class frmPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPessoa));
            lblFirstName = new Label();
            txtFirstName = new CustomControls.CustomTextBox();
            txtLastName = new CustomControls.CustomTextBox();
            lblLastName = new Label();
            panel1 = new Panel();
            lblBalanceValue = new Label();
            lblBalanceText = new Label();
            btnClose = new CustomControls.CustomButton();
            btnDelete = new CustomControls.CustomButton();
            btnSave = new CustomControls.CustomButton();
            lblCPF = new Label();
            mkbCPF = new CustomControls.CustonMaskedBox();
            mkbCNH = new CustomControls.CustonMaskedBox();
            lblCNH = new Label();
            lblDateOfBirth = new Label();
            dtpDateOfBirth = new DateTimePicker();
            lblPenalty = new Label();
            ltvtxtPenalty = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            txtPenaltyType = new CustomControls.CustomTextBox();
            btnPenaltyAdd = new CustomControls.CustomButton();
            listView2 = new ListView();
            lblRentalRecord = new Label();
            txtPenaltyValue = new CustomControls.CustomTextBox();
            btnRentalRecordAdd = new CustomControls.CustomButton();
            txtEmail = new CustomControls.CustomTextBox();
            lblEmail = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(18, 60);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(66, 36);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Nome";
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.BorderColor = Color.DeepSkyBlue;
            txtFirstName.BorderFocusColor = Color.AliceBlue;
            txtFirstName.BorderSize = 2;
            txtFirstName.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(91, 60);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.MaxLenght = 32767;
            txtFirstName.MultLine = false;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Padding = new Padding(7);
            txtFirstName.PasswordChar = false;
            txtFirstName.PlaceHolder = "";
            txtFirstName.Size = new Size(316, 36);
            txtFirstName.TabIndex = 1;
            txtFirstName.Texts = "";
            txtFirstName.UnderlineStyle = false;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.BorderColor = Color.DeepSkyBlue;
            txtLastName.BorderFocusColor = Color.AliceBlue;
            txtLastName.BorderSize = 2;
            txtLastName.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(532, 60);
            txtLastName.Margin = new Padding(4);
            txtLastName.MaxLenght = 32767;
            txtLastName.MultLine = false;
            txtLastName.Name = "txtLastName";
            txtLastName.Padding = new Padding(7);
            txtLastName.PasswordChar = false;
            txtLastName.PlaceHolder = "";
            txtLastName.Size = new Size(455, 36);
            txtLastName.TabIndex = 3;
            txtLastName.Texts = "";
            txtLastName.UnderlineStyle = false;
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(432, 60);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(93, 36);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Sobrenome";
            lblLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(lblBalanceValue);
            panel1.Controls.Add(lblBalanceText);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 53);
            panel1.TabIndex = 4;
            // 
            // lblBalanceValue
            // 
            lblBalanceValue.AutoSize = true;
            lblBalanceValue.Location = new Point(91, 15);
            lblBalanceValue.Name = "lblBalanceValue";
            lblBalanceValue.Size = new Size(32, 17);
            lblBalanceValue.TabIndex = 5;
            lblBalanceValue.Text = "0.0";
            // 
            // lblBalanceText
            // 
            lblBalanceText.AutoSize = true;
            lblBalanceText.Location = new Point(12, 15);
            lblBalanceText.Name = "lblBalanceText";
            lblBalanceText.Size = new Size(80, 17);
            lblBalanceText.TabIndex = 4;
            lblBalanceText.Text = "Saldo R$:";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.White;
            btnClose.BackgroudColor = Color.White;
            btnClose.BorderColor = Color.PaleVioletRed;
            btnClose.BorderRadius = 40;
            btnClose.BorderSize = 0;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Black;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(849, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 40);
            btnClose.TabIndex = 2;
            btnClose.Text = "Fechar";
            btnClose.TextColor = Color.Black;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.White;
            btnDelete.BackgroudColor = Color.White;
            btnDelete.BorderColor = Color.PaleVioletRed;
            btnDelete.BorderRadius = 40;
            btnDelete.BorderSize = 0;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(682, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 40);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Excluir";
            btnDelete.TextColor = Color.Black;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.White;
            btnSave.BackgroudColor = Color.White;
            btnSave.BackgroundImageLayout = ImageLayout.None;
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 40;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Black;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(512, 3);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.No;
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Salvar";
            btnSave.TextColor = Color.Black;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblCPF
            // 
            lblCPF.Location = new Point(348, 123);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(66, 36);
            lblCPF.TabIndex = 5;
            lblCPF.Text = "CPF";
            lblCPF.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mkbCPF
            // 
            mkbCPF.BackColor = Color.White;
            mkbCPF.BorderColor = Color.DeepSkyBlue;
            mkbCPF.BorderFocusColor = Color.AliceBlue;
            mkbCPF.BorderSize = 2;
            mkbCPF.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mkbCPF.Location = new Point(421, 123);
            mkbCPF.Margin = new Padding(4);
            mkbCPF.Name = "mkbCPF";
            mkbCPF.Padding = new Padding(7);
            mkbCPF.Size = new Size(232, 36);
            mkbCPF.TabIndex = 6;
            mkbCPF.TextMask = "000.000.000-00";
            mkbCPF.Texts = "   .   .   -";
            mkbCPF.UnderlineStyle = false;
            // 
            // mkbCNH
            // 
            mkbCNH.BackColor = Color.White;
            mkbCNH.BorderColor = Color.DeepSkyBlue;
            mkbCNH.BorderFocusColor = Color.AliceBlue;
            mkbCNH.BorderSize = 2;
            mkbCNH.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mkbCNH.Location = new Point(754, 123);
            mkbCNH.Margin = new Padding(4);
            mkbCNH.Name = "mkbCNH";
            mkbCNH.Padding = new Padding(7);
            mkbCNH.Size = new Size(232, 36);
            mkbCNH.TabIndex = 8;
            mkbCNH.TextMask = "000000000";
            mkbCNH.Texts = "";
            mkbCNH.UnderlineStyle = false;
            // 
            // lblCNH
            // 
            lblCNH.Location = new Point(681, 123);
            lblCNH.Name = "lblCNH";
            lblCNH.Size = new Size(66, 36);
            lblCNH.TabIndex = 7;
            lblCNH.Text = "CNH";
            lblCNH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.ImageAlign = ContentAlignment.MiddleLeft;
            lblDateOfBirth.Location = new Point(24, 123);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(153, 36);
            lblDateOfBirth.TabIndex = 9;
            lblDateOfBirth.Text = "Data de Nacimento";
            lblDateOfBirth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(183, 127);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(127, 25);
            dtpDateOfBirth.TabIndex = 10;
            // 
            // lblPenalty
            // 
            lblPenalty.AutoSize = true;
            lblPenalty.Location = new Point(18, 268);
            lblPenalty.Name = "lblPenalty";
            lblPenalty.Size = new Size(96, 17);
            lblPenalty.TabIndex = 11;
            lblPenalty.Text = "Penalidades";
            // 
            // ltvtxtPenalty
            // 
            ltvtxtPenalty.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            ltvtxtPenalty.FullRowSelect = true;
            ltvtxtPenalty.Location = new Point(12, 338);
            ltvtxtPenalty.Name = "ltvtxtPenalty";
            ltvtxtPenalty.Size = new Size(430, 254);
            ltvtxtPenalty.TabIndex = 12;
            ltvtxtPenalty.UseCompatibleStateImageBehavior = false;
            ltvtxtPenalty.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Motivo";
            columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Valor";
            columnHeader2.Width = 100;
            // 
            // txtPenaltyType
            // 
            txtPenaltyType.BackColor = Color.White;
            txtPenaltyType.BorderColor = Color.DeepSkyBlue;
            txtPenaltyType.BorderFocusColor = Color.AliceBlue;
            txtPenaltyType.BorderSize = 2;
            txtPenaltyType.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPenaltyType.Location = new Point(18, 295);
            txtPenaltyType.Margin = new Padding(4);
            txtPenaltyType.MaxLenght = 32767;
            txtPenaltyType.MultLine = false;
            txtPenaltyType.Name = "txtPenaltyType";
            txtPenaltyType.Padding = new Padding(7);
            txtPenaltyType.PasswordChar = false;
            txtPenaltyType.PlaceHolder = "Tipo da penalidade";
            txtPenaltyType.Size = new Size(204, 36);
            txtPenaltyType.TabIndex = 13;
            txtPenaltyType.Texts = "";
            txtPenaltyType.UnderlineStyle = false;
            // 
            // btnPenaltyAdd
            // 
            btnPenaltyAdd.BackColor = Color.White;
            btnPenaltyAdd.BackgroudColor = Color.White;
            btnPenaltyAdd.BorderColor = Color.PaleVioletRed;
            btnPenaltyAdd.BorderRadius = 40;
            btnPenaltyAdd.BorderSize = 0;
            btnPenaltyAdd.FlatAppearance.BorderSize = 0;
            btnPenaltyAdd.FlatStyle = FlatStyle.Flat;
            btnPenaltyAdd.ForeColor = Color.Black;
            btnPenaltyAdd.Location = new Point(342, 291);
            btnPenaltyAdd.Name = "btnPenaltyAdd";
            btnPenaltyAdd.Size = new Size(100, 40);
            btnPenaltyAdd.TabIndex = 15;
            btnPenaltyAdd.Text = "Adicionar";
            btnPenaltyAdd.TextColor = Color.Black;
            btnPenaltyAdd.UseVisualStyleBackColor = false;
            btnPenaltyAdd.Click += btnPenaltyAdd_Click;
            // 
            // listView2
            // 
            listView2.Location = new Point(557, 338);
            listView2.Name = "listView2";
            listView2.Size = new Size(430, 254);
            listView2.TabIndex = 17;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // lblRentalRecord
            // 
            lblRentalRecord.AutoSize = true;
            lblRentalRecord.Location = new Point(557, 268);
            lblRentalRecord.Name = "lblRentalRecord";
            lblRentalRecord.Size = new Size(160, 17);
            lblRentalRecord.TabIndex = 16;
            lblRentalRecord.Text = "Registro de Aluguel";
            // 
            // txtPenaltyValue
            // 
            txtPenaltyValue.BackColor = Color.White;
            txtPenaltyValue.BorderColor = Color.DeepSkyBlue;
            txtPenaltyValue.BorderFocusColor = Color.AliceBlue;
            txtPenaltyValue.BorderSize = 2;
            txtPenaltyValue.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPenaltyValue.Location = new Point(230, 295);
            txtPenaltyValue.Margin = new Padding(4);
            txtPenaltyValue.MaxLenght = 32767;
            txtPenaltyValue.MultLine = false;
            txtPenaltyValue.Name = "txtPenaltyValue";
            txtPenaltyValue.Padding = new Padding(7);
            txtPenaltyValue.PasswordChar = false;
            txtPenaltyValue.PlaceHolder = "Valor";
            txtPenaltyValue.Size = new Size(105, 36);
            txtPenaltyValue.TabIndex = 21;
            txtPenaltyValue.Texts = "";
            txtPenaltyValue.UnderlineStyle = false;
            // 
            // btnRentalRecordAdd
            // 
            btnRentalRecordAdd.BackColor = Color.White;
            btnRentalRecordAdd.BackgroudColor = Color.White;
            btnRentalRecordAdd.BorderColor = Color.PaleVioletRed;
            btnRentalRecordAdd.BorderRadius = 40;
            btnRentalRecordAdd.BorderSize = 0;
            btnRentalRecordAdd.FlatAppearance.BorderSize = 0;
            btnRentalRecordAdd.FlatStyle = FlatStyle.Flat;
            btnRentalRecordAdd.ForeColor = Color.Black;
            btnRentalRecordAdd.Location = new Point(557, 292);
            btnRentalRecordAdd.Name = "btnRentalRecordAdd";
            btnRentalRecordAdd.Size = new Size(430, 40);
            btnRentalRecordAdd.TabIndex = 22;
            btnRentalRecordAdd.Text = "Adicionar veiculo ao registro";
            btnRentalRecordAdd.TextColor = Color.Black;
            btnRentalRecordAdd.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderColor = Color.DeepSkyBlue;
            txtEmail.BorderFocusColor = Color.AliceBlue;
            txtEmail.BorderSize = 2;
            txtEmail.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(120, 192);
            txtEmail.Margin = new Padding(4);
            txtEmail.MaxLenght = 32767;
            txtEmail.MultLine = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceHolder = "";
            txtEmail.Size = new Size(860, 36);
            txtEmail.TabIndex = 23;
            txtEmail.Texts = "";
            txtEmail.UnderlineStyle = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(18, 192);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 17);
            lblEmail.TabIndex = 24;
            lblEmail.Text = "Email";
            // 
            // frmPessoa
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 604);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnRentalRecordAdd);
            Controls.Add(txtPenaltyValue);
            Controls.Add(listView2);
            Controls.Add(lblRentalRecord);
            Controls.Add(btnPenaltyAdd);
            Controls.Add(txtPenaltyType);
            Controls.Add(ltvtxtPenalty);
            Controls.Add(lblPenalty);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(lblDateOfBirth);
            Controls.Add(mkbCNH);
            Controls.Add(lblCNH);
            Controls.Add(mkbCPF);
            Controls.Add(lblCPF);
            Controls.Add(panel1);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmPessoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private CustomControls.CustomTextBox txtFirstName;
        private CustomControls.CustomTextBox txtLastName;
        private Label lblLastName;
        private Panel panel1;
        private CustomControls.CustomButton btnClose;
        private CustomControls.CustomButton btnDelete;
        private CustomControls.CustomButton btnSave;
        private Label lblCPF;
        private CustomControls.CustonMaskedBox mkbCPF;
        private CustomControls.CustonMaskedBox mkbCNH;
        private Label lblCNH;
        private Label lblDateOfBirth;
        private DateTimePicker dtpDateOfBirth;
        private Label lblBalanceText;
        private Label lblBalanceValue;
        private Label lblPenalty;
        private ListView ltvtxtPenalty;
        private CustomControls.CustomTextBox txtPenaltyType;
        private CustomControls.CustomButton btnPenaltyAdd;
        private CustomControls.CustomButton customButton2;
        private CustomControls.CustomTextBox customTextBox4;
        private ListView listView2;
        private Label lblRentalRecord;
        private CustomControls.CustomTextBox txtPenaltyValue;
        private CustomControls.CustomButton btnRentalRecordAdd;
        private CustomControls.CustomTextBox txtEmail;
        private Label lblEmail;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}