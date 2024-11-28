namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    partial class frmUser
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            lblFirstName = new Label();
            txtFirstName = new CustomControls.CustomTextBox();
            txtLastName = new CustomControls.CustomTextBox();
            lblLastName = new Label();
            panel1 = new Panel();
            pnlBalance = new Panel();
            ptbAddBalance = new PictureBox();
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
            lblViolation = new Label();
            ltvViolation = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            cmsPenalty = new ContextMenuStrip(components);
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            apagarToolStripMenuItem = new ToolStripMenuItem();
            txtViolationType = new CustomControls.CustomTextBox();
            btnViolationAdd = new CustomControls.CustomButton();
            listView2 = new ListView();
            lblRentalRecord = new Label();
            txtViolationValue = new CustomControls.CustomTextBox();
            btnRentalRecordAdd = new CustomControls.CustomButton();
            txtEmail = new CustomControls.CustomTextBox();
            lblEmail = new Label();
            btnEditViolation = new CustomControls.CustomButton();
            panel1.SuspendLayout();
            pnlBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAddBalance).BeginInit();
            cmsPenalty.SuspendLayout();
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
            txtFirstName.BorderColor = Color.SeaGreen;
            txtFirstName.BorderFocusColor = Color.PaleGreen;
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
            txtFirstName.ReadOnly = false;
            txtFirstName.Size = new Size(316, 36);
            txtFirstName.TabIndex = 0;
            txtFirstName.Texts = "";
            txtFirstName.UnderlineStyle = true;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.BorderColor = Color.SeaGreen;
            txtLastName.BorderFocusColor = Color.PaleGreen;
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
            txtLastName.ReadOnly = false;
            txtLastName.Size = new Size(455, 36);
            txtLastName.TabIndex = 1;
            txtLastName.Texts = "";
            txtLastName.UnderlineStyle = true;
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
            panel1.Controls.Add(pnlBalance);
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
            // pnlBalance
            // 
            pnlBalance.Controls.Add(ptbAddBalance);
            pnlBalance.Controls.Add(lblBalanceValue);
            pnlBalance.Location = new Point(91, 0);
            pnlBalance.Name = "pnlBalance";
            pnlBalance.Size = new Size(86, 50);
            pnlBalance.TabIndex = 7;
            // 
            // ptbAddBalance
            // 
            ptbAddBalance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptbAddBalance.Cursor = Cursors.Hand;
            ptbAddBalance.Image = (Image)resources.GetObject("ptbAddBalance.Image");
            ptbAddBalance.Location = new Point(51, 3);
            ptbAddBalance.Name = "ptbAddBalance";
            ptbAddBalance.Size = new Size(32, 32);
            ptbAddBalance.TabIndex = 6;
            ptbAddBalance.TabStop = false;
            ptbAddBalance.Visible = false;
            ptbAddBalance.Click += ptbAddBalance_Click;
            // 
            // lblBalanceValue
            // 
            lblBalanceValue.AutoSize = true;
            lblBalanceValue.Location = new Point(3, 15);
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
            btnClose.TabIndex = 12;
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
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Excluir";
            btnDelete.TextColor = Color.Black;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.AccessibleDescription = "";
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
            btnSave.TabIndex = 10;
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
            mkbCPF.BorderColor = Color.SeaGreen;
            mkbCPF.BorderFocusColor = Color.PaleGreen;
            mkbCPF.BorderSize = 2;
            mkbCPF.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mkbCPF.Location = new Point(421, 123);
            mkbCPF.Margin = new Padding(4);
            mkbCPF.Name = "mkbCPF";
            mkbCPF.Padding = new Padding(7);
            mkbCPF.Size = new Size(232, 36);
            mkbCPF.TabIndex = 3;
            mkbCPF.TextMask = "000.000.000-00";
            mkbCPF.Texts = "   .   .   -";
            mkbCPF.UnderlineStyle = true;
            // 
            // mkbCNH
            // 
            mkbCNH.BackColor = Color.White;
            mkbCNH.BorderColor = Color.SeaGreen;
            mkbCNH.BorderFocusColor = Color.PaleGreen;
            mkbCNH.BorderSize = 2;
            mkbCNH.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mkbCNH.Location = new Point(754, 123);
            mkbCNH.Margin = new Padding(4);
            mkbCNH.Name = "mkbCNH";
            mkbCNH.Padding = new Padding(7);
            mkbCNH.Size = new Size(232, 36);
            mkbCNH.TabIndex = 4;
            mkbCNH.TextMask = "000000000000";
            mkbCNH.Texts = "";
            mkbCNH.UnderlineStyle = true;
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
            dtpDateOfBirth.MinDate = new DateTime(1910, 1, 1, 0, 0, 0, 0);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(127, 25);
            dtpDateOfBirth.TabIndex = 2;
            // 
            // lblViolation
            // 
            lblViolation.AutoSize = true;
            lblViolation.Location = new Point(18, 268);
            lblViolation.Name = "lblViolation";
            lblViolation.Size = new Size(80, 17);
            lblViolation.TabIndex = 11;
            lblViolation.Text = "Violações";
            // 
            // ltvViolation
            // 
            ltvViolation.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader1, columnHeader2 });
            ltvViolation.ContextMenuStrip = cmsPenalty;
            ltvViolation.Enabled = false;
            ltvViolation.FullRowSelect = true;
            ltvViolation.Location = new Point(12, 338);
            ltvViolation.Name = "ltvViolation";
            ltvViolation.Size = new Size(441, 254);
            ltvViolation.TabIndex = 13;
            ltvViolation.TabStop = false;
            ltvViolation.UseCompatibleStateImageBehavior = false;
            ltvViolation.View = View.Details;
            ltvViolation.DoubleClick += ltvPenalty_DoubleClick;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ID";
            columnHeader3.Width = 90;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Motivo";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Valor";
            columnHeader2.Width = 110;
            // 
            // cmsPenalty
            // 
            cmsPenalty.Items.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, editarToolStripMenuItem, apagarToolStripMenuItem });
            cmsPenalty.Name = "cmsPenalty";
            cmsPenalty.Size = new Size(126, 70);
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(125, 22);
            adicionarToolStripMenuItem.Text = "Adicionar";
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(125, 22);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // apagarToolStripMenuItem
            // 
            apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            apagarToolStripMenuItem.Size = new Size(125, 22);
            apagarToolStripMenuItem.Text = "Apagar";
            apagarToolStripMenuItem.Click += apagarToolStripMenuItem_Click;
            // 
            // txtViolationType
            // 
            txtViolationType.BackColor = Color.White;
            txtViolationType.BorderColor = Color.SeaGreen;
            txtViolationType.BorderFocusColor = Color.PaleGreen;
            txtViolationType.BorderSize = 2;
            txtViolationType.Enabled = false;
            txtViolationType.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtViolationType.Location = new Point(18, 295);
            txtViolationType.Margin = new Padding(4);
            txtViolationType.MaxLenght = 30;
            txtViolationType.MultLine = false;
            txtViolationType.Name = "txtViolationType";
            txtViolationType.Padding = new Padding(7);
            txtViolationType.PasswordChar = false;
            txtViolationType.PlaceHolder = "Tipo da violação";
            txtViolationType.ReadOnly = false;
            txtViolationType.Size = new Size(204, 36);
            txtViolationType.TabIndex = 6;
            txtViolationType.Texts = "";
            txtViolationType.UnderlineStyle = true;
            // 
            // btnViolationAdd
            // 
            btnViolationAdd.BackColor = Color.White;
            btnViolationAdd.BackgroudColor = Color.White;
            btnViolationAdd.BorderColor = Color.PaleVioletRed;
            btnViolationAdd.BorderRadius = 40;
            btnViolationAdd.BorderSize = 0;
            btnViolationAdd.Enabled = false;
            btnViolationAdd.FlatAppearance.BorderSize = 0;
            btnViolationAdd.FlatStyle = FlatStyle.Flat;
            btnViolationAdd.ForeColor = Color.Black;
            btnViolationAdd.Location = new Point(342, 291);
            btnViolationAdd.Name = "btnViolationAdd";
            btnViolationAdd.Size = new Size(100, 40);
            btnViolationAdd.TabIndex = 8;
            btnViolationAdd.Text = "Adicionar";
            btnViolationAdd.TextColor = Color.Black;
            btnViolationAdd.UseVisualStyleBackColor = false;
            btnViolationAdd.Click += btnPenaltyAdd_Click;
            // 
            // listView2
            // 
            listView2.Enabled = false;
            listView2.Location = new Point(557, 338);
            listView2.Name = "listView2";
            listView2.Size = new Size(430, 254);
            listView2.TabIndex = 14;
            listView2.TabStop = false;
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
            // txtViolationValue
            // 
            txtViolationValue.BackColor = Color.White;
            txtViolationValue.BorderColor = Color.SeaGreen;
            txtViolationValue.BorderFocusColor = Color.PaleGreen;
            txtViolationValue.BorderSize = 2;
            txtViolationValue.Enabled = false;
            txtViolationValue.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtViolationValue.Location = new Point(230, 295);
            txtViolationValue.Margin = new Padding(4);
            txtViolationValue.MaxLenght = 9;
            txtViolationValue.MultLine = false;
            txtViolationValue.Name = "txtViolationValue";
            txtViolationValue.Padding = new Padding(7);
            txtViolationValue.PasswordChar = false;
            txtViolationValue.PlaceHolder = "Valor";
            txtViolationValue.ReadOnly = false;
            txtViolationValue.Size = new Size(105, 36);
            txtViolationValue.TabIndex = 7;
            txtViolationValue.Texts = "";
            txtViolationValue.UnderlineStyle = true;
            // 
            // btnRentalRecordAdd
            // 
            btnRentalRecordAdd.BackColor = Color.White;
            btnRentalRecordAdd.BackgroudColor = Color.White;
            btnRentalRecordAdd.BorderColor = Color.PaleVioletRed;
            btnRentalRecordAdd.BorderRadius = 40;
            btnRentalRecordAdd.BorderSize = 0;
            btnRentalRecordAdd.Enabled = false;
            btnRentalRecordAdd.FlatAppearance.BorderSize = 0;
            btnRentalRecordAdd.FlatStyle = FlatStyle.Flat;
            btnRentalRecordAdd.ForeColor = Color.Black;
            btnRentalRecordAdd.Location = new Point(557, 292);
            btnRentalRecordAdd.Name = "btnRentalRecordAdd";
            btnRentalRecordAdd.Size = new Size(430, 40);
            btnRentalRecordAdd.TabIndex = 9;
            btnRentalRecordAdd.Text = "Adicionar veiculo ao registro";
            btnRentalRecordAdd.TextColor = Color.Black;
            btnRentalRecordAdd.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderColor = Color.SeaGreen;
            txtEmail.BorderFocusColor = Color.PaleGreen;
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
            txtEmail.ReadOnly = false;
            txtEmail.Size = new Size(860, 36);
            txtEmail.TabIndex = 5;
            txtEmail.Texts = "";
            txtEmail.UnderlineStyle = true;
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
            // btnEditViolation
            // 
            btnEditViolation.BackColor = Color.White;
            btnEditViolation.BackgroudColor = Color.White;
            btnEditViolation.BorderColor = Color.PaleVioletRed;
            btnEditViolation.BorderRadius = 40;
            btnEditViolation.BorderSize = 0;
            btnEditViolation.FlatAppearance.BorderSize = 0;
            btnEditViolation.FlatStyle = FlatStyle.Flat;
            btnEditViolation.ForeColor = Color.Black;
            btnEditViolation.Location = new Point(342, 291);
            btnEditViolation.Name = "btnEditViolation";
            btnEditViolation.Size = new Size(100, 40);
            btnEditViolation.TabIndex = 25;
            btnEditViolation.Text = "Editar";
            btnEditViolation.TextColor = Color.Black;
            btnEditViolation.UseVisualStyleBackColor = false;
            btnEditViolation.Visible = false;
            btnEditViolation.Click += btnEditPenalty_Click;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 604);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnRentalRecordAdd);
            Controls.Add(txtViolationValue);
            Controls.Add(listView2);
            Controls.Add(lblRentalRecord);
            Controls.Add(txtViolationType);
            Controls.Add(ltvViolation);
            Controls.Add(lblViolation);
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
            Controls.Add(btnViolationAdd);
            Controls.Add(btnEditViolation);
            Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Usuario";
            KeyDown += frmUser_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlBalance.ResumeLayout(false);
            pnlBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAddBalance).EndInit();
            cmsPenalty.ResumeLayout(false);
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
        private Label lblViolation;
        private ListView ltvViolation;
        private CustomControls.CustomTextBox txtViolationType;
        private CustomControls.CustomButton btnViolationAdd;
        private CustomControls.CustomButton customButton2;
        private CustomControls.CustomTextBox customTextBox4;
        private ListView listView2;
        private Label lblRentalRecord;
        private CustomControls.CustomTextBox txtViolationValue;
        private CustomControls.CustomButton btnRentalRecordAdd;
        private CustomControls.CustomTextBox txtEmail;
        private Label lblEmail;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ContextMenuStrip cmsPenalty;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem apagarToolStripMenuItem;
        private CustomControls.CustomButton btnEditViolation;
        private PictureBox ptbAddBalance;
        private Panel pnlBalance;
    }
}