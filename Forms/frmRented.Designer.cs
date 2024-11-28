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
            ltvRecord = new ListView();
            mkbCPF = new CustomControls.CustonMaskedBox();
            customButton1 = new CustomControls.CustomButton();
            txtLicensePlate = new CustomControls.CustomTextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            customButton2 = new CustomControls.CustomButton();
            customButton3 = new CustomControls.CustomButton();
            label5 = new Label();
            dtpReturnDay = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            lblName = new Label();
            txtName = new CustomControls.CustomTextBox();
            SuspendLayout();
            // 
            // ltvRecord
            // 
            ltvRecord.Location = new Point(12, 514);
            ltvRecord.Name = "ltvRecord";
            ltvRecord.Size = new Size(474, 35);
            ltvRecord.TabIndex = 0;
            ltvRecord.UseCompatibleStateImageBehavior = false;
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
            mkbCPF.Enter += mkbCPF_Enter;
            mkbCPF.Leave += txtCPF_Leave;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.White;
            customButton1.BackgroudColor = Color.White;
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 40;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.Black;
            customButton1.Location = new Point(316, 7);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 40);
            customButton1.TabIndex = 2;
            customButton1.Text = "Alugar";
            customButton1.TextColor = Color.Black;
            customButton1.UseVisualStyleBackColor = false;
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
            txtLicensePlate.TabIndex = 1;
            txtLicensePlate.Texts = "";
            txtLicensePlate.UnderlineStyle = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(14, 315);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(129, 25);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 295);
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
            label4.Location = new Point(153, 480);
            label4.Name = "label4";
            label4.Size = new Size(176, 17);
            label4.TabIndex = 8;
            label4.Text = "Utimos 50, locatarios";
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.White;
            customButton2.BackgroudColor = Color.White;
            customButton2.BorderColor = Color.PaleVioletRed;
            customButton2.BorderRadius = 40;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.ForeColor = Color.Black;
            customButton2.Location = new Point(316, 103);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(150, 40);
            customButton2.TabIndex = 9;
            customButton2.Text = "Cancelar";
            customButton2.TextColor = Color.Black;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.White;
            customButton3.BackgroudColor = Color.White;
            customButton3.BorderColor = Color.PaleVioletRed;
            customButton3.BorderRadius = 40;
            customButton3.BorderSize = 0;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.ForeColor = Color.Black;
            customButton3.Location = new Point(316, 55);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(150, 40);
            customButton3.TabIndex = 10;
            customButton3.Text = "Extender Aluguel";
            customButton3.TextColor = Color.Black;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 295);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 12;
            label5.Text = "Até";
            // 
            // dtpReturnDay
            // 
            dtpReturnDay.Format = DateTimePickerFormat.Short;
            dtpReturnDay.Location = new Point(247, 315);
            dtpReturnDay.Name = "dtpReturnDay";
            dtpReturnDay.Size = new Size(129, 25);
            dtpReturnDay.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 370);
            label6.Name = "label6";
            label6.Size = new Size(184, 17);
            label6.TabIndex = 13;
            label6.Text = "Dias até o vencimento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(195, 370);
            label7.Name = "label7";
            label7.Size = new Size(16, 17);
            label7.TabIndex = 14;
            label7.Text = "0";
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
            txtName.BorderColor = Color.FromArgb(93, 181, 245);
            txtName.BorderFocusColor = Color.PaleGreen;
            txtName.BorderSize = 2;
            txtName.Enabled = false;
            txtName.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(13, 162);
            txtName.Margin = new Padding(4);
            txtName.MaxLenght = 32767;
            txtName.MultLine = false;
            txtName.Name = "txtName";
            txtName.Padding = new Padding(7);
            txtName.PasswordChar = false;
            txtName.PlaceHolder = "Insira o CPF para ver o nome.";
            txtName.ReadOnly = false;
            txtName.Size = new Size(453, 36);
            txtName.TabIndex = 15;
            txtName.Texts = "";
            txtName.UnderlineStyle = false;
            // 
            // frmRented
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 561);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpReturnDay);
            Controls.Add(customButton3);
            Controls.Add(customButton2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtLicensePlate);
            Controls.Add(customButton1);
            Controls.Add(mkbCPF);
            Controls.Add(ltvRecord);
            Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmRented";
            Text = "Alugar Veiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ltvRecord;
        private CustomControls.CustonMaskedBox mkbCPF;
        private CustomControls.CustomButton customButton1;
        private CustomControls.CustomTextBox txtLicensePlate;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CustomControls.CustomButton customButton2;
        private CustomControls.CustomButton customButton3;
        private Label label5;
        private DateTimePicker dtpReturnDay;
        private Label label6;
        private Label label7;
        private Label lblName;
        private CustomControls.CustomTextBox txtName;
    }
}