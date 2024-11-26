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
            txtCPF = new CustomControls.CustonMaskedBox();
            customButton1 = new CustomControls.CustomButton();
            customTextBox1 = new CustomControls.CustomTextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            customButton2 = new CustomControls.CustomButton();
            customButton3 = new CustomControls.CustomButton();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // ltvRecord
            // 
            ltvRecord.Location = new Point(12, 225);
            ltvRecord.Name = "ltvRecord";
            ltvRecord.Size = new Size(429, 273);
            ltvRecord.TabIndex = 0;
            ltvRecord.UseCompatibleStateImageBehavior = false;
            // 
            // txtCPF
            // 
            txtCPF.BackColor = Color.White;
            txtCPF.BorderColor = Color.DeepSkyBlue;
            txtCPF.BorderFocusColor = Color.AliceBlue;
            txtCPF.BorderSize = 2;
            txtCPF.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCPF.Location = new Point(13, 93);
            txtCPF.Margin = new Padding(4);
            txtCPF.Name = "txtCPF";
            txtCPF.Padding = new Padding(7);
            txtCPF.Size = new Size(232, 30);
            txtCPF.TabIndex = 1;
            txtCPF.TextMask = "000.000.000-00";
            txtCPF.Texts = "   .   .   -";
            txtCPF.UnderlineStyle = false;
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
            customButton1.Location = new Point(291, 12);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 40);
            customButton1.TabIndex = 2;
            customButton1.Text = "Alugar";
            customButton1.TextColor = Color.Black;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = Color.White;
            customTextBox1.BorderColor = Color.DeepSkyBlue;
            customTextBox1.BorderFocusColor = Color.AliceBlue;
            customTextBox1.BorderSize = 2;
            customTextBox1.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customTextBox1.Location = new Point(13, 24);
            customTextBox1.Margin = new Padding(4);
            customTextBox1.MaxLenght = 32767;
            customTextBox1.MultLine = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(7);
            customTextBox1.PasswordChar = false;
            customTextBox1.PlaceHolder = "";
            customTextBox1.ReadOnly = true;
            customTextBox1.Size = new Size(232, 36);
            customTextBox1.TabIndex = 3;
            customTextBox1.Texts = "";
            customTextBox1.UnderlineStyle = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(13, 160);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(129, 25);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 140);
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
            label4.Location = new Point(145, 205);
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
            customButton2.Location = new Point(291, 108);
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
            customButton3.Location = new Point(291, 60);
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
            label5.Location = new Point(171, 140);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 12;
            label5.Text = "Até";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(171, 160);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(129, 25);
            dateTimePicker2.TabIndex = 11;
            // 
            // frmRented
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 510);
            Controls.Add(label5);
            Controls.Add(dateTimePicker2);
            Controls.Add(customButton3);
            Controls.Add(customButton2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(customTextBox1);
            Controls.Add(customButton1);
            Controls.Add(txtCPF);
            Controls.Add(ltvRecord);
            Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmRented";
            Text = "Alugar Veiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ltvRecord;
        private CustomControls.CustonMaskedBox txtCPF;
        private CustomControls.CustomButton customButton1;
        private CustomControls.CustomTextBox customTextBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CustomControls.CustomButton customButton2;
        private CustomControls.CustomButton customButton3;
        private Label label5;
        private DateTimePicker dateTimePicker2;
    }
}