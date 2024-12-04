namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Forms
{
    partial class frmRented
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRented));
            ltvRecord = new ListView();
            chUserId = new ColumnHeader();
            chRentalDate = new ColumnHeader();
            chRentalExpired = new ColumnHeader();
            chRentalValue = new ColumnHeader();
            mkbCPF = new CustomControls.CustonMaskedBox();
            btnRent = new CustomControls.CustomButton();
            txtLicensePlate = new CustomControls.CustomTextBox();
            dtpStartingDay = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCancelRental = new CustomControls.CustomButton();
            label5 = new Label();
            dtpReturnDay = new DateTimePicker();
            lblDaysRemainingText = new Label();
            lblDaysRemainingValue = new Label();
            lblName = new Label();
            txtName = new CustomControls.CustomTextBox();
            lblTotalValue = new Label();
            lblTotalValueText = new Label();
            SuspendLayout();
            // 
            // ltvRecord
            // 
            ltvRecord.Columns.AddRange(new ColumnHeader[] { chUserId, chRentalDate, chRentalExpired, chRentalValue });
            ltvRecord.FullRowSelect = true;
            ltvRecord.Location = new Point(12, 320);
            ltvRecord.MultiSelect = false;
            ltvRecord.Name = "ltvRecord";
            ltvRecord.Size = new Size(474, 229);
            ltvRecord.TabIndex = 3;
            ltvRecord.UseCompatibleStateImageBehavior = false;
            ltvRecord.View = View.Details;
            // 
            // chUserId
            // 
            chUserId.Text = "Usuario Id";
            chUserId.Width = 110;
            // 
            // chRentalDate
            // 
            chRentalDate.Text = "Alugado Em";
            chRentalDate.Width = 120;
            // 
            // chRentalExpired
            // 
            chRentalExpired.Text = "Expirado Em";
            chRentalExpired.Width = 120;
            // 
            // chRentalValue
            // 
            chRentalValue.Text = "Valor";
            chRentalValue.Width = 115;
            // 
            // mkbCPF
            // 
            mkbCPF.BackColor = Color.White;
            mkbCPF.BorderColor = Color.SeaGreen;
            mkbCPF.BorderFocusColor = Color.PaleGreen;
            mkbCPF.BorderSize = 2;
            mkbCPF.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mkbCPF.Location = new Point(13, 93);
            mkbCPF.Margin = new Padding(4);
            mkbCPF.Name = "mkbCPF";
            mkbCPF.Padding = new Padding(7);
            mkbCPF.Size = new Size(232, 30);
            mkbCPF.TabIndex = 0;
            mkbCPF.TextMask = "000.000.000-00";
            mkbCPF.Texts = "   .   .   -";
            mkbCPF.UnderlineStyle = true;
            mkbCPF._TextChanged += mkbCPF__TextChanged;
            mkbCPF._MouseClick += mkbCPF__MouseClick;
            mkbCPF.Enter += mkbCPF_Enter;
            mkbCPF.Leave += txtCPF_Leave;
            // 
            // btnRent
            // 
            btnRent.BackColor = Color.White;
            btnRent.BackgroudColor = Color.White;
            btnRent.BorderColor = Color.PaleVioletRed;
            btnRent.BorderRadius = 40;
            btnRent.BorderSize = 0;
            btnRent.FlatAppearance.BorderSize = 0;
            btnRent.FlatStyle = FlatStyle.Flat;
            btnRent.ForeColor = Color.Black;
            btnRent.Location = new Point(316, 24);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(150, 40);
            btnRent.TabIndex = 4;
            btnRent.Text = "Alugar";
            btnRent.TextColor = Color.Black;
            btnRent.UseVisualStyleBackColor = false;
            btnRent.Click += btnRent_Click;
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.BackColor = Color.White;
            txtLicensePlate.BorderColor = Color.SeaGreen;
            txtLicensePlate.BorderFocusColor = Color.PaleGreen;
            txtLicensePlate.BorderSize = 2;
            txtLicensePlate.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLicensePlate.Location = new Point(13, 24);
            txtLicensePlate.Margin = new Padding(4);
            txtLicensePlate.MaxLenght = 32767;
            txtLicensePlate.MultLine = false;
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Padding = new Padding(7);
            txtLicensePlate.PasswordChar = false;
            txtLicensePlate.PlaceHolder = "";
            txtLicensePlate.ReadOnly = true;
            txtLicensePlate.Size = new Size(232, 36);
            txtLicensePlate.TabIndex = 7;
            txtLicensePlate.TabStop = false;
            txtLicensePlate.Texts = "";
            txtLicensePlate.UnderlineStyle = true;
            // 
            // dtpStartingDay
            // 
            dtpStartingDay.Format = DateTimePickerFormat.Short;
            dtpStartingDay.Location = new Point(13, 230);
            dtpStartingDay.Name = "dtpStartingDay";
            dtpStartingDay.Size = new Size(129, 25);
            dtpStartingDay.TabIndex = 1;
            dtpStartingDay.ValueChanged += dtpStartingDay_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 210);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 5;
            label1.Text = "Alugado em";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 3);
            label2.Name = "label2";
            label2.Size = new Size(136, 17);
            label2.TabIndex = 6;
            label2.Text = "Placa do Veículo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 72);
            label3.Name = "label3";
            label3.Size = new Size(184, 17);
            label3.TabIndex = 7;
            label3.Text = "CPF de quem vai alugar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 300);
            label4.Name = "label4";
            label4.Size = new Size(176, 17);
            label4.TabIndex = 8;
            label4.Text = "Utimos 50, locatarios";
            // 
            // btnCancelRental
            // 
            btnCancelRental.BackColor = Color.White;
            btnCancelRental.BackgroudColor = Color.White;
            btnCancelRental.BorderColor = Color.PaleVioletRed;
            btnCancelRental.BorderRadius = 40;
            btnCancelRental.BorderSize = 0;
            btnCancelRental.FlatAppearance.BorderSize = 0;
            btnCancelRental.FlatStyle = FlatStyle.Flat;
            btnCancelRental.ForeColor = Color.Black;
            btnCancelRental.Location = new Point(316, 72);
            btnCancelRental.Name = "btnCancelRental";
            btnCancelRental.Size = new Size(150, 40);
            btnCancelRental.TabIndex = 6;
            btnCancelRental.Text = "Cancelar Aluguel";
            btnCancelRental.TextColor = Color.Black;
            btnCancelRental.UseVisualStyleBackColor = false;
            btnCancelRental.Visible = false;
            btnCancelRental.Click += btnCancelRental_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 210);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 12;
            label5.Text = "Até";
            // 
            // dtpReturnDay
            // 
            dtpReturnDay.Format = DateTimePickerFormat.Short;
            dtpReturnDay.Location = new Point(246, 230);
            dtpReturnDay.Name = "dtpReturnDay";
            dtpReturnDay.Size = new Size(129, 25);
            dtpReturnDay.TabIndex = 2;
            dtpReturnDay.ValueChanged += dtpReturnDay_ValueChanged;
            // 
            // lblDaysRemainingText
            // 
            lblDaysRemainingText.AutoSize = true;
            lblDaysRemainingText.Location = new Point(13, 268);
            lblDaysRemainingText.Name = "lblDaysRemainingText";
            lblDaysRemainingText.Size = new Size(120, 17);
            lblDaysRemainingText.TabIndex = 13;
            lblDaysRemainingText.Text = "Dias restante:";
            // 
            // lblDaysRemainingValue
            // 
            lblDaysRemainingValue.AutoSize = true;
            lblDaysRemainingValue.Location = new Point(133, 268);
            lblDaysRemainingValue.Name = "lblDaysRemainingValue";
            lblDaysRemainingValue.Size = new Size(16, 17);
            lblDaysRemainingValue.TabIndex = 14;
            lblDaysRemainingValue.Text = "0";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(13, 141);
            lblName.Name = "lblName";
            lblName.Size = new Size(264, 17);
            lblName.TabIndex = 16;
            lblName.Text = "Nome completo de quem vai alugar";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderColor = Color.PaleGreen;
            txtName.BorderFocusColor = Color.PaleGreen;
            txtName.BorderSize = 2;
            txtName.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(13, 162);
            txtName.Margin = new Padding(4);
            txtName.MaxLenght = 32767;
            txtName.MultLine = false;
            txtName.Name = "txtName";
            txtName.Padding = new Padding(7);
            txtName.PasswordChar = false;
            txtName.PlaceHolder = "Insira o CPF para ver o nome.";
            txtName.ReadOnly = true;
            txtName.Size = new Size(453, 36);
            txtName.TabIndex = 8;
            txtName.TabStop = false;
            txtName.Texts = "";
            txtName.UnderlineStyle = false;
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(380, 268);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(16, 17);
            lblTotalValue.TabIndex = 18;
            lblTotalValue.Text = "0";
            // 
            // lblTotalValueText
            // 
            lblTotalValueText.AutoSize = true;
            lblTotalValueText.Location = new Point(246, 268);
            lblTotalValueText.Name = "lblTotalValueText";
            lblTotalValueText.Size = new Size(128, 17);
            lblTotalValueText.TabIndex = 17;
            lblTotalValueText.Text = "Valor total: R$";
            // 
            // frmRented
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(498, 561);
            Controls.Add(lblTotalValue);
            Controls.Add(lblTotalValueText);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblDaysRemainingValue);
            Controls.Add(lblDaysRemainingText);
            Controls.Add(label5);
            Controls.Add(dtpReturnDay);
            Controls.Add(btnCancelRental);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpStartingDay);
            Controls.Add(txtLicensePlate);
            Controls.Add(btnRent);
            Controls.Add(mkbCPF);
            Controls.Add(ltvRecord);
            Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "frmRented";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alugar Veiculo";
            KeyDown += frmRented_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ltvRecord;
        private CustomControls.CustonMaskedBox mkbCPF;
        private CustomControls.CustomButton btnRent;
        private CustomControls.CustomTextBox txtLicensePlate;
        private DateTimePicker dtpStartingDay;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CustomControls.CustomButton btnCancelRental;
        private Label label5;
        private DateTimePicker dtpReturnDay;
        private Label lblDaysRemainingText;
        private Label lblDaysRemainingValue;
        private Label lblName;
        private CustomControls.CustomTextBox txtName;
        private Label lblTotalValue;
        private Label lblTotalValueText;
        private ColumnHeader chUserId;
        private ColumnHeader chRentalDate;
        private ColumnHeader chRentalExpired;
        private ColumnHeader chRentalValue;
    }
}