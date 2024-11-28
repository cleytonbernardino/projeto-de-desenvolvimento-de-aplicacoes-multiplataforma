namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    partial class frmVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicle));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtMileage = new CustomControls.CustomTextBox();
            txtDailyVehicleRate = new CustomControls.CustomTextBox();
            lblDailyVehicleRate = new Label();
            groupBox2 = new GroupBox();
            rbElectroHydraulic = new RadioButton();
            rbElectrical = new RadioButton();
            rbHydraulics = new RadioButton();
            rbMechanic = new RadioButton();
            lblMileage = new Label();
            gpbDocuments = new GroupBox();
            cbLincense = new CheckBox();
            cbKey = new CheckBox();
            cbManual = new CheckBox();
            gpbAddons = new GroupBox();
            cbEletricLocks = new CheckBox();
            cbEletricGlass = new CheckBox();
            cbAr = new CheckBox();
            txtObs = new CustomControls.CustomTextBox();
            lblObs = new Label();
            cbxFuelType = new ComboBox();
            lblGas = new Label();
            txtColor = new CustomControls.CustomTextBox();
            lblColor = new Label();
            mkbRenavam = new CustomControls.CustonMaskedBox();
            lblRenavam = new Label();
            txtChassiNumber = new CustomControls.CustomTextBox();
            lblChassi = new Label();
            dtpModelYear = new DateTimePicker();
            lblModelYear = new Label();
            txtModel = new CustomControls.CustomTextBox();
            lblModel = new Label();
            cbxBrand = new ComboBox();
            lblBrand = new Label();
            txtLicensePlate = new CustomControls.CustomTextBox();
            lblLicensePlate = new Label();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblLastManuntencao = new Label();
            gpbInsecure = new GroupBox();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            cbResponsabilidade = new CheckBox();
            cbAll = new CheckBox();
            panel1 = new Panel();
            btnClose = new CustomControls.CustomButton();
            btnDelete = new CustomControls.CustomButton();
            btnSave = new CustomControls.CustomButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            gpbDocuments.SuspendLayout();
            gpbAddons.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            gpbInsecure.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1019, 522);
            tabControl1.TabIndex = 100;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtMileage);
            tabPage1.Controls.Add(txtDailyVehicleRate);
            tabPage1.Controls.Add(lblDailyVehicleRate);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(lblMileage);
            tabPage1.Controls.Add(gpbDocuments);
            tabPage1.Controls.Add(gpbAddons);
            tabPage1.Controls.Add(txtObs);
            tabPage1.Controls.Add(lblObs);
            tabPage1.Controls.Add(cbxFuelType);
            tabPage1.Controls.Add(lblGas);
            tabPage1.Controls.Add(txtColor);
            tabPage1.Controls.Add(lblColor);
            tabPage1.Controls.Add(mkbRenavam);
            tabPage1.Controls.Add(lblRenavam);
            tabPage1.Controls.Add(txtChassiNumber);
            tabPage1.Controls.Add(lblChassi);
            tabPage1.Controls.Add(dtpModelYear);
            tabPage1.Controls.Add(lblModelYear);
            tabPage1.Controls.Add(txtModel);
            tabPage1.Controls.Add(lblModel);
            tabPage1.Controls.Add(cbxBrand);
            tabPage1.Controls.Add(lblBrand);
            tabPage1.Controls.Add(txtLicensePlate);
            tabPage1.Controls.Add(lblLicensePlate);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1011, 492);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Informações Basicas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtMileage
            // 
            txtMileage.BackColor = Color.White;
            txtMileage.BorderColor = Color.SeaGreen;
            txtMileage.BorderFocusColor = Color.PaleGreen;
            txtMileage.BorderSize = 2;
            txtMileage.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMileage.Location = new Point(684, 160);
            txtMileage.Margin = new Padding(4);
            txtMileage.MaxLenght = 8;
            txtMileage.MultLine = false;
            txtMileage.Name = "txtMileage";
            txtMileage.Padding = new Padding(7);
            txtMileage.PasswordChar = false;
            txtMileage.PlaceHolder = "";
            txtMileage.ReadOnly = false;
            txtMileage.Size = new Size(155, 36);
            txtMileage.TabIndex = 8;
            txtMileage.Texts = "";
            txtMileage.UnderlineStyle = true;
            txtMileage.KeyPress += txtKm_KeyPress;
            // 
            // txtDailyVehicleRate
            // 
            txtDailyVehicleRate.BackColor = Color.White;
            txtDailyVehicleRate.BorderColor = Color.SeaGreen;
            txtDailyVehicleRate.BorderFocusColor = Color.PaleGreen;
            txtDailyVehicleRate.BorderSize = 2;
            txtDailyVehicleRate.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDailyVehicleRate.Location = new Point(845, 160);
            txtDailyVehicleRate.Margin = new Padding(4);
            txtDailyVehicleRate.MaxLenght = 17;
            txtDailyVehicleRate.MultLine = false;
            txtDailyVehicleRate.Name = "txtDailyVehicleRate";
            txtDailyVehicleRate.Padding = new Padding(7);
            txtDailyVehicleRate.PasswordChar = false;
            txtDailyVehicleRate.PlaceHolder = "";
            txtDailyVehicleRate.ReadOnly = false;
            txtDailyVehicleRate.Size = new Size(155, 36);
            txtDailyVehicleRate.TabIndex = 9;
            txtDailyVehicleRate.Texts = "";
            txtDailyVehicleRate.UnderlineStyle = true;
            txtDailyVehicleRate._KeyPress += txtDailyVehicleRate__KeyPress;
            // 
            // lblDailyVehicleRate
            // 
            lblDailyVehicleRate.AutoSize = true;
            lblDailyVehicleRate.Location = new Point(845, 138);
            lblDailyVehicleRate.Name = "lblDailyVehicleRate";
            lblDailyVehicleRate.Size = new Size(136, 17);
            lblDailyVehicleRate.TabIndex = 24;
            lblDailyVehicleRate.Text = "Valor do aluguel";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbElectroHydraulic);
            groupBox2.Controls.Add(rbElectrical);
            groupBox2.Controls.Add(rbHydraulics);
            groupBox2.Controls.Add(rbMechanic);
            groupBox2.Location = new Point(699, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(301, 124);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Direção";
            // 
            // rbElectroHydraulic
            // 
            rbElectroHydraulic.AutoSize = true;
            rbElectroHydraulic.Location = new Point(133, 24);
            rbElectroHydraulic.Name = "rbElectroHydraulic";
            rbElectroHydraulic.Size = new Size(162, 21);
            rbElectroHydraulic.TabIndex = 3;
            rbElectroHydraulic.Text = "Eletro-hidráulica";
            rbElectroHydraulic.UseVisualStyleBackColor = true;
            rbElectroHydraulic.CheckedChanged += rbElectroHydraulic_CheckedChanged;
            // 
            // rbElectrical
            // 
            rbElectrical.AutoSize = true;
            rbElectrical.Location = new Point(6, 78);
            rbElectrical.Name = "rbElectrical";
            rbElectrical.Size = new Size(90, 21);
            rbElectrical.TabIndex = 2;
            rbElectrical.Text = "Elétrica";
            rbElectrical.UseVisualStyleBackColor = true;
            rbElectrical.CheckedChanged += rbElectrical_CheckedChanged;
            // 
            // rbHydraulics
            // 
            rbHydraulics.AutoSize = true;
            rbHydraulics.Location = new Point(6, 51);
            rbHydraulics.Name = "rbHydraulics";
            rbHydraulics.Size = new Size(106, 21);
            rbHydraulics.TabIndex = 1;
            rbHydraulics.Text = "Hidráulica";
            rbHydraulics.UseVisualStyleBackColor = true;
            rbHydraulics.CheckedChanged += rbHydraulics_CheckedChanged;
            // 
            // rbMechanic
            // 
            rbMechanic.AutoSize = true;
            rbMechanic.Checked = true;
            rbMechanic.Location = new Point(6, 23);
            rbMechanic.Name = "rbMechanic";
            rbMechanic.Size = new Size(90, 21);
            rbMechanic.TabIndex = 0;
            rbMechanic.TabStop = true;
            rbMechanic.Text = "Mecânica";
            rbMechanic.UseVisualStyleBackColor = true;
            rbMechanic.CheckedChanged += rbMechanic_CheckedChanged;
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Location = new Point(684, 138);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(104, 17);
            lblMileage.TabIndex = 21;
            lblMileage.Text = "Kilometragem";
            // 
            // gpbDocuments
            // 
            gpbDocuments.Controls.Add(cbLincense);
            gpbDocuments.Controls.Add(cbKey);
            gpbDocuments.Controls.Add(cbManual);
            gpbDocuments.Location = new Point(366, 219);
            gpbDocuments.Name = "gpbDocuments";
            gpbDocuments.Size = new Size(292, 124);
            gpbDocuments.TabIndex = 11;
            gpbDocuments.TabStop = false;
            gpbDocuments.Text = "Documentação";
            // 
            // cbLincense
            // 
            cbLincense.AutoSize = true;
            cbLincense.Location = new Point(6, 78);
            cbLincense.Name = "cbLincense";
            cbLincense.Size = new Size(107, 21);
            cbLincense.TabIndex = 2;
            cbLincense.Text = "Licenciado";
            cbLincense.UseVisualStyleBackColor = true;
            // 
            // cbKey
            // 
            cbKey.AutoSize = true;
            cbKey.Location = new Point(6, 51);
            cbKey.Name = "cbKey";
            cbKey.Size = new Size(131, 21);
            cbKey.TabIndex = 1;
            cbKey.Text = "Chave Reserva";
            cbKey.UseVisualStyleBackColor = true;
            // 
            // cbManual
            // 
            cbManual.AutoSize = true;
            cbManual.Location = new Point(6, 24);
            cbManual.Name = "cbManual";
            cbManual.Size = new Size(203, 21);
            cbManual.TabIndex = 0;
            cbManual.Text = "Manual do Proprietario";
            cbManual.UseVisualStyleBackColor = true;
            // 
            // gpbAddons
            // 
            gpbAddons.Controls.Add(cbEletricLocks);
            gpbAddons.Controls.Add(cbEletricGlass);
            gpbAddons.Controls.Add(cbAr);
            gpbAddons.Location = new Point(10, 219);
            gpbAddons.Name = "gpbAddons";
            gpbAddons.Size = new Size(309, 124);
            gpbAddons.TabIndex = 10;
            gpbAddons.TabStop = false;
            gpbAddons.Text = "Adicionais";
            // 
            // cbEletricLocks
            // 
            cbEletricLocks.AutoSize = true;
            cbEletricLocks.Location = new Point(6, 78);
            cbEletricLocks.Name = "cbEletricLocks";
            cbEletricLocks.Size = new Size(147, 21);
            cbEletricLocks.TabIndex = 2;
            cbEletricLocks.Text = "Travas Eletrica";
            cbEletricLocks.UseVisualStyleBackColor = true;
            // 
            // cbEletricGlass
            // 
            cbEletricGlass.AutoSize = true;
            cbEletricGlass.Location = new Point(6, 51);
            cbEletricGlass.Name = "cbEletricGlass";
            cbEletricGlass.Size = new Size(155, 21);
            cbEletricGlass.TabIndex = 1;
            cbEletricGlass.Text = "Vidros Eletricos";
            cbEletricGlass.UseVisualStyleBackColor = true;
            // 
            // cbAr
            // 
            cbAr.AutoSize = true;
            cbAr.Location = new Point(6, 24);
            cbAr.Name = "cbAr";
            cbAr.Size = new Size(147, 21);
            cbAr.TabIndex = 0;
            cbAr.Text = "Ar Condicionado";
            cbAr.UseVisualStyleBackColor = true;
            // 
            // txtObs
            // 
            txtObs.BackColor = Color.White;
            txtObs.BorderColor = Color.SeaGreen;
            txtObs.BorderFocusColor = Color.SpringGreen;
            txtObs.BorderSize = 2;
            txtObs.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObs.Location = new Point(10, 376);
            txtObs.Margin = new Padding(4);
            txtObs.MaxLenght = 255;
            txtObs.MultLine = true;
            txtObs.Name = "txtObs";
            txtObs.Padding = new Padding(7);
            txtObs.PasswordChar = false;
            txtObs.PlaceHolder = "";
            txtObs.ReadOnly = false;
            txtObs.Size = new Size(993, 112);
            txtObs.TabIndex = 13;
            txtObs.Texts = "";
            txtObs.UnderlineStyle = false;
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Location = new Point(10, 355);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(96, 17);
            lblObs.TabIndex = 17;
            lblObs.Text = "Observações";
            // 
            // cbxFuelType
            // 
            cbxFuelType.AutoCompleteMode = AutoCompleteMode.Append;
            cbxFuelType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxFuelType.FormattingEnabled = true;
            cbxFuelType.Items.AddRange(new object[] { "Álcool", "Elétrico", "Etanol", "Gasolina", "Hibrido" });
            cbxFuelType.Location = new Point(535, 171);
            cbxFuelType.Name = "cbxFuelType";
            cbxFuelType.Size = new Size(142, 25);
            cbxFuelType.TabIndex = 7;
            cbxFuelType.Text = "Selecione um";
            cbxFuelType.KeyPress += comboBox1_KeyPress;
            // 
            // lblGas
            // 
            lblGas.AutoSize = true;
            lblGas.Location = new Point(535, 138);
            lblGas.Name = "lblGas";
            lblGas.Size = new Size(96, 17);
            lblGas.TabIndex = 15;
            lblGas.Text = "Combustivel";
            // 
            // txtColor
            // 
            txtColor.BackColor = Color.White;
            txtColor.BorderColor = Color.SeaGreen;
            txtColor.BorderFocusColor = Color.SpringGreen;
            txtColor.BorderSize = 2;
            txtColor.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtColor.Location = new Point(271, 159);
            txtColor.Margin = new Padding(4);
            txtColor.MaxLenght = 25;
            txtColor.MultLine = false;
            txtColor.Name = "txtColor";
            txtColor.Padding = new Padding(7);
            txtColor.PasswordChar = false;
            txtColor.PlaceHolder = "";
            txtColor.ReadOnly = false;
            txtColor.Size = new Size(229, 36);
            txtColor.TabIndex = 6;
            txtColor.Texts = "";
            txtColor.UnderlineStyle = true;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(271, 138);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(32, 17);
            lblColor.TabIndex = 13;
            lblColor.Text = "Cor";
            // 
            // mkbRenavam
            // 
            mkbRenavam.BackColor = Color.White;
            mkbRenavam.BorderColor = Color.SeaGreen;
            mkbRenavam.BorderFocusColor = Color.SpringGreen;
            mkbRenavam.BorderSize = 2;
            mkbRenavam.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mkbRenavam.Location = new Point(13, 159);
            mkbRenavam.Margin = new Padding(4);
            mkbRenavam.Name = "mkbRenavam";
            mkbRenavam.Padding = new Padding(7);
            mkbRenavam.Size = new Size(214, 30);
            mkbRenavam.TabIndex = 5;
            mkbRenavam.TextMask = "00000000000";
            mkbRenavam.Texts = "";
            mkbRenavam.UnderlineStyle = true;
            // 
            // lblRenavam
            // 
            lblRenavam.AutoSize = true;
            lblRenavam.Location = new Point(13, 138);
            lblRenavam.Name = "lblRenavam";
            lblRenavam.Size = new Size(64, 17);
            lblRenavam.TabIndex = 11;
            lblRenavam.Text = "Renavam";
            // 
            // txtChassiNumber
            // 
            txtChassiNumber.BackColor = Color.White;
            txtChassiNumber.BorderColor = Color.SeaGreen;
            txtChassiNumber.BorderFocusColor = Color.SpringGreen;
            txtChassiNumber.BorderSize = 2;
            txtChassiNumber.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChassiNumber.Location = new Point(649, 87);
            txtChassiNumber.Margin = new Padding(4);
            txtChassiNumber.MaxLenght = 17;
            txtChassiNumber.MultLine = false;
            txtChassiNumber.Name = "txtChassiNumber";
            txtChassiNumber.Padding = new Padding(7);
            txtChassiNumber.PasswordChar = false;
            txtChassiNumber.PlaceHolder = "";
            txtChassiNumber.ReadOnly = false;
            txtChassiNumber.Size = new Size(351, 36);
            txtChassiNumber.TabIndex = 4;
            txtChassiNumber.Texts = "";
            txtChassiNumber.UnderlineStyle = true;
            // 
            // lblChassi
            // 
            lblChassi.AutoSize = true;
            lblChassi.Location = new Point(649, 66);
            lblChassi.Name = "lblChassi";
            lblChassi.Size = new Size(136, 17);
            lblChassi.TabIndex = 9;
            lblChassi.Text = "Número do Chassi";
            // 
            // dtpModelYear
            // 
            dtpModelYear.Format = DateTimePickerFormat.Short;
            dtpModelYear.Location = new Point(479, 87);
            dtpModelYear.MinDate = new DateTime(1910, 1, 1, 0, 0, 0, 0);
            dtpModelYear.Name = "dtpModelYear";
            dtpModelYear.Size = new Size(132, 25);
            dtpModelYear.TabIndex = 3;
            // 
            // lblModelYear
            // 
            lblModelYear.AutoSize = true;
            lblModelYear.Location = new Point(479, 66);
            lblModelYear.Name = "lblModelYear";
            lblModelYear.Size = new Size(112, 17);
            lblModelYear.TabIndex = 7;
            lblModelYear.Text = "Ano do Modelo";
            // 
            // txtModel
            // 
            txtModel.BackColor = Color.White;
            txtModel.BorderColor = Color.SeaGreen;
            txtModel.BorderFocusColor = Color.SpringGreen;
            txtModel.BorderSize = 2;
            txtModel.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModel.Location = new Point(167, 87);
            txtModel.Margin = new Padding(4);
            txtModel.MaxLenght = 55;
            txtModel.MultLine = false;
            txtModel.Name = "txtModel";
            txtModel.Padding = new Padding(7);
            txtModel.PasswordChar = false;
            txtModel.PlaceHolder = "";
            txtModel.ReadOnly = false;
            txtModel.Size = new Size(275, 36);
            txtModel.TabIndex = 2;
            txtModel.Texts = "";
            txtModel.UnderlineStyle = true;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(167, 66);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(56, 17);
            lblModel.TabIndex = 5;
            lblModel.Text = "Modelo";
            // 
            // cbxBrand
            // 
            cbxBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxBrand.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxBrand.FormattingEnabled = true;
            cbxBrand.Items.AddRange(new object[] { "Abarth", "Agrale", "Alfa Romeo", "Aston Martin", "Audi", "BMW", "Caoa Chery", "Chevrolet", "Chrysler", "Citroën", "Dodge", "Ferrari", "Fiat", "Ford", "Honda", "Hyundai", "Iveco", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Lexus", "Lotus", "Maserati", "McLaren", "Mercedes-Benz", "Mini", "Mitsubishi", "Nissan", "Peugeot", "Porsche", "Ram", "Renault", "Rolls-Royce", "Subaru", "Suzuki", "Toyota", "Volkswagen", "Volvo" });
            cbxBrand.Location = new Point(16, 87);
            cbxBrand.Name = "cbxBrand";
            cbxBrand.Size = new Size(121, 25);
            cbxBrand.TabIndex = 1;
            cbxBrand.Text = "Digite aqui";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(16, 67);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(48, 17);
            lblBrand.TabIndex = 2;
            lblBrand.Text = "Marca";
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.BackColor = Color.White;
            txtLicensePlate.BorderColor = Color.SeaGreen;
            txtLicensePlate.BorderFocusColor = Color.SpringGreen;
            txtLicensePlate.BorderSize = 2;
            txtLicensePlate.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLicensePlate.Location = new Point(159, 7);
            txtLicensePlate.Margin = new Padding(4);
            txtLicensePlate.MaxLenght = 7;
            txtLicensePlate.MultLine = false;
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Padding = new Padding(7);
            txtLicensePlate.PasswordChar = false;
            txtLicensePlate.PlaceHolder = "Insira a Placa sem traço(-).";
            txtLicensePlate.ReadOnly = false;
            txtLicensePlate.Size = new Size(843, 36);
            txtLicensePlate.TabIndex = 0;
            txtLicensePlate.Texts = "";
            txtLicensePlate.UnderlineStyle = true;
            // 
            // lblLicensePlate
            // 
            lblLicensePlate.Location = new Point(8, 7);
            lblLicensePlate.Name = "lblLicensePlate";
            lblLicensePlate.Size = new Size(136, 36);
            lblLicensePlate.TabIndex = 0;
            lblLicensePlate.Text = "Placa";
            lblLicensePlate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(gpbInsecure);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1011, 494);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Seguro e Manutenção";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(lblLastManuntencao);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(234, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(774, 488);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manutenção";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 213);
            label1.Name = "label1";
            label1.Size = new Size(440, 17);
            label1.TabIndex = 2;
            label1.Text = "PENSAR EM ALGO PARA COLOCAR AQUI PARA PREENCHER ESPAÇO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(15, 51);
            dateTimePicker1.MinDate = new DateTime(1940, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(171, 25);
            dateTimePicker1.TabIndex = 1;
            // 
            // lblLastManuntencao
            // 
            lblLastManuntencao.AutoSize = true;
            lblLastManuntencao.Location = new Point(15, 24);
            lblLastManuntencao.Name = "lblLastManuntencao";
            lblLastManuntencao.Size = new Size(144, 17);
            lblLastManuntencao.TabIndex = 0;
            lblLastManuntencao.Text = "Utima Manuntenção";
            // 
            // gpbInsecure
            // 
            gpbInsecure.Controls.Add(checkBox8);
            gpbInsecure.Controls.Add(checkBox7);
            gpbInsecure.Controls.Add(checkBox6);
            gpbInsecure.Controls.Add(checkBox5);
            gpbInsecure.Controls.Add(checkBox4);
            gpbInsecure.Controls.Add(checkBox3);
            gpbInsecure.Controls.Add(checkBox2);
            gpbInsecure.Controls.Add(checkBox1);
            gpbInsecure.Controls.Add(cbResponsabilidade);
            gpbInsecure.Controls.Add(cbAll);
            gpbInsecure.Dock = DockStyle.Left;
            gpbInsecure.Location = new Point(3, 3);
            gpbInsecure.Name = "gpbInsecure";
            gpbInsecure.Size = new Size(231, 488);
            gpbInsecure.TabIndex = 0;
            gpbInsecure.TabStop = false;
            gpbInsecure.Text = "Informações de Seguro";
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(3, 267);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(171, 21);
            checkBox8.TabIndex = 9;
            checkBox8.Text = "Seguro obrigatorio";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(3, 240);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(171, 21);
            checkBox7.TabIndex = 8;
            checkBox7.Text = "Dano por Terceiros";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(5, 213);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(83, 21);
            checkBox6.TabIndex = 7;
            checkBox6.Text = "Colisão";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 186);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(187, 21);
            checkBox5.TabIndex = 6;
            checkBox5.Text = "Assistencia 24 Horas";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 159);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(179, 21);
            checkBox4.TabIndex = 5;
            checkBox4.Text = "Pessoal de Acidente";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 132);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(115, 21);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "Perda Total";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 105);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(131, 21);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Furto e Roubo";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 78);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(187, 21);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Contra dano material";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbResponsabilidade
            // 
            cbResponsabilidade.AutoSize = true;
            cbResponsabilidade.Location = new Point(6, 51);
            cbResponsabilidade.Name = "cbResponsabilidade";
            cbResponsabilidade.Size = new Size(171, 21);
            cbResponsabilidade.TabIndex = 1;
            cbResponsabilidade.Text = "Responsabilidae **";
            cbResponsabilidade.UseVisualStyleBackColor = true;
            // 
            // cbAll
            // 
            cbAll.AutoSize = true;
            cbAll.Location = new Point(6, 24);
            cbAll.Name = "cbAll";
            cbAll.Size = new Size(147, 21);
            cbAll.TabIndex = 0;
            cbAll.Text = "Cobertura Total";
            cbAll.UseVisualStyleBackColor = true;
            cbAll.CheckedChanged += cbAll_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 53);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
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
            btnClose.TabIndex = 16;
            btnClose.Text = "Fechar";
            btnClose.TextColor = Color.Black;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // btnDelete
            // 
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
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Excluir";
            btnDelete.TextColor = Color.Black;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += btnDelete_MouseEnter;
            btnDelete.MouseLeave += btnDelete_MouseLeave;
            // 
            // btnSave
            // 
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
            btnSave.TabIndex = 14;
            btnSave.Text = "Salvar";
            btnSave.TextColor = Color.Black;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.MouseEnter += btnSave_MouseEnter;
            btnSave.MouseLeave += btnSave_MouseLeave;
            // 
            // frmVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 581);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(1035, 620);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(1035, 620);
            Name = "frmVehicle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Veiculo";
            KeyDown += frmVehicle_KeyDown;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gpbDocuments.ResumeLayout(false);
            gpbDocuments.PerformLayout();
            gpbAddons.ResumeLayout(false);
            gpbAddons.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gpbInsecure.ResumeLayout(false);
            gpbInsecure.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label lblModel;
        private ComboBox cbxBrand;
        private Label lblBrand;
        private CustomControls.CustomTextBox txtLicensePlate;
        private Label lblLicensePlate;
        private TabPage tabPage2;
        private CustomControls.CustomTextBox txtChassiNumber;
        private Label lblChassi;
        private DateTimePicker dtpModelYear;
        private Label lblModelYear;
        private CustomControls.CustomTextBox txtModel;
        private CustomControls.CustonMaskedBox mkbRenavam;
        private Label lblRenavam;
        private ComboBox cbxFuelType;
        private Label lblGas;
        private CustomControls.CustomTextBox txtColor;
        private Label lblColor;
        private CustomControls.CustomTextBox txtObs;
        private Label lblObs;
        private GroupBox gpbAddons;
        private CheckBox cbEletricGlass;
        private CheckBox cbAr;
        private GroupBox gpbDocuments;
        private CheckBox cbLincense;
        private CheckBox cbKey;
        private CheckBox cbManual;
        private Label lblMileage;
        private Panel panel1;
        private CustomControls.CustomButton btnSave;
        private CustomControls.CustomButton btnClose;
        private CustomControls.CustomButton btnDelete;
        private GroupBox gpbInsecure;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox cbResponsabilidade;
        private CheckBox cbAll;
        private GroupBox groupBox1;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private Label lblLastManuntencao;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private RadioButton rbElectroHydraulic;
        private RadioButton rbElectrical;
        private RadioButton rbHydraulics;
        private RadioButton rbMechanic;
        private Label label1;
        private CheckBox cbEletricLocks;
        private CustomControls.CustomTextBox txtDailyVehicleRate;
        private Label lblDailyVehicleRate;
        private CustomControls.CustomTextBox txtMileage;
    }
}