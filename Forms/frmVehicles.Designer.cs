namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    partial class frmVehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicles));
            txtSearch = new CustomControls.CustomTextBox();
            btnAdd = new CustomControls.CustomButton();
            btnSearch = new CustomControls.CustomButton();
            btnEdit = new CustomControls.CustomButton();
            tmrSearch = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            btnRent = new CustomControls.CustomButton();
            ltvVehicle = new ListView();
            chId = new ColumnHeader();
            chModel = new ColumnHeader();
            chLicensePlate = new ColumnHeader();
            chBrand = new ColumnHeader();
            chColor = new ColumnHeader();
            chRented = new ColumnHeader();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = Color.White;
            txtSearch.BorderColor = Color.SpringGreen;
            txtSearch.BorderFocusColor = Color.SeaGreen;
            txtSearch.BorderSize = 2;
            txtSearch.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(9, 9);
            txtSearch.Margin = new Padding(4);
            txtSearch.MaximumSize = new Size(1000, 36);
            txtSearch.MaxLenght = 32767;
            txtSearch.MultLine = false;
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(7);
            txtSearch.PasswordChar = false;
            txtSearch.PlaceHolder = "Digite a placa a ser pesquisada aqui.";
            txtSearch.Size = new Size(547, 36);
            txtSearch.TabIndex = 2;
            txtSearch.Texts = "";
            txtSearch.UnderlineStyle = true;
            txtSearch._TextChanged += txtSearch__TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(47, 125, 65);
            btnAdd.BackgroudColor = Color.FromArgb(47, 125, 65);
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 40;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 212, 111);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(741, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Adicionar";
            btnAdd.TextColor = Color.Black;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(110, 189, 244);
            btnSearch.BackgroudColor = Color.FromArgb(110, 189, 244);
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 40;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(87, 149, 194);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Black;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(585, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 40);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Pesquisar";
            btnSearch.TextColor = Color.Black;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(90, 71, 255);
            btnEdit.BackgroudColor = Color.FromArgb(90, 71, 255);
            btnEdit.BorderColor = Color.FromArgb(75, 131, 193);
            btnEdit.BorderRadius = 40;
            btnEdit.BorderSize = 0;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 131, 193);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.Black;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(585, 51);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 40);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Editar";
            btnEdit.TextColor = Color.Black;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // tmrSearch
            // 
            tmrSearch.Interval = 900;
            tmrSearch.Tick += tmrSearch_Tick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(212, 63);
            label1.Name = "label1";
            label1.Size = new Size(344, 17);
            label1.TabIndex = 7;
            label1.Text = "Colocar Cores Melhores para esse botões ->";
            // 
            // btnRent
            // 
            btnRent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRent.BackColor = Color.FromArgb(110, 189, 244);
            btnRent.BackgroudColor = Color.FromArgb(110, 189, 244);
            btnRent.BorderColor = Color.PaleVioletRed;
            btnRent.BorderRadius = 40;
            btnRent.BorderSize = 0;
            btnRent.FlatAppearance.BorderSize = 0;
            btnRent.FlatAppearance.MouseOverBackColor = Color.FromArgb(87, 149, 194);
            btnRent.FlatStyle = FlatStyle.Flat;
            btnRent.ForeColor = Color.Black;
            btnRent.Image = (Image)resources.GetObject("btnRent.Image");
            btnRent.ImageAlign = ContentAlignment.MiddleLeft;
            btnRent.Location = new Point(741, 51);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(150, 40);
            btnRent.TabIndex = 8;
            btnRent.Text = "Alugar";
            btnRent.TextColor = Color.Black;
            btnRent.UseVisualStyleBackColor = false;
            btnRent.Click += btnRent_Click;
            // 
            // ltvVehicle
            // 
            ltvVehicle.Activation = ItemActivation.TwoClick;
            ltvVehicle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ltvVehicle.Columns.AddRange(new ColumnHeader[] { chId, chModel, chLicensePlate, chBrand, chColor, chRented });
            ltvVehicle.FullRowSelect = true;
            ltvVehicle.GridLines = true;
            ltvVehicle.Location = new Point(9, 97);
            ltvVehicle.MultiSelect = false;
            ltvVehicle.Name = "ltvVehicle";
            ltvVehicle.Size = new Size(898, 405);
            ltvVehicle.TabIndex = 9;
            ltvVehicle.UseCompatibleStateImageBehavior = false;
            ltvVehicle.View = View.Details;
            ltvVehicle.DoubleClick += ltvVehicle_DoubleClick;
            // 
            // chId
            // 
            chId.Text = "Id";
            chId.Width = 96;
            // 
            // chModel
            // 
            chModel.Text = "Modelo";
            chModel.Width = 239;
            // 
            // chLicensePlate
            // 
            chLicensePlate.Text = "Placa";
            chLicensePlate.Width = 239;
            // 
            // chBrand
            // 
            chBrand.Text = "Marca";
            chBrand.Width = 239;
            // 
            // chColor
            // 
            chColor.Text = "Color";
            chColor.Width = 144;
            // 
            // chRented
            // 
            chRented.Text = "Alugado";
            chRented.Width = 239;
            // 
            // frmVehicles
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(915, 510);
            Controls.Add(ltvVehicle);
            Controls.Add(btnRent);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmVehicles";
            Padding = new Padding(5);
            ShowInTaskbar = false;
            Text = "frmVehicleTable";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.CustomTextBox txtSearch;
        private CustomControls.CustomButton btnAdd;
        private CustomControls.CustomButton btnSearch;
        private CustomControls.CustomButton btnEdit;
        private System.Windows.Forms.Timer tmrSearch;
        private Label label1;
        private CustomControls.CustomButton btnRent;
        private ColumnHeader chId;
        private ColumnHeader chModel;
        private ColumnHeader chLicensePlate;
        private ColumnHeader chBrand;
        private ColumnHeader chColor;
        private ColumnHeader chRented;
        private ListView ltvVehicle;
    }
}